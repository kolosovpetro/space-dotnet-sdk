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

public sealed class PackageData
     : IPropagatePropertyAccessPath
{
    public PackageData() { }
    
    public PackageData(PackageType type, string repository, string name, long versions, long updated, string lastVersion)
    {
        Type = type;
        Repository = repository;
        Name = name;
        Versions = versions;
        Updated = updated;
        LastVersion = lastVersion;
    }
    
    private PropertyValue<PackageType> _type = new PropertyValue<PackageType>(nameof(PackageData), nameof(Type), "type");
    
    [Required]
    [JsonPropertyName("type")]
    public PackageType Type
    {
        get => _type.GetValue(InlineErrors);
        set => _type.SetValue(value);
    }

    private PropertyValue<string> _repository = new PropertyValue<string>(nameof(PackageData), nameof(Repository), "repository");
    
    [Required]
    [JsonPropertyName("repository")]
    public string Repository
    {
        get => _repository.GetValue(InlineErrors);
        set => _repository.SetValue(value);
    }

    private PropertyValue<string> _name = new PropertyValue<string>(nameof(PackageData), nameof(Name), "name");
    
    [Required]
    [JsonPropertyName("name")]
    public string Name
    {
        get => _name.GetValue(InlineErrors);
        set => _name.SetValue(value);
    }

    private PropertyValue<long> _versions = new PropertyValue<long>(nameof(PackageData), nameof(Versions), "versions");
    
    [Required]
    [JsonPropertyName("versions")]
    public long Versions
    {
        get => _versions.GetValue(InlineErrors);
        set => _versions.SetValue(value);
    }

    private PropertyValue<long> _updated = new PropertyValue<long>(nameof(PackageData), nameof(Updated), "updated");
    
    [Required]
    [JsonPropertyName("updated")]
    public long Updated
    {
        get => _updated.GetValue(InlineErrors);
        set => _updated.SetValue(value);
    }

    private PropertyValue<string> _lastVersion = new PropertyValue<string>(nameof(PackageData), nameof(LastVersion), "lastVersion");
    
    [Required]
    [JsonPropertyName("lastVersion")]
    public string LastVersion
    {
        get => _lastVersion.GetValue(InlineErrors);
        set => _lastVersion.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _type.SetAccessPath(parentChainPath, validateHasBeenSet);
        _repository.SetAccessPath(parentChainPath, validateHasBeenSet);
        _name.SetAccessPath(parentChainPath, validateHasBeenSet);
        _versions.SetAccessPath(parentChainPath, validateHasBeenSet);
        _updated.SetAccessPath(parentChainPath, validateHasBeenSet);
        _lastVersion.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

