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

public sealed class ESAuthModule
     : IPropagatePropertyAccessPath
{
    public ESAuthModule() { }
    
    public ESAuthModule(string id, string key, string name, int ordinal, bool enabled, ESAuthModuleSettings settings, string? iconDataURI = null)
    {
        Id = id;
        Key = key;
        Name = name;
        Ordinal = ordinal;
        IsEnabled = enabled;
        IconDataURI = iconDataURI;
        Settings = settings;
    }
    
    private PropertyValue<string> _id = new PropertyValue<string>(nameof(ESAuthModule), nameof(Id), "id");
    
    [Required]
    [JsonPropertyName("id")]
    public string Id
    {
        get => _id.GetValue(InlineErrors);
        set => _id.SetValue(value);
    }

    private PropertyValue<string> _key = new PropertyValue<string>(nameof(ESAuthModule), nameof(Key), "key");
    
    [Required]
    [JsonPropertyName("key")]
    public string Key
    {
        get => _key.GetValue(InlineErrors);
        set => _key.SetValue(value);
    }

    private PropertyValue<string> _name = new PropertyValue<string>(nameof(ESAuthModule), nameof(Name), "name");
    
    [Required]
    [JsonPropertyName("name")]
    public string Name
    {
        get => _name.GetValue(InlineErrors);
        set => _name.SetValue(value);
    }

    private PropertyValue<int> _ordinal = new PropertyValue<int>(nameof(ESAuthModule), nameof(Ordinal), "ordinal");
    
    [Required]
    [JsonPropertyName("ordinal")]
    public int Ordinal
    {
        get => _ordinal.GetValue(InlineErrors);
        set => _ordinal.SetValue(value);
    }

    private PropertyValue<bool> _enabled = new PropertyValue<bool>(nameof(ESAuthModule), nameof(IsEnabled), "enabled");
    
    [Required]
    [JsonPropertyName("enabled")]
    public bool IsEnabled
    {
        get => _enabled.GetValue(InlineErrors);
        set => _enabled.SetValue(value);
    }

    private PropertyValue<string?> _iconDataURI = new PropertyValue<string?>(nameof(ESAuthModule), nameof(IconDataURI), "iconDataURI");
    
    [JsonPropertyName("iconDataURI")]
    public string? IconDataURI
    {
        get => _iconDataURI.GetValue(InlineErrors);
        set => _iconDataURI.SetValue(value);
    }

    private PropertyValue<ESAuthModuleSettings> _settings = new PropertyValue<ESAuthModuleSettings>(nameof(ESAuthModule), nameof(Settings), "settings");
    
    [Required]
    [JsonPropertyName("settings")]
    public ESAuthModuleSettings Settings
    {
        get => _settings.GetValue(InlineErrors);
        set => _settings.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _id.SetAccessPath(parentChainPath, validateHasBeenSet);
        _key.SetAccessPath(parentChainPath, validateHasBeenSet);
        _name.SetAccessPath(parentChainPath, validateHasBeenSet);
        _ordinal.SetAccessPath(parentChainPath, validateHasBeenSet);
        _enabled.SetAccessPath(parentChainPath, validateHasBeenSet);
        _iconDataURI.SetAccessPath(parentChainPath, validateHasBeenSet);
        _settings.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

