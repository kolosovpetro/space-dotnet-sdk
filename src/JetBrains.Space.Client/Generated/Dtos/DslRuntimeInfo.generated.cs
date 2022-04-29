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

public sealed class DslRuntimeInfo
     : IPropagatePropertyAccessPath
{
    public DslRuntimeInfo() { }
    
    public DslRuntimeInfo(string mavenRepoUrl, MavenCoordinates mavenCoordinates)
    {
        MavenRepoUrl = mavenRepoUrl;
        MavenCoordinates = mavenCoordinates;
    }
    
    private PropertyValue<string> _mavenRepoUrl = new PropertyValue<string>(nameof(DslRuntimeInfo), nameof(MavenRepoUrl), "mavenRepoUrl");
    
    [Required]
    [JsonPropertyName("mavenRepoUrl")]
    public string MavenRepoUrl
    {
        get => _mavenRepoUrl.GetValue(InlineErrors);
        set => _mavenRepoUrl.SetValue(value);
    }

    private PropertyValue<MavenCoordinates> _mavenCoordinates = new PropertyValue<MavenCoordinates>(nameof(DslRuntimeInfo), nameof(MavenCoordinates), "mavenCoordinates");
    
    [Required]
    [JsonPropertyName("mavenCoordinates")]
    public MavenCoordinates MavenCoordinates
    {
        get => _mavenCoordinates.GetValue(InlineErrors);
        set => _mavenCoordinates.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _mavenRepoUrl.SetAccessPath(parentChainPath, validateHasBeenSet);
        _mavenCoordinates.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}
