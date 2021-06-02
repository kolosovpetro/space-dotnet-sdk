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

namespace JetBrains.Space.Client.BlogPostRequestPartialBuilder
{
    public static class BlogPostRequestPartialExtensions
    {
        public static Partial<BlogPostRequest> WithTitle(this Partial<BlogPostRequest> it)
            => it.AddFieldName("title");
        
        public static Partial<BlogPostRequest> WithContent(this Partial<BlogPostRequest> it)
            => it.AddFieldName("content");
        
        public static Partial<BlogPostRequest> WithLocations(this Partial<BlogPostRequest> it)
            => it.AddFieldName("locations");
        
        public static Partial<BlogPostRequest> WithTeams(this Partial<BlogPostRequest> it)
            => it.AddFieldName("teams");
        
        public static Partial<BlogPostRequest> WithEvent(this Partial<BlogPostRequest> it)
            => it.AddFieldName("event");
        
        public static Partial<BlogPostRequest> WithEvent(this Partial<BlogPostRequest> it, Func<Partial<BlogCalendarEvent>, Partial<BlogCalendarEvent>> partialBuilder)
            => it.AddFieldName("event", partialBuilder(new Partial<BlogCalendarEvent>(it)));
        
    }
    
}
