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
    public class PublicHolidaysCalendarsPostRequest
         : IPropagatePropertyAccessPath
    {
        public PublicHolidaysCalendarsPostRequest() { }
        
        public PublicHolidaysCalendarsPostRequest(string name, string location)
        {
            Name = name;
            Location = location;
        }
        
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(PublicHolidaysCalendarsPostRequest), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get { return _name.GetValue(); }
            set { _name.SetValue(value); }
        }
    
        private PropertyValue<string> _location = new PropertyValue<string>(nameof(PublicHolidaysCalendarsPostRequest), nameof(Location));
        
        [Required]
        [JsonPropertyName("location")]
        public string Location
        {
            get { return _location.GetValue(); }
            set { _location.SetValue(value); }
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _name.SetAccessPath(path, validateHasBeenSet);
            _location.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
