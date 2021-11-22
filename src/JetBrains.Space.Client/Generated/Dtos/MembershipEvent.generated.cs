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

public sealed class MembershipEvent
     : IPropagatePropertyAccessPath
{
    public MembershipEvent() { }
    
    public MembershipEvent(TDMemberProfile profile, List<TDMembership> membership)
    {
        Profile = profile;
        Membership = membership;
    }
    
    private PropertyValue<TDMemberProfile> _profile = new PropertyValue<TDMemberProfile>(nameof(MembershipEvent), nameof(Profile), "profile");
    
    [Required]
    [JsonPropertyName("profile")]
    public TDMemberProfile Profile
    {
        get => _profile.GetValue(InlineErrors);
        set => _profile.SetValue(value);
    }

    private PropertyValue<List<TDMembership>> _membership = new PropertyValue<List<TDMembership>>(nameof(MembershipEvent), nameof(Membership), "membership", new List<TDMembership>());
    
    [Required]
    [JsonPropertyName("membership")]
    public List<TDMembership> Membership
    {
        get => _membership.GetValue(InlineErrors);
        set => _membership.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _profile.SetAccessPath(parentChainPath, validateHasBeenSet);
        _membership.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

