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
    public class CustomFieldsForTypeKeyForEntityIdValuesPatchRequest
         : IPropagatePropertyAccessPath
    {
        public CustomFieldsForTypeKeyForEntityIdValuesPatchRequest() { }
        
        public CustomFieldsForTypeKeyForEntityIdValuesPatchRequest(List<CustomFieldValueDto> values)
        {
            Values = values;
        }
        
        private PropertyValue<List<CustomFieldValueDto>> _values = new PropertyValue<List<CustomFieldValueDto>>(nameof(CustomFieldsForTypeKeyForEntityIdValuesPatchRequest), nameof(Values));
        
        [Required]
        [JsonPropertyName("values")]
        public List<CustomFieldValueDto> Values
        {
            get { return _values.GetValue(); }
            set { _values.SetValue(value); }
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _values.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
