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
    public class PublicHolidaysCalendarsForIdPatchRequest
         : IPropagatePropertyAccessPath
    {
        public PublicHolidaysCalendarsForIdPatchRequest() { }
        
        public PublicHolidaysCalendarsForIdPatchRequest(string name, string location)
        {
            Name = name;
            Location = location;
        }
        
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(PublicHolidaysCalendarsForIdPatchRequest), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get => _name.GetValue();
            set => _name.SetValue(value);
        }
    
        private PropertyValue<string> _location = new PropertyValue<string>(nameof(PublicHolidaysCalendarsForIdPatchRequest), nameof(Location));
        
        [Required]
        [JsonPropertyName("location")]
        public string Location
        {
            get => _location.GetValue();
            set => _location.SetValue(value);
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _name.SetAccessPath(path, validateHasBeenSet);
            _location.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
