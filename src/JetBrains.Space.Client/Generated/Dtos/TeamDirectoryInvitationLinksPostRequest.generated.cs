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
    public class TeamDirectoryInvitationLinksPostRequest
         : IPropagatePropertyAccessPath
    {
        public TeamDirectoryInvitationLinksPostRequest() { }
        
        public TeamDirectoryInvitationLinksPostRequest(string name, DateTime expiresAt, int inviteeLimit)
        {
            Name = name;
            ExpiresAt = expiresAt;
            InviteeLimit = inviteeLimit;
        }
        
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(TeamDirectoryInvitationLinksPostRequest), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get => _name.GetValue();
            set => _name.SetValue(value);
        }
    
        private PropertyValue<DateTime> _expiresAt = new PropertyValue<DateTime>(nameof(TeamDirectoryInvitationLinksPostRequest), nameof(ExpiresAt));
        
        [Required]
        [JsonPropertyName("expiresAt")]
        [JsonConverter(typeof(SpaceDateTimeConverter))]
        public DateTime ExpiresAt
        {
            get => _expiresAt.GetValue();
            set => _expiresAt.SetValue(value);
        }
    
        private PropertyValue<int> _inviteeLimit = new PropertyValue<int>(nameof(TeamDirectoryInvitationLinksPostRequest), nameof(InviteeLimit));
        
        [Required]
        [JsonPropertyName("inviteeLimit")]
        public int InviteeLimit
        {
            get => _inviteeLimit.GetValue();
            set => _inviteeLimit.SetValue(value);
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _name.SetAccessPath(path, validateHasBeenSet);
            _expiresAt.SetAccessPath(path, validateHasBeenSet);
            _inviteeLimit.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
