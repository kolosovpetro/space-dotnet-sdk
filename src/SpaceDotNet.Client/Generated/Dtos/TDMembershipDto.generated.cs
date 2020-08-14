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
    public sealed class TDMembershipDto
         : IPropagatePropertyAccessPath
    {
        public TDMembershipDto() { }
        
        public TDMembershipDto(string id, TDTeamDto team, TDRoleDto role, bool lead, bool requiresApproval, bool archived, Dictionary<string, CFValueDto> customFields, TDMemberProfileDto? member = null, TDMemberProfileDto? manager = null, SpaceDate? since = null, SpaceDate? till = null, SpaceTime? activeSince = null, SpaceTime? activeTill = null, TDMembershipDto? editFor = null, TDMembershipDto? pendingEdit = null, TDMemberProfileDto? approver = null)
        {
            Id = id;
            Member = member;
            Team = team;
            Role = role;
            Lead = lead;
            Manager = manager;
            Since = since;
            Till = till;
            ActiveSince = activeSince;
            ActiveTill = activeTill;
            RequiresApproval = requiresApproval;
            Archived = archived;
            EditFor = editFor;
            PendingEdit = pendingEdit;
            Approver = approver;
            CustomFields = customFields;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(TDMembershipDto), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<TDMemberProfileDto?> _member = new PropertyValue<TDMemberProfileDto?>(nameof(TDMembershipDto), nameof(Member));
        
        [JsonPropertyName("member")]
        public TDMemberProfileDto? Member
        {
            get { return _member.GetValue(); }
            set { _member.SetValue(value); }
        }
    
        private PropertyValue<TDTeamDto> _team = new PropertyValue<TDTeamDto>(nameof(TDMembershipDto), nameof(Team));
        
        [Required]
        [JsonPropertyName("team")]
        public TDTeamDto Team
        {
            get { return _team.GetValue(); }
            set { _team.SetValue(value); }
        }
    
        private PropertyValue<TDRoleDto> _role = new PropertyValue<TDRoleDto>(nameof(TDMembershipDto), nameof(Role));
        
        [Required]
        [JsonPropertyName("role")]
        public TDRoleDto Role
        {
            get { return _role.GetValue(); }
            set { _role.SetValue(value); }
        }
    
        private PropertyValue<bool> _lead = new PropertyValue<bool>(nameof(TDMembershipDto), nameof(Lead));
        
        [Required]
        [JsonPropertyName("lead")]
        public bool Lead
        {
            get { return _lead.GetValue(); }
            set { _lead.SetValue(value); }
        }
    
        private PropertyValue<TDMemberProfileDto?> _manager = new PropertyValue<TDMemberProfileDto?>(nameof(TDMembershipDto), nameof(Manager));
        
        [JsonPropertyName("manager")]
        public TDMemberProfileDto? Manager
        {
            get { return _manager.GetValue(); }
            set { _manager.SetValue(value); }
        }
    
        private PropertyValue<SpaceDate?> _since = new PropertyValue<SpaceDate?>(nameof(TDMembershipDto), nameof(Since));
        
        [JsonPropertyName("since")]
        public SpaceDate? Since
        {
            get { return _since.GetValue(); }
            set { _since.SetValue(value); }
        }
    
        private PropertyValue<SpaceDate?> _till = new PropertyValue<SpaceDate?>(nameof(TDMembershipDto), nameof(Till));
        
        [JsonPropertyName("till")]
        public SpaceDate? Till
        {
            get { return _till.GetValue(); }
            set { _till.SetValue(value); }
        }
    
        private PropertyValue<SpaceTime?> _activeSince = new PropertyValue<SpaceTime?>(nameof(TDMembershipDto), nameof(ActiveSince));
        
        [JsonPropertyName("activeSince")]
        public SpaceTime? ActiveSince
        {
            get { return _activeSince.GetValue(); }
            set { _activeSince.SetValue(value); }
        }
    
        private PropertyValue<SpaceTime?> _activeTill = new PropertyValue<SpaceTime?>(nameof(TDMembershipDto), nameof(ActiveTill));
        
        [JsonPropertyName("activeTill")]
        public SpaceTime? ActiveTill
        {
            get { return _activeTill.GetValue(); }
            set { _activeTill.SetValue(value); }
        }
    
        private PropertyValue<bool> _requiresApproval = new PropertyValue<bool>(nameof(TDMembershipDto), nameof(RequiresApproval));
        
        [Required]
        [JsonPropertyName("requiresApproval")]
        public bool RequiresApproval
        {
            get { return _requiresApproval.GetValue(); }
            set { _requiresApproval.SetValue(value); }
        }
    
        private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(TDMembershipDto), nameof(Archived));
        
        [Required]
        [JsonPropertyName("archived")]
        public bool Archived
        {
            get { return _archived.GetValue(); }
            set { _archived.SetValue(value); }
        }
    
        private PropertyValue<TDMembershipDto?> _editFor = new PropertyValue<TDMembershipDto?>(nameof(TDMembershipDto), nameof(EditFor));
        
        [JsonPropertyName("editFor")]
        public TDMembershipDto? EditFor
        {
            get { return _editFor.GetValue(); }
            set { _editFor.SetValue(value); }
        }
    
        private PropertyValue<TDMembershipDto?> _pendingEdit = new PropertyValue<TDMembershipDto?>(nameof(TDMembershipDto), nameof(PendingEdit));
        
        [JsonPropertyName("pendingEdit")]
        public TDMembershipDto? PendingEdit
        {
            get { return _pendingEdit.GetValue(); }
            set { _pendingEdit.SetValue(value); }
        }
    
        private PropertyValue<TDMemberProfileDto?> _approver = new PropertyValue<TDMemberProfileDto?>(nameof(TDMembershipDto), nameof(Approver));
        
        [JsonPropertyName("approver")]
        public TDMemberProfileDto? Approver
        {
            get { return _approver.GetValue(); }
            set { _approver.SetValue(value); }
        }
    
        private PropertyValue<Dictionary<string, CFValueDto>> _customFields = new PropertyValue<Dictionary<string, CFValueDto>>(nameof(TDMembershipDto), nameof(CustomFields));
        
        [Required]
        [JsonPropertyName("customFields")]
        public Dictionary<string, CFValueDto> CustomFields
        {
            get { return _customFields.GetValue(); }
            set { _customFields.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _member.SetAccessPath(path, validateHasBeenSet);
            _team.SetAccessPath(path, validateHasBeenSet);
            _role.SetAccessPath(path, validateHasBeenSet);
            _lead.SetAccessPath(path, validateHasBeenSet);
            _manager.SetAccessPath(path, validateHasBeenSet);
            _since.SetAccessPath(path, validateHasBeenSet);
            _till.SetAccessPath(path, validateHasBeenSet);
            _activeSince.SetAccessPath(path, validateHasBeenSet);
            _activeTill.SetAccessPath(path, validateHasBeenSet);
            _requiresApproval.SetAccessPath(path, validateHasBeenSet);
            _archived.SetAccessPath(path, validateHasBeenSet);
            _editFor.SetAccessPath(path, validateHasBeenSet);
            _pendingEdit.SetAccessPath(path, validateHasBeenSet);
            _approver.SetAccessPath(path, validateHasBeenSet);
            _customFields.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
