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
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client
{
    public sealed class M2ChannelRecord
         : IPropagatePropertyAccessPath
    {
        public M2ChannelRecord() { }
        
        public M2ChannelRecord(string id, M2ChannelContact contact, int totalMessages, bool archived, MessageInfo? lastMessage = null, List<ChannelParticipant>? participants = null, bool? channelArchived = null, M2ChannelContentInfo? content = null, List<ChannelItemRecord>? pinnedMessages = null)
        {
            Id = id;
            Contact = contact;
            TotalMessages = totalMessages;
            LastMessage = lastMessage;
            Participants = participants;
            IsChannelArchived = channelArchived;
            IsArchived = archived;
            Content = content;
            PinnedMessages = pinnedMessages;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(M2ChannelRecord), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get => _id.GetValue();
            set => _id.SetValue(value);
        }
    
        private PropertyValue<M2ChannelContact> _contact = new PropertyValue<M2ChannelContact>(nameof(M2ChannelRecord), nameof(Contact));
        
        [Required]
        [JsonPropertyName("contact")]
        public M2ChannelContact Contact
        {
            get => _contact.GetValue();
            set => _contact.SetValue(value);
        }
    
        private PropertyValue<int> _totalMessages = new PropertyValue<int>(nameof(M2ChannelRecord), nameof(TotalMessages));
        
        [Required]
        [JsonPropertyName("totalMessages")]
        public int TotalMessages
        {
            get => _totalMessages.GetValue();
            set => _totalMessages.SetValue(value);
        }
    
        private PropertyValue<MessageInfo?> _lastMessage = new PropertyValue<MessageInfo?>(nameof(M2ChannelRecord), nameof(LastMessage));
        
        [JsonPropertyName("lastMessage")]
        public MessageInfo? LastMessage
        {
            get => _lastMessage.GetValue();
            set => _lastMessage.SetValue(value);
        }
    
        private PropertyValue<List<ChannelParticipant>?> _participants = new PropertyValue<List<ChannelParticipant>?>(nameof(M2ChannelRecord), nameof(Participants));
        
        [JsonPropertyName("participants")]
        public List<ChannelParticipant>? Participants
        {
            get => _participants.GetValue();
            set => _participants.SetValue(value);
        }
    
        private PropertyValue<bool?> _channelArchived = new PropertyValue<bool?>(nameof(M2ChannelRecord), nameof(IsChannelArchived));
        
        [JsonPropertyName("channelArchived")]
        public bool? IsChannelArchived
        {
            get => _channelArchived.GetValue();
            set => _channelArchived.SetValue(value);
        }
    
        private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(M2ChannelRecord), nameof(IsArchived));
        
        [Required]
        [JsonPropertyName("archived")]
        public bool IsArchived
        {
            get => _archived.GetValue();
            set => _archived.SetValue(value);
        }
    
        private PropertyValue<M2ChannelContentInfo?> _content = new PropertyValue<M2ChannelContentInfo?>(nameof(M2ChannelRecord), nameof(Content));
        
        [JsonPropertyName("content")]
        public M2ChannelContentInfo? Content
        {
            get => _content.GetValue();
            set => _content.SetValue(value);
        }
    
        private PropertyValue<List<ChannelItemRecord>?> _pinnedMessages = new PropertyValue<List<ChannelItemRecord>?>(nameof(M2ChannelRecord), nameof(PinnedMessages));
        
        [JsonPropertyName("pinnedMessages")]
        public List<ChannelItemRecord>? PinnedMessages
        {
            get => _pinnedMessages.GetValue();
            set => _pinnedMessages.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _contact.SetAccessPath(path, validateHasBeenSet);
            _totalMessages.SetAccessPath(path, validateHasBeenSet);
            _lastMessage.SetAccessPath(path, validateHasBeenSet);
            _participants.SetAccessPath(path, validateHasBeenSet);
            _channelArchived.SetAccessPath(path, validateHasBeenSet);
            _archived.SetAccessPath(path, validateHasBeenSet);
            _content.SetAccessPath(path, validateHasBeenSet);
            _pinnedMessages.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
