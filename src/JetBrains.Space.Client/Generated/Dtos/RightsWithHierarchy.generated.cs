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

public sealed class RightsWithHierarchy
     : IPropagatePropertyAccessPath
{
    public RightsWithHierarchy() { }
    
    public RightsWithHierarchy(List<RightTypeRight> rights, List<RightsGroup> rightsGroups, List<RightsDeps> deps)
    {
        Rights = rights;
        RightsGroups = rightsGroups;
        Deps = deps;
    }
    
    private PropertyValue<List<RightTypeRight>> _rights = new PropertyValue<List<RightTypeRight>>(nameof(RightsWithHierarchy), nameof(Rights), "rights", new List<RightTypeRight>());
    
    [Required]
    [JsonPropertyName("rights")]
    public List<RightTypeRight> Rights
    {
        get => _rights.GetValue(InlineErrors);
        set => _rights.SetValue(value);
    }

    private PropertyValue<List<RightsGroup>> _rightsGroups = new PropertyValue<List<RightsGroup>>(nameof(RightsWithHierarchy), nameof(RightsGroups), "rightsGroups", new List<RightsGroup>());
    
    [Required]
    [JsonPropertyName("rightsGroups")]
    public List<RightsGroup> RightsGroups
    {
        get => _rightsGroups.GetValue(InlineErrors);
        set => _rightsGroups.SetValue(value);
    }

    private PropertyValue<List<RightsDeps>> _deps = new PropertyValue<List<RightsDeps>>(nameof(RightsWithHierarchy), nameof(Deps), "deps", new List<RightsDeps>());
    
    [Required]
    [JsonPropertyName("deps")]
    public List<RightsDeps> Deps
    {
        get => _deps.GetValue(InlineErrors);
        set => _deps.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _rights.SetAccessPath(parentChainPath, validateHasBeenSet);
        _rightsGroups.SetAccessPath(parentChainPath, validateHasBeenSet);
        _deps.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

