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
    public class TeamDirectoryProfilesForProfileVcsPasswordPatchRequest
         : IPropagatePropertyAccessPath
    {
        public TeamDirectoryProfilesForProfileVcsPasswordPatchRequest() { }
        
        public TeamDirectoryProfilesForProfileVcsPasswordPatchRequest(string password)
        {
            Password = password;
        }
        
        private PropertyValue<string> _password = new PropertyValue<string>(nameof(TeamDirectoryProfilesForProfileVcsPasswordPatchRequest), nameof(Password));
        
        [Required]
        [JsonPropertyName("password")]
        public string Password
        {
            get { return _password.GetValue(); }
            set { _password.SetValue(value); }
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _password.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
