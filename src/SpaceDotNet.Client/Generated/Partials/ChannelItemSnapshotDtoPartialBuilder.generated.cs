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

namespace SpaceDotNet.Client.ChannelItemSnapshotDtoPartialBuilder
{
    public static class ChannelItemSnapshotDtoPartialExtensions
    {
        public static Partial<ChannelItemSnapshotDto> WithId(this Partial<ChannelItemSnapshotDto> it)
            => it.AddFieldName("id");
        
        public static Partial<ChannelItemSnapshotDto> WithChannelId(this Partial<ChannelItemSnapshotDto> it)
            => it.AddFieldName("channelId");
        
        public static Partial<ChannelItemSnapshotDto> WithText(this Partial<ChannelItemSnapshotDto> it)
            => it.AddFieldName("text");
        
        public static Partial<ChannelItemSnapshotDto> WithDetails(this Partial<ChannelItemSnapshotDto> it)
            => it.AddFieldName("details");
        
        public static Partial<ChannelItemSnapshotDto> WithDetails(this Partial<ChannelItemSnapshotDto> it, Func<Partial<M2ItemContentDetailsDto>, Partial<M2ItemContentDetailsDto>> partialBuilder)
            => it.AddFieldName("details", partialBuilder(new Partial<M2ItemContentDetailsDto>(it)));
        
        public static Partial<ChannelItemSnapshotDto> WithAuthor(this Partial<ChannelItemSnapshotDto> it)
            => it.AddFieldName("author");
        
        public static Partial<ChannelItemSnapshotDto> WithAuthor(this Partial<ChannelItemSnapshotDto> it, Func<Partial<CPrincipalDto>, Partial<CPrincipalDto>> partialBuilder)
            => it.AddFieldName("author", partialBuilder(new Partial<CPrincipalDto>(it)));
        
        public static Partial<ChannelItemSnapshotDto> WithCreated(this Partial<ChannelItemSnapshotDto> it)
            => it.AddFieldName("created");
        
        public static Partial<ChannelItemSnapshotDto> WithTime(this Partial<ChannelItemSnapshotDto> it)
            => it.AddFieldName("time");
        
        public static Partial<ChannelItemSnapshotDto> WithAttachments(this Partial<ChannelItemSnapshotDto> it)
            => it.AddFieldName("attachments");
        
        public static Partial<ChannelItemSnapshotDto> WithAttachments(this Partial<ChannelItemSnapshotDto> it, Func<Partial<AttachmentInfoDto>, Partial<AttachmentInfoDto>> partialBuilder)
            => it.AddFieldName("attachments", partialBuilder(new Partial<AttachmentInfoDto>(it)));
        
    }
    
}
