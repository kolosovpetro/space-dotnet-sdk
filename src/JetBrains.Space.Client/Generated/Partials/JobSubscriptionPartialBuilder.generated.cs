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

namespace JetBrains.Space.Client.JobSubscriptionPartialBuilder
{
    public static class JobSubscriptionPartialExtensions
    {
        public static Partial<JobSubscription> WithId(this Partial<JobSubscription> it)
            => it.AddFieldName("id");
        
        public static Partial<JobSubscription> WithJobId(this Partial<JobSubscription> it)
            => it.AddFieldName("jobId");
        
        public static Partial<JobSubscription> WithProject(this Partial<JobSubscription> it)
            => it.AddFieldName("project");
        
        public static Partial<JobSubscription> WithProject(this Partial<JobSubscription> it, Func<Partial<PRProject>, Partial<PRProject>> partialBuilder)
            => it.AddFieldName("project", partialBuilder(new Partial<PRProject>(it)));
        
        public static Partial<JobSubscription> WithState(this Partial<JobSubscription> it)
            => it.AddFieldName("state");
        
        public static Partial<JobSubscription> WithState(this Partial<JobSubscription> it, Func<Partial<JobSubscriptionState>, Partial<JobSubscriptionState>> partialBuilder)
            => it.AddFieldName("state", partialBuilder(new Partial<JobSubscriptionState>(it)));
        
        public static Partial<JobSubscription> WithIsArchived(this Partial<JobSubscription> it)
            => it.AddFieldName("archived");
        
    }
    
}
