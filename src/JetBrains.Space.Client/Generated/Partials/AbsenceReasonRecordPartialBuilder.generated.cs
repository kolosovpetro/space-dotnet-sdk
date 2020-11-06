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
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Client.Internal;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client.AbsenceReasonRecordPartialBuilder
{
    public static class AbsenceReasonRecordPartialExtensions
    {
        public static Partial<AbsenceReasonRecord> WithId(this Partial<AbsenceReasonRecord> it)
            => it.AddFieldName("id");
        
        public static Partial<AbsenceReasonRecord> WithIsArchived(this Partial<AbsenceReasonRecord> it)
            => it.AddFieldName("archived");
        
        public static Partial<AbsenceReasonRecord> WithName(this Partial<AbsenceReasonRecord> it)
            => it.AddFieldName("name");
        
        public static Partial<AbsenceReasonRecord> WithDescription(this Partial<AbsenceReasonRecord> it)
            => it.AddFieldName("description");
        
        public static Partial<AbsenceReasonRecord> WithIsDefaultAvailability(this Partial<AbsenceReasonRecord> it)
            => it.AddFieldName("defaultAvailability");
        
        public static Partial<AbsenceReasonRecord> WithIsApprovalRequired(this Partial<AbsenceReasonRecord> it)
            => it.AddFieldName("approvalRequired");
        
        public static Partial<AbsenceReasonRecord> WithIcon(this Partial<AbsenceReasonRecord> it)
            => it.AddFieldName("icon");
        
    }
    
}