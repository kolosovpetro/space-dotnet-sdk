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

namespace JetBrains.Space.Client.CodeReviewWebhookEventPartialBuilder
{
    public static class CodeReviewWebhookEventPartialExtensions
    {
        public static Partial<CodeReviewWebhookEvent> WithProjectKey(this Partial<CodeReviewWebhookEvent> it)
            => it.AddFieldName("projectKey");
        
        public static Partial<CodeReviewWebhookEvent> WithProjectKey(this Partial<CodeReviewWebhookEvent> it, Func<Partial<ProjectKey>, Partial<ProjectKey>> partialBuilder)
            => it.AddFieldName("projectKey", partialBuilder(new Partial<ProjectKey>(it)));
        
        public static Partial<CodeReviewWebhookEvent> WithRepository(this Partial<CodeReviewWebhookEvent> it)
            => it.AddFieldName("repository");
        
        public static Partial<CodeReviewWebhookEvent> WithReviewId(this Partial<CodeReviewWebhookEvent> it)
            => it.AddFieldName("reviewId");
        
        public static Partial<CodeReviewWebhookEvent> WithTitle(this Partial<CodeReviewWebhookEvent> it)
            => it.AddFieldName("title");
        
        public static Partial<CodeReviewWebhookEvent> WithIsMergeRequest(this Partial<CodeReviewWebhookEvent> it)
            => it.AddFieldName("isMergeRequest");
        
    }
    
}
