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

public class NotificationsPrivateFeedsForIdPatchRequest
     : IPropagatePropertyAccessPath
{
    public NotificationsPrivateFeedsForIdPatchRequest() { }
    
    public NotificationsPrivateFeedsForIdPatchRequest(string? name = null, string? icon = null, PrivateFeedColor? color = null)
    {
        Name = name;
        Icon = icon;
        Color = color;
    }
    
    private PropertyValue<string?> _name = new PropertyValue<string?>(nameof(NotificationsPrivateFeedsForIdPatchRequest), nameof(Name), "name");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("name")]
    public string? Name
    {
        get => _name.GetValue(InlineErrors);
        set => _name.SetValue(value);
    }

    private PropertyValue<string?> _icon = new PropertyValue<string?>(nameof(NotificationsPrivateFeedsForIdPatchRequest), nameof(Icon), "icon");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("icon")]
    public string? Icon
    {
        get => _icon.GetValue(InlineErrors);
        set => _icon.SetValue(value);
    }

    private PropertyValue<PrivateFeedColor?> _color = new PropertyValue<PrivateFeedColor?>(nameof(NotificationsPrivateFeedsForIdPatchRequest), nameof(Color), "color");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("color")]
    public PrivateFeedColor? Color
    {
        get => _color.GetValue(InlineErrors);
        set => _color.SetValue(value);
    }

    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _name.SetAccessPath(parentChainPath, validateHasBeenSet);
        _icon.SetAccessPath(parentChainPath, validateHasBeenSet);
        _color.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

