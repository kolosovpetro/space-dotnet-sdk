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

public sealed class EventTypeInfoDTO
     : IPropagatePropertyAccessPath
{
    public EventTypeInfoDTO() { }
    
    public EventTypeInfoDTO(string code, string name, string description, List<CRight> rights, int sortOrder, string? featureFlag = null)
    {
        Code = code;
        Name = name;
        Description = description;
        Rights = rights;
        FeatureFlag = featureFlag;
        SortOrder = sortOrder;
    }
    
    private PropertyValue<string> _code = new PropertyValue<string>(nameof(EventTypeInfoDTO), nameof(Code), "code");
    
    [Required]
    [JsonPropertyName("code")]
    public string Code
    {
        get => _code.GetValue(InlineErrors);
        set => _code.SetValue(value);
    }

    private PropertyValue<string> _name = new PropertyValue<string>(nameof(EventTypeInfoDTO), nameof(Name), "name");
    
    [Required]
    [JsonPropertyName("name")]
    public string Name
    {
        get => _name.GetValue(InlineErrors);
        set => _name.SetValue(value);
    }

    private PropertyValue<string> _description = new PropertyValue<string>(nameof(EventTypeInfoDTO), nameof(Description), "description");
    
    [Required]
    [JsonPropertyName("description")]
    public string Description
    {
        get => _description.GetValue(InlineErrors);
        set => _description.SetValue(value);
    }

    private PropertyValue<List<CRight>> _rights = new PropertyValue<List<CRight>>(nameof(EventTypeInfoDTO), nameof(Rights), "rights", new List<CRight>());
    
    [Required]
    [JsonPropertyName("rights")]
    public List<CRight> Rights
    {
        get => _rights.GetValue(InlineErrors);
        set => _rights.SetValue(value);
    }

    private PropertyValue<string?> _featureFlag = new PropertyValue<string?>(nameof(EventTypeInfoDTO), nameof(FeatureFlag), "featureFlag");
    
    [JsonPropertyName("featureFlag")]
    public string? FeatureFlag
    {
        get => _featureFlag.GetValue(InlineErrors);
        set => _featureFlag.SetValue(value);
    }

    private PropertyValue<int> _sortOrder = new PropertyValue<int>(nameof(EventTypeInfoDTO), nameof(SortOrder), "sortOrder");
    
    [Required]
    [JsonPropertyName("sortOrder")]
    public int SortOrder
    {
        get => _sortOrder.GetValue(InlineErrors);
        set => _sortOrder.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _code.SetAccessPath(parentChainPath, validateHasBeenSet);
        _name.SetAccessPath(parentChainPath, validateHasBeenSet);
        _description.SetAccessPath(parentChainPath, validateHasBeenSet);
        _rights.SetAccessPath(parentChainPath, validateHasBeenSet);
        _featureFlag.SetAccessPath(parentChainPath, validateHasBeenSet);
        _sortOrder.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

