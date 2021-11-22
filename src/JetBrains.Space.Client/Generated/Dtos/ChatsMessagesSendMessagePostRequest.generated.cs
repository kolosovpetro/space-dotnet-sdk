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

public class ChatsMessagesSendMessagePostRequest
     : IPropagatePropertyAccessPath
{
    public ChatsMessagesSendMessagePostRequest() { }
    
    public ChatsMessagesSendMessagePostRequest(MessageRecipient recipient, ChatMessage content, bool? unfurlLinks = null, List<AttachmentIn>? attachments = null, string? externalId = null, bool? resolveNames = null, bool? pending = null)
    {
        Recipient = recipient;
        Content = content;
        IsUnfurlLinks = unfurlLinks;
        Attachments = attachments;
        ExternalId = externalId;
        IsResolveNames = resolveNames;
        IsPending = pending;
    }
    
    private PropertyValue<MessageRecipient> _recipient = new PropertyValue<MessageRecipient>(nameof(ChatsMessagesSendMessagePostRequest), nameof(Recipient), "recipient");
    
    [Required]
    [JsonPropertyName("recipient")]
    public MessageRecipient Recipient
    {
        get => _recipient.GetValue(InlineErrors);
        set => _recipient.SetValue(value);
    }

    private PropertyValue<ChatMessage> _content = new PropertyValue<ChatMessage>(nameof(ChatsMessagesSendMessagePostRequest), nameof(Content), "content");
    
    [Required]
    [JsonPropertyName("content")]
    public ChatMessage Content
    {
        get => _content.GetValue(InlineErrors);
        set => _content.SetValue(value);
    }

    private PropertyValue<bool?> _unfurlLinks = new PropertyValue<bool?>(nameof(ChatsMessagesSendMessagePostRequest), nameof(IsUnfurlLinks), "unfurlLinks");
    
    [JsonPropertyName("unfurlLinks")]
    public bool? IsUnfurlLinks
    {
        get => _unfurlLinks.GetValue(InlineErrors);
        set => _unfurlLinks.SetValue(value);
    }

    private PropertyValue<List<AttachmentIn>?> _attachments = new PropertyValue<List<AttachmentIn>?>(nameof(ChatsMessagesSendMessagePostRequest), nameof(Attachments), "attachments");
    
    [JsonPropertyName("attachments")]
    public List<AttachmentIn>? Attachments
    {
        get => _attachments.GetValue(InlineErrors);
        set => _attachments.SetValue(value);
    }

    private PropertyValue<string?> _externalId = new PropertyValue<string?>(nameof(ChatsMessagesSendMessagePostRequest), nameof(ExternalId), "externalId");
    
    [JsonPropertyName("externalId")]
    public string? ExternalId
    {
        get => _externalId.GetValue(InlineErrors);
        set => _externalId.SetValue(value);
    }

    private PropertyValue<bool?> _resolveNames = new PropertyValue<bool?>(nameof(ChatsMessagesSendMessagePostRequest), nameof(IsResolveNames), "resolveNames");
    
    [JsonPropertyName("resolveNames")]
    public bool? IsResolveNames
    {
        get => _resolveNames.GetValue(InlineErrors);
        set => _resolveNames.SetValue(value);
    }

    private PropertyValue<bool?> _pending = new PropertyValue<bool?>(nameof(ChatsMessagesSendMessagePostRequest), nameof(IsPending), "pending");
    
    [JsonPropertyName("pending")]
    public bool? IsPending
    {
        get => _pending.GetValue(InlineErrors);
        set => _pending.SetValue(value);
    }

    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _recipient.SetAccessPath(parentChainPath, validateHasBeenSet);
        _content.SetAccessPath(parentChainPath, validateHasBeenSet);
        _unfurlLinks.SetAccessPath(parentChainPath, validateHasBeenSet);
        _attachments.SetAccessPath(parentChainPath, validateHasBeenSet);
        _externalId.SetAccessPath(parentChainPath, validateHasBeenSet);
        _resolveNames.SetAccessPath(parentChainPath, validateHasBeenSet);
        _pending.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

