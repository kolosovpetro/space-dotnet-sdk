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

public sealed class AppMessageDeliveryDTOClientErrorDTO
     : IPropagatePropertyAccessPath
{
    public AppMessageDeliveryDTOClientErrorDTO() { }
    
    public AppMessageDeliveryDTOClientErrorDTO(string className, string? message = null, string? causeClassName = null, string? causeMessage = null)
    {
        ClassName = className;
        Message = message;
        CauseClassName = causeClassName;
        CauseMessage = causeMessage;
    }
    
    private PropertyValue<string> _className = new PropertyValue<string>(nameof(AppMessageDeliveryDTOClientErrorDTO), nameof(ClassName), "className");
    
    [Required]
    [JsonPropertyName("className")]
    public string ClassName
    {
        get => _className.GetValue(InlineErrors);
        set => _className.SetValue(value);
    }

    private PropertyValue<string?> _message = new PropertyValue<string?>(nameof(AppMessageDeliveryDTOClientErrorDTO), nameof(Message), "message");
    
    [JsonPropertyName("message")]
    public string? Message
    {
        get => _message.GetValue(InlineErrors);
        set => _message.SetValue(value);
    }

    private PropertyValue<string?> _causeClassName = new PropertyValue<string?>(nameof(AppMessageDeliveryDTOClientErrorDTO), nameof(CauseClassName), "causeClassName");
    
    [JsonPropertyName("causeClassName")]
    public string? CauseClassName
    {
        get => _causeClassName.GetValue(InlineErrors);
        set => _causeClassName.SetValue(value);
    }

    private PropertyValue<string?> _causeMessage = new PropertyValue<string?>(nameof(AppMessageDeliveryDTOClientErrorDTO), nameof(CauseMessage), "causeMessage");
    
    [JsonPropertyName("causeMessage")]
    public string? CauseMessage
    {
        get => _causeMessage.GetValue(InlineErrors);
        set => _causeMessage.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _className.SetAccessPath(parentChainPath, validateHasBeenSet);
        _message.SetAccessPath(parentChainPath, validateHasBeenSet);
        _causeClassName.SetAccessPath(parentChainPath, validateHasBeenSet);
        _causeMessage.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

