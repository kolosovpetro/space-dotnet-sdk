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

public sealed class TrustedCertificate
     : IPropagatePropertyAccessPath
{
    public TrustedCertificate() { }
    
    public TrustedCertificate(string id, string alias, string data, CertificateInfo info, bool archived)
    {
        Id = id;
        Alias = alias;
        Data = data;
        Info = info;
        IsArchived = archived;
    }
    
    private PropertyValue<string> _id = new PropertyValue<string>(nameof(TrustedCertificate), nameof(Id), "id");
    
    [Required]
    [JsonPropertyName("id")]
    public string Id
    {
        get => _id.GetValue(InlineErrors);
        set => _id.SetValue(value);
    }

    private PropertyValue<string> _alias = new PropertyValue<string>(nameof(TrustedCertificate), nameof(Alias), "alias");
    
    [Required]
    [JsonPropertyName("alias")]
    public string Alias
    {
        get => _alias.GetValue(InlineErrors);
        set => _alias.SetValue(value);
    }

    private PropertyValue<string> _data = new PropertyValue<string>(nameof(TrustedCertificate), nameof(Data), "data");
    
    [Required]
    [JsonPropertyName("data")]
    public string Data
    {
        get => _data.GetValue(InlineErrors);
        set => _data.SetValue(value);
    }

    private PropertyValue<CertificateInfo> _info = new PropertyValue<CertificateInfo>(nameof(TrustedCertificate), nameof(Info), "info");
    
    [Required]
    [JsonPropertyName("info")]
    public CertificateInfo Info
    {
        get => _info.GetValue(InlineErrors);
        set => _info.SetValue(value);
    }

    private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(TrustedCertificate), nameof(IsArchived), "archived");
    
    [Required]
    [JsonPropertyName("archived")]
    public bool IsArchived
    {
        get => _archived.GetValue(InlineErrors);
        set => _archived.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _id.SetAccessPath(parentChainPath, validateHasBeenSet);
        _alias.SetAccessPath(parentChainPath, validateHasBeenSet);
        _data.SetAccessPath(parentChainPath, validateHasBeenSet);
        _info.SetAccessPath(parentChainPath, validateHasBeenSet);
        _archived.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

