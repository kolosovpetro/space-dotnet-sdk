using System.Text;
using JetBrains.Space.Common;
using JetBrains.Space.Generator.Model.HttpApi;
using JetBrains.Space.Generator.CodeGeneration.Extensions;

namespace JetBrains.Space.Generator.CodeGeneration.CSharp.Extensions;

public static class ApiFieldTypeExtensions
{
    public static CSharpType ToCSharpPrimitiveType(this ApiType.Primitive subject) =>
        subject.Type switch
        {
            "Byte" => CSharpType.Byte,
            "Short" => CSharpType.Short,
            "Int" => CSharpType.Int,
            "Long" => CSharpType.Long,
            "Float" => CSharpType.Float,
            "Double" => CSharpType.Double,
            "Boolean" => CSharpType.Bool,
            "String" => CSharpType.String,
            "Date" => CSharpType.SpaceDate,
            "DateTime" => CSharpType.SpaceTime,
            _ => CSharpType.Object
        };

    public static bool IsCSharpReferenceType(this ApiType apiType) =>
        apiType switch
        {
            ApiType.Enum => false,
            ApiType.Primitive primitiveType when primitiveType.ToCSharpPrimitiveType() != CSharpType.String =>
                false,
            _ => true
        };

    public static string ToCSharpType(this ApiType apiType, CodeGenerationContext context)
    {
        switch (apiType)
        {
            case ApiType.Array apiFieldTypeArray:
            {
                var sb = new StringBuilder();
                sb.Append("List<");
                sb.Append(ToCSharpType(apiFieldTypeArray.ElementType, context));
                sb.Append(">");
                return sb.ToString();
            }

            case ApiType.Dto apiFieldTypeDto:
                if (apiFieldTypeDto.DtoRef?.Id != null && context.TryGetDto(apiFieldTypeDto.DtoRef.Id, out var apiDto))
                {
                    return apiDto!.ToCSharpClassName();
                }
                else
                {
                    return "object";
                }
                
            case ApiType.Enum apiFieldTypeEnum:
                if (apiFieldTypeEnum.EnumRef?.Id != null && context.TryGetEnum(apiFieldTypeEnum.EnumRef.Id, out var apiEnum))
                {
                    return apiEnum!.ToCSharpClassName();
                }
                else
                {
                    return "string";
                }
                
            case ApiType.UrlParam apiFieldTypeUrlParam:
                if (apiFieldTypeUrlParam.UrlParamRef?.Id != null && context.TryGetUrlParameter(apiFieldTypeUrlParam.UrlParamRef.Id, out var apiUrlParam))
                {
                    return apiUrlParam!.ToCSharpClassName();
                }
                else
                {
                    throw new ResourceException("Could not generate type name for URL parameter with ref id: " + apiFieldTypeUrlParam.UrlParamRef?.Id);
                }
                
            case ApiType.Map apiFieldTypeMap:
            {
                var sb = new StringBuilder();
                sb.Append("Dictionary<string, ");
                sb.Append(ToCSharpType(apiFieldTypeMap.ValueType, context));
                sb.Append(">");
                return sb.ToString();
            }

            case ApiType.Object apiFieldTypeObject:
                if (apiFieldTypeObject.Kind == ApiType.Object.ObjectKind.PAIR)
                {
                    // Known anonymous type
                    var sb = new StringBuilder();
                    sb.Append("Pair<");
                    sb.Append(ToCSharpType(apiFieldTypeObject.Fields[0].Type, context));
                    sb.Append(", ");
                    sb.Append(ToCSharpType(apiFieldTypeObject.Fields[1].Type, context));
                    sb.Append(">");
                    return sb.ToString();
                }
                else if (apiFieldTypeObject.Kind == ApiType.Object.ObjectKind.TRIPLE)
                {
                    // Known anonymous type
                    var sb = new StringBuilder();
                    sb.Append("Triple<");
                    sb.Append(ToCSharpType(apiFieldTypeObject.Fields[0].Type, context));
                    sb.Append(", ");
                    sb.Append(ToCSharpType(apiFieldTypeObject.Fields[1].Type, context));
                    sb.Append(", ");
                    sb.Append(ToCSharpType(apiFieldTypeObject.Fields[2].Type, context));
                    sb.Append(">");
                    return sb.ToString();
                }
                else if (apiFieldTypeObject.Kind == ApiType.Object.ObjectKind.BATCH)
                {
                    // Known anonymous type
                    var sb = new StringBuilder();
                    sb.Append("Batch<");
                    sb.Append(ToCSharpType(apiFieldTypeObject.GetBatchDataType()!.ElementType, context));
                    sb.Append(">");
                    return sb.ToString();
                }  
                else if (apiFieldTypeObject.Kind == ApiType.Object.ObjectKind.MOD)
                {
                    // Known anonymous type
                    var sb = new StringBuilder();
                    sb.Append("Modification<");
                    sb.Append(ToCSharpType(apiFieldTypeObject.Fields[0].Type, context));
                    sb.Append(">");
                    return sb.ToString();
                }
                else if (apiFieldTypeObject.Kind == ApiType.Object.ObjectKind.REQUEST_BODY)
                {
                    // Request body/anonymous type?
                    throw new ResourceException($"The method {nameof(ToCSharpType)}() should not be called with object kind: " + apiFieldTypeObject.Kind 
                        + $". Ensure {nameof(CodeGenerationContextEnricher)} has run, and then invoke apiEndpoint.{nameof(ApiEndpointExtensions.ToCSharpRequestBodyClassName)}() to retrieve the proper type name.");
                }
                else
                {
                    // Unknown object kind
                    throw new ResourceException("Could not generate type for object kind: " + apiFieldTypeObject.ClassName);
                }
                
            case ApiType.Primitive apiFieldTypePrimitive:
                return apiFieldTypePrimitive.ToCSharpPrimitiveType().Value;
        
            case ApiType.Ref apiFieldTypeReference:
                if (apiFieldTypeReference.DtoRef?.Id != null && context.TryGetDto(apiFieldTypeReference.DtoRef.Id, out var apiReferenceDto))
                {
                    return apiReferenceDto!.ToCSharpClassName();
                }
                else
                {
                    return "object";
                }

            default:
                return "object";
        }
    }
}