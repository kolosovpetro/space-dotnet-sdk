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
    public sealed class HAEnumDto
         : IPropagatePropertyAccessPath
    {
        public HAEnumDto() { }
        
        public HAEnumDto(string id, string name, List<string> values, HADeprecationDto? deprecation = null)
        {
            Id = id;
            Name = name;
            Values = values;
            Deprecation = deprecation;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(HAEnumDto), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(HAEnumDto), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get { return _name.GetValue(); }
            set { _name.SetValue(value); }
        }
    
        private PropertyValue<List<string>> _values = new PropertyValue<List<string>>(nameof(HAEnumDto), nameof(Values));
        
        [Required]
        [JsonPropertyName("values")]
        public List<string> Values
        {
            get { return _values.GetValue(); }
            set { _values.SetValue(value); }
        }
    
        private PropertyValue<HADeprecationDto?> _deprecation = new PropertyValue<HADeprecationDto?>(nameof(HAEnumDto), nameof(Deprecation));
        
        [JsonPropertyName("deprecation")]
        public HADeprecationDto? Deprecation
        {
            get { return _deprecation.GetValue(); }
            set { _deprecation.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _name.SetAccessPath(path, validateHasBeenSet);
            _values.SetAccessPath(path, validateHasBeenSet);
            _deprecation.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
