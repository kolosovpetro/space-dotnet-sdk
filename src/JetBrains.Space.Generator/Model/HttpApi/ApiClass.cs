using System.Collections.Generic;
using System.Text.Json.Serialization;
using JetBrains.Space.Generator.Model.HttpApi.Converters;

namespace JetBrains.Space.Generator.Model.HttpApi;

[JsonConverter(typeof(ApiClassConverter))]
public abstract class ApiClass
{
    [JsonPropertyName("className")]
    public string? ClassName { get; set; }
    
    [JsonPropertyName("visibilityModifier")]
    public ApiVisibilityModifier VisibilityModifier { get; set; }
    
    [JsonPropertyName("name")]
    public string Name { get; set; }
        
    [JsonPropertyName("implements")]
    public List<string> Implements { get; set; } = new();
        
    [JsonPropertyName("innerSubclasses")]
    public List<ApiClass> InnerSubclasses { get; set; } = new();
        
    [JsonPropertyName("properties")]
    public List<ApiProperty> Properties { get; set; } = new();
    
    [JsonPropertyName("deprecation")]
    public ApiDeprecation? Deprecation { get; set; } = default;
    
    [JsonPropertyName("doc")]
    public string? Documentation { get; set; } = default;
    
    public class Clazz : ApiClass
    {
        [JsonPropertyName("open")]
        public bool IsOpen { get; set; }
        
        [JsonPropertyName("abstract")]
        public bool IsAbstract { get; set; }
        
        [JsonPropertyName("sealed")]
        public bool IsSealed { get; set; }
    
        [JsonPropertyName("extends")]
        public string? Extends { get; set; } = default;
    }
    
    public class Interface : ApiClass
    {
        [JsonPropertyName("sealed")]
        public bool IsSealed { get; set; }
    }
    
    public class Object : ApiClass
    {
        [JsonPropertyName("extends")]
        public string? Extends { get; set; } = default;
    }
}