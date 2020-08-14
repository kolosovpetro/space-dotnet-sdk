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
    public sealed class TDProfileNameDto
         : IPropagatePropertyAccessPath
    {
        public TDProfileNameDto() { }
        
        public TDProfileNameDto(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        
        private PropertyValue<string> _firstName = new PropertyValue<string>(nameof(TDProfileNameDto), nameof(FirstName));
        
        [Required]
        [JsonPropertyName("firstName")]
        public string FirstName
        {
            get { return _firstName.GetValue(); }
            set { _firstName.SetValue(value); }
        }
    
        private PropertyValue<string> _lastName = new PropertyValue<string>(nameof(TDProfileNameDto), nameof(LastName));
        
        [Required]
        [JsonPropertyName("lastName")]
        public string LastName
        {
            get { return _lastName.GetValue(); }
            set { _lastName.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _firstName.SetAccessPath(path, validateHasBeenSet);
            _lastName.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
