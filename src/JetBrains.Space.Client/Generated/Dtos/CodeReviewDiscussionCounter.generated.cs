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

public sealed class CodeReviewDiscussionCounter
     : IPropagatePropertyAccessPath
{
    public CodeReviewDiscussionCounter() { }
    
    public CodeReviewDiscussionCounter(string id, DiscussionCounter discussionCounter)
    {
        Id = id;
        DiscussionCounter = discussionCounter;
    }
    
    private PropertyValue<string> _id = new PropertyValue<string>(nameof(CodeReviewDiscussionCounter), nameof(Id), "id");
    
    [Required]
    [JsonPropertyName("id")]
    public string Id
    {
        get => _id.GetValue(InlineErrors);
        set => _id.SetValue(value);
    }

    private PropertyValue<DiscussionCounter> _discussionCounter = new PropertyValue<DiscussionCounter>(nameof(CodeReviewDiscussionCounter), nameof(DiscussionCounter), "discussionCounter");
    
    [Required]
    [JsonPropertyName("discussionCounter")]
    public DiscussionCounter DiscussionCounter
    {
        get => _discussionCounter.GetValue(InlineErrors);
        set => _discussionCounter.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _id.SetAccessPath(parentChainPath, validateHasBeenSet);
        _discussionCounter.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

