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

namespace JetBrains.Space.Client.TeamMembershipEventPartialBuilder
{
    public static class TeamMembershipEventPartialExtensions
    {
        public static Partial<TeamMembershipEvent> WithMeta(this Partial<TeamMembershipEvent> it)
            => it.AddFieldName("meta");
        
        public static Partial<TeamMembershipEvent> WithMeta(this Partial<TeamMembershipEvent> it, Func<Partial<KMetaMod>, Partial<KMetaMod>> partialBuilder)
            => it.AddFieldName("meta", partialBuilder(new Partial<KMetaMod>(it)));
        
        public static Partial<TeamMembershipEvent> WithMembership(this Partial<TeamMembershipEvent> it)
            => it.AddFieldName("membership");
        
        public static Partial<TeamMembershipEvent> WithMembership(this Partial<TeamMembershipEvent> it, Func<Partial<TDMembership>, Partial<TDMembership>> partialBuilder)
            => it.AddFieldName("membership", partialBuilder(new Partial<TDMembership>(it)));
        
        public static Partial<TeamMembershipEvent> WithTeam(this Partial<TeamMembershipEvent> it)
            => it.AddFieldName("team");
        
        public static Partial<TeamMembershipEvent> WithRole(this Partial<TeamMembershipEvent> it)
            => it.AddFieldName("role");
        
        public static Partial<TeamMembershipEvent> WithLead(this Partial<TeamMembershipEvent> it)
            => it.AddFieldName("lead");
        
        public static Partial<TeamMembershipEvent> WithManager(this Partial<TeamMembershipEvent> it)
            => it.AddFieldName("manager");
        
        public static Partial<TeamMembershipEvent> WithSince(this Partial<TeamMembershipEvent> it)
            => it.AddFieldName("since");
        
        public static Partial<TeamMembershipEvent> WithTill(this Partial<TeamMembershipEvent> it)
            => it.AddFieldName("till");
        
        public static Partial<TeamMembershipEvent> WithDeleted(this Partial<TeamMembershipEvent> it)
            => it.AddFieldName("deleted");
        
        public static Partial<TeamMembershipEvent> WithApprovedBy(this Partial<TeamMembershipEvent> it)
            => it.AddFieldName("approvedBy");
        
    }
    
}
