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

public sealed class EmojiReactionRecord
     : IPropagatePropertyAccessPath
{
    public EmojiReactionRecord() { }
    
    public EmojiReactionRecord(string id, string itemId, string emoji, int count, bool meReacted, long order)
    {
        Id = id;
        ItemId = itemId;
        Emoji = emoji;
        Count = count;
        IsMeReacted = meReacted;
        Order = order;
    }
    
    private PropertyValue<string> _id = new PropertyValue<string>(nameof(EmojiReactionRecord), nameof(Id), "id");
    
    [Required]
    [JsonPropertyName("id")]
    public string Id
    {
        get => _id.GetValue(InlineErrors);
        set => _id.SetValue(value);
    }

    private PropertyValue<string> _itemId = new PropertyValue<string>(nameof(EmojiReactionRecord), nameof(ItemId), "itemId");
    
    [Required]
    [JsonPropertyName("itemId")]
    public string ItemId
    {
        get => _itemId.GetValue(InlineErrors);
        set => _itemId.SetValue(value);
    }

    private PropertyValue<string> _emoji = new PropertyValue<string>(nameof(EmojiReactionRecord), nameof(Emoji), "emoji");
    
    [Required]
    [JsonPropertyName("emoji")]
    public string Emoji
    {
        get => _emoji.GetValue(InlineErrors);
        set => _emoji.SetValue(value);
    }

    private PropertyValue<int> _count = new PropertyValue<int>(nameof(EmojiReactionRecord), nameof(Count), "count");
    
    [Required]
    [JsonPropertyName("count")]
    public int Count
    {
        get => _count.GetValue(InlineErrors);
        set => _count.SetValue(value);
    }

    private PropertyValue<bool> _meReacted = new PropertyValue<bool>(nameof(EmojiReactionRecord), nameof(IsMeReacted), "meReacted");
    
    [Required]
    [JsonPropertyName("meReacted")]
    public bool IsMeReacted
    {
        get => _meReacted.GetValue(InlineErrors);
        set => _meReacted.SetValue(value);
    }

    private PropertyValue<long> _order = new PropertyValue<long>(nameof(EmojiReactionRecord), nameof(Order), "order");
    
    [Required]
    [JsonPropertyName("order")]
    public long Order
    {
        get => _order.GetValue(InlineErrors);
        set => _order.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _id.SetAccessPath(parentChainPath, validateHasBeenSet);
        _itemId.SetAccessPath(parentChainPath, validateHasBeenSet);
        _emoji.SetAccessPath(parentChainPath, validateHasBeenSet);
        _count.SetAccessPath(parentChainPath, validateHasBeenSet);
        _meReacted.SetAccessPath(parentChainPath, validateHasBeenSet);
        _order.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

