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
    public class TeamDirectoryMembershipsPostRequest
         : IPropagatePropertyAccessPath
    {
        public TeamDirectoryMembershipsPostRequest() { }
        
        public TeamDirectoryMembershipsPostRequest(ProfileIdentifier member, string teamId, string roleId, bool lead = false, bool requiresApproval = false, ProfileIdentifier? manager = null, DateTime? activeSince = null, DateTime? activeTill = null, string? previousMembershipId = null, List<CustomFieldInputValue>? customFieldValues = null)
        {
            Member = member;
            TeamId = teamId;
            RoleId = roleId;
            IsLead = lead;
            Manager = manager;
            ActiveSince = activeSince;
            ActiveTill = activeTill;
            PreviousMembershipId = previousMembershipId;
            IsRequiresApproval = requiresApproval;
            CustomFieldValues = customFieldValues;
        }
        
        private PropertyValue<ProfileIdentifier> _member = new PropertyValue<ProfileIdentifier>(nameof(TeamDirectoryMembershipsPostRequest), nameof(Member));
        
        [Required]
        [JsonPropertyName("member")]
        public ProfileIdentifier Member
        {
            get => _member.GetValue();
            set => _member.SetValue(value);
        }
    
        private PropertyValue<string> _teamId = new PropertyValue<string>(nameof(TeamDirectoryMembershipsPostRequest), nameof(TeamId));
        
        [Required]
        [JsonPropertyName("teamId")]
        public string TeamId
        {
            get => _teamId.GetValue();
            set => _teamId.SetValue(value);
        }
    
        private PropertyValue<string> _roleId = new PropertyValue<string>(nameof(TeamDirectoryMembershipsPostRequest), nameof(RoleId));
        
        [Required]
        [JsonPropertyName("roleId")]
        public string RoleId
        {
            get => _roleId.GetValue();
            set => _roleId.SetValue(value);
        }
    
        private PropertyValue<bool> _lead = new PropertyValue<bool>(nameof(TeamDirectoryMembershipsPostRequest), nameof(IsLead));
        
        [Obsolete("The property is deprecated (since 2020-12-01) (marked for removal)")]
        [JsonPropertyName("lead")]
        public bool IsLead
        {
            get => _lead.GetValue();
            set => _lead.SetValue(value);
        }
    
        private PropertyValue<ProfileIdentifier?> _manager = new PropertyValue<ProfileIdentifier?>(nameof(TeamDirectoryMembershipsPostRequest), nameof(Manager));
        
        [JsonPropertyName("manager")]
        public ProfileIdentifier? Manager
        {
            get => _manager.GetValue();
            set => _manager.SetValue(value);
        }
    
        private PropertyValue<DateTime?> _activeSince = new PropertyValue<DateTime?>(nameof(TeamDirectoryMembershipsPostRequest), nameof(ActiveSince));
        
        [JsonPropertyName("activeSince")]
        [JsonConverter(typeof(SpaceDateTimeConverter))]
        public DateTime? ActiveSince
        {
            get => _activeSince.GetValue();
            set => _activeSince.SetValue(value);
        }
    
        private PropertyValue<DateTime?> _activeTill = new PropertyValue<DateTime?>(nameof(TeamDirectoryMembershipsPostRequest), nameof(ActiveTill));
        
        [JsonPropertyName("activeTill")]
        [JsonConverter(typeof(SpaceDateTimeConverter))]
        public DateTime? ActiveTill
        {
            get => _activeTill.GetValue();
            set => _activeTill.SetValue(value);
        }
    
        private PropertyValue<string?> _previousMembershipId = new PropertyValue<string?>(nameof(TeamDirectoryMembershipsPostRequest), nameof(PreviousMembershipId));
        
        [JsonPropertyName("previousMembershipId")]
        public string? PreviousMembershipId
        {
            get => _previousMembershipId.GetValue();
            set => _previousMembershipId.SetValue(value);
        }
    
        private PropertyValue<bool> _requiresApproval = new PropertyValue<bool>(nameof(TeamDirectoryMembershipsPostRequest), nameof(IsRequiresApproval));
        
        [JsonPropertyName("requiresApproval")]
        public bool IsRequiresApproval
        {
            get => _requiresApproval.GetValue();
            set => _requiresApproval.SetValue(value);
        }
    
        private PropertyValue<List<CustomFieldInputValue>?> _customFieldValues = new PropertyValue<List<CustomFieldInputValue>?>(nameof(TeamDirectoryMembershipsPostRequest), nameof(CustomFieldValues));
        
        [JsonPropertyName("customFieldValues")]
        public List<CustomFieldInputValue>? CustomFieldValues
        {
            get => _customFieldValues.GetValue();
            set => _customFieldValues.SetValue(value);
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _member.SetAccessPath(path, validateHasBeenSet);
            _teamId.SetAccessPath(path, validateHasBeenSet);
            _roleId.SetAccessPath(path, validateHasBeenSet);
            _lead.SetAccessPath(path, validateHasBeenSet);
            _manager.SetAccessPath(path, validateHasBeenSet);
            _activeSince.SetAccessPath(path, validateHasBeenSet);
            _activeTill.SetAccessPath(path, validateHasBeenSet);
            _previousMembershipId.SetAccessPath(path, validateHasBeenSet);
            _requiresApproval.SetAccessPath(path, validateHasBeenSet);
            _customFieldValues.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
