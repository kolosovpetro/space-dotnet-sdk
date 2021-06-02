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

namespace JetBrains.Space.Client
{
    [JsonConverter(typeof(ClassNameDtoTypeConverter))]
    public class RecurrenceRuleFreq
         : IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public virtual string? ClassName => "RecurrenceRuleFreq";
        
        public static RecurrenceRuleFreqDaily Daily(int interval)
            => new RecurrenceRuleFreqDaily(interval: interval);
        
        public static RecurrenceRuleFreqMonthlyOnDate MonthlyOnDate(int day, int interval)
            => new RecurrenceRuleFreqMonthlyOnDate(day: day, interval: interval);
        
        public static RecurrenceRuleFreqMonthlyOnFirstWeekday MonthlyOnFirstWeekday(Weekday weekday, int shift, int interval)
            => new RecurrenceRuleFreqMonthlyOnFirstWeekday(weekday: weekday, shift: shift, interval: interval);
        
        public static RecurrenceRuleFreqMonthlyOnLastWeekday MonthlyOnLastWeekday(Weekday weekday, int interval)
            => new RecurrenceRuleFreqMonthlyOnLastWeekday(weekday: weekday, interval: interval);
        
        public static RecurrenceRuleFreqMonthlyOnStartDate MonthlyOnStartDate(int interval)
            => new RecurrenceRuleFreqMonthlyOnStartDate(interval: interval);
        
        public static RecurrenceRuleFreqWeekly Weekly(List<Weekday> weekdays, int interval)
            => new RecurrenceRuleFreqWeekly(weekdays: weekdays, interval: interval);
        
        public static RecurrenceRuleFreqYearly Yearly(int interval)
            => new RecurrenceRuleFreqYearly(interval: interval);
        
        public RecurrenceRuleFreq() { }
        
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
        }
    
    }
    
}
