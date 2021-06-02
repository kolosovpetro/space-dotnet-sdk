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

namespace JetBrains.Space.Client.CodeReviewSubscriptionFilterInPartialBuilder
{
    public static class CodeReviewSubscriptionFilterInPartialExtensions
    {
        public static Partial<CodeReviewSubscriptionFilterIn> WithProject(this Partial<CodeReviewSubscriptionFilterIn> it)
            => it.AddFieldName("project");
        
        public static Partial<CodeReviewSubscriptionFilterIn> WithRepository(this Partial<CodeReviewSubscriptionFilterIn> it)
            => it.AddFieldName("repository");
        
        public static Partial<CodeReviewSubscriptionFilterIn> WithAuthors(this Partial<CodeReviewSubscriptionFilterIn> it)
            => it.AddFieldName("authors");
        
        public static Partial<CodeReviewSubscriptionFilterIn> WithParticipants(this Partial<CodeReviewSubscriptionFilterIn> it)
            => it.AddFieldName("participants");
        
        public static Partial<CodeReviewSubscriptionFilterIn> WithBranchSpec(this Partial<CodeReviewSubscriptionFilterIn> it)
            => it.AddFieldName("branchSpec");
        
        public static Partial<CodeReviewSubscriptionFilterIn> WithPathSpec(this Partial<CodeReviewSubscriptionFilterIn> it)
            => it.AddFieldName("pathSpec");
        
        public static Partial<CodeReviewSubscriptionFilterIn> WithTitleRegex(this Partial<CodeReviewSubscriptionFilterIn> it)
            => it.AddFieldName("titleRegex");
        
    }
    
}
