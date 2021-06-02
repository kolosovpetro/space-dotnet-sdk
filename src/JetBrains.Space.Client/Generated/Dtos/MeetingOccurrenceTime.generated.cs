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
    public sealed class MeetingOccurrenceTime
         : IPropagatePropertyAccessPath
    {
        public MeetingOccurrenceTime() { }
        
        public MeetingOccurrenceTime(DateTime start, DateTime end)
        {
            Start = start;
            End = end;
        }
        
        private PropertyValue<DateTime> _start = new PropertyValue<DateTime>(nameof(MeetingOccurrenceTime), nameof(Start));
        
        [Required]
        [JsonPropertyName("start")]
        [JsonConverter(typeof(SpaceDateTimeConverter))]
        public DateTime Start
        {
            get => _start.GetValue();
            set => _start.SetValue(value);
        }
    
        private PropertyValue<DateTime> _end = new PropertyValue<DateTime>(nameof(MeetingOccurrenceTime), nameof(End));
        
        [Required]
        [JsonPropertyName("end")]
        [JsonConverter(typeof(SpaceDateTimeConverter))]
        public DateTime End
        {
            get => _end.GetValue();
            set => _end.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _start.SetAccessPath(path, validateHasBeenSet);
            _end.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
