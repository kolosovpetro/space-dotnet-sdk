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
    public sealed class ReviewerChangedEvent
         : FeedEvent, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "ReviewerChangedEvent";
        
        public ReviewerChangedEvent() { }
        
        public ReviewerChangedEvent(TDMemberProfile uid, ReviewerChangedType changeType)
        {
            Uid = uid;
            ChangeType = changeType;
        }
        
        private PropertyValue<TDMemberProfile> _uid = new PropertyValue<TDMemberProfile>(nameof(ReviewerChangedEvent), nameof(Uid));
        
        [Required]
        [JsonPropertyName("uid")]
        public TDMemberProfile Uid
        {
            get => _uid.GetValue();
            set => _uid.SetValue(value);
        }
    
        private PropertyValue<ReviewerChangedType> _changeType = new PropertyValue<ReviewerChangedType>(nameof(ReviewerChangedEvent), nameof(ChangeType));
        
        [Required]
        [JsonPropertyName("changeType")]
        public ReviewerChangedType ChangeType
        {
            get => _changeType.GetValue();
            set => _changeType.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _uid.SetAccessPath(path, validateHasBeenSet);
            _changeType.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
