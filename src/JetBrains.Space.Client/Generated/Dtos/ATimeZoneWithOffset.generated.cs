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
    public sealed class ATimeZoneWithOffset
         : IPropagatePropertyAccessPath
    {
        public ATimeZoneWithOffset() { }
        
        public ATimeZoneWithOffset(string id, int offset)
        {
            Id = id;
            Offset = offset;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(ATimeZoneWithOffset), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get => _id.GetValue();
            set => _id.SetValue(value);
        }
    
        private PropertyValue<int> _offset = new PropertyValue<int>(nameof(ATimeZoneWithOffset), nameof(Offset));
        
        [Required]
        [JsonPropertyName("offset")]
        public int Offset
        {
            get => _offset.GetValue();
            set => _offset.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _offset.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
