using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization;

namespace JetBrains.Space.Generator.Model.HttpApi;

[JsonConverter(typeof(EnumStringConverter))]
[SuppressMessage("ReSharper", "InconsistentNaming")]
public enum ApiVisibilityModifier
{
    [EnumMember(Value = "DEFAULT")] DEFAULT,
    [EnumMember(Value = "PRIVATE")] PRIVATE,
    [EnumMember(Value = "INTERNAL")] INTERNAL
}