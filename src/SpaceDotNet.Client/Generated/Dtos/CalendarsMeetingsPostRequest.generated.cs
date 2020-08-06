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
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public class CalendarsMeetingsPostRequest
         : IPropagatePropertyAccessPath
    {
        public CalendarsMeetingsPostRequest() { }
        
        public CalendarsMeetingsPostRequest(string summary, CalendarEventSpecDto occurrenceRule, List<string>? locations = null, List<string>? profiles = null, List<string>? externalParticipants = null, List<string>? teams = null, MeetingVisibility? visibility = null, MeetingModificationPreference? modificationPreference = null, MeetingJoiningPreference? joiningPreference = null, bool notifyOnExport = true, string? description = null, string? organizer = null)
        {
            Summary = summary;
            Description = description;
            OccurrenceRule = occurrenceRule;
            Locations = (locations ?? new List<string>());
            Profiles = (profiles ?? new List<string>());
            ExternalParticipants = (externalParticipants ?? new List<string>());
            Teams = (teams ?? new List<string>());
            Visibility = (visibility ?? MeetingVisibility.EVERYONE);
            ModificationPreference = (modificationPreference ?? MeetingModificationPreference.PARTICIPANTS);
            JoiningPreference = (joiningPreference ?? MeetingJoiningPreference.NOBODY);
            NotifyOnExport = notifyOnExport;
            Organizer = organizer;
        }
        
        private PropertyValue<string> _summary = new PropertyValue<string>(nameof(CalendarsMeetingsPostRequest), nameof(Summary));
        
        [Required]
        [JsonPropertyName("summary")]
        public string Summary
        {
            get { return _summary.GetValue(); }
            set { _summary.SetValue(value); }
        }
    
        private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(CalendarsMeetingsPostRequest), nameof(Description));
        
        [JsonPropertyName("description")]
        public string? Description
        {
            get { return _description.GetValue(); }
            set { _description.SetValue(value); }
        }
    
        private PropertyValue<CalendarEventSpecDto> _occurrenceRule = new PropertyValue<CalendarEventSpecDto>(nameof(CalendarsMeetingsPostRequest), nameof(OccurrenceRule));
        
        [Required]
        [JsonPropertyName("occurrenceRule")]
        public CalendarEventSpecDto OccurrenceRule
        {
            get { return _occurrenceRule.GetValue(); }
            set { _occurrenceRule.SetValue(value); }
        }
    
        private PropertyValue<List<string>> _locations = new PropertyValue<List<string>>(nameof(CalendarsMeetingsPostRequest), nameof(Locations));
        
        [JsonPropertyName("locations")]
        public List<string> Locations
        {
            get { return _locations.GetValue(); }
            set { _locations.SetValue(value); }
        }
    
        private PropertyValue<List<string>> _profiles = new PropertyValue<List<string>>(nameof(CalendarsMeetingsPostRequest), nameof(Profiles));
        
        [JsonPropertyName("profiles")]
        public List<string> Profiles
        {
            get { return _profiles.GetValue(); }
            set { _profiles.SetValue(value); }
        }
    
        private PropertyValue<List<string>> _externalParticipants = new PropertyValue<List<string>>(nameof(CalendarsMeetingsPostRequest), nameof(ExternalParticipants));
        
        [JsonPropertyName("externalParticipants")]
        public List<string> ExternalParticipants
        {
            get { return _externalParticipants.GetValue(); }
            set { _externalParticipants.SetValue(value); }
        }
    
        private PropertyValue<List<string>> _teams = new PropertyValue<List<string>>(nameof(CalendarsMeetingsPostRequest), nameof(Teams));
        
        [JsonPropertyName("teams")]
        public List<string> Teams
        {
            get { return _teams.GetValue(); }
            set { _teams.SetValue(value); }
        }
    
        private PropertyValue<MeetingVisibility> _visibility = new PropertyValue<MeetingVisibility>(nameof(CalendarsMeetingsPostRequest), nameof(Visibility));
        
        [JsonPropertyName("visibility")]
        public MeetingVisibility Visibility
        {
            get { return _visibility.GetValue(); }
            set { _visibility.SetValue(value); }
        }
    
        private PropertyValue<MeetingModificationPreference> _modificationPreference = new PropertyValue<MeetingModificationPreference>(nameof(CalendarsMeetingsPostRequest), nameof(ModificationPreference));
        
        [JsonPropertyName("modificationPreference")]
        public MeetingModificationPreference ModificationPreference
        {
            get { return _modificationPreference.GetValue(); }
            set { _modificationPreference.SetValue(value); }
        }
    
        private PropertyValue<MeetingJoiningPreference> _joiningPreference = new PropertyValue<MeetingJoiningPreference>(nameof(CalendarsMeetingsPostRequest), nameof(JoiningPreference));
        
        [JsonPropertyName("joiningPreference")]
        public MeetingJoiningPreference JoiningPreference
        {
            get { return _joiningPreference.GetValue(); }
            set { _joiningPreference.SetValue(value); }
        }
    
        private PropertyValue<bool> _notifyOnExport = new PropertyValue<bool>(nameof(CalendarsMeetingsPostRequest), nameof(NotifyOnExport));
        
        [JsonPropertyName("notifyOnExport")]
        public bool NotifyOnExport
        {
            get { return _notifyOnExport.GetValue(); }
            set { _notifyOnExport.SetValue(value); }
        }
    
        private PropertyValue<string?> _organizer = new PropertyValue<string?>(nameof(CalendarsMeetingsPostRequest), nameof(Organizer));
        
        [JsonPropertyName("organizer")]
        public string? Organizer
        {
            get { return _organizer.GetValue(); }
            set { _organizer.SetValue(value); }
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _summary.SetAccessPath(path, validateHasBeenSet);
            _description.SetAccessPath(path, validateHasBeenSet);
            _occurrenceRule.SetAccessPath(path, validateHasBeenSet);
            _locations.SetAccessPath(path, validateHasBeenSet);
            _profiles.SetAccessPath(path, validateHasBeenSet);
            _externalParticipants.SetAccessPath(path, validateHasBeenSet);
            _teams.SetAccessPath(path, validateHasBeenSet);
            _visibility.SetAccessPath(path, validateHasBeenSet);
            _modificationPreference.SetAccessPath(path, validateHasBeenSet);
            _joiningPreference.SetAccessPath(path, validateHasBeenSet);
            _notifyOnExport.SetAccessPath(path, validateHasBeenSet);
            _organizer.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}