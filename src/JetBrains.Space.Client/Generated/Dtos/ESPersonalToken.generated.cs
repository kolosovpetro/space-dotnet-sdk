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

public sealed class ESPersonalToken
     : IPropagatePropertyAccessPath
{
    public ESPersonalToken() { }
    
    public ESPersonalToken(string id, string name, TDMemberProfile profile, string scope, DateTime created, DateTime? expires = null, AccessRecord? lastAccess = null)
    {
        Id = id;
        Name = name;
        Profile = profile;
        Scope = scope;
        Created = created;
        Expires = expires;
        LastAccess = lastAccess;
    }
    
    private PropertyValue<string> _id = new PropertyValue<string>(nameof(ESPersonalToken), nameof(Id), "id");
    
    [Required]
    [JsonPropertyName("id")]
    public string Id
    {
        get => _id.GetValue(InlineErrors);
        set => _id.SetValue(value);
    }

    private PropertyValue<string> _name = new PropertyValue<string>(nameof(ESPersonalToken), nameof(Name), "name");
    
    [Required]
    [JsonPropertyName("name")]
    public string Name
    {
        get => _name.GetValue(InlineErrors);
        set => _name.SetValue(value);
    }

    private PropertyValue<TDMemberProfile> _profile = new PropertyValue<TDMemberProfile>(nameof(ESPersonalToken), nameof(Profile), "profile");
    
    [Required]
    [JsonPropertyName("profile")]
    public TDMemberProfile Profile
    {
        get => _profile.GetValue(InlineErrors);
        set => _profile.SetValue(value);
    }

    private PropertyValue<string> _scope = new PropertyValue<string>(nameof(ESPersonalToken), nameof(Scope), "scope");
    
    [Required]
    [JsonPropertyName("scope")]
    public string Scope
    {
        get => _scope.GetValue(InlineErrors);
        set => _scope.SetValue(value);
    }

    private PropertyValue<DateTime> _created = new PropertyValue<DateTime>(nameof(ESPersonalToken), nameof(Created), "created");
    
    [Required]
    [JsonPropertyName("created")]
    [JsonConverter(typeof(SpaceDateTimeConverter))]
    public DateTime Created
    {
        get => _created.GetValue(InlineErrors);
        set => _created.SetValue(value);
    }

    private PropertyValue<DateTime?> _expires = new PropertyValue<DateTime?>(nameof(ESPersonalToken), nameof(Expires), "expires");
    
    [JsonPropertyName("expires")]
    [JsonConverter(typeof(SpaceDateTimeConverter))]
    public DateTime? Expires
    {
        get => _expires.GetValue(InlineErrors);
        set => _expires.SetValue(value);
    }

    private PropertyValue<AccessRecord?> _lastAccess = new PropertyValue<AccessRecord?>(nameof(ESPersonalToken), nameof(LastAccess), "lastAccess");
    
    [JsonPropertyName("lastAccess")]
    public AccessRecord? LastAccess
    {
        get => _lastAccess.GetValue(InlineErrors);
        set => _lastAccess.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _id.SetAccessPath(parentChainPath, validateHasBeenSet);
        _name.SetAccessPath(parentChainPath, validateHasBeenSet);
        _profile.SetAccessPath(parentChainPath, validateHasBeenSet);
        _scope.SetAccessPath(parentChainPath, validateHasBeenSet);
        _created.SetAccessPath(parentChainPath, validateHasBeenSet);
        _expires.SetAccessPath(parentChainPath, validateHasBeenSet);
        _lastAccess.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

