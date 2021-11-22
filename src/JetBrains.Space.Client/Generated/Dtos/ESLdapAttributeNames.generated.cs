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

public sealed class ESLdapAttributeNames
     : IPropagatePropertyAccessPath
{
    public ESLdapAttributeNames() { }
    
    public ESLdapAttributeNames(string? fullNameAttributeName = null, string? usernameAttributeName = null, string? emailAttributeName = null, string? groupsAttributeName = null)
    {
        FullNameAttributeName = fullNameAttributeName;
        UsernameAttributeName = usernameAttributeName;
        EmailAttributeName = emailAttributeName;
        GroupsAttributeName = groupsAttributeName;
    }
    
    private PropertyValue<string?> _fullNameAttributeName = new PropertyValue<string?>(nameof(ESLdapAttributeNames), nameof(FullNameAttributeName), "fullNameAttributeName");
    
    [JsonPropertyName("fullNameAttributeName")]
    public string? FullNameAttributeName
    {
        get => _fullNameAttributeName.GetValue(InlineErrors);
        set => _fullNameAttributeName.SetValue(value);
    }

    private PropertyValue<string?> _usernameAttributeName = new PropertyValue<string?>(nameof(ESLdapAttributeNames), nameof(UsernameAttributeName), "usernameAttributeName");
    
    [JsonPropertyName("usernameAttributeName")]
    public string? UsernameAttributeName
    {
        get => _usernameAttributeName.GetValue(InlineErrors);
        set => _usernameAttributeName.SetValue(value);
    }

    private PropertyValue<string?> _emailAttributeName = new PropertyValue<string?>(nameof(ESLdapAttributeNames), nameof(EmailAttributeName), "emailAttributeName");
    
    [JsonPropertyName("emailAttributeName")]
    public string? EmailAttributeName
    {
        get => _emailAttributeName.GetValue(InlineErrors);
        set => _emailAttributeName.SetValue(value);
    }

    private PropertyValue<string?> _groupsAttributeName = new PropertyValue<string?>(nameof(ESLdapAttributeNames), nameof(GroupsAttributeName), "groupsAttributeName");
    
    [JsonPropertyName("groupsAttributeName")]
    public string? GroupsAttributeName
    {
        get => _groupsAttributeName.GetValue(InlineErrors);
        set => _groupsAttributeName.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _fullNameAttributeName.SetAccessPath(parentChainPath, validateHasBeenSet);
        _usernameAttributeName.SetAccessPath(parentChainPath, validateHasBeenSet);
        _emailAttributeName.SetAccessPath(parentChainPath, validateHasBeenSet);
        _groupsAttributeName.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

