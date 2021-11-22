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

public sealed class ESHubProfileLoginDetails
     : ESProfileLoginDetails, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public override string? ClassName => "ES_HubProfileLoginDetails";
    
    public ESHubProfileLoginDetails() { }
    
    public ESHubProfileLoginDetails(bool emailVerified, string? login = null, string? hubAuthModuleLogin = null, string? firstName = null, string? lastName = null, string? email = null, string? avatarUrl = null)
    {
        Login = login;
        HubAuthModuleLogin = hubAuthModuleLogin;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        IsEmailVerified = emailVerified;
        AvatarUrl = avatarUrl;
    }
    
    private PropertyValue<string?> _login = new PropertyValue<string?>(nameof(ESHubProfileLoginDetails), nameof(Login), "login");
    
    [JsonPropertyName("login")]
    public string? Login
    {
        get => _login.GetValue(InlineErrors);
        set => _login.SetValue(value);
    }

    private PropertyValue<string?> _hubAuthModuleLogin = new PropertyValue<string?>(nameof(ESHubProfileLoginDetails), nameof(HubAuthModuleLogin), "hubAuthModuleLogin");
    
    [JsonPropertyName("hubAuthModuleLogin")]
    public string? HubAuthModuleLogin
    {
        get => _hubAuthModuleLogin.GetValue(InlineErrors);
        set => _hubAuthModuleLogin.SetValue(value);
    }

    private PropertyValue<string?> _firstName = new PropertyValue<string?>(nameof(ESHubProfileLoginDetails), nameof(FirstName), "firstName");
    
    [JsonPropertyName("firstName")]
    public string? FirstName
    {
        get => _firstName.GetValue(InlineErrors);
        set => _firstName.SetValue(value);
    }

    private PropertyValue<string?> _lastName = new PropertyValue<string?>(nameof(ESHubProfileLoginDetails), nameof(LastName), "lastName");
    
    [JsonPropertyName("lastName")]
    public string? LastName
    {
        get => _lastName.GetValue(InlineErrors);
        set => _lastName.SetValue(value);
    }

    private PropertyValue<string?> _email = new PropertyValue<string?>(nameof(ESHubProfileLoginDetails), nameof(Email), "email");
    
    [JsonPropertyName("email")]
    public string? Email
    {
        get => _email.GetValue(InlineErrors);
        set => _email.SetValue(value);
    }

    private PropertyValue<bool> _emailVerified = new PropertyValue<bool>(nameof(ESHubProfileLoginDetails), nameof(IsEmailVerified), "emailVerified");
    
    [Required]
    [JsonPropertyName("emailVerified")]
    public bool IsEmailVerified
    {
        get => _emailVerified.GetValue(InlineErrors);
        set => _emailVerified.SetValue(value);
    }

    private PropertyValue<string?> _avatarUrl = new PropertyValue<string?>(nameof(ESHubProfileLoginDetails), nameof(AvatarUrl), "avatarUrl");
    
    [JsonPropertyName("avatarUrl")]
    public string? AvatarUrl
    {
        get => _avatarUrl.GetValue(InlineErrors);
        set => _avatarUrl.SetValue(value);
    }

    public override void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _login.SetAccessPath(parentChainPath, validateHasBeenSet);
        _hubAuthModuleLogin.SetAccessPath(parentChainPath, validateHasBeenSet);
        _firstName.SetAccessPath(parentChainPath, validateHasBeenSet);
        _lastName.SetAccessPath(parentChainPath, validateHasBeenSet);
        _email.SetAccessPath(parentChainPath, validateHasBeenSet);
        _emailVerified.SetAccessPath(parentChainPath, validateHasBeenSet);
        _avatarUrl.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

