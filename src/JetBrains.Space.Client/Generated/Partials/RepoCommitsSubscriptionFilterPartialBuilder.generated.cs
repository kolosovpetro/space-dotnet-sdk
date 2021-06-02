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

namespace JetBrains.Space.Client.RepoCommitsSubscriptionFilterPartialBuilder
{
    public static class RepoCommitsSubscriptionFilterPartialExtensions
    {
        public static Partial<RepoCommitsSubscriptionFilter> WithProjects(this Partial<RepoCommitsSubscriptionFilter> it)
            => it.AddFieldName("projects");
        
        public static Partial<RepoCommitsSubscriptionFilter> WithProjects(this Partial<RepoCommitsSubscriptionFilter> it, Func<Partial<PRProject>, Partial<PRProject>> partialBuilder)
            => it.AddFieldName("projects", partialBuilder(new Partial<PRProject>(it)));
        
        public static Partial<RepoCommitsSubscriptionFilter> WithRepository(this Partial<RepoCommitsSubscriptionFilter> it)
            => it.AddFieldName("repository");
        
        public static Partial<RepoCommitsSubscriptionFilter> WithSpec(this Partial<RepoCommitsSubscriptionFilter> it)
            => it.AddFieldName("spec");
        
        public static Partial<RepoCommitsSubscriptionFilter> WithSpec(this Partial<RepoCommitsSubscriptionFilter> it, Func<Partial<RepoCommitsSubscriptionFilterSpec>, Partial<RepoCommitsSubscriptionFilterSpec>> partialBuilder)
            => it.AddFieldName("spec", partialBuilder(new Partial<RepoCommitsSubscriptionFilterSpec>(it)));
        
    }
    
}
