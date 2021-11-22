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

public sealed class ESGithubAuthModuleSettings
     : ESOAuth2AuthModuleSettings, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public override string? ClassName => "ES_GithubAuthModuleSettings";
    
    public ESGithubAuthModuleSettings() { }
    
    public ESGithubAuthModuleSettings(string githubUrl, string clientId, string clientSecret, bool registerNewUsers, List<string> organizations)
    {
        GithubUrl = githubUrl;
        ClientId = clientId;
        ClientSecret = clientSecret;
        IsRegisterNewUsers = registerNewUsers;
        Organizations = organizations;
    }
    
    private PropertyValue<string> _githubUrl = new PropertyValue<string>(nameof(ESGithubAuthModuleSettings), nameof(GithubUrl), "githubUrl");
    
    [Required]
    [JsonPropertyName("githubUrl")]
    public string GithubUrl
    {
        get => _githubUrl.GetValue(InlineErrors);
        set => _githubUrl.SetValue(value);
    }

    private PropertyValue<string> _clientId = new PropertyValue<string>(nameof(ESGithubAuthModuleSettings), nameof(ClientId), "clientId");
    
    [Required]
    [JsonPropertyName("clientId")]
    public string ClientId
    {
        get => _clientId.GetValue(InlineErrors);
        set => _clientId.SetValue(value);
    }

    private PropertyValue<string> _clientSecret = new PropertyValue<string>(nameof(ESGithubAuthModuleSettings), nameof(ClientSecret), "clientSecret");
    
    [Required]
    [JsonPropertyName("clientSecret")]
    public string ClientSecret
    {
        get => _clientSecret.GetValue(InlineErrors);
        set => _clientSecret.SetValue(value);
    }

    private PropertyValue<bool> _registerNewUsers = new PropertyValue<bool>(nameof(ESGithubAuthModuleSettings), nameof(IsRegisterNewUsers), "registerNewUsers");
    
    [Required]
    [JsonPropertyName("registerNewUsers")]
    public bool IsRegisterNewUsers
    {
        get => _registerNewUsers.GetValue(InlineErrors);
        set => _registerNewUsers.SetValue(value);
    }

    private PropertyValue<List<string>> _organizations = new PropertyValue<List<string>>(nameof(ESGithubAuthModuleSettings), nameof(Organizations), "organizations", new List<string>());
    
    [Required]
    [JsonPropertyName("organizations")]
    public List<string> Organizations
    {
        get => _organizations.GetValue(InlineErrors);
        set => _organizations.SetValue(value);
    }

    public override void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _githubUrl.SetAccessPath(parentChainPath, validateHasBeenSet);
        _clientId.SetAccessPath(parentChainPath, validateHasBeenSet);
        _clientSecret.SetAccessPath(parentChainPath, validateHasBeenSet);
        _registerNewUsers.SetAccessPath(parentChainPath, validateHasBeenSet);
        _organizations.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

