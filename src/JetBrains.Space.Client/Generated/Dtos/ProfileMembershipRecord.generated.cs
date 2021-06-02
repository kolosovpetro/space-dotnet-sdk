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
    public sealed class ProfileMembershipRecord
         : IPropagatePropertyAccessPath
    {
        public ProfileMembershipRecord() { }
        
        public ProfileMembershipRecord(string id, List<TDMembership> memberships, List<TDMembership>? unapprovedMemberships = null)
        {
            Id = id;
            Memberships = memberships;
            UnapprovedMemberships = unapprovedMemberships;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(ProfileMembershipRecord), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get => _id.GetValue();
            set => _id.SetValue(value);
        }
    
        private PropertyValue<List<TDMembership>> _memberships = new PropertyValue<List<TDMembership>>(nameof(ProfileMembershipRecord), nameof(Memberships), new List<TDMembership>());
        
        [Required]
        [JsonPropertyName("memberships")]
        public List<TDMembership> Memberships
        {
            get => _memberships.GetValue();
            set => _memberships.SetValue(value);
        }
    
        private PropertyValue<List<TDMembership>?> _unapprovedMemberships = new PropertyValue<List<TDMembership>?>(nameof(ProfileMembershipRecord), nameof(UnapprovedMemberships));
        
        [JsonPropertyName("unapprovedMemberships")]
        public List<TDMembership>? UnapprovedMemberships
        {
            get => _unapprovedMemberships.GetValue();
            set => _unapprovedMemberships.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _memberships.SetAccessPath(path, validateHasBeenSet);
            _unapprovedMemberships.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
