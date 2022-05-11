using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using JetBrains.Annotations;
using JetBrains.Space.Common.Json.Serialization;

#nullable disable

namespace JetBrains.Space.Generator.Model.HttpApi.Converters;

public class ApiFieldTypeConverter : JsonConverter<ApiType>
{
    private static readonly Dictionary<string, Type> TypeMap = new(StringComparer.OrdinalIgnoreCase)
    {
        { "HA_Type.Array", typeof(ApiType.Array) },
        { "HA_Type.Dto", typeof(ApiType.Dto) },
        { "HA_Type.Enum", typeof(ApiType.Enum) },
        { "HA_Type.UrlParam", typeof(ApiType.UrlParam) },
        { "HA_Type.Map", typeof(ApiType.Map) },
        { "HA_Type.Object", typeof(ApiType.Object) },
        { "HA_Type.Primitive", typeof(ApiType.Primitive) },
        { "HA_Type.Ref", typeof(ApiType.Ref) }
    };
        
    public override bool CanConvert(Type objectType) => typeof(ApiType).IsAssignableFrom(objectType);

    [CanBeNull]
    public override ApiType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null) return null;

        var readerAtStart = reader;
            
        using var jsonDocument = JsonDocument.ParseValue(ref reader);
        var jsonObject = jsonDocument.RootElement;

        var className = jsonObject.GetStringValue("className");
        if (!string.IsNullOrEmpty(className) && TypeMap.TryGetValue(className, out var targetType))
        {
            return JsonSerializer.Deserialize(ref readerAtStart, targetType, options) as ApiType;
        }
            
        return JsonSerializer.Deserialize<ApiType.Object>(ref readerAtStart);
    }

    public override void Write(Utf8JsonWriter writer, ApiType value, JsonSerializerOptions options)
    {
        value.ClassName = TypeMap.First(it => it.Value == value.GetType()).Key;
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}