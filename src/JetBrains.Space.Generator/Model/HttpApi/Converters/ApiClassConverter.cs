using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using JetBrains.Annotations;
using JetBrains.Space.Common.Json.Serialization;

#nullable disable

namespace JetBrains.Space.Generator.Model.HttpApi.Converters;

public class ApiClassConverter : JsonConverter<ApiClass>
{
    private static readonly Dictionary<string, Type> TypeMap = new(StringComparer.OrdinalIgnoreCase)
    {
        { "HA_Class.Clazz", typeof(ApiClass.Clazz) },
        { "HA_Class.Interface", typeof(ApiClass.Interface) },
        { "HA_Class.Object", typeof(ApiClass.Object) }
    };
    
    public override bool CanConvert(Type objectType) => typeof(ApiClass).IsAssignableFrom(objectType);

    [CanBeNull]
    public override ApiClass Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null) return null;

        var readerAtStart = reader;
            
        using var jsonDocument = JsonDocument.ParseValue(ref reader);
        var jsonObject = jsonDocument.RootElement;

        var className = jsonObject.GetStringValue("className");
        if (!string.IsNullOrEmpty(className) && TypeMap.TryGetValue(className, out var targetType))
        {
            return JsonSerializer.Deserialize(ref readerAtStart, targetType, options) as ApiClass;
        }
            
        throw new JsonException("No className field was found that maps to a ApiClass subtype.");
    }

    public override void Write(Utf8JsonWriter writer, ApiClass value, JsonSerializerOptions options)
    {
        value.ClassName = TypeMap.First(it => it.Value == value.GetType()).Key;
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}