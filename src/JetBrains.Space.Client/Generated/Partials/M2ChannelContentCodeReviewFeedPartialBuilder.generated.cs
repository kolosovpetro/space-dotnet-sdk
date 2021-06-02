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

namespace JetBrains.Space.Client.M2ChannelContentCodeReviewFeedPartialBuilder
{
    public static class M2ChannelContentCodeReviewFeedPartialExtensions
    {
        public static Partial<M2ChannelContentCodeReviewFeed> WithCodeReviewId(this Partial<M2ChannelContentCodeReviewFeed> it)
            => it.AddFieldName("codeReviewId");
        
        public static Partial<M2ChannelContentCodeReviewFeed> WithNotificationDefaults(this Partial<M2ChannelContentCodeReviewFeed> it)
            => it.AddFieldName("notificationDefaults");
        
        public static Partial<M2ChannelContentCodeReviewFeed> WithNotificationDefaults(this Partial<M2ChannelContentCodeReviewFeed> it, Func<Partial<ChannelSpecificDefaults>, Partial<ChannelSpecificDefaults>> partialBuilder)
            => it.AddFieldName("notificationDefaults", partialBuilder(new Partial<ChannelSpecificDefaults>(it)));
        
        public static Partial<M2ChannelContentCodeReviewFeed> WithCodeReview(this Partial<M2ChannelContentCodeReviewFeed> it)
            => it.AddFieldName("codeReview");
        
        public static Partial<M2ChannelContentCodeReviewFeed> WithCodeReview(this Partial<M2ChannelContentCodeReviewFeed> it, Func<Partial<CodeReviewRecord>, Partial<CodeReviewRecord>> partialBuilder)
            => it.AddFieldName("codeReview", partialBuilder(new Partial<CodeReviewRecord>(it)));
        
        public static Partial<M2ChannelContentCodeReviewFeed> WithParticipants(this Partial<M2ChannelContentCodeReviewFeed> it)
            => it.AddFieldName("participants");
        
        public static Partial<M2ChannelContentCodeReviewFeed> WithParticipants(this Partial<M2ChannelContentCodeReviewFeed> it, Func<Partial<CodeReviewParticipants>, Partial<CodeReviewParticipants>> partialBuilder)
            => it.AddFieldName("participants", partialBuilder(new Partial<CodeReviewParticipants>(it)));
        
        public static Partial<M2ChannelContentCodeReviewFeed> WithPendingMessageCounter(this Partial<M2ChannelContentCodeReviewFeed> it)
            => it.AddFieldName("pendingMessageCounter");
        
        public static Partial<M2ChannelContentCodeReviewFeed> WithPendingMessageCounter(this Partial<M2ChannelContentCodeReviewFeed> it, Func<Partial<CodeReviewPendingMessageCounter>, Partial<CodeReviewPendingMessageCounter>> partialBuilder)
            => it.AddFieldName("pendingMessageCounter", partialBuilder(new Partial<CodeReviewPendingMessageCounter>(it)));
        
        public static Partial<M2ChannelContentCodeReviewFeed> WithProject(this Partial<M2ChannelContentCodeReviewFeed> it)
            => it.AddFieldName("project");
        
        public static Partial<M2ChannelContentCodeReviewFeed> WithProject(this Partial<M2ChannelContentCodeReviewFeed> it, Func<Partial<PRProject>, Partial<PRProject>> partialBuilder)
            => it.AddFieldName("project", partialBuilder(new Partial<PRProject>(it)));
        
    }
    
}
