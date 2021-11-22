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

public sealed class ArticlePreviewRecord
     : IPropagatePropertyAccessPath
{
    public ArticlePreviewRecord() { }
    
    public ArticlePreviewRecord(string id, bool archived, List<ArticleMarkdownImage> previewImages, string preview, List<AttachmentInfo>? previewAttachments = null, int? wordsNumber = null, bool? cut = null)
    {
        Id = id;
        IsArchived = archived;
        PreviewImages = previewImages;
        Preview = preview;
        PreviewAttachments = previewAttachments;
        WordsNumber = wordsNumber;
        IsCut = cut;
    }
    
    private PropertyValue<string> _id = new PropertyValue<string>(nameof(ArticlePreviewRecord), nameof(Id), "id");
    
    [Required]
    [JsonPropertyName("id")]
    public string Id
    {
        get => _id.GetValue(InlineErrors);
        set => _id.SetValue(value);
    }

    private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(ArticlePreviewRecord), nameof(IsArchived), "archived");
    
    [Required]
    [JsonPropertyName("archived")]
    public bool IsArchived
    {
        get => _archived.GetValue(InlineErrors);
        set => _archived.SetValue(value);
    }

    private PropertyValue<List<ArticleMarkdownImage>> _previewImages = new PropertyValue<List<ArticleMarkdownImage>>(nameof(ArticlePreviewRecord), nameof(PreviewImages), "previewImages", new List<ArticleMarkdownImage>());
    
    [Required]
    [JsonPropertyName("previewImages")]
    public List<ArticleMarkdownImage> PreviewImages
    {
        get => _previewImages.GetValue(InlineErrors);
        set => _previewImages.SetValue(value);
    }

    private PropertyValue<string> _preview = new PropertyValue<string>(nameof(ArticlePreviewRecord), nameof(Preview), "preview");
    
    [Required]
    [JsonPropertyName("preview")]
    public string Preview
    {
        get => _preview.GetValue(InlineErrors);
        set => _preview.SetValue(value);
    }

    private PropertyValue<List<AttachmentInfo>?> _previewAttachments = new PropertyValue<List<AttachmentInfo>?>(nameof(ArticlePreviewRecord), nameof(PreviewAttachments), "previewAttachments");
    
    [JsonPropertyName("previewAttachments")]
    public List<AttachmentInfo>? PreviewAttachments
    {
        get => _previewAttachments.GetValue(InlineErrors);
        set => _previewAttachments.SetValue(value);
    }

    private PropertyValue<int?> _wordsNumber = new PropertyValue<int?>(nameof(ArticlePreviewRecord), nameof(WordsNumber), "wordsNumber");
    
    [JsonPropertyName("wordsNumber")]
    public int? WordsNumber
    {
        get => _wordsNumber.GetValue(InlineErrors);
        set => _wordsNumber.SetValue(value);
    }

    private PropertyValue<bool?> _cut = new PropertyValue<bool?>(nameof(ArticlePreviewRecord), nameof(IsCut), "cut");
    
    [JsonPropertyName("cut")]
    public bool? IsCut
    {
        get => _cut.GetValue(InlineErrors);
        set => _cut.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _id.SetAccessPath(parentChainPath, validateHasBeenSet);
        _archived.SetAccessPath(parentChainPath, validateHasBeenSet);
        _previewImages.SetAccessPath(parentChainPath, validateHasBeenSet);
        _preview.SetAccessPath(parentChainPath, validateHasBeenSet);
        _previewAttachments.SetAccessPath(parentChainPath, validateHasBeenSet);
        _wordsNumber.SetAccessPath(parentChainPath, validateHasBeenSet);
        _cut.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

