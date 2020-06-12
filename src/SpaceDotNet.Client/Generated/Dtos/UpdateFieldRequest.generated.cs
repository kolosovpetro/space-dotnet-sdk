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
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public class UpdateFieldRequest
    {
        private PropertyValue<string?> _name = new PropertyValue<string?>(nameof(UpdateFieldRequest), nameof(Name));
        
        [JsonPropertyName("name")]
        public string? Name
        {
            get { return _name.GetValue(); }
            set { _name.SetValue(value); }
        }
    
        private PropertyValue<string?> _key = new PropertyValue<string?>(nameof(UpdateFieldRequest), nameof(Key));
        
        [JsonPropertyName("key")]
        public string? Key
        {
            get { return _key.GetValue(); }
            set { _key.SetValue(value); }
        }
    
        private PropertyValue<CFConstraintDto?> _constraint = new PropertyValue<CFConstraintDto?>(nameof(UpdateFieldRequest), nameof(Constraint));
        
        [JsonPropertyName("constraint")]
        public CFConstraintDto? Constraint
        {
            get { return _constraint.GetValue(); }
            set { _constraint.SetValue(value); }
        }
    
        private PropertyValue<bool?> _required = new PropertyValue<bool?>(nameof(UpdateFieldRequest), nameof(Required));
        
        [JsonPropertyName("required")]
        public bool? Required
        {
            get { return _required.GetValue(); }
            set { _required.SetValue(value); }
        }
    
        private PropertyValue<bool?> _private = new PropertyValue<bool?>(nameof(UpdateFieldRequest), nameof(Private));
        
        [JsonPropertyName("private")]
        public bool? Private
        {
            get { return _private.GetValue(); }
            set { _private.SetValue(value); }
        }
    
        private PropertyValue<AccessType?> _access = new PropertyValue<AccessType?>(nameof(UpdateFieldRequest), nameof(Access));
        
        [JsonPropertyName("access")]
        public AccessType? Access
        {
            get { return _access.GetValue(); }
            set { _access.SetValue(value); }
        }
    
        private PropertyValue<CFValueDto?> _defaultValue = new PropertyValue<CFValueDto?>(nameof(UpdateFieldRequest), nameof(DefaultValue));
        
        [JsonPropertyName("defaultValue")]
        public CFValueDto? DefaultValue
        {
            get { return _defaultValue.GetValue(); }
            set { _defaultValue.SetValue(value); }
        }
    
        private PropertyValue<List<EnumValueDataDto>?> _enumValues = new PropertyValue<List<EnumValueDataDto>?>(nameof(UpdateFieldRequest), nameof(EnumValues));
        
        [JsonPropertyName("enumValues")]
        public List<EnumValueDataDto>? EnumValues
        {
            get { return _enumValues.GetValue(); }
            set { _enumValues.SetValue(value); }
        }
    
    }
    
}