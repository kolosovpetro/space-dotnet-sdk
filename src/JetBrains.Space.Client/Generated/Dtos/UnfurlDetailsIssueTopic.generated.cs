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
using System.Globalization;
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
    public sealed class UnfurlDetailsIssueTopic
         : UnfurlDetails, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "UnfurlDetailsIssueTopic";
        
        public UnfurlDetailsIssueTopic() { }
        
        public UnfurlDetailsIssueTopic(Topic topic, bool strikeThrough)
        {
            Topic = topic;
            IsStrikeThrough = strikeThrough;
        }
        
        private PropertyValue<Topic> _topic = new PropertyValue<Topic>(nameof(UnfurlDetailsIssueTopic), nameof(Topic));
        
        [Required]
        [JsonPropertyName("topic")]
        public Topic Topic
        {
            get => _topic.GetValue();
            set => _topic.SetValue(value);
        }
    
        private PropertyValue<bool> _strikeThrough = new PropertyValue<bool>(nameof(UnfurlDetailsIssueTopic), nameof(IsStrikeThrough));
        
        [Required]
        [JsonPropertyName("strikeThrough")]
        public bool IsStrikeThrough
        {
            get => _strikeThrough.GetValue();
            set => _strikeThrough.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _topic.SetAccessPath(path, validateHasBeenSet);
            _strikeThrough.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}