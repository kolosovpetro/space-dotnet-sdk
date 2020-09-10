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

namespace SpaceDotNet.Client.InvitationLinkPartialBuilder
{
    public static class InvitationLinkPartialExtensions
    {
        public static Partial<InvitationLink> WithId(this Partial<InvitationLink> it)
            => it.AddFieldName("id");
        
        public static Partial<InvitationLink> WithName(this Partial<InvitationLink> it)
            => it.AddFieldName("name");
        
        public static Partial<InvitationLink> WithCreatedBy(this Partial<InvitationLink> it)
            => it.AddFieldName("createdBy");
        
        public static Partial<InvitationLink> WithCreatedBy(this Partial<InvitationLink> it, Func<Partial<CPrincipal>, Partial<CPrincipal>> partialBuilder)
            => it.AddFieldName("createdBy", partialBuilder(new Partial<CPrincipal>(it)));
        
        public static Partial<InvitationLink> WithCreatedAt(this Partial<InvitationLink> it)
            => it.AddFieldName("createdAt");
        
        public static Partial<InvitationLink> WithExpiresAt(this Partial<InvitationLink> it)
            => it.AddFieldName("expiresAt");
        
        public static Partial<InvitationLink> WithInviteeLimit(this Partial<InvitationLink> it)
            => it.AddFieldName("inviteeLimit");
        
        public static Partial<InvitationLink> WithInviteeUsage(this Partial<InvitationLink> it)
            => it.AddFieldName("inviteeUsage");
        
        public static Partial<InvitationLink> WithIsDeleted(this Partial<InvitationLink> it)
            => it.AddFieldName("deleted");
        
    }
    
}