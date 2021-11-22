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

public sealed class ArticleRecord
     : IPropagatePropertyAccessPath
{
    public ArticleRecord() { }
    
    public ArticleRecord(string id, bool archived, string title, DateTime created, TDMemberProfile author, List<BGArticleAlias> aliases, M2ChannelRecord channel, string content, bool editable, string preview, List<ArticleMarkdownImage> previewImages, AllReactionsToItemRecord reactions, TDMemberProfile? archivedBy = null, DateTime? archivedAt = null, List<AttachmentInfo>? attachments = null, M2ChannelContentRecord? channelContent = null, bool? cut = null, MeetingRecord? @event = null, ExternalEntityInfoRecord? externalEntityInfo = null, List<TDLocation>? locations = null, List<AttachmentInfo>? previewAttachments = null, List<TDTeam>? teams = null, int? wordsNumber = null)
    {
        Id = id;
        IsArchived = archived;
        Title = title;
        Created = created;
        Author = author;
        Aliases = aliases;
        ArchivedBy = archivedBy;
        ArchivedAt = archivedAt;
        Attachments = attachments;
        Channel = channel;
        ChannelContent = channelContent;
        Content = content;
        IsCut = cut;
        IsEditable = editable;
        Event = @event;
        ExternalEntityInfo = externalEntityInfo;
        Locations = locations;
        Preview = preview;
        PreviewAttachments = previewAttachments;
        PreviewImages = previewImages;
        Reactions = reactions;
        Teams = teams;
        WordsNumber = wordsNumber;
    }
    
    private PropertyValue<string> _id = new PropertyValue<string>(nameof(ArticleRecord), nameof(Id), "id");
    
    [Required]
    [JsonPropertyName("id")]
    public string Id
    {
        get => _id.GetValue(InlineErrors);
        set => _id.SetValue(value);
    }

    private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(ArticleRecord), nameof(IsArchived), "archived");
    
    [Required]
    [JsonPropertyName("archived")]
    public bool IsArchived
    {
        get => _archived.GetValue(InlineErrors);
        set => _archived.SetValue(value);
    }

    private PropertyValue<string> _title = new PropertyValue<string>(nameof(ArticleRecord), nameof(Title), "title");
    
    [Required]
    [JsonPropertyName("title")]
    public string Title
    {
        get => _title.GetValue(InlineErrors);
        set => _title.SetValue(value);
    }

    private PropertyValue<DateTime> _created = new PropertyValue<DateTime>(nameof(ArticleRecord), nameof(Created), "created");
    
    [Required]
    [JsonPropertyName("created")]
    [JsonConverter(typeof(SpaceDateTimeConverter))]
    public DateTime Created
    {
        get => _created.GetValue(InlineErrors);
        set => _created.SetValue(value);
    }

    private PropertyValue<TDMemberProfile> _author = new PropertyValue<TDMemberProfile>(nameof(ArticleRecord), nameof(Author), "author");
    
    [Required]
    [JsonPropertyName("author")]
    public TDMemberProfile Author
    {
        get => _author.GetValue(InlineErrors);
        set => _author.SetValue(value);
    }

    private PropertyValue<List<BGArticleAlias>> _aliases = new PropertyValue<List<BGArticleAlias>>(nameof(ArticleRecord), nameof(Aliases), "aliases", new List<BGArticleAlias>());
    
    [Required]
    [JsonPropertyName("aliases")]
    public List<BGArticleAlias> Aliases
    {
        get => _aliases.GetValue(InlineErrors);
        set => _aliases.SetValue(value);
    }

    private PropertyValue<TDMemberProfile?> _archivedBy = new PropertyValue<TDMemberProfile?>(nameof(ArticleRecord), nameof(ArchivedBy), "archivedBy");
    
    [JsonPropertyName("archivedBy")]
    public TDMemberProfile? ArchivedBy
    {
        get => _archivedBy.GetValue(InlineErrors);
        set => _archivedBy.SetValue(value);
    }

    private PropertyValue<DateTime?> _archivedAt = new PropertyValue<DateTime?>(nameof(ArticleRecord), nameof(ArchivedAt), "archivedAt");
    
    [JsonPropertyName("archivedAt")]
    [JsonConverter(typeof(SpaceDateTimeConverter))]
    public DateTime? ArchivedAt
    {
        get => _archivedAt.GetValue(InlineErrors);
        set => _archivedAt.SetValue(value);
    }

    private PropertyValue<List<AttachmentInfo>?> _attachments = new PropertyValue<List<AttachmentInfo>?>(nameof(ArticleRecord), nameof(Attachments), "attachments");
    
    [JsonPropertyName("attachments")]
    public List<AttachmentInfo>? Attachments
    {
        get => _attachments.GetValue(InlineErrors);
        set => _attachments.SetValue(value);
    }

    private PropertyValue<M2ChannelRecord> _channel = new PropertyValue<M2ChannelRecord>(nameof(ArticleRecord), nameof(Channel), "channel");
    
    [Required]
    [JsonPropertyName("channel")]
    public M2ChannelRecord Channel
    {
        get => _channel.GetValue(InlineErrors);
        set => _channel.SetValue(value);
    }

    private PropertyValue<M2ChannelContentRecord?> _channelContent = new PropertyValue<M2ChannelContentRecord?>(nameof(ArticleRecord), nameof(ChannelContent), "channelContent");
    
    [JsonPropertyName("channelContent")]
    public M2ChannelContentRecord? ChannelContent
    {
        get => _channelContent.GetValue(InlineErrors);
        set => _channelContent.SetValue(value);
    }

    private PropertyValue<string> _content = new PropertyValue<string>(nameof(ArticleRecord), nameof(Content), "content");
    
    [Required]
    [JsonPropertyName("content")]
    public string Content
    {
        get => _content.GetValue(InlineErrors);
        set => _content.SetValue(value);
    }

    private PropertyValue<bool?> _cut = new PropertyValue<bool?>(nameof(ArticleRecord), nameof(IsCut), "cut");
    
    [JsonPropertyName("cut")]
    public bool? IsCut
    {
        get => _cut.GetValue(InlineErrors);
        set => _cut.SetValue(value);
    }

    private PropertyValue<bool> _editable = new PropertyValue<bool>(nameof(ArticleRecord), nameof(IsEditable), "editable");
    
    [Required]
    [JsonPropertyName("editable")]
    public bool IsEditable
    {
        get => _editable.GetValue(InlineErrors);
        set => _editable.SetValue(value);
    }

    private PropertyValue<MeetingRecord?> _event = new PropertyValue<MeetingRecord?>(nameof(ArticleRecord), nameof(Event), "event");
    
    [JsonPropertyName("event")]
    public MeetingRecord? Event
    {
        get => _event.GetValue(InlineErrors);
        set => _event.SetValue(value);
    }

    private PropertyValue<ExternalEntityInfoRecord?> _externalEntityInfo = new PropertyValue<ExternalEntityInfoRecord?>(nameof(ArticleRecord), nameof(ExternalEntityInfo), "externalEntityInfo");
    
    [JsonPropertyName("externalEntityInfo")]
    public ExternalEntityInfoRecord? ExternalEntityInfo
    {
        get => _externalEntityInfo.GetValue(InlineErrors);
        set => _externalEntityInfo.SetValue(value);
    }

    private PropertyValue<List<TDLocation>?> _locations = new PropertyValue<List<TDLocation>?>(nameof(ArticleRecord), nameof(Locations), "locations");
    
    [JsonPropertyName("locations")]
    public List<TDLocation>? Locations
    {
        get => _locations.GetValue(InlineErrors);
        set => _locations.SetValue(value);
    }

    private PropertyValue<string> _preview = new PropertyValue<string>(nameof(ArticleRecord), nameof(Preview), "preview");
    
    [Required]
    [JsonPropertyName("preview")]
    public string Preview
    {
        get => _preview.GetValue(InlineErrors);
        set => _preview.SetValue(value);
    }

    private PropertyValue<List<AttachmentInfo>?> _previewAttachments = new PropertyValue<List<AttachmentInfo>?>(nameof(ArticleRecord), nameof(PreviewAttachments), "previewAttachments");
    
    [JsonPropertyName("previewAttachments")]
    public List<AttachmentInfo>? PreviewAttachments
    {
        get => _previewAttachments.GetValue(InlineErrors);
        set => _previewAttachments.SetValue(value);
    }

    private PropertyValue<List<ArticleMarkdownImage>> _previewImages = new PropertyValue<List<ArticleMarkdownImage>>(nameof(ArticleRecord), nameof(PreviewImages), "previewImages", new List<ArticleMarkdownImage>());
    
    [Required]
    [JsonPropertyName("previewImages")]
    public List<ArticleMarkdownImage> PreviewImages
    {
        get => _previewImages.GetValue(InlineErrors);
        set => _previewImages.SetValue(value);
    }

    private PropertyValue<AllReactionsToItemRecord> _reactions = new PropertyValue<AllReactionsToItemRecord>(nameof(ArticleRecord), nameof(Reactions), "reactions");
    
    [Required]
    [JsonPropertyName("reactions")]
    public AllReactionsToItemRecord Reactions
    {
        get => _reactions.GetValue(InlineErrors);
        set => _reactions.SetValue(value);
    }

    private PropertyValue<List<TDTeam>?> _teams = new PropertyValue<List<TDTeam>?>(nameof(ArticleRecord), nameof(Teams), "teams");
    
    [JsonPropertyName("teams")]
    public List<TDTeam>? Teams
    {
        get => _teams.GetValue(InlineErrors);
        set => _teams.SetValue(value);
    }

    private PropertyValue<int?> _wordsNumber = new PropertyValue<int?>(nameof(ArticleRecord), nameof(WordsNumber), "wordsNumber");
    
    [JsonPropertyName("wordsNumber")]
    public int? WordsNumber
    {
        get => _wordsNumber.GetValue(InlineErrors);
        set => _wordsNumber.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _id.SetAccessPath(parentChainPath, validateHasBeenSet);
        _archived.SetAccessPath(parentChainPath, validateHasBeenSet);
        _title.SetAccessPath(parentChainPath, validateHasBeenSet);
        _created.SetAccessPath(parentChainPath, validateHasBeenSet);
        _author.SetAccessPath(parentChainPath, validateHasBeenSet);
        _aliases.SetAccessPath(parentChainPath, validateHasBeenSet);
        _archivedBy.SetAccessPath(parentChainPath, validateHasBeenSet);
        _archivedAt.SetAccessPath(parentChainPath, validateHasBeenSet);
        _attachments.SetAccessPath(parentChainPath, validateHasBeenSet);
        _channel.SetAccessPath(parentChainPath, validateHasBeenSet);
        _channelContent.SetAccessPath(parentChainPath, validateHasBeenSet);
        _content.SetAccessPath(parentChainPath, validateHasBeenSet);
        _cut.SetAccessPath(parentChainPath, validateHasBeenSet);
        _editable.SetAccessPath(parentChainPath, validateHasBeenSet);
        _event.SetAccessPath(parentChainPath, validateHasBeenSet);
        _externalEntityInfo.SetAccessPath(parentChainPath, validateHasBeenSet);
        _locations.SetAccessPath(parentChainPath, validateHasBeenSet);
        _preview.SetAccessPath(parentChainPath, validateHasBeenSet);
        _previewAttachments.SetAccessPath(parentChainPath, validateHasBeenSet);
        _previewImages.SetAccessPath(parentChainPath, validateHasBeenSet);
        _reactions.SetAccessPath(parentChainPath, validateHasBeenSet);
        _teams.SetAccessPath(parentChainPath, validateHasBeenSet);
        _wordsNumber.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

