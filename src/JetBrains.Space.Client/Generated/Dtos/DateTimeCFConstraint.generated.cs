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
    public sealed class DateTimeCFConstraint
         : CFConstraint, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public override string? ClassName => "DateTimeCFConstraint";
        
        public DateTimeCFConstraint() { }
        
        public DateTimeCFConstraint(DateTime? min = null, DateTime? max = null, string? message = null)
        {
            Min = min;
            Max = max;
            Message = message;
        }
        
        private PropertyValue<DateTime?> _min = new PropertyValue<DateTime?>(nameof(DateTimeCFConstraint), nameof(Min));
        
        [JsonPropertyName("min")]
        [JsonConverter(typeof(SpaceDateTimeConverter))]
        public DateTime? Min
        {
            get => _min.GetValue();
            set => _min.SetValue(value);
        }
    
        private PropertyValue<DateTime?> _max = new PropertyValue<DateTime?>(nameof(DateTimeCFConstraint), nameof(Max));
        
        [JsonPropertyName("max")]
        [JsonConverter(typeof(SpaceDateTimeConverter))]
        public DateTime? Max
        {
            get => _max.GetValue();
            set => _max.SetValue(value);
        }
    
        private PropertyValue<string?> _message = new PropertyValue<string?>(nameof(DateTimeCFConstraint), nameof(Message));
        
        [JsonPropertyName("message")]
        public string? Message
        {
            get => _message.GetValue();
            set => _message.SetValue(value);
        }
    
        public override void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _min.SetAccessPath(path, validateHasBeenSet);
            _max.SetAccessPath(path, validateHasBeenSet);
            _message.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
