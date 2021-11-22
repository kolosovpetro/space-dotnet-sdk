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

public sealed class SubscriptionRequestedAuthorizations
     : IPropagatePropertyAccessPath
{
    public SubscriptionRequestedAuthorizations() { }
    
    public SubscriptionRequestedAuthorizations(List<Right> rights, List<string> rightCodes, List<PRProject> projects, PermissionContextApi? permissionContext = null)
    {
        Rights = rights;
        RightCodes = rightCodes;
        PermissionContext = permissionContext;
        Projects = projects;
    }
    
    private PropertyValue<List<Right>> _rights = new PropertyValue<List<Right>>(nameof(SubscriptionRequestedAuthorizations), nameof(Rights), "rights", new List<Right>());
    
    [Required]
    [JsonPropertyName("rights")]
    public List<Right> Rights
    {
        get => _rights.GetValue(InlineErrors);
        set => _rights.SetValue(value);
    }

    private PropertyValue<List<string>> _rightCodes = new PropertyValue<List<string>>(nameof(SubscriptionRequestedAuthorizations), nameof(RightCodes), "rightCodes", new List<string>());
    
    [Required]
    [JsonPropertyName("rightCodes")]
    public List<string> RightCodes
    {
        get => _rightCodes.GetValue(InlineErrors);
        set => _rightCodes.SetValue(value);
    }

    private PropertyValue<PermissionContextApi?> _permissionContext = new PropertyValue<PermissionContextApi?>(nameof(SubscriptionRequestedAuthorizations), nameof(PermissionContext), "permissionContext");
    
    [JsonPropertyName("permissionContext")]
    public PermissionContextApi? PermissionContext
    {
        get => _permissionContext.GetValue(InlineErrors);
        set => _permissionContext.SetValue(value);
    }

    private PropertyValue<List<PRProject>> _projects = new PropertyValue<List<PRProject>>(nameof(SubscriptionRequestedAuthorizations), nameof(Projects), "projects", new List<PRProject>());
    
    [Required]
    [JsonPropertyName("projects")]
    public List<PRProject> Projects
    {
        get => _projects.GetValue(InlineErrors);
        set => _projects.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _rights.SetAccessPath(parentChainPath, validateHasBeenSet);
        _rightCodes.SetAccessPath(parentChainPath, validateHasBeenSet);
        _permissionContext.SetAccessPath(parentChainPath, validateHasBeenSet);
        _projects.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

