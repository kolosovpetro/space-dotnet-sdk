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

public sealed class ApplicationWebhookEvent
     : WebhookEvent, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "ApplicationWebhookEvent";
    
    public ApplicationWebhookEvent() { }
    
    public ApplicationWebhookEvent(KMetaMod meta, ESApp application, bool clientIdChanged, bool clientSecretChanged, bool verificationTokenChanged, bool signingKeyChanged, Modification<string>? name = null, Modification<TDMemberProfile>? owner = null, Modification<bool>? archived = null, Modification<string>? endpointURI = null)
    {
        Meta = meta;
        Application = application;
        Name = name;
        Owner = owner;
        Archived = archived;
        EndpointURI = endpointURI;
        IsClientIdChanged = clientIdChanged;
        IsClientSecretChanged = clientSecretChanged;
        IsVerificationTokenChanged = verificationTokenChanged;
        IsSigningKeyChanged = signingKeyChanged;
    }
    
    private PropertyValue<KMetaMod> _meta = new PropertyValue<KMetaMod>(nameof(ApplicationWebhookEvent), nameof(Meta), "meta");
    
    [Required]
    [JsonPropertyName("meta")]
    public KMetaMod Meta
    {
        get => _meta.GetValue(InlineErrors);
        set => _meta.SetValue(value);
    }

    private PropertyValue<ESApp> _application = new PropertyValue<ESApp>(nameof(ApplicationWebhookEvent), nameof(Application), "application");
    
    [Required]
    [JsonPropertyName("application")]
    public ESApp Application
    {
        get => _application.GetValue(InlineErrors);
        set => _application.SetValue(value);
    }

    private PropertyValue<Modification<string>?> _name = new PropertyValue<Modification<string>?>(nameof(ApplicationWebhookEvent), nameof(Name), "name");
    
    [JsonPropertyName("name")]
    public Modification<string>? Name
    {
        get => _name.GetValue(InlineErrors);
        set => _name.SetValue(value);
    }

    private PropertyValue<Modification<TDMemberProfile>?> _owner = new PropertyValue<Modification<TDMemberProfile>?>(nameof(ApplicationWebhookEvent), nameof(Owner), "owner");
    
    [JsonPropertyName("owner")]
    public Modification<TDMemberProfile>? Owner
    {
        get => _owner.GetValue(InlineErrors);
        set => _owner.SetValue(value);
    }

    private PropertyValue<Modification<bool>?> _archived = new PropertyValue<Modification<bool>?>(nameof(ApplicationWebhookEvent), nameof(Archived), "archived");
    
    [JsonPropertyName("archived")]
    public Modification<bool>? Archived
    {
        get => _archived.GetValue(InlineErrors);
        set => _archived.SetValue(value);
    }

    private PropertyValue<Modification<string>?> _endpointURI = new PropertyValue<Modification<string>?>(nameof(ApplicationWebhookEvent), nameof(EndpointURI), "endpointURI");
    
    [JsonPropertyName("endpointURI")]
    public Modification<string>? EndpointURI
    {
        get => _endpointURI.GetValue(InlineErrors);
        set => _endpointURI.SetValue(value);
    }

    private PropertyValue<bool> _clientIdChanged = new PropertyValue<bool>(nameof(ApplicationWebhookEvent), nameof(IsClientIdChanged), "clientIdChanged");
    
    [Required]
    [JsonPropertyName("clientIdChanged")]
    public bool IsClientIdChanged
    {
        get => _clientIdChanged.GetValue(InlineErrors);
        set => _clientIdChanged.SetValue(value);
    }

    private PropertyValue<bool> _clientSecretChanged = new PropertyValue<bool>(nameof(ApplicationWebhookEvent), nameof(IsClientSecretChanged), "clientSecretChanged");
    
    [Required]
    [JsonPropertyName("clientSecretChanged")]
    public bool IsClientSecretChanged
    {
        get => _clientSecretChanged.GetValue(InlineErrors);
        set => _clientSecretChanged.SetValue(value);
    }

    private PropertyValue<bool> _verificationTokenChanged = new PropertyValue<bool>(nameof(ApplicationWebhookEvent), nameof(IsVerificationTokenChanged), "verificationTokenChanged");
    
    [Required]
    [JsonPropertyName("verificationTokenChanged")]
    public bool IsVerificationTokenChanged
    {
        get => _verificationTokenChanged.GetValue(InlineErrors);
        set => _verificationTokenChanged.SetValue(value);
    }

    private PropertyValue<bool> _signingKeyChanged = new PropertyValue<bool>(nameof(ApplicationWebhookEvent), nameof(IsSigningKeyChanged), "signingKeyChanged");
    
    [Required]
    [JsonPropertyName("signingKeyChanged")]
    public bool IsSigningKeyChanged
    {
        get => _signingKeyChanged.GetValue(InlineErrors);
        set => _signingKeyChanged.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _meta.SetAccessPath(parentChainPath, validateHasBeenSet);
        _application.SetAccessPath(parentChainPath, validateHasBeenSet);
        _name.SetAccessPath(parentChainPath, validateHasBeenSet);
        _owner.SetAccessPath(parentChainPath, validateHasBeenSet);
        _archived.SetAccessPath(parentChainPath, validateHasBeenSet);
        _endpointURI.SetAccessPath(parentChainPath, validateHasBeenSet);
        _clientIdChanged.SetAccessPath(parentChainPath, validateHasBeenSet);
        _clientSecretChanged.SetAccessPath(parentChainPath, validateHasBeenSet);
        _verificationTokenChanged.SetAccessPath(parentChainPath, validateHasBeenSet);
        _signingKeyChanged.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

