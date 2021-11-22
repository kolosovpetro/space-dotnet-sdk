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

public sealed class IssueStatusData
     : IPropagatePropertyAccessPath
{
    public IssueStatusData() { }
    
    public IssueStatusData(string name, bool resolved, string color, string? existingId = null, IssueStatus? originalStatus = null)
    {
        ExistingId = existingId;
        Name = name;
        IsResolved = resolved;
        Color = color;
        OriginalStatus = originalStatus;
    }
    
    private PropertyValue<string?> _existingId = new PropertyValue<string?>(nameof(IssueStatusData), nameof(ExistingId), "existingId");
    
    [JsonPropertyName("existingId")]
    public string? ExistingId
    {
        get => _existingId.GetValue(InlineErrors);
        set => _existingId.SetValue(value);
    }

    private PropertyValue<string> _name = new PropertyValue<string>(nameof(IssueStatusData), nameof(Name), "name");
    
    [Required]
    [JsonPropertyName("name")]
    public string Name
    {
        get => _name.GetValue(InlineErrors);
        set => _name.SetValue(value);
    }

    private PropertyValue<bool> _resolved = new PropertyValue<bool>(nameof(IssueStatusData), nameof(IsResolved), "resolved");
    
    [Required]
    [JsonPropertyName("resolved")]
    public bool IsResolved
    {
        get => _resolved.GetValue(InlineErrors);
        set => _resolved.SetValue(value);
    }

    private PropertyValue<string> _color = new PropertyValue<string>(nameof(IssueStatusData), nameof(Color), "color");
    
    [Required]
    [JsonPropertyName("color")]
    public string Color
    {
        get => _color.GetValue(InlineErrors);
        set => _color.SetValue(value);
    }

    private PropertyValue<IssueStatus?> _originalStatus = new PropertyValue<IssueStatus?>(nameof(IssueStatusData), nameof(OriginalStatus), "originalStatus");
    
    [JsonPropertyName("originalStatus")]
    public IssueStatus? OriginalStatus
    {
        get => _originalStatus.GetValue(InlineErrors);
        set => _originalStatus.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _existingId.SetAccessPath(parentChainPath, validateHasBeenSet);
        _name.SetAccessPath(parentChainPath, validateHasBeenSet);
        _resolved.SetAccessPath(parentChainPath, validateHasBeenSet);
        _color.SetAccessPath(parentChainPath, validateHasBeenSet);
        _originalStatus.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

