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
    public sealed class ESSamlAttributeNames
         : IPropagatePropertyAccessPath
    {
        public ESSamlAttributeNames() { }
        
        public ESSamlAttributeNames(bool emailVerified, string? loginAttributeName = null, string? firstNameAttributeName = null, string? lastNameAttributeName = null, string? fullNameAttributeName = null, string? emailAttributeName = null)
        {
            LoginAttributeName = loginAttributeName;
            FirstNameAttributeName = firstNameAttributeName;
            LastNameAttributeName = lastNameAttributeName;
            FullNameAttributeName = fullNameAttributeName;
            EmailAttributeName = emailAttributeName;
            IsEmailVerified = emailVerified;
        }
        
        private PropertyValue<string?> _loginAttributeName = new PropertyValue<string?>(nameof(ESSamlAttributeNames), nameof(LoginAttributeName));
        
        [JsonPropertyName("loginAttributeName")]
        public string? LoginAttributeName
        {
            get => _loginAttributeName.GetValue();
            set => _loginAttributeName.SetValue(value);
        }
    
        private PropertyValue<string?> _firstNameAttributeName = new PropertyValue<string?>(nameof(ESSamlAttributeNames), nameof(FirstNameAttributeName));
        
        [JsonPropertyName("firstNameAttributeName")]
        public string? FirstNameAttributeName
        {
            get => _firstNameAttributeName.GetValue();
            set => _firstNameAttributeName.SetValue(value);
        }
    
        private PropertyValue<string?> _lastNameAttributeName = new PropertyValue<string?>(nameof(ESSamlAttributeNames), nameof(LastNameAttributeName));
        
        [JsonPropertyName("lastNameAttributeName")]
        public string? LastNameAttributeName
        {
            get => _lastNameAttributeName.GetValue();
            set => _lastNameAttributeName.SetValue(value);
        }
    
        private PropertyValue<string?> _fullNameAttributeName = new PropertyValue<string?>(nameof(ESSamlAttributeNames), nameof(FullNameAttributeName));
        
        [JsonPropertyName("fullNameAttributeName")]
        public string? FullNameAttributeName
        {
            get => _fullNameAttributeName.GetValue();
            set => _fullNameAttributeName.SetValue(value);
        }
    
        private PropertyValue<string?> _emailAttributeName = new PropertyValue<string?>(nameof(ESSamlAttributeNames), nameof(EmailAttributeName));
        
        [JsonPropertyName("emailAttributeName")]
        public string? EmailAttributeName
        {
            get => _emailAttributeName.GetValue();
            set => _emailAttributeName.SetValue(value);
        }
    
        private PropertyValue<bool> _emailVerified = new PropertyValue<bool>(nameof(ESSamlAttributeNames), nameof(IsEmailVerified));
        
        [Required]
        [JsonPropertyName("emailVerified")]
        public bool IsEmailVerified
        {
            get => _emailVerified.GetValue();
            set => _emailVerified.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _loginAttributeName.SetAccessPath(path, validateHasBeenSet);
            _firstNameAttributeName.SetAccessPath(path, validateHasBeenSet);
            _lastNameAttributeName.SetAccessPath(path, validateHasBeenSet);
            _fullNameAttributeName.SetAccessPath(path, validateHasBeenSet);
            _emailAttributeName.SetAccessPath(path, validateHasBeenSet);
            _emailVerified.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
