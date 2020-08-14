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
    public class HrmBusinessEntitiesForIdPatchRequest
         : IPropagatePropertyAccessPath
    {
        public HrmBusinessEntitiesForIdPatchRequest() { }
        
        public HrmBusinessEntitiesForIdPatchRequest(string name, string locationId, int? vacationAllowance = null)
        {
            Name = name;
            LocationId = locationId;
            VacationAllowance = vacationAllowance;
        }
        
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(HrmBusinessEntitiesForIdPatchRequest), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get { return _name.GetValue(); }
            set { _name.SetValue(value); }
        }
    
        private PropertyValue<string> _locationId = new PropertyValue<string>(nameof(HrmBusinessEntitiesForIdPatchRequest), nameof(LocationId));
        
        [Required]
        [JsonPropertyName("locationId")]
        public string LocationId
        {
            get { return _locationId.GetValue(); }
            set { _locationId.SetValue(value); }
        }
    
        private PropertyValue<int?> _vacationAllowance = new PropertyValue<int?>(nameof(HrmBusinessEntitiesForIdPatchRequest), nameof(VacationAllowance));
        
        [JsonPropertyName("vacationAllowance")]
        public int? VacationAllowance
        {
            get { return _vacationAllowance.GetValue(); }
            set { _vacationAllowance.SetValue(value); }
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _name.SetAccessPath(path, validateHasBeenSet);
            _locationId.SetAccessPath(path, validateHasBeenSet);
            _vacationAllowance.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
