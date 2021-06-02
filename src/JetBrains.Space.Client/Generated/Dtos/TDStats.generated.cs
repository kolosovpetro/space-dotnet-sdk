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
    public sealed class TDStats
         : IPropagatePropertyAccessPath
    {
        public TDStats() { }
        
        public TDStats(int totalMembers, List<Pair<TDTeam, int>> teams, List<Pair<TDRole, int>> roles, List<Pair<TDLocation, int>> locations)
        {
            TotalMembers = totalMembers;
            Teams = teams;
            Roles = roles;
            Locations = locations;
        }
        
        private PropertyValue<int> _totalMembers = new PropertyValue<int>(nameof(TDStats), nameof(TotalMembers));
        
        [Required]
        [JsonPropertyName("totalMembers")]
        public int TotalMembers
        {
            get => _totalMembers.GetValue();
            set => _totalMembers.SetValue(value);
        }
    
        private PropertyValue<List<Pair<TDTeam, int>>> _teams = new PropertyValue<List<Pair<TDTeam, int>>>(nameof(TDStats), nameof(Teams), new List<Pair<TDTeam, int>>());
        
        [Required]
        [JsonPropertyName("teams")]
        public List<Pair<TDTeam, int>> Teams
        {
            get => _teams.GetValue();
            set => _teams.SetValue(value);
        }
    
        private PropertyValue<List<Pair<TDRole, int>>> _roles = new PropertyValue<List<Pair<TDRole, int>>>(nameof(TDStats), nameof(Roles), new List<Pair<TDRole, int>>());
        
        [Required]
        [JsonPropertyName("roles")]
        public List<Pair<TDRole, int>> Roles
        {
            get => _roles.GetValue();
            set => _roles.SetValue(value);
        }
    
        private PropertyValue<List<Pair<TDLocation, int>>> _locations = new PropertyValue<List<Pair<TDLocation, int>>>(nameof(TDStats), nameof(Locations), new List<Pair<TDLocation, int>>());
        
        [Required]
        [JsonPropertyName("locations")]
        public List<Pair<TDLocation, int>> Locations
        {
            get => _locations.GetValue();
            set => _locations.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _totalMembers.SetAccessPath(path, validateHasBeenSet);
            _teams.SetAccessPath(path, validateHasBeenSet);
            _roles.SetAccessPath(path, validateHasBeenSet);
            _locations.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
