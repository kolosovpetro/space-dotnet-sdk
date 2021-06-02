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

namespace JetBrains.Space.Client.BlogWebhookEventPartialBuilder
{
    public static class BlogWebhookEventPartialExtensions
    {
        public static Partial<BlogWebhookEvent> WithMeta(this Partial<BlogWebhookEvent> it)
            => it.AddFieldName("meta");
        
        public static Partial<BlogWebhookEvent> WithMeta(this Partial<BlogWebhookEvent> it, Func<Partial<KMetaMod>, Partial<KMetaMod>> partialBuilder)
            => it.AddFieldName("meta", partialBuilder(new Partial<KMetaMod>(it)));
        
        public static Partial<BlogWebhookEvent> WithArticle(this Partial<BlogWebhookEvent> it)
            => it.AddFieldName("article");
        
        public static Partial<BlogWebhookEvent> WithArticle(this Partial<BlogWebhookEvent> it, Func<Partial<ArticleRecord>, Partial<ArticleRecord>> partialBuilder)
            => it.AddFieldName("article", partialBuilder(new Partial<ArticleRecord>(it)));
        
        public static Partial<BlogWebhookEvent> WithAction(this Partial<BlogWebhookEvent> it)
            => it.AddFieldName("action");
        
        public static Partial<BlogWebhookEvent> WithAuthor(this Partial<BlogWebhookEvent> it)
            => it.AddFieldName("author");
        
        public static Partial<BlogWebhookEvent> WithCreated(this Partial<BlogWebhookEvent> it)
            => it.AddFieldName("created");
        
        public static Partial<BlogWebhookEvent> WithTitle(this Partial<BlogWebhookEvent> it)
            => it.AddFieldName("title");
        
        public static Partial<BlogWebhookEvent> WithIsTextChanged(this Partial<BlogWebhookEvent> it)
            => it.AddFieldName("textChanged");
        
        public static Partial<BlogWebhookEvent> WithUnpublished(this Partial<BlogWebhookEvent> it)
            => it.AddFieldName("unpublished");
        
        public static Partial<BlogWebhookEvent> WithTeams(this Partial<BlogWebhookEvent> it)
            => it.AddFieldName("teams");
        
        public static Partial<BlogWebhookEvent> WithLocations(this Partial<BlogWebhookEvent> it)
            => it.AddFieldName("locations");
        
        public static Partial<BlogWebhookEvent> WithExternalEntityInfo(this Partial<BlogWebhookEvent> it)
            => it.AddFieldName("externalEntityInfo");
        
    }
    
}
