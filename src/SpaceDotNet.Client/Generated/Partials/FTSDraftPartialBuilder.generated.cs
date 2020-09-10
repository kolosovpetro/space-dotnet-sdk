// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS0108

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client.FTSDraftPartialBuilder
{
    public static class FTSDraftPartialExtensions
    {
        public static Partial<FTSDraft> WithId(this Partial<FTSDraft> it)
            => it.AddFieldName("id");
        
        public static Partial<FTSDraft> WithTitle(this Partial<FTSDraft> it)
            => it.AddFieldName("title");
        
        public static Partial<FTSDraft> WithAuthor(this Partial<FTSDraft> it)
            => it.AddFieldName("author");
        
        public static Partial<FTSDraft> WithAuthor(this Partial<FTSDraft> it, Func<Partial<TDMemberProfile>, Partial<TDMemberProfile>> partialBuilder)
            => it.AddFieldName("author", partialBuilder(new Partial<TDMemberProfile>(it)));
        
        public static Partial<FTSDraft> WithDate(this Partial<FTSDraft> it)
            => it.AddFieldName("date");
        
        public static Partial<FTSDraft> WithSnippets(this Partial<FTSDraft> it)
            => it.AddFieldName("snippets");
        
        public static Partial<FTSDraft> WithSnippets(this Partial<FTSDraft> it, Func<Partial<FTSSnippet>, Partial<FTSSnippet>> partialBuilder)
            => it.AddFieldName("snippets", partialBuilder(new Partial<FTSSnippet>(it)));
        
    }
    
}