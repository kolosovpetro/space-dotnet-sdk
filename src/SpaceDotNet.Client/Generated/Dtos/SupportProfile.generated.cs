// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS0108

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public sealed class SupportProfile
         : IPropagatePropertyAccessPath
    {
        public SupportProfile() { }
        
        public SupportProfile(TDMemberProfile profile, bool adminPermissionsGranted)
        {
            Profile = profile;
            IsAdminPermissionsGranted = adminPermissionsGranted;
        }
        
        private PropertyValue<TDMemberProfile> _profile = new PropertyValue<TDMemberProfile>(nameof(SupportProfile), nameof(Profile));
        
        [Required]
        [JsonPropertyName("profile")]
        public TDMemberProfile Profile
        {
            get { return _profile.GetValue(); }
            set { _profile.SetValue(value); }
        }
    
        private PropertyValue<bool> _adminPermissionsGranted = new PropertyValue<bool>(nameof(SupportProfile), nameof(IsAdminPermissionsGranted));
        
        [Required]
        [JsonPropertyName("adminPermissionsGranted")]
        public bool IsAdminPermissionsGranted
        {
            get { return _adminPermissionsGranted.GetValue(); }
            set { _adminPermissionsGranted.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _profile.SetAccessPath(path, validateHasBeenSet);
            _adminPermissionsGranted.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}