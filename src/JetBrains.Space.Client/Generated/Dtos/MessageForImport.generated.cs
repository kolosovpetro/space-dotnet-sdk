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

public sealed class MessageForImport
     : IPropagatePropertyAccessPath
{
    public MessageForImport() { }
    
    public MessageForImport(string authorPrincipalId, string text, long createdAtUtc, List<AttachmentIn>? attachments = null)
    {
        AuthorPrincipalId = authorPrincipalId;
        Text = text;
        CreatedAtUtc = createdAtUtc;
        Attachments = attachments;
    }
    
    private PropertyValue<string> _authorPrincipalId = new PropertyValue<string>(nameof(MessageForImport), nameof(AuthorPrincipalId), "authorPrincipalId");
    
    [Required]
    [JsonPropertyName("authorPrincipalId")]
    public string AuthorPrincipalId
    {
        get => _authorPrincipalId.GetValue(InlineErrors);
        set => _authorPrincipalId.SetValue(value);
    }

    private PropertyValue<string> _text = new PropertyValue<string>(nameof(MessageForImport), nameof(Text), "text");
    
    [Required]
    [JsonPropertyName("text")]
    public string Text
    {
        get => _text.GetValue(InlineErrors);
        set => _text.SetValue(value);
    }

    private PropertyValue<long> _createdAtUtc = new PropertyValue<long>(nameof(MessageForImport), nameof(CreatedAtUtc), "createdAtUtc");
    
    [Required]
    [JsonPropertyName("createdAtUtc")]
    public long CreatedAtUtc
    {
        get => _createdAtUtc.GetValue(InlineErrors);
        set => _createdAtUtc.SetValue(value);
    }

    private PropertyValue<List<AttachmentIn>?> _attachments = new PropertyValue<List<AttachmentIn>?>(nameof(MessageForImport), nameof(Attachments), "attachments");
    
    [JsonPropertyName("attachments")]
    public List<AttachmentIn>? Attachments
    {
        get => _attachments.GetValue(InlineErrors);
        set => _attachments.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _authorPrincipalId.SetAccessPath(parentChainPath, validateHasBeenSet);
        _text.SetAccessPath(parentChainPath, validateHasBeenSet);
        _createdAtUtc.SetAccessPath(parentChainPath, validateHasBeenSet);
        _attachments.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

