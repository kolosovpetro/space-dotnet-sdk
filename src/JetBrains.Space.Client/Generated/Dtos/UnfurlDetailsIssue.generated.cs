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

public sealed class UnfurlDetailsIssue
     : UnfurlDetails, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "UnfurlDetailsIssue";
    
    public UnfurlDetailsIssue() { }
    
    public UnfurlDetailsIssue(Issue issue, bool? strikeThrough = null, bool? compact = null)
    {
        Issue = issue;
        IsStrikeThrough = strikeThrough;
        IsCompact = compact;
    }
    
    private PropertyValue<Issue> _issue = new PropertyValue<Issue>(nameof(UnfurlDetailsIssue), nameof(Issue), "issue");
    
    [Required]
    [JsonPropertyName("issue")]
    public Issue Issue
    {
        get => _issue.GetValue(InlineErrors);
        set => _issue.SetValue(value);
    }

    private PropertyValue<bool?> _strikeThrough = new PropertyValue<bool?>(nameof(UnfurlDetailsIssue), nameof(IsStrikeThrough), "strikeThrough");
    
    [JsonPropertyName("strikeThrough")]
    public bool? IsStrikeThrough
    {
        get => _strikeThrough.GetValue(InlineErrors);
        set => _strikeThrough.SetValue(value);
    }

    private PropertyValue<bool?> _compact = new PropertyValue<bool?>(nameof(UnfurlDetailsIssue), nameof(IsCompact), "compact");
    
    [JsonPropertyName("compact")]
    public bool? IsCompact
    {
        get => _compact.GetValue(InlineErrors);
        set => _compact.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _issue.SetAccessPath(parentChainPath, validateHasBeenSet);
        _strikeThrough.SetAccessPath(parentChainPath, validateHasBeenSet);
        _compact.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

