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

namespace JetBrains.Space.Client.CodeDiscussionRecordPartialBuilder
{
    public static class CodeDiscussionRecordPartialExtensions
    {
        public static Partial<CodeDiscussionRecord> WithId(this Partial<CodeDiscussionRecord> it)
            => it.AddFieldName("id");
        
        public static Partial<CodeDiscussionRecord> WithProjectId(this Partial<CodeDiscussionRecord> it)
            => it.AddFieldName("projectId");
        
        public static Partial<CodeDiscussionRecord> WithProject(this Partial<CodeDiscussionRecord> it)
            => it.AddFieldName("project");
        
        public static Partial<CodeDiscussionRecord> WithProject(this Partial<CodeDiscussionRecord> it, Func<Partial<PRProject>, Partial<PRProject>> partialBuilder)
            => it.AddFieldName("project", partialBuilder(new Partial<PRProject>(it)));
        
        public static Partial<CodeDiscussionRecord> WithAnchor(this Partial<CodeDiscussionRecord> it)
            => it.AddFieldName("anchor");
        
        public static Partial<CodeDiscussionRecord> WithAnchor(this Partial<CodeDiscussionRecord> it, Func<Partial<CodeDiscussionAnchor>, Partial<CodeDiscussionAnchor>> partialBuilder)
            => it.AddFieldName("anchor", partialBuilder(new Partial<CodeDiscussionAnchor>(it)));
        
        public static Partial<CodeDiscussionRecord> WithCreated(this Partial<CodeDiscussionRecord> it)
            => it.AddFieldName("created");
        
        public static Partial<CodeDiscussionRecord> WithChannel(this Partial<CodeDiscussionRecord> it)
            => it.AddFieldName("channel");
        
        public static Partial<CodeDiscussionRecord> WithChannel(this Partial<CodeDiscussionRecord> it, Func<Partial<M2ChannelRecord>, Partial<M2ChannelRecord>> partialBuilder)
            => it.AddFieldName("channel", partialBuilder(new Partial<M2ChannelRecord>(it)));
        
        public static Partial<CodeDiscussionRecord> WithIsResolvable(this Partial<CodeDiscussionRecord> it)
            => it.AddFieldName("resolvable");
        
        public static Partial<CodeDiscussionRecord> WithIsResolved(this Partial<CodeDiscussionRecord> it)
            => it.AddFieldName("resolved");
        
        public static Partial<CodeDiscussionRecord> WithSnippet(this Partial<CodeDiscussionRecord> it)
            => it.AddFieldName("snippet");
        
        public static Partial<CodeDiscussionRecord> WithSnippet(this Partial<CodeDiscussionRecord> it, Func<Partial<CodeDiscussionSnippet>, Partial<CodeDiscussionSnippet>> partialBuilder)
            => it.AddFieldName("snippet", partialBuilder(new Partial<CodeDiscussionSnippet>(it)));
        
        public static Partial<CodeDiscussionRecord> WithResolvedBy(this Partial<CodeDiscussionRecord> it)
            => it.AddFieldName("resolvedBy");
        
        public static Partial<CodeDiscussionRecord> WithResolvedBy(this Partial<CodeDiscussionRecord> it, Func<Partial<CPrincipal>, Partial<CPrincipal>> partialBuilder)
            => it.AddFieldName("resolvedBy", partialBuilder(new Partial<CPrincipal>(it)));
        
        public static Partial<CodeDiscussionRecord> WithIsPending(this Partial<CodeDiscussionRecord> it)
            => it.AddFieldName("pending");
        
        public static Partial<CodeDiscussionRecord> WithReview(this Partial<CodeDiscussionRecord> it)
            => it.AddFieldName("review");
        
        public static Partial<CodeDiscussionRecord> WithReview(this Partial<CodeDiscussionRecord> it, Func<Partial<CodeReviewRecord>, Partial<CodeReviewRecord>> partialBuilder)
            => it.AddFieldName("review", partialBuilder(new Partial<CodeReviewRecord>(it)));
        
        public static Partial<CodeDiscussionRecord> WithFeedItemId(this Partial<CodeDiscussionRecord> it)
            => it.AddFieldName("feedItemId");
        
        public static Partial<CodeDiscussionRecord> WithReviews(this Partial<CodeDiscussionRecord> it)
            => it.AddFieldName("reviews");
        
        public static Partial<CodeDiscussionRecord> WithReviews(this Partial<CodeDiscussionRecord> it, Func<Partial<CodeReviewRecord>, Partial<CodeReviewRecord>> partialBuilder)
            => it.AddFieldName("reviews", partialBuilder(new Partial<CodeReviewRecord>(it)));
        
        public static Partial<CodeDiscussionRecord> WithIsArchived(this Partial<CodeDiscussionRecord> it)
            => it.AddFieldName("archived");
        
    }
    
}
