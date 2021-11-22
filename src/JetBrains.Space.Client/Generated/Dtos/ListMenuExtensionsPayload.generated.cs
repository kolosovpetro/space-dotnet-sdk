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

public sealed class ListMenuExtensionsPayload
     : ApplicationPayload, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "ListMenuExtensionsPayload";
    
    public ListMenuExtensionsPayload() { }
    
    public ListMenuExtensionsPayload(string clientId, string? userId = null, string? verificationToken = null)
    {
        ClientId = clientId;
        UserId = userId;
        VerificationToken = verificationToken;
    }
    
    private PropertyValue<string> _clientId = new PropertyValue<string>(nameof(ListMenuExtensionsPayload), nameof(ClientId), "clientId");
    
    [Required]
    [JsonPropertyName("clientId")]
    public string ClientId
    {
        get => _clientId.GetValue(InlineErrors);
        set => _clientId.SetValue(value);
    }

    private PropertyValue<string?> _userId = new PropertyValue<string?>(nameof(ListMenuExtensionsPayload), nameof(UserId), "userId");
    
    [JsonPropertyName("userId")]
    public string? UserId
    {
        get => _userId.GetValue(InlineErrors);
        set => _userId.SetValue(value);
    }

    private PropertyValue<string?> _verificationToken = new PropertyValue<string?>(nameof(ListMenuExtensionsPayload), nameof(VerificationToken), "verificationToken");
    
    [JsonPropertyName("verificationToken")]
    public string? VerificationToken
    {
        get => _verificationToken.GetValue(InlineErrors);
        set => _verificationToken.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _clientId.SetAccessPath(parentChainPath, validateHasBeenSet);
        _userId.SetAccessPath(parentChainPath, validateHasBeenSet);
        _verificationToken.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

