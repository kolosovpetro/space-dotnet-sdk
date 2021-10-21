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

public class ApplicationsPostRequest
     : IPropagatePropertyAccessPath
{
    public ApplicationsPostRequest() { }
    
    public ApplicationsPostRequest(string name, bool endpointSslVerification = true, string? pictureAttachmentId = null, string? defaultExternalPicture = null, string? clientId = null, string? clientSecret = null, bool? clientCredentialsFlowEnabled = null, bool? codeFlowEnabled = null, string? codeFlowRedirectURIs = null, bool? pkceRequired = null, bool? implicitFlowEnabled = null, string? implicitFlowRedirectURIs = null, string? endpointUri = null, EndpointAuthCreate? appLevelAuth = null, string? sslKeystoreAuth = null, bool? hasVerificationToken = null, bool? hasSigningKey = null, bool? hasPublicKeySignature = null, string? basicAuthUsername = null, string? basicAuthPassword = null, string? bearerAuthToken = null, bool? connectToSpace = false, string? state = null)
    {
        Name = name;
        PictureAttachmentId = pictureAttachmentId;
        DefaultExternalPicture = defaultExternalPicture;
        ClientId = clientId;
        ClientSecret = clientSecret;
        IsClientCredentialsFlowEnabled = clientCredentialsFlowEnabled;
        IsCodeFlowEnabled = codeFlowEnabled;
        CodeFlowRedirectURIs = codeFlowRedirectURIs;
        IsPkceRequired = pkceRequired;
        IsImplicitFlowEnabled = implicitFlowEnabled;
        ImplicitFlowRedirectURIs = implicitFlowRedirectURIs;
        EndpointUri = endpointUri;
        IsEndpointSslVerification = endpointSslVerification;
        AppLevelAuth = appLevelAuth;
        SslKeystoreAuth = sslKeystoreAuth;
        IsHasVerificationToken = hasVerificationToken;
        IsHasSigningKey = hasSigningKey;
        IsHasPublicKeySignature = hasPublicKeySignature;
        BasicAuthUsername = basicAuthUsername;
        BasicAuthPassword = basicAuthPassword;
        BearerAuthToken = bearerAuthToken;
        IsConnectToSpace = connectToSpace;
        State = state;
    }
    
    private PropertyValue<string> _name = new PropertyValue<string>(nameof(ApplicationsPostRequest), nameof(Name));
    
    [Required]
    [JsonPropertyName("name")]
    public string Name
    {
        get => _name.GetValue();
        set => _name.SetValue(value);
    }

    private PropertyValue<string?> _pictureAttachmentId = new PropertyValue<string?>(nameof(ApplicationsPostRequest), nameof(PictureAttachmentId));
    
    [JsonPropertyName("pictureAttachmentId")]
    public string? PictureAttachmentId
    {
        get => _pictureAttachmentId.GetValue();
        set => _pictureAttachmentId.SetValue(value);
    }

    private PropertyValue<string?> _defaultExternalPicture = new PropertyValue<string?>(nameof(ApplicationsPostRequest), nameof(DefaultExternalPicture));
    
    [JsonPropertyName("defaultExternalPicture")]
    public string? DefaultExternalPicture
    {
        get => _defaultExternalPicture.GetValue();
        set => _defaultExternalPicture.SetValue(value);
    }

    private PropertyValue<string?> _clientId = new PropertyValue<string?>(nameof(ApplicationsPostRequest), nameof(ClientId));
    
    [JsonPropertyName("clientId")]
    public string? ClientId
    {
        get => _clientId.GetValue();
        set => _clientId.SetValue(value);
    }

    private PropertyValue<string?> _clientSecret = new PropertyValue<string?>(nameof(ApplicationsPostRequest), nameof(ClientSecret));
    
    [JsonPropertyName("clientSecret")]
    public string? ClientSecret
    {
        get => _clientSecret.GetValue();
        set => _clientSecret.SetValue(value);
    }

    private PropertyValue<bool?> _clientCredentialsFlowEnabled = new PropertyValue<bool?>(nameof(ApplicationsPostRequest), nameof(IsClientCredentialsFlowEnabled));
    
    [JsonPropertyName("clientCredentialsFlowEnabled")]
    public bool? IsClientCredentialsFlowEnabled
    {
        get => _clientCredentialsFlowEnabled.GetValue();
        set => _clientCredentialsFlowEnabled.SetValue(value);
    }

    private PropertyValue<bool?> _codeFlowEnabled = new PropertyValue<bool?>(nameof(ApplicationsPostRequest), nameof(IsCodeFlowEnabled));
    
    [JsonPropertyName("codeFlowEnabled")]
    public bool? IsCodeFlowEnabled
    {
        get => _codeFlowEnabled.GetValue();
        set => _codeFlowEnabled.SetValue(value);
    }

    private PropertyValue<string?> _codeFlowRedirectURIs = new PropertyValue<string?>(nameof(ApplicationsPostRequest), nameof(CodeFlowRedirectURIs));
    
    [JsonPropertyName("codeFlowRedirectURIs")]
    public string? CodeFlowRedirectURIs
    {
        get => _codeFlowRedirectURIs.GetValue();
        set => _codeFlowRedirectURIs.SetValue(value);
    }

    private PropertyValue<bool?> _pkceRequired = new PropertyValue<bool?>(nameof(ApplicationsPostRequest), nameof(IsPkceRequired));
    
    [JsonPropertyName("pkceRequired")]
    public bool? IsPkceRequired
    {
        get => _pkceRequired.GetValue();
        set => _pkceRequired.SetValue(value);
    }

    private PropertyValue<bool?> _implicitFlowEnabled = new PropertyValue<bool?>(nameof(ApplicationsPostRequest), nameof(IsImplicitFlowEnabled));
    
    [JsonPropertyName("implicitFlowEnabled")]
    public bool? IsImplicitFlowEnabled
    {
        get => _implicitFlowEnabled.GetValue();
        set => _implicitFlowEnabled.SetValue(value);
    }

    private PropertyValue<string?> _implicitFlowRedirectURIs = new PropertyValue<string?>(nameof(ApplicationsPostRequest), nameof(ImplicitFlowRedirectURIs));
    
    [JsonPropertyName("implicitFlowRedirectURIs")]
    public string? ImplicitFlowRedirectURIs
    {
        get => _implicitFlowRedirectURIs.GetValue();
        set => _implicitFlowRedirectURIs.SetValue(value);
    }

    private PropertyValue<string?> _endpointUri = new PropertyValue<string?>(nameof(ApplicationsPostRequest), nameof(EndpointUri));
    
    [JsonPropertyName("endpointUri")]
    public string? EndpointUri
    {
        get => _endpointUri.GetValue();
        set => _endpointUri.SetValue(value);
    }

    private PropertyValue<bool> _endpointSslVerification = new PropertyValue<bool>(nameof(ApplicationsPostRequest), nameof(IsEndpointSslVerification));
    
    [JsonPropertyName("endpointSslVerification")]
    public bool IsEndpointSslVerification
    {
        get => _endpointSslVerification.GetValue();
        set => _endpointSslVerification.SetValue(value);
    }

    private PropertyValue<EndpointAuthCreate?> _appLevelAuth = new PropertyValue<EndpointAuthCreate?>(nameof(ApplicationsPostRequest), nameof(AppLevelAuth));
    
    [JsonPropertyName("appLevelAuth")]
    public EndpointAuthCreate? AppLevelAuth
    {
        get => _appLevelAuth.GetValue();
        set => _appLevelAuth.SetValue(value);
    }

    private PropertyValue<string?> _sslKeystoreAuth = new PropertyValue<string?>(nameof(ApplicationsPostRequest), nameof(SslKeystoreAuth));
    
    [JsonPropertyName("sslKeystoreAuth")]
    public string? SslKeystoreAuth
    {
        get => _sslKeystoreAuth.GetValue();
        set => _sslKeystoreAuth.SetValue(value);
    }

    private PropertyValue<bool?> _hasVerificationToken = new PropertyValue<bool?>(nameof(ApplicationsPostRequest), nameof(IsHasVerificationToken));
    
    [Obsolete("It's an obsolete auth type - please use another one (since 2021-09-02) (will be removed in a future version)")]
    [JsonPropertyName("hasVerificationToken")]
    public bool? IsHasVerificationToken
    {
        get => _hasVerificationToken.GetValue();
        set => _hasVerificationToken.SetValue(value);
    }

    private PropertyValue<bool?> _hasSigningKey = new PropertyValue<bool?>(nameof(ApplicationsPostRequest), nameof(IsHasSigningKey));
    
    [Obsolete("Use appLevelAuth instead (since 2021-09-02) (will be removed in a future version)")]
    [JsonPropertyName("hasSigningKey")]
    public bool? IsHasSigningKey
    {
        get => _hasSigningKey.GetValue();
        set => _hasSigningKey.SetValue(value);
    }

    private PropertyValue<bool?> _hasPublicKeySignature = new PropertyValue<bool?>(nameof(ApplicationsPostRequest), nameof(IsHasPublicKeySignature));
    
    [Obsolete("Use appLevelAuth instead (since 2021-09-02) (will be removed in a future version)")]
    [JsonPropertyName("hasPublicKeySignature")]
    public bool? IsHasPublicKeySignature
    {
        get => _hasPublicKeySignature.GetValue();
        set => _hasPublicKeySignature.SetValue(value);
    }

    private PropertyValue<string?> _basicAuthUsername = new PropertyValue<string?>(nameof(ApplicationsPostRequest), nameof(BasicAuthUsername));
    
    [Obsolete("Use appLevelAuth instead (since 2021-09-02) (will be removed in a future version)")]
    [JsonPropertyName("basicAuthUsername")]
    public string? BasicAuthUsername
    {
        get => _basicAuthUsername.GetValue();
        set => _basicAuthUsername.SetValue(value);
    }

    private PropertyValue<string?> _basicAuthPassword = new PropertyValue<string?>(nameof(ApplicationsPostRequest), nameof(BasicAuthPassword));
    
    [Obsolete("Use appLevelAuth instead (since 2021-09-02) (will be removed in a future version)")]
    [JsonPropertyName("basicAuthPassword")]
    public string? BasicAuthPassword
    {
        get => _basicAuthPassword.GetValue();
        set => _basicAuthPassword.SetValue(value);
    }

    private PropertyValue<string?> _bearerAuthToken = new PropertyValue<string?>(nameof(ApplicationsPostRequest), nameof(BearerAuthToken));
    
    [Obsolete("Use appLevelAuth instead (since 2021-09-02) (will be removed in a future version)")]
    [JsonPropertyName("bearerAuthToken")]
    public string? BearerAuthToken
    {
        get => _bearerAuthToken.GetValue();
        set => _bearerAuthToken.SetValue(value);
    }

    private PropertyValue<bool?> _connectToSpace = new PropertyValue<bool?>(nameof(ApplicationsPostRequest), nameof(IsConnectToSpace));
    
    [JsonPropertyName("connectToSpace")]
    public bool? IsConnectToSpace
    {
        get => _connectToSpace.GetValue();
        set => _connectToSpace.SetValue(value);
    }

    private PropertyValue<string?> _state = new PropertyValue<string?>(nameof(ApplicationsPostRequest), nameof(State));
    
    [JsonPropertyName("state")]
    public string? State
    {
        get => _state.GetValue();
        set => _state.SetValue(value);
    }

    public virtual void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _name.SetAccessPath(path, validateHasBeenSet);
        _pictureAttachmentId.SetAccessPath(path, validateHasBeenSet);
        _defaultExternalPicture.SetAccessPath(path, validateHasBeenSet);
        _clientId.SetAccessPath(path, validateHasBeenSet);
        _clientSecret.SetAccessPath(path, validateHasBeenSet);
        _clientCredentialsFlowEnabled.SetAccessPath(path, validateHasBeenSet);
        _codeFlowEnabled.SetAccessPath(path, validateHasBeenSet);
        _codeFlowRedirectURIs.SetAccessPath(path, validateHasBeenSet);
        _pkceRequired.SetAccessPath(path, validateHasBeenSet);
        _implicitFlowEnabled.SetAccessPath(path, validateHasBeenSet);
        _implicitFlowRedirectURIs.SetAccessPath(path, validateHasBeenSet);
        _endpointUri.SetAccessPath(path, validateHasBeenSet);
        _endpointSslVerification.SetAccessPath(path, validateHasBeenSet);
        _appLevelAuth.SetAccessPath(path, validateHasBeenSet);
        _sslKeystoreAuth.SetAccessPath(path, validateHasBeenSet);
        _hasVerificationToken.SetAccessPath(path, validateHasBeenSet);
        _hasSigningKey.SetAccessPath(path, validateHasBeenSet);
        _hasPublicKeySignature.SetAccessPath(path, validateHasBeenSet);
        _basicAuthUsername.SetAccessPath(path, validateHasBeenSet);
        _basicAuthPassword.SetAccessPath(path, validateHasBeenSet);
        _bearerAuthToken.SetAccessPath(path, validateHasBeenSet);
        _connectToSpace.SetAccessPath(path, validateHasBeenSet);
        _state.SetAccessPath(path, validateHasBeenSet);
    }

}

