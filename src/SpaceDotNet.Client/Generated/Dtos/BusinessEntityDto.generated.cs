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
    public sealed class BusinessEntityDto
         : IPropagatePropertyAccessPath
    {
        public BusinessEntityDto() { }
        
        public BusinessEntityDto(string id, string name, TDLocationDto location, int vacationAllowance, bool archived)
        {
            Id = id;
            Name = name;
            Location = location;
            VacationAllowance = vacationAllowance;
            Archived = archived;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(BusinessEntityDto), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(BusinessEntityDto), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get { return _name.GetValue(); }
            set { _name.SetValue(value); }
        }
    
        private PropertyValue<TDLocationDto> _location = new PropertyValue<TDLocationDto>(nameof(BusinessEntityDto), nameof(Location));
        
        [Required]
        [JsonPropertyName("location")]
        public TDLocationDto Location
        {
            get { return _location.GetValue(); }
            set { _location.SetValue(value); }
        }
    
        private PropertyValue<int> _vacationAllowance = new PropertyValue<int>(nameof(BusinessEntityDto), nameof(VacationAllowance));
        
        [Required]
        [JsonPropertyName("vacationAllowance")]
        public int VacationAllowance
        {
            get { return _vacationAllowance.GetValue(); }
            set { _vacationAllowance.SetValue(value); }
        }
    
        private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(BusinessEntityDto), nameof(Archived));
        
        [Required]
        [JsonPropertyName("archived")]
        public bool Archived
        {
            get { return _archived.GetValue(); }
            set { _archived.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _name.SetAccessPath(path, validateHasBeenSet);
            _location.SetAccessPath(path, validateHasBeenSet);
            _vacationAllowance.SetAccessPath(path, validateHasBeenSet);
            _archived.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}