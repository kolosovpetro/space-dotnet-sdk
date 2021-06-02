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

namespace JetBrains.Space.Client.MemberCommonSubscriptionFilterPartialBuilder
{
    public static class MemberCommonSubscriptionFilterPartialExtensions
    {
        public static Partial<MemberCommonSubscriptionFilter> WithTeams(this Partial<MemberCommonSubscriptionFilter> it)
            => it.AddFieldName("teams");
        
        public static Partial<MemberCommonSubscriptionFilter> WithTeams(this Partial<MemberCommonSubscriptionFilter> it, Func<Partial<TDTeam>, Partial<TDTeam>> partialBuilder)
            => it.AddFieldName("teams", partialBuilder(new Partial<TDTeam>(it)));
        
        public static Partial<MemberCommonSubscriptionFilter> WithLocations(this Partial<MemberCommonSubscriptionFilter> it)
            => it.AddFieldName("locations");
        
        public static Partial<MemberCommonSubscriptionFilter> WithLocations(this Partial<MemberCommonSubscriptionFilter> it, Func<Partial<TDLocation>, Partial<TDLocation>> partialBuilder)
            => it.AddFieldName("locations", partialBuilder(new Partial<TDLocation>(it)));
        
    }
    
}
