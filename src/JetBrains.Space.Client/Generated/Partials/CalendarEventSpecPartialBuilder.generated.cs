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

namespace JetBrains.Space.Client.CalendarEventSpecPartialBuilder
{
    public static class CalendarEventSpecPartialExtensions
    {
        public static Partial<CalendarEventSpec> WithStart(this Partial<CalendarEventSpec> it)
            => it.AddFieldName("start");
        
        public static Partial<CalendarEventSpec> WithEnd(this Partial<CalendarEventSpec> it)
            => it.AddFieldName("end");
        
        public static Partial<CalendarEventSpec> WithRecurrenceRule(this Partial<CalendarEventSpec> it)
            => it.AddFieldName("recurrenceRule");
        
        public static Partial<CalendarEventSpec> WithRecurrenceRule(this Partial<CalendarEventSpec> it, Func<Partial<RecurrenceRule>, Partial<RecurrenceRule>> partialBuilder)
            => it.AddFieldName("recurrenceRule", partialBuilder(new Partial<RecurrenceRule>(it)));
        
        public static Partial<CalendarEventSpec> WithIsAllDay(this Partial<CalendarEventSpec> it)
            => it.AddFieldName("allDay");
        
        public static Partial<CalendarEventSpec> WithTimezone(this Partial<CalendarEventSpec> it)
            => it.AddFieldName("timezone");
        
        public static Partial<CalendarEventSpec> WithTimezone(this Partial<CalendarEventSpec> it, Func<Partial<ATimeZone>, Partial<ATimeZone>> partialBuilder)
            => it.AddFieldName("timezone", partialBuilder(new Partial<ATimeZone>(it)));
        
        public static Partial<CalendarEventSpec> WithParentId(this Partial<CalendarEventSpec> it)
            => it.AddFieldName("parentId");
        
        public static Partial<CalendarEventSpec> WithInitialMeetingStart(this Partial<CalendarEventSpec> it)
            => it.AddFieldName("initialMeetingStart");
        
        public static Partial<CalendarEventSpec> WithBusyStatus(this Partial<CalendarEventSpec> it)
            => it.AddFieldName("busyStatus");
        
        public static Partial<CalendarEventSpec> WithBusyStatus(this Partial<CalendarEventSpec> it, Func<Partial<BusyStatus>, Partial<BusyStatus>> partialBuilder)
            => it.AddFieldName("busyStatus", partialBuilder(new Partial<BusyStatus>(it)));
        
        public static Partial<CalendarEventSpec> WithNextChainId(this Partial<CalendarEventSpec> it)
            => it.AddFieldName("nextChainId");
        
    }
    
}
