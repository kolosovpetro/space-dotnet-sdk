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

namespace JetBrains.Space.Client.AbsenceRecordPartialBuilder
{
    public static class AbsenceRecordPartialExtensions
    {
        public static Partial<AbsenceRecord> WithId(this Partial<AbsenceRecord> it)
            => it.AddFieldName("id");
        
        public static Partial<AbsenceRecord> WithIsArchived(this Partial<AbsenceRecord> it)
            => it.AddFieldName("archived");
        
        public static Partial<AbsenceRecord> WithMember(this Partial<AbsenceRecord> it)
            => it.AddFieldName("member");
        
        public static Partial<AbsenceRecord> WithMember(this Partial<AbsenceRecord> it, Func<Partial<TDMemberProfile>, Partial<TDMemberProfile>> partialBuilder)
            => it.AddFieldName("member", partialBuilder(new Partial<TDMemberProfile>(it)));
        
        public static Partial<AbsenceRecord> WithIcon(this Partial<AbsenceRecord> it)
            => it.AddFieldName("icon");
        
        public static Partial<AbsenceRecord> WithReason(this Partial<AbsenceRecord> it)
            => it.AddFieldName("reason");
        
        public static Partial<AbsenceRecord> WithReason(this Partial<AbsenceRecord> it, Func<Partial<AbsenceReasonRecord>, Partial<AbsenceReasonRecord>> partialBuilder)
            => it.AddFieldName("reason", partialBuilder(new Partial<AbsenceReasonRecord>(it)));
        
        public static Partial<AbsenceRecord> WithDescription(this Partial<AbsenceRecord> it)
            => it.AddFieldName("description");
        
        public static Partial<AbsenceRecord> WithSince(this Partial<AbsenceRecord> it)
            => it.AddFieldName("since");
        
        public static Partial<AbsenceRecord> WithTill(this Partial<AbsenceRecord> it)
            => it.AddFieldName("till");
        
        public static Partial<AbsenceRecord> WithLocation(this Partial<AbsenceRecord> it)
            => it.AddFieldName("location");
        
        public static Partial<AbsenceRecord> WithLocation(this Partial<AbsenceRecord> it, Func<Partial<TDLocation>, Partial<TDLocation>> partialBuilder)
            => it.AddFieldName("location", partialBuilder(new Partial<TDLocation>(it)));
        
        public static Partial<AbsenceRecord> WithIsAvailable(this Partial<AbsenceRecord> it)
            => it.AddFieldName("available");
        
        public static Partial<AbsenceRecord> WithApproval(this Partial<AbsenceRecord> it)
            => it.AddFieldName("approval");
        
        public static Partial<AbsenceRecord> WithApproval(this Partial<AbsenceRecord> it, Func<Partial<AbsenceApproval>, Partial<AbsenceApproval>> partialBuilder)
            => it.AddFieldName("approval", partialBuilder(new Partial<AbsenceApproval>(it)));
        
        public static Partial<AbsenceRecord> WithCustomFields(this Partial<AbsenceRecord> it)
            => it.AddFieldName("customFields");
        
        public static Partial<AbsenceRecord> WithCustomFields(this Partial<AbsenceRecord> it, Func<Partial<CFValue>, Partial<CFValue>> partialBuilder)
            => it.AddFieldName("customFields", partialBuilder(new Partial<CFValue>(it)));
        
    }
    
}
