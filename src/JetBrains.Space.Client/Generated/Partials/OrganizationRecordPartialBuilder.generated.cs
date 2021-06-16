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

namespace JetBrains.Space.Client.OrganizationRecordPartialBuilder
{
    public static class OrganizationRecordPartialExtensions
    {
        public static Partial<OrganizationRecord> WithId(this Partial<OrganizationRecord> it)
            => it.AddFieldName("id");
        
        public static Partial<OrganizationRecord> WithOrgId(this Partial<OrganizationRecord> it)
            => it.AddFieldName("orgId");
        
        public static Partial<OrganizationRecord> WithName(this Partial<OrganizationRecord> it)
            => it.AddFieldName("name");
        
        public static Partial<OrganizationRecord> WithSlogan(this Partial<OrganizationRecord> it)
            => it.AddFieldName("slogan");
        
        public static Partial<OrganizationRecord> WithLogoId(this Partial<OrganizationRecord> it)
            => it.AddFieldName("logoId");
        
        public static Partial<OrganizationRecord> WithIsOnboardingRequired(this Partial<OrganizationRecord> it)
            => it.AddFieldName("onboardingRequired");
        
        public static Partial<OrganizationRecord> WithIsAllowDomainsEdit(this Partial<OrganizationRecord> it)
            => it.AddFieldName("allowDomainsEdit");
        
        public static Partial<OrganizationRecord> WithTimezone(this Partial<OrganizationRecord> it)
            => it.AddFieldName("timezone");
        
        public static Partial<OrganizationRecord> WithTimezone(this Partial<OrganizationRecord> it, Func<Partial<ATimeZone>, Partial<ATimeZone>> partialBuilder)
            => it.AddFieldName("timezone", partialBuilder(new Partial<ATimeZone>(it)));
        
        public static Partial<OrganizationRecord> WithSlackWorkspace(this Partial<OrganizationRecord> it)
            => it.AddFieldName("slackWorkspace");
        
    }
    
}