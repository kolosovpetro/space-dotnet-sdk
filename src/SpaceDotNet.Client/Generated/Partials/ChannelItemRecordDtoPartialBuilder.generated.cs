// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client.ChannelItemRecordDtoPartialBuilder
{
    public static class ChannelItemRecordDtoPartialExtensions
    {
        public static Partial<ChannelItemRecordDto> WithText(this Partial<ChannelItemRecordDto> it)
            => it.AddFieldName("text");
        
        public static Partial<ChannelItemRecordDto> WithDetails(this Partial<ChannelItemRecordDto> it)
            => it.AddFieldName("details");
        
        public static Partial<ChannelItemRecordDto> WithDetails(this Partial<ChannelItemRecordDto> it, Func<Partial<M2ItemContentDetailsDto>, Partial<M2ItemContentDetailsDto>> partialBuilder)
            => it.AddFieldName("details", partialBuilder(new Partial<M2ItemContentDetailsDto>(it)));
        
        public static Partial<ChannelItemRecordDto> WithAuthor(this Partial<ChannelItemRecordDto> it)
            => it.AddFieldName("author");
        
        public static Partial<ChannelItemRecordDto> WithAuthor(this Partial<ChannelItemRecordDto> it, Func<Partial<CPrincipalDto>, Partial<CPrincipalDto>> partialBuilder)
            => it.AddFieldName("author", partialBuilder(new Partial<CPrincipalDto>(it)));
        
        public static Partial<ChannelItemRecordDto> WithCreated(this Partial<ChannelItemRecordDto> it)
            => it.AddFieldName("created");
        
        public static Partial<ChannelItemRecordDto> WithTime(this Partial<ChannelItemRecordDto> it)
            => it.AddFieldName("time");
        
        public static Partial<ChannelItemRecordDto> WithReactions(this Partial<ChannelItemRecordDto> it)
            => it.AddFieldName("reactions");
        
        public static Partial<ChannelItemRecordDto> WithReactions(this Partial<ChannelItemRecordDto> it, Func<Partial<AllReactionsToItemRecordDto>, Partial<AllReactionsToItemRecordDto>> partialBuilder)
            => it.AddFieldName("reactions", partialBuilder(new Partial<AllReactionsToItemRecordDto>(it)));
        
        public static Partial<ChannelItemRecordDto> WithThread(this Partial<ChannelItemRecordDto> it)
            => it.AddFieldName("thread");
        
        public static Partial<ChannelItemRecordDto> WithThread(this Partial<ChannelItemRecordDto> it, Func<Partial<M2ChannelRecordDto>, Partial<M2ChannelRecordDto>> partialBuilder)
            => it.AddFieldName("thread", partialBuilder(new Partial<M2ChannelRecordDto>(it)));
        
        public static Partial<ChannelItemRecordDto> WithProjectedItem(this Partial<ChannelItemRecordDto> it)
            => it.AddFieldName("projectedItem");
        
        public static Partial<ChannelItemRecordDto> WithProjectedItemRecursive(this Partial<ChannelItemRecordDto> it)
            => it.AddFieldName("projectedItem!");
        
        public static Partial<ChannelItemRecordDto> WithProjectedItem(this Partial<ChannelItemRecordDto> it, Func<Partial<ChannelItemRecordDto>, Partial<ChannelItemRecordDto>> partialBuilder)
            => it.AddFieldName("projectedItem", partialBuilder(new Partial<ChannelItemRecordDto>(it)));
        
        public static Partial<ChannelItemRecordDto> WithAttachments(this Partial<ChannelItemRecordDto> it)
            => it.AddFieldName("attachments");
        
        public static Partial<ChannelItemRecordDto> WithAttachments(this Partial<ChannelItemRecordDto> it, Func<Partial<AttachmentInfoDto>, Partial<AttachmentInfoDto>> partialBuilder)
            => it.AddFieldName("attachments", partialBuilder(new Partial<AttachmentInfoDto>(it)));
        
        public static Partial<ChannelItemRecordDto> WithAttachmentsInfos(this Partial<ChannelItemRecordDto> it)
            => it.AddFieldName("attachmentsInfos");
        
        public static Partial<ChannelItemRecordDto> WithAttachmentsInfos(this Partial<ChannelItemRecordDto> it, Func<Partial<AttachmentInfoDto>, Partial<AttachmentInfoDto>> partialBuilder)
            => it.AddFieldName("attachmentsInfos", partialBuilder(new Partial<AttachmentInfoDto>(it)));
        
        public static Partial<ChannelItemRecordDto> WithPending(this Partial<ChannelItemRecordDto> it)
            => it.AddFieldName("pending");
        
        public static Partial<ChannelItemRecordDto> WithId(this Partial<ChannelItemRecordDto> it)
            => it.AddFieldName("id");
        
        public static Partial<ChannelItemRecordDto> WithArchived(this Partial<ChannelItemRecordDto> it)
            => it.AddFieldName("archived");
        
        public static Partial<ChannelItemRecordDto> WithEdited(this Partial<ChannelItemRecordDto> it)
            => it.AddFieldName("edited");
        
        public static Partial<ChannelItemRecordDto> WithPinned(this Partial<ChannelItemRecordDto> it)
            => it.AddFieldName("pinned");
        
        public static Partial<ChannelItemRecordDto> WithSuggestedParticipants(this Partial<ChannelItemRecordDto> it)
            => it.AddFieldName("suggestedParticipants");
        
        public static Partial<ChannelItemRecordDto> WithSuggestedParticipants(this Partial<ChannelItemRecordDto> it, Func<Partial<CPrincipalDto>, Partial<CPrincipalDto>> partialBuilder)
            => it.AddFieldName("suggestedParticipants", partialBuilder(new Partial<CPrincipalDto>(it)));
        
    }
    
}
