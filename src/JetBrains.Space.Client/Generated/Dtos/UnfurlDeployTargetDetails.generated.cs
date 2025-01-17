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

public sealed class UnfurlDeployTargetDetails
     : UnfurlDetails, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "UnfurlDeployTargetDetails";
    
    public UnfurlDeployTargetDetails() { }
    
    public UnfurlDeployTargetDetails(DeployTargetRecord targetRef, string? targetName = null, bool? showLinkIcon = null, bool? skipDetailsRender = null)
    {
        TargetRef = targetRef;
        TargetName = targetName;
        IsShowLinkIcon = showLinkIcon;
        IsSkipDetailsRender = skipDetailsRender;
    }
    
    private PropertyValue<DeployTargetRecord> _targetRef = new PropertyValue<DeployTargetRecord>(nameof(UnfurlDeployTargetDetails), nameof(TargetRef), "targetRef");
    
    [Required]
    [JsonPropertyName("targetRef")]
    public DeployTargetRecord TargetRef
    {
        get => _targetRef.GetValue(InlineErrors);
        set => _targetRef.SetValue(value);
    }

    private PropertyValue<string?> _targetName = new PropertyValue<string?>(nameof(UnfurlDeployTargetDetails), nameof(TargetName), "targetName");
    
    [JsonPropertyName("targetName")]
    public string? TargetName
    {
        get => _targetName.GetValue(InlineErrors);
        set => _targetName.SetValue(value);
    }

    private PropertyValue<bool?> _showLinkIcon = new PropertyValue<bool?>(nameof(UnfurlDeployTargetDetails), nameof(IsShowLinkIcon), "showLinkIcon");
    
    [JsonPropertyName("showLinkIcon")]
    public bool? IsShowLinkIcon
    {
        get => _showLinkIcon.GetValue(InlineErrors);
        set => _showLinkIcon.SetValue(value);
    }

    private PropertyValue<bool?> _skipDetailsRender = new PropertyValue<bool?>(nameof(UnfurlDeployTargetDetails), nameof(IsSkipDetailsRender), "skipDetailsRender");
    
    [JsonPropertyName("skipDetailsRender")]
    public bool? IsSkipDetailsRender
    {
        get => _skipDetailsRender.GetValue(InlineErrors);
        set => _skipDetailsRender.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _targetRef.SetAccessPath(parentChainPath, validateHasBeenSet);
        _targetName.SetAccessPath(parentChainPath, validateHasBeenSet);
        _showLinkIcon.SetAccessPath(parentChainPath, validateHasBeenSet);
        _skipDetailsRender.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

