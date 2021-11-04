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

public sealed class EndpointAuthUpdate
     : IPropagatePropertyAccessPath
{
    public EndpointAuthUpdate() { }
    
    public EndpointAuthUpdate(EndpointAppLevelAuthUpdateType appLevelAuth, bool hasVerificationToken, string? basicAuthUsername = null, string? basicAuthPassword = null, string? bearerAuthToken = null, string? sslKeystoreAuth = null)
    {
        AppLevelAuth = appLevelAuth;
        BasicAuthUsername = (basicAuthUsername ?? string.Empty);
        BasicAuthPassword = (basicAuthPassword ?? string.Empty);
        BearerAuthToken = (bearerAuthToken ?? string.Empty);
        IsHasVerificationToken = hasVerificationToken;
        SslKeystoreAuth = sslKeystoreAuth;
    }
    
    private PropertyValue<EndpointAppLevelAuthUpdateType> _appLevelAuth = new PropertyValue<EndpointAppLevelAuthUpdateType>(nameof(EndpointAuthUpdate), nameof(AppLevelAuth));
    
    [JsonPropertyName("appLevelAuth")]
    public EndpointAppLevelAuthUpdateType AppLevelAuth
    {
        get => _appLevelAuth.GetValue();
        set => _appLevelAuth.SetValue(value);
    }

    private PropertyValue<string> _basicAuthUsername = new PropertyValue<string>(nameof(EndpointAuthUpdate), nameof(BasicAuthUsername), string.Empty);
    
    [JsonPropertyName("basicAuthUsername")]
    public string BasicAuthUsername
    {
        get => _basicAuthUsername.GetValue();
        set => _basicAuthUsername.SetValue(value);
    }

    private PropertyValue<string> _basicAuthPassword = new PropertyValue<string>(nameof(EndpointAuthUpdate), nameof(BasicAuthPassword), string.Empty);
    
    [JsonPropertyName("basicAuthPassword")]
    public string BasicAuthPassword
    {
        get => _basicAuthPassword.GetValue();
        set => _basicAuthPassword.SetValue(value);
    }

    private PropertyValue<string> _bearerAuthToken = new PropertyValue<string>(nameof(EndpointAuthUpdate), nameof(BearerAuthToken), string.Empty);
    
    [JsonPropertyName("bearerAuthToken")]
    public string BearerAuthToken
    {
        get => _bearerAuthToken.GetValue();
        set => _bearerAuthToken.SetValue(value);
    }

    private PropertyValue<bool> _hasVerificationToken = new PropertyValue<bool>(nameof(EndpointAuthUpdate), nameof(IsHasVerificationToken));
    
    [JsonPropertyName("hasVerificationToken")]
    public bool IsHasVerificationToken
    {
        get => _hasVerificationToken.GetValue();
        set => _hasVerificationToken.SetValue(value);
    }

    private PropertyValue<string?> _sslKeystoreAuth = new PropertyValue<string?>(nameof(EndpointAuthUpdate), nameof(SslKeystoreAuth));
    
    [JsonPropertyName("sslKeystoreAuth")]
    public string? SslKeystoreAuth
    {
        get => _sslKeystoreAuth.GetValue();
        set => _sslKeystoreAuth.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _appLevelAuth.SetAccessPath(path, validateHasBeenSet);
        _basicAuthUsername.SetAccessPath(path, validateHasBeenSet);
        _basicAuthPassword.SetAccessPath(path, validateHasBeenSet);
        _bearerAuthToken.SetAccessPath(path, validateHasBeenSet);
        _hasVerificationToken.SetAccessPath(path, validateHasBeenSet);
        _sslKeystoreAuth.SetAccessPath(path, validateHasBeenSet);
    }

}

