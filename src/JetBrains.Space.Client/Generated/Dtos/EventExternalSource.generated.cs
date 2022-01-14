// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS1591
#pragma warning disable CS0108
#pragma warning disable 618

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client;

public sealed class EventExternalSource
     : IPropagatePropertyAccessPath
{
    public EventExternalSource() { }
    
    public EventExternalSource(string sourceName, string externalId, string? sourceLink = null)
    {
        SourceName = sourceName;
        ExternalId = externalId;
        SourceLink = sourceLink;
    }
    
    private PropertyValue<string> _sourceName = new PropertyValue<string>(nameof(EventExternalSource), nameof(SourceName), "sourceName");
    
    [Required]
    [JsonPropertyName("sourceName")]
    public string SourceName
    {
        get => _sourceName.GetValue(InlineErrors);
        set => _sourceName.SetValue(value);
    }

    private PropertyValue<string> _externalId = new PropertyValue<string>(nameof(EventExternalSource), nameof(ExternalId), "externalId");
    
    [Required]
    [JsonPropertyName("externalId")]
    public string ExternalId
    {
        get => _externalId.GetValue(InlineErrors);
        set => _externalId.SetValue(value);
    }

    private PropertyValue<string?> _sourceLink = new PropertyValue<string?>(nameof(EventExternalSource), nameof(SourceLink), "sourceLink");
    
    [JsonPropertyName("sourceLink")]
    public string? SourceLink
    {
        get => _sourceLink.GetValue(InlineErrors);
        set => _sourceLink.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _sourceName.SetAccessPath(parentChainPath, validateHasBeenSet);
        _externalId.SetAccessPath(parentChainPath, validateHasBeenSet);
        _sourceLink.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

