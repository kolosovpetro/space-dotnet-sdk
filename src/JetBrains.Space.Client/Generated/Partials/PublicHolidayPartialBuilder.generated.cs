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

namespace JetBrains.Space.Client.PublicHolidayPartialBuilder
{
    public static class PublicHolidayPartialExtensions
    {
        public static Partial<PublicHoliday> WithId(this Partial<PublicHoliday> it)
            => it.AddFieldName("id");
        
        public static Partial<PublicHoliday> WithCalendar(this Partial<PublicHoliday> it)
            => it.AddFieldName("calendar");
        
        public static Partial<PublicHoliday> WithCalendar(this Partial<PublicHoliday> it, Func<Partial<PublicHolidayCalendarRecord>, Partial<PublicHolidayCalendarRecord>> partialBuilder)
            => it.AddFieldName("calendar", partialBuilder(new Partial<PublicHolidayCalendarRecord>(it)));
        
        public static Partial<PublicHoliday> WithName(this Partial<PublicHoliday> it)
            => it.AddFieldName("name");
        
        public static Partial<PublicHoliday> WithDate(this Partial<PublicHoliday> it)
            => it.AddFieldName("date");
        
        public static Partial<PublicHoliday> WithIsWorkingDay(this Partial<PublicHoliday> it)
            => it.AddFieldName("workingDay");
        
        public static Partial<PublicHoliday> WithIsHalfDay(this Partial<PublicHoliday> it)
            => it.AddFieldName("halfDay");
        
        public static Partial<PublicHoliday> WithIsArchived(this Partial<PublicHoliday> it)
            => it.AddFieldName("archived");
        
    }
    
}
