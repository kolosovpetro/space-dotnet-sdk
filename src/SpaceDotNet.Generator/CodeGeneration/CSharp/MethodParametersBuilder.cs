using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpaceDotNet.Generator.CodeGeneration.CSharp.Extensions;
using SpaceDotNet.Generator.CodeGeneration.Extensions;
using SpaceDotNet.Generator.Model.HttpApi;

namespace SpaceDotNet.Generator.CodeGeneration.CSharp
{
    public class MethodParametersBuilder
    {
        private class MethodParameter
        {
            public string Type { get; set; }
            public string Name { get; set; }
            public string? DefaultValue { get; set; }

            public MethodParameter(string type, string name, string? defaultValue)
            {
                Type = type;
                Name = name;
                DefaultValue = defaultValue;
            }
        }

        private readonly CodeGenerationContext _context;
        private readonly List<MethodParameter> _parameters;

        public MethodParametersBuilder(CodeGenerationContext context) 
            : this(context, new List<MethodParameter>())
        {
        }
        
        private MethodParametersBuilder(CodeGenerationContext context, List<MethodParameter> parameters)
        {
            _context = context;
            _parameters = parameters;
        }

        public MethodParametersBuilder WithParametersForApiDtoFields(IEnumerable<ApiDtoField> apiDtoFields) 
            => WithParametersForApiFields(apiDtoFields.Select(it => it.Field));

        public MethodParametersBuilder WithParametersForApiFields(IEnumerable<ApiField> apiFields)
        {
            var methodParametersBuilder = this;
            var orderedFields = apiFields.OrderBy(it => !it.Type.Nullable ? 0 : 1).ToList();
            foreach (var field in orderedFields)
            {
                var parameterType = field.Type.ToCSharpType(_context);
                if (field.Type.Nullable)
                {
                    parameterType += "?";
                }
                
                var parameterName = field.ToCSharpVariableName();
                var parameterDefaultValue = DetermineDefaultValueForField(field);

                methodParametersBuilder = methodParametersBuilder
                    .WithParameter(parameterType, parameterName, parameterDefaultValue);
            }

            return methodParametersBuilder;
        }

        public MethodParametersBuilder WithParametersForApiParameters(IEnumerable<ApiParameter> apiParameters)
        {
            var methodParametersBuilder = this;
            var orderedParameters = apiParameters.OrderBy(it => !it.Field.Type.Nullable ? 0 : 1).ToList();
            foreach (var parameter in orderedParameters)
            {
                var parameterType = parameter.Field.Type.ToCSharpType(_context);
                if (parameter.Field.Type.Nullable)
                {
                    parameterType += "?";
                }
                
                var parameterName = parameter.Field.ToCSharpVariableName();
                var parameterDefaultValue = DetermineDefaultValueForField(parameter.Field);
                
                methodParametersBuilder = methodParametersBuilder
                    .WithParameter(parameterType, parameterName, parameterDefaultValue);
            }

            return methodParametersBuilder;
        }

        public MethodParametersBuilder WithParameter(string type, string name, string? defaultValue = null)
        {
            var futureParameters = new List<MethodParameter>(_parameters);
            futureParameters.Add(new MethodParameter(type, name, defaultValue));
            return new MethodParametersBuilder(_context, futureParameters);
        }
        
        public MethodParametersBuilder WithDefaultValueForAllParameters(string? defaultValue)
        {
            var futureParameters = new List<MethodParameter>();
            foreach (var futureParameter in _parameters)
            {
                futureParameters.Add(new MethodParameter(futureParameter.Type, futureParameter.Name, defaultValue));
            }
            return new MethodParametersBuilder(_context, futureParameters);
        }

        public MethodParametersBuilder WithDefaultValueForParameter(string name, string? defaultValue = null)
        {
            var futureParameters = new List<MethodParameter>();
            foreach (var futureParameter in _parameters)
            {
                if (futureParameter.Name == name)
                {
                    futureParameters.Add(new MethodParameter(futureParameter.Type, futureParameter.Name, defaultValue));
                }
                else
                {
                    futureParameters.Add(futureParameter);
                }
            }
            return new MethodParametersBuilder(_context, futureParameters);
        }

