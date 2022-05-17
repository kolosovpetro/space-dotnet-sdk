using System;
using System.Collections.Generic;
using System.Text;
using JetBrains.Space.Generator.CodeGeneration.CSharp.Extensions;
using JetBrains.Space.Generator.Model.HttpApi;

namespace JetBrains.Space.Generator.CodeGeneration.CSharp.Generators;

public class CSharpApiModelClassGenerator
{
    private readonly CodeGenerationContext _codeGenerationContext;

    public CSharpApiModelClassGenerator(CodeGenerationContext codeGenerationContext)
    {
        _codeGenerationContext = codeGenerationContext;
    }

    public string GenerateClassDefinition(ApiClass apiClass)
    {
        var indent = new Indent();
        var builder = new StringBuilder();
            
        var typeNameForClass = apiClass.ToCSharpClassName();

        if (!string.IsNullOrEmpty(apiClass.Documentation))
        {
            builder.Append(
                indent.Wrap(
                    apiClass.Documentation.ToCSharpDocumentationSummary()));
        }
        if (apiClass.Deprecation != null)
        {
            builder.AppendLine($"{indent}{apiClass.Deprecation.ToCSharpDeprecation()}");
        }

        var modifier = apiClass.VisibilityModifier switch
        {
            ApiVisibilityModifier.DEFAULT => "public",
            ApiVisibilityModifier.PRIVATE => "private",
            ApiVisibilityModifier.INTERNAL => "internal",
            _ => throw new NotSupportedException($"VisibilityModifier '{apiClass.VisibilityModifier}' for class '{apiClass.Name}' is not supported.")
        };

        var hierarchyRoleForClass = apiClass switch
        {
            ApiClass.Interface @interface => "interface",
            ApiClass.Clazz @class => @class.IsAbstract
                ? "abstract class"
                : @class.IsSealed 
                    ? "sealed class" 
                    : "class",
            ApiClass.Object @object => "class",
            _ => throw new NotSupportedException($"{nameof(ApiClass)} of type '{apiClass.GetType()}' for class '{apiClass.Name}' is not supported.")
        };
        
        var classHierarchy = new List<string>();
        foreach (var classImplements in apiClass.Implements)
        {
            if (_codeGenerationContext.TryGetClass(classImplements, out var apiClassImplements))
            {
                classHierarchy.Add(apiClassImplements!.ToCSharpClassName());
            }
        }
        
        builder.AppendLine($"{indent}{modifier} {hierarchyRoleForClass} {typeNameForClass}");
        if (classHierarchy.Count > 0)
        {
            indent.Increment();
            builder.AppendLine($"{indent} : " + string.Join(", ", classHierarchy));
            indent.Decrement();
        }
        builder.AppendLine($"{indent}{{");
        indent.Increment();
        
        foreach (var apiClassProperty in apiClass.Properties)
        {
            builder.AppendLine(indent.Wrap(GenerateProperty(apiClass, apiClassProperty)));
        }
        
        foreach (var apiClassInnerSubclass in apiClass.InnerSubclasses)
        {
            builder.AppendLine(indent.Wrap(GenerateClassDefinition(apiClassInnerSubclass)));
        }
        
        indent.Decrement();
        builder.AppendLine($"{indent}}}");
        
        return builder.ToString();
    }

    private string GenerateProperty(ApiClass apiClass, ApiProperty apiProperty)
    {
        var indent = new Indent();
        var builder = new StringBuilder();

        var apiField = new ApiField
        {
            Name = apiProperty.Name,
            Type = apiProperty.Type,
            Optional = false,
            Description = null,
            Deprecation = apiProperty.Deprecation,
            DefaultValue = apiProperty.Value
        };
        
        var propertyName = apiField.ToCSharpPropertyName(apiClass.ToCSharpClassName());
        var value = apiField.ToCSharpDefaultValueForParameterList(_codeGenerationContext);
        
        if (apiProperty.Deprecation != null)
        {
            builder.AppendLine($"{indent}{apiProperty.Deprecation.ToCSharpDeprecation()}");
        }
        
        var modifier = apiProperty.VisibilityModifier switch
        {
            ApiVisibilityModifier.DEFAULT => "public",
            ApiVisibilityModifier.PRIVATE => "private",
            ApiVisibilityModifier.INTERNAL => "internal",
            _ => throw new NotSupportedException($"VisibilityModifier '{apiProperty.VisibilityModifier}' for property '{apiClass.Name}.{apiProperty.Name}' is not supported.")
        };
        
        var @override = apiProperty.IsOverride ? "/*override*/" : "";
        
        builder.Append($"{indent}{modifier} {@override} ");
        builder.Append(apiField.Type.ToCSharpType(_codeGenerationContext));
        if (apiField.Type.Nullable)
        {
            builder.Append('?');
        }
        
        if (!apiField.Type.Nullable && apiField.RequiresAddedNullability())
        {
            builder.Append('?');
        }
        
        builder.Append(" ");
        builder.AppendLine($"{indent}{propertyName} => {value};");
        
        return builder.ToString();
    }
}