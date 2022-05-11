using System.Text.Json.Serialization;
using JetBrains.Space.Generator.Model.HttpApi.Converters;

namespace JetBrains.Space.Generator.Model.HttpApi;

public class ApiProperty
{
    [JsonPropertyName("visibilityModifier")]
    public ApiVisibilityModifier VisibilityModifier { get; set; }
    
    [JsonPropertyName("name")]
    public string Name { get; set; }
    
    [JsonPropertyName("type")]
    [JsonConverter(typeof(ApiFieldTypeConverter))]
    public ApiType Type { get; set; }
    
    [JsonPropertyName("value")]
    [JsonConverter(typeof(ApiDefaultValueConverter))]
    public ApiDefaultValue Value { get; set; }
    
    [JsonPropertyName("deprecation")]
    public ApiDeprecation? Deprecation { get; set; } = default;
    
    [JsonPropertyName("override")]
    public bool IsOverride { get; set; }
}