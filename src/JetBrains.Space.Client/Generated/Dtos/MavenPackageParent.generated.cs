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

public sealed class MavenPackageParent
     : IPropagatePropertyAccessPath
{
    public MavenPackageParent() { }
    
    public MavenPackageParent(string group, string artifact, string version)
    {
        Group = group;
        Artifact = artifact;
        Version = version;
    }
    
    private PropertyValue<string> _group = new PropertyValue<string>(nameof(MavenPackageParent), nameof(Group), "group");
    
    [Required]
    [JsonPropertyName("group")]
    public string Group
    {
        get => _group.GetValue(InlineErrors);
        set => _group.SetValue(value);
    }

    private PropertyValue<string> _artifact = new PropertyValue<string>(nameof(MavenPackageParent), nameof(Artifact), "artifact");
    
    [Required]
    [JsonPropertyName("artifact")]
    public string Artifact
    {
        get => _artifact.GetValue(InlineErrors);
        set => _artifact.SetValue(value);
    }

    private PropertyValue<string> _version = new PropertyValue<string>(nameof(MavenPackageParent), nameof(Version), "version");
    
    [Required]
    [JsonPropertyName("version")]
    public string Version
    {
        get => _version.GetValue(InlineErrors);
        set => _version.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _group.SetAccessPath(parentChainPath, validateHasBeenSet);
        _artifact.SetAccessPath(parentChainPath, validateHasBeenSet);
        _version.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

