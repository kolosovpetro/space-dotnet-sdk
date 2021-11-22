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

public class ChatsMessagesDeleteMessagePostRequest
     : IPropagatePropertyAccessPath
{
    public ChatsMessagesDeleteMessagePostRequest() { }
    
    public ChatsMessagesDeleteMessagePostRequest(string channel, ChatMessageIdentifier id)
    {
        Channel = channel;
        Id = id;
    }
    
    private PropertyValue<string> _channel = new PropertyValue<string>(nameof(ChatsMessagesDeleteMessagePostRequest), nameof(Channel), "channel");
    
    [Required]
    [JsonPropertyName("channel")]
    public string Channel
    {
        get => _channel.GetValue(InlineErrors);
        set => _channel.SetValue(value);
    }

    private PropertyValue<ChatMessageIdentifier> _id = new PropertyValue<ChatMessageIdentifier>(nameof(ChatsMessagesDeleteMessagePostRequest), nameof(Id), "id");
    
    [Required]
    [JsonPropertyName("id")]
    public ChatMessageIdentifier Id
    {
        get => _id.GetValue(InlineErrors);
        set => _id.SetValue(value);
    }

    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _channel.SetAccessPath(parentChainPath, validateHasBeenSet);
        _id.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

