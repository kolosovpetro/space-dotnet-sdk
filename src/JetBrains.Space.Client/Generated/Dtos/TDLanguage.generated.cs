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
    public sealed class TDLanguage
         : IPropagatePropertyAccessPath
    {
        public TDLanguage() { }
        
        public TDLanguage(string id, string code, string name, string nativeName, string firstNameTitle, string lastNameTitle)
        {
            Id = id;
            Code = code;
            Name = name;
            NativeName = nativeName;
            FirstNameTitle = firstNameTitle;
            LastNameTitle = lastNameTitle;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(TDLanguage), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get => _id.GetValue();
            set => _id.SetValue(value);
        }
    
        private PropertyValue<string> _code = new PropertyValue<string>(nameof(TDLanguage), nameof(Code));
        
        [Required]
        [JsonPropertyName("code")]
        public string Code
        {
            get => _code.GetValue();
            set => _code.SetValue(value);
        }
    
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(TDLanguage), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get => _name.GetValue();
            set => _name.SetValue(value);
        }
    
        private PropertyValue<string> _nativeName = new PropertyValue<string>(nameof(TDLanguage), nameof(NativeName));
        
        [Required]
        [JsonPropertyName("nativeName")]
        public string NativeName
        {
            get => _nativeName.GetValue();
            set => _nativeName.SetValue(value);
        }
    
        private PropertyValue<string> _firstNameTitle = new PropertyValue<string>(nameof(TDLanguage), nameof(FirstNameTitle));
        
        [Required]
        [JsonPropertyName("firstNameTitle")]
        public string FirstNameTitle
        {
            get => _firstNameTitle.GetValue();
            set => _firstNameTitle.SetValue(value);
        }
    
        private PropertyValue<string> _lastNameTitle = new PropertyValue<string>(nameof(TDLanguage), nameof(LastNameTitle));
        
        [Required]
        [JsonPropertyName("lastNameTitle")]
        public string LastNameTitle
        {
            get => _lastNameTitle.GetValue();
            set => _lastNameTitle.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _code.SetAccessPath(path, validateHasBeenSet);
            _name.SetAccessPath(path, validateHasBeenSet);
            _nativeName.SetAccessPath(path, validateHasBeenSet);
            _firstNameTitle.SetAccessPath(path, validateHasBeenSet);
            _lastNameTitle.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