        public string BuildMethodParametersDefinition() =>
            string.Join(", ", _parameters
                .OrderBy(RequiredParametersFirstOrder)
                .Select(it =>
                {
                    var parameterDefinition = it.Type + " " + it.Name;
                    if (!string.IsNullOrEmpty(it.DefaultValue))
                    {
                        parameterDefinition += " = " + it.DefaultValue;
                    }
                    return parameterDefinition;
                }));

        public string BuildMethodCallParametersDefinition() =>
            string.Join(", ", _parameters
                .OrderBy(RequiredParametersFirstOrder)
                .Select(it =>
                {
                    var parameterDefinition = it.Name;
                    if (!string.IsNullOrEmpty(it.DefaultValue))
                    {
                        parameterDefinition += ": " + it.DefaultValue;
                    }
                    else
                    {
                        parameterDefinition += ": " + parameterDefinition;
                    }
                    return parameterDefinition;
                }));

        private int RequiredParametersFirstOrder(MethodParameter it) => string.IsNullOrEmpty(it.DefaultValue) ? 0 : 1;
        
        private string? DetermineDefaultValueForField(ApiField field)
        {
            if (field.DefaultValue != null)
            {
                switch (field.DefaultValue)
                {
                    case ApiDefaultValue.Const.Primitive primitive:
                        return primitive.Expression;
                    
                    case ApiDefaultValue.Const.EnumEntry enumEntry:
                        if (FeatureFlags.GenerateOptionalParameterDefaultReferenceTypes)
                        {
                            var apiEnumRef = field.Type as ApiFieldType.Enum;
                            if (apiEnumRef == null || !_context.TryGetEnum(apiEnumRef.EnumRef!.Id, out var apiEnum) || apiEnum == null)
                            {
                                throw new NotSupportedException("For " + nameof(ApiDefaultValue.Const.EnumEntry) + ", the field type should be of type" + nameof(ApiFieldType.Enum) + ".");
                            }

                            var typeNameForEnum = apiEnum.ToCSharpClassName();
                            var identifierForValue = CSharpIdentifier.ForClassOrNamespace(enumEntry.EntryName);

                            return $"{typeNameForEnum}.{identifierForValue}";
                        }
                        else if (FeatureFlags.GenerateAlternativeForOptionalParameterDefaultReferenceTypes)
                        {
                            return "null";
                        }
                        else
                        {
                            return null;
                        }

                    case ApiDefaultValue.Collection collection:
                        if (FeatureFlags.GenerateOptionalParameterDefaultReferenceTypes)
                        {
                            var typeNameForArrayElement = field.Type.GetArrayElementTypeOrType().ToCSharpType(_context);

                            var builder = new StringBuilder();
                            builder.Append($"new List<{typeNameForArrayElement}>()");

                            if (collection.Elements.Count > 0)
                            {
                                throw new NotSupportedException("Default values with populated collections are not supported yet.");
                            }
                        
                            return builder.ToString();
                        }
                        else if (FeatureFlags.GenerateAlternativeForOptionalParameterDefaultReferenceTypes)
                        {
                            return "null";
                        }
                        else
                        {
                            return null;
                        }

                    case ApiDefaultValue.Map map:
                        if (FeatureFlags.GenerateOptionalParameterDefaultReferenceTypes)
                        {
                            var typeNameForMapValue = field.Type.GetMapValueTypeOrType().ToCSharpType(_context);

                            var builder = new StringBuilder();
                            builder.Append($"new Dictionary<string, {typeNameForMapValue}>()");
 
                            if (map.Elements.Count > 0)
                            {
                                throw new NotSupportedException("Default values with populated maps are not supported yet.");
                            }

                            return builder.ToString();
                        }
                        else if (FeatureFlags.GenerateAlternativeForOptionalParameterDefaultReferenceTypes)
                        {
                            return "null";
                        }
                        else
                        {
                            return null;
                        }

                    case ApiDefaultValue.Reference reference:
                        throw new NotSupportedException(nameof(ApiDefaultValue.Reference) + " is not supported yet.");
                }
            } 
            
            if (field.Type.Nullable)
            {
                return "null";
            }

            return null;
        }
    }
}