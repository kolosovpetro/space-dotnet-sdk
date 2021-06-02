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
    public sealed class TeamMembershipEvent
         : WebhookEvent, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "TeamMembershipEvent";
        
        public TeamMembershipEvent() { }
        
        public TeamMembershipEvent(KMetaMod meta, TDMembership membership, Modification<TDTeam>? team = null, Modification<TDRole>? role = null, Modification<bool>? lead = null, Modification<TDMemberProfile>? manager = null, Modification<DateTime>? since = null, Modification<DateTime>? till = null, Modification<bool>? deleted = null, Modification<TDMemberProfile>? approvedBy = null)
        {
            Meta = meta;
            Membership = membership;
            Team = team;
            Role = role;
            Lead = lead;
            Manager = manager;
            Since = since;
            Till = till;
            Deleted = deleted;
            ApprovedBy = approvedBy;
        }
        
        private PropertyValue<KMetaMod> _meta = new PropertyValue<KMetaMod>(nameof(TeamMembershipEvent), nameof(Meta));
        
        [Required]
        [JsonPropertyName("meta")]
        public KMetaMod Meta
        {
            get => _meta.GetValue();
            set => _meta.SetValue(value);
        }
    
        private PropertyValue<TDMembership> _membership = new PropertyValue<TDMembership>(nameof(TeamMembershipEvent), nameof(Membership));
        
        [Required]
        [JsonPropertyName("membership")]
        public TDMembership Membership
        {
            get => _membership.GetValue();
            set => _membership.SetValue(value);
        }
    
        private PropertyValue<Modification<TDTeam>?> _team = new PropertyValue<Modification<TDTeam>?>(nameof(TeamMembershipEvent), nameof(Team));
        
        [JsonPropertyName("team")]
        public Modification<TDTeam>? Team
        {
            get => _team.GetValue();
            set => _team.SetValue(value);
        }
    
        private PropertyValue<Modification<TDRole>?> _role = new PropertyValue<Modification<TDRole>?>(nameof(TeamMembershipEvent), nameof(Role));
        
        [JsonPropertyName("role")]
        public Modification<TDRole>? Role
        {
            get => _role.GetValue();
            set => _role.SetValue(value);
        }
    
        private PropertyValue<Modification<bool>?> _lead = new PropertyValue<Modification<bool>?>(nameof(TeamMembershipEvent), nameof(Lead));
        
        [JsonPropertyName("lead")]
        public Modification<bool>? Lead
        {
            get => _lead.GetValue();
            set => _lead.SetValue(value);
        }
    
        private PropertyValue<Modification<TDMemberProfile>?> _manager = new PropertyValue<Modification<TDMemberProfile>?>(nameof(TeamMembershipEvent), nameof(Manager));
        
        [JsonPropertyName("manager")]
        public Modification<TDMemberProfile>? Manager
        {
            get => _manager.GetValue();
            set => _manager.SetValue(value);
        }
    
        private PropertyValue<Modification<DateTime>?> _since = new PropertyValue<Modification<DateTime>?>(nameof(TeamMembershipEvent), nameof(Since));
        
        [JsonPropertyName("since")]
        public Modification<DateTime>? Since
        {
            get => _since.GetValue();
            set => _since.SetValue(value);
        }
    
        private PropertyValue<Modification<DateTime>?> _till = new PropertyValue<Modification<DateTime>?>(nameof(TeamMembershipEvent), nameof(Till));
        
        [JsonPropertyName("till")]
        public Modification<DateTime>? Till
        {
            get => _till.GetValue();
            set => _till.SetValue(value);
        }
    
        private PropertyValue<Modification<bool>?> _deleted = new PropertyValue<Modification<bool>?>(nameof(TeamMembershipEvent), nameof(Deleted));
        
        [JsonPropertyName("deleted")]
        public Modification<bool>? Deleted
        {
            get => _deleted.GetValue();
            set => _deleted.SetValue(value);
        }
    
        private PropertyValue<Modification<TDMemberProfile>?> _approvedBy = new PropertyValue<Modification<TDMemberProfile>?>(nameof(TeamMembershipEvent), nameof(ApprovedBy));
        
        [JsonPropertyName("approvedBy")]
        public Modification<TDMemberProfile>? ApprovedBy
        {
            get => _approvedBy.GetValue();
            set => _approvedBy.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _meta.SetAccessPath(path, validateHasBeenSet);
            _membership.SetAccessPath(path, validateHasBeenSet);
            _team.SetAccessPath(path, validateHasBeenSet);
            _role.SetAccessPath(path, validateHasBeenSet);
            _lead.SetAccessPath(path, validateHasBeenSet);
            _manager.SetAccessPath(path, validateHasBeenSet);
            _since.SetAccessPath(path, validateHasBeenSet);
            _till.SetAccessPath(path, validateHasBeenSet);
            _deleted.SetAccessPath(path, validateHasBeenSet);
            _approvedBy.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
