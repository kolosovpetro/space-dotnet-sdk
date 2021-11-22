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

public sealed class MeetingRecord
     : IPropagatePropertyAccessPath
{
    public MeetingRecord() { }
    
    public MeetingRecord(string id, bool archived, DateTime starts, DateTime finishes, bool allDay, List<TDLocation> rooms, List<Participant> participants, ATimeZone? timezone = null, ArticleRecord? article = null)
    {
        Id = id;
        IsArchived = archived;
        Starts = starts;
        Finishes = finishes;
        Timezone = timezone;
        IsAllDay = allDay;
        Rooms = rooms;
        Participants = participants;
        Article = article;
    }
    
    private PropertyValue<string> _id = new PropertyValue<string>(nameof(MeetingRecord), nameof(Id), "id");
    
    [Required]
    [JsonPropertyName("id")]
    public string Id
    {
        get => _id.GetValue(InlineErrors);
        set => _id.SetValue(value);
    }

    private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(MeetingRecord), nameof(IsArchived), "archived");
    
    [Required]
    [JsonPropertyName("archived")]
    public bool IsArchived
    {
        get => _archived.GetValue(InlineErrors);
        set => _archived.SetValue(value);
    }

    private PropertyValue<DateTime> _starts = new PropertyValue<DateTime>(nameof(MeetingRecord), nameof(Starts), "starts");
    
    [Required]
    [JsonPropertyName("starts")]
    [JsonConverter(typeof(SpaceDateTimeConverter))]
    public DateTime Starts
    {
        get => _starts.GetValue(InlineErrors);
        set => _starts.SetValue(value);
    }

    private PropertyValue<DateTime> _finishes = new PropertyValue<DateTime>(nameof(MeetingRecord), nameof(Finishes), "finishes");
    
    [Required]
    [JsonPropertyName("finishes")]
    [JsonConverter(typeof(SpaceDateTimeConverter))]
    public DateTime Finishes
    {
        get => _finishes.GetValue(InlineErrors);
        set => _finishes.SetValue(value);
    }

    private PropertyValue<ATimeZone?> _timezone = new PropertyValue<ATimeZone?>(nameof(MeetingRecord), nameof(Timezone), "timezone");
    
    [JsonPropertyName("timezone")]
    public ATimeZone? Timezone
    {
        get => _timezone.GetValue(InlineErrors);
        set => _timezone.SetValue(value);
    }

    private PropertyValue<bool> _allDay = new PropertyValue<bool>(nameof(MeetingRecord), nameof(IsAllDay), "allDay");
    
    [Required]
    [JsonPropertyName("allDay")]
    public bool IsAllDay
    {
        get => _allDay.GetValue(InlineErrors);
        set => _allDay.SetValue(value);
    }

    private PropertyValue<List<TDLocation>> _rooms = new PropertyValue<List<TDLocation>>(nameof(MeetingRecord), nameof(Rooms), "rooms", new List<TDLocation>());
    
    [Required]
    [JsonPropertyName("rooms")]
    public List<TDLocation> Rooms
    {
        get => _rooms.GetValue(InlineErrors);
        set => _rooms.SetValue(value);
    }

    private PropertyValue<List<Participant>> _participants = new PropertyValue<List<Participant>>(nameof(MeetingRecord), nameof(Participants), "participants", new List<Participant>());
    
    [Required]
    [JsonPropertyName("participants")]
    public List<Participant> Participants
    {
        get => _participants.GetValue(InlineErrors);
        set => _participants.SetValue(value);
    }

    private PropertyValue<ArticleRecord?> _article = new PropertyValue<ArticleRecord?>(nameof(MeetingRecord), nameof(Article), "article");
    
    [JsonPropertyName("article")]
    public ArticleRecord? Article
    {
        get => _article.GetValue(InlineErrors);
        set => _article.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _id.SetAccessPath(parentChainPath, validateHasBeenSet);
        _archived.SetAccessPath(parentChainPath, validateHasBeenSet);
        _starts.SetAccessPath(parentChainPath, validateHasBeenSet);
        _finishes.SetAccessPath(parentChainPath, validateHasBeenSet);
        _timezone.SetAccessPath(parentChainPath, validateHasBeenSet);
        _allDay.SetAccessPath(parentChainPath, validateHasBeenSet);
        _rooms.SetAccessPath(parentChainPath, validateHasBeenSet);
        _participants.SetAccessPath(parentChainPath, validateHasBeenSet);
        _article.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

