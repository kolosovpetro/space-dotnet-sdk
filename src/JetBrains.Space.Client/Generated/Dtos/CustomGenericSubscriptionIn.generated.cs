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
    public sealed class CustomGenericSubscriptionIn
         : IPropagatePropertyAccessPath
    {
        public CustomGenericSubscriptionIn() { }
        
        public CustomGenericSubscriptionIn(string subjectCode, List<SubscriptionFilterIn> filters, List<string> eventTypeCodes)
        {
            SubjectCode = subjectCode;
            Filters = filters;
            EventTypeCodes = eventTypeCodes;
        }
        
        private PropertyValue<string> _subjectCode = new PropertyValue<string>(nameof(CustomGenericSubscriptionIn), nameof(SubjectCode));
        
        [Required]
        [JsonPropertyName("subjectCode")]
        public string SubjectCode
        {
            get => _subjectCode.GetValue();
            set => _subjectCode.SetValue(value);
        }
    
        private PropertyValue<List<SubscriptionFilterIn>> _filters = new PropertyValue<List<SubscriptionFilterIn>>(nameof(CustomGenericSubscriptionIn), nameof(Filters), new List<SubscriptionFilterIn>());
        
        [Required]
        [JsonPropertyName("filters")]
        public List<SubscriptionFilterIn> Filters
        {
            get => _filters.GetValue();
            set => _filters.SetValue(value);
        }
    
        private PropertyValue<List<string>> _eventTypeCodes = new PropertyValue<List<string>>(nameof(CustomGenericSubscriptionIn), nameof(EventTypeCodes), new List<string>());
        
        [Required]
        [JsonPropertyName("eventTypeCodes")]
        public List<string> EventTypeCodes
        {
            get => _eventTypeCodes.GetValue();
            set => _eventTypeCodes.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _subjectCode.SetAccessPath(path, validateHasBeenSet);
            _filters.SetAccessPath(path, validateHasBeenSet);
            _eventTypeCodes.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
