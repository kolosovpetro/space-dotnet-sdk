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

public sealed class ESRefreshToken
     : IPropagatePropertyAccessPath
{
    public ESRefreshToken() { }
    
    public ESRefreshToken(string id, XScopeApi scope, AccessRecord? lastAccess = null)
    {
        Id = id;
        Scope = scope;
        LastAccess = lastAccess;
    }
    
    private PropertyValue<string> _id = new PropertyValue<string>(nameof(ESRefreshToken), nameof(Id), "id");
    
    [Required]
    [JsonPropertyName("id")]
    public string Id
    {
        get => _id.GetValue(InlineErrors);
        set => _id.SetValue(value);
    }

    private PropertyValue<XScopeApi> _scope = new PropertyValue<XScopeApi>(nameof(ESRefreshToken), nameof(Scope), "scope");
    
    [Required]
    [JsonPropertyName("scope")]
    public XScopeApi Scope
    {
        get => _scope.GetValue(InlineErrors);
        set => _scope.SetValue(value);
    }

    private PropertyValue<AccessRecord?> _lastAccess = new PropertyValue<AccessRecord?>(nameof(ESRefreshToken), nameof(LastAccess), "lastAccess");
    
    [JsonPropertyName("lastAccess")]
    public AccessRecord? LastAccess
    {
        get => _lastAccess.GetValue(InlineErrors);
        set => _lastAccess.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _id.SetAccessPath(parentChainPath, validateHasBeenSet);
        _scope.SetAccessPath(parentChainPath, validateHasBeenSet);
        _lastAccess.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

