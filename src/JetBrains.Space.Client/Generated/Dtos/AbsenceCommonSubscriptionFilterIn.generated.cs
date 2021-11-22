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

public sealed class AbsenceCommonSubscriptionFilterIn
     : SubscriptionFilterIn, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "AbsenceCommonSubscriptionFilterIn";
    
    public AbsenceCommonSubscriptionFilterIn() { }
    
    public AbsenceCommonSubscriptionFilterIn(List<string> reasons)
    {
        Reasons = reasons;
    }
    
    private PropertyValue<List<string>> _reasons = new PropertyValue<List<string>>(nameof(AbsenceCommonSubscriptionFilterIn), nameof(Reasons), "reasons", new List<string>());
    
    [Required]
    [JsonPropertyName("reasons")]
    public List<string> Reasons
    {
        get => _reasons.GetValue(InlineErrors);
        set => _reasons.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _reasons.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

