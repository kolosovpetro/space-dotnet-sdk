// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public sealed class MCActionDto
         : IPropagatePropertyAccessPath
    {
        public MCActionDto() { }
        
        public MCActionDto(string id, string value)
        {
            Id = id;
            Value = value;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(MCActionDto), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<string> _value = new PropertyValue<string>(nameof(MCActionDto), nameof(Value));
        
        [Required]
        [JsonPropertyName("value")]
        public string Value
        {
            get { return _value.GetValue(); }
            set { _value.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _value.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
