using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Types;
using JetBrains.Space.Generator.Model.HttpApi.Converters;

namespace JetBrains.Space.Generator.Model.HttpApi;

public abstract class ApiType
{
    [JsonPropertyName("className")]
    public string? ClassName { get; set; }
        
    [JsonPropertyName("nullable")]
    public bool Nullable { get; set; }

    [JsonPropertyName("tags")] 
    public List<string> Tags { get; set; } = new();

    public class Primitive : ApiType
    {
        [JsonPropertyName("primitive")]
        public string Type { get; set; } = default!;
    }
        
    public class Array : ApiType
    {
        [JsonPropertyName("elementType")]
        [JsonConverter(typeof(ApiFieldTypeConverter))]
        public ApiType ElementType { get; set; } = default!;
    }
        
    public class Map : ApiType
    {
        [JsonPropertyName("valueType")]
        [JsonConverter(typeof(ApiFieldTypeConverter))]
        public ApiType ValueType { get; set; } = default!;
    }
        
    public class Object : ApiType
    {
        [JsonPropertyName("fields")]
        public List<ApiField> Fields { get; set; } = new();
            
        [JsonPropertyName("kind")]
        public ObjectKind Kind { get; set; }

        [JsonConverter(typeof(EnumStringConverter))]
        [SuppressMessage("ReSharper", "InconsistentNaming")]
        public enum ObjectKind
        {
            [EnumMember(Value = "PAIR")] PAIR,
            [EnumMember(Value = "TRIPLE")] TRIPLE,
            [EnumMember(Value = "BATCH")] BATCH,
            [EnumMember(Value = "MOD")] MOD,
            [EnumMember(Value = "REQUEST_BODY")] REQUEST_BODY
        }
    }
        
    public class Enum : ApiType
    {
        [JsonPropertyName("enum")]
        public Reference<ApiEnum>? EnumRef { get; set; }
    }
        
    public class UrlParam : ApiType
    {
        [JsonPropertyName("urlParam")]
        public Reference<ApiUrlParameter>? UrlParamRef { get; set; }
    }
        
    public class Dto : ApiType
    {
        [JsonPropertyName("dto")]
        public ApiDto? DtoRef { get; set; }
    }
        
    public class Ref : ApiType
    {
        [JsonPropertyName("dto")]
        public ApiDto? DtoRef { get; set; }
    }
}