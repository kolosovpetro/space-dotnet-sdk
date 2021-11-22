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

public sealed class NavigateUrlAction
     : MessageAction, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "NavigateUrlAction";
    
    public NavigateUrlAction() { }
    
    public NavigateUrlAction(string url, bool withBackUrl, bool openInNewTab)
    {
        Url = url;
        IsWithBackUrl = withBackUrl;
        IsOpenInNewTab = openInNewTab;
    }
    
    private PropertyValue<string> _url = new PropertyValue<string>(nameof(NavigateUrlAction), nameof(Url), "url");
    
    [Required]
    [JsonPropertyName("url")]
    public string Url
    {
        get => _url.GetValue(InlineErrors);
        set => _url.SetValue(value);
    }

    private PropertyValue<bool> _withBackUrl = new PropertyValue<bool>(nameof(NavigateUrlAction), nameof(IsWithBackUrl), "withBackUrl");
    
    [Required]
    [JsonPropertyName("withBackUrl")]
    public bool IsWithBackUrl
    {
        get => _withBackUrl.GetValue(InlineErrors);
        set => _withBackUrl.SetValue(value);
    }

    private PropertyValue<bool> _openInNewTab = new PropertyValue<bool>(nameof(NavigateUrlAction), nameof(IsOpenInNewTab), "openInNewTab");
    
    [Required]
    [JsonPropertyName("openInNewTab")]
    public bool IsOpenInNewTab
    {
        get => _openInNewTab.GetValue(InlineErrors);
        set => _openInNewTab.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _url.SetAccessPath(parentChainPath, validateHasBeenSet);
        _withBackUrl.SetAccessPath(parentChainPath, validateHasBeenSet);
        _openInNewTab.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

