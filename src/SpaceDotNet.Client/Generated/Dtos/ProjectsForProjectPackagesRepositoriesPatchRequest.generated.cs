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
    public class ProjectsForProjectPackagesRepositoriesPatchRequest
         : IPropagatePropertyAccessPath
    {
        public ProjectsForProjectPackagesRepositoriesPatchRequest() { }
        
        public ProjectsForProjectPackagesRepositoriesPatchRequest(string id, string? name = null, string? description = null, bool? @public = null, ESPackageRepositorySettingsDto? settings = null)
        {
            Id = id;
            Name = name;
            Description = description;
            Public = @public;
            Settings = settings;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(ProjectsForProjectPackagesRepositoriesPatchRequest), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<string?> _name = new PropertyValue<string?>(nameof(ProjectsForProjectPackagesRepositoriesPatchRequest), nameof(Name));
        
        [JsonPropertyName("name")]
        public string? Name
        {
            get { return _name.GetValue(); }
            set { _name.SetValue(value); }
        }
    
        private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(ProjectsForProjectPackagesRepositoriesPatchRequest), nameof(Description));
        
        [JsonPropertyName("description")]
        public string? Description
        {
            get { return _description.GetValue(); }
            set { _description.SetValue(value); }
        }
    
        private PropertyValue<bool?> _public = new PropertyValue<bool?>(nameof(ProjectsForProjectPackagesRepositoriesPatchRequest), nameof(Public));
        
        [JsonPropertyName("public")]
        public bool? Public
        {
            get { return _public.GetValue(); }
            set { _public.SetValue(value); }
        }
    
        private PropertyValue<ESPackageRepositorySettingsDto?> _settings = new PropertyValue<ESPackageRepositorySettingsDto?>(nameof(ProjectsForProjectPackagesRepositoriesPatchRequest), nameof(Settings));
        
        [JsonPropertyName("settings")]
        public ESPackageRepositorySettingsDto? Settings
        {
            get { return _settings.GetValue(); }
            set { _settings.SetValue(value); }
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _name.SetAccessPath(path, validateHasBeenSet);
            _description.SetAccessPath(path, validateHasBeenSet);
            _public.SetAccessPath(path, validateHasBeenSet);
            _settings.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}