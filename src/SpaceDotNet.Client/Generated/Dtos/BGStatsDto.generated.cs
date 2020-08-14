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
    public sealed class BGStatsDto
         : IPropagatePropertyAccessPath
    {
        public BGStatsDto() { }
        
        public BGStatsDto(int totalBlogs, List<Pair<TDTeamDto, int>> teams, List<Pair<TDLocationDto, int>> locations, List<Pair<PRProjectDto, int>>? projects = null)
        {
            TotalBlogs = totalBlogs;
            Teams = teams;
            Projects = projects;
            Locations = locations;
        }
        
        private PropertyValue<int> _totalBlogs = new PropertyValue<int>(nameof(BGStatsDto), nameof(TotalBlogs));
        
        [Required]
        [JsonPropertyName("totalBlogs")]
        public int TotalBlogs
        {
            get { return _totalBlogs.GetValue(); }
            set { _totalBlogs.SetValue(value); }
        }
    
        private PropertyValue<List<Pair<TDTeamDto, int>>> _teams = new PropertyValue<List<Pair<TDTeamDto, int>>>(nameof(BGStatsDto), nameof(Teams));
        
        [Required]
        [JsonPropertyName("teams")]
        public List<Pair<TDTeamDto, int>> Teams
        {
            get { return _teams.GetValue(); }
            set { _teams.SetValue(value); }
        }
    
        private PropertyValue<List<Pair<PRProjectDto, int>>?> _projects = new PropertyValue<List<Pair<PRProjectDto, int>>?>(nameof(BGStatsDto), nameof(Projects));
        
        [JsonPropertyName("projects")]
        public List<Pair<PRProjectDto, int>>? Projects
        {
            get { return _projects.GetValue(); }
            set { _projects.SetValue(value); }
        }
    
        private PropertyValue<List<Pair<TDLocationDto, int>>> _locations = new PropertyValue<List<Pair<TDLocationDto, int>>>(nameof(BGStatsDto), nameof(Locations));
        
        [Required]
        [JsonPropertyName("locations")]
        public List<Pair<TDLocationDto, int>> Locations
        {
            get { return _locations.GetValue(); }
            set { _locations.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _totalBlogs.SetAccessPath(path, validateHasBeenSet);
            _teams.SetAccessPath(path, validateHasBeenSet);
            _projects.SetAccessPath(path, validateHasBeenSet);
            _locations.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
