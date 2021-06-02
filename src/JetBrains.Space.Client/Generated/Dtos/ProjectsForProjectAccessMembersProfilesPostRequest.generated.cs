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
    public class ProjectsForProjectAccessMembersProfilesPostRequest
         : IPropagatePropertyAccessPath
    {
        public ProjectsForProjectAccessMembersProfilesPostRequest() { }
        
        public ProjectsForProjectAccessMembersProfilesPostRequest(ProfileIdentifier profile)
        {
            Profile = profile;
        }
        
        private PropertyValue<ProfileIdentifier> _profile = new PropertyValue<ProfileIdentifier>(nameof(ProjectsForProjectAccessMembersProfilesPostRequest), nameof(Profile));
        
        [Required]
        [JsonPropertyName("profile")]
        public ProfileIdentifier Profile
        {
            get => _profile.GetValue();
            set => _profile.SetValue(value);
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _profile.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
