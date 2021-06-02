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
    public class ProjectsForProjectPackagesRepositoriesForRepositoryPatchRequest
         : IPropagatePropertyAccessPath
    {
        public ProjectsForProjectPackagesRepositoriesForRepositoryPatchRequest() { }
        
        public ProjectsForProjectPackagesRepositoriesForRepositoryPatchRequest(string? name = null, string? description = null, bool? @public = null, ESPackageRepositorySettings? settings = null)
        {
            Name = name;
            Description = description;
            IsPublic = @public;
            Settings = settings;
        }
        
        private PropertyValue<string?> _name = new PropertyValue<string?>(nameof(ProjectsForProjectPackagesRepositoriesForRepositoryPatchRequest), nameof(Name));
        
        [JsonPropertyName("name")]
        public string? Name
        {
            get => _name.GetValue();
            set => _name.SetValue(value);
        }
    
        private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(ProjectsForProjectPackagesRepositoriesForRepositoryPatchRequest), nameof(Description));
        
        [JsonPropertyName("description")]
        public string? Description
        {
            get => _description.GetValue();
            set => _description.SetValue(value);
        }
    
        private PropertyValue<bool?> _public = new PropertyValue<bool?>(nameof(ProjectsForProjectPackagesRepositoriesForRepositoryPatchRequest), nameof(IsPublic));
        
        [JsonPropertyName("public")]
        public bool? IsPublic
        {
            get => _public.GetValue();
            set => _public.SetValue(value);
        }
    
        private PropertyValue<ESPackageRepositorySettings?> _settings = new PropertyValue<ESPackageRepositorySettings?>(nameof(ProjectsForProjectPackagesRepositoriesForRepositoryPatchRequest), nameof(Settings));
        
        [JsonPropertyName("settings")]
        public ESPackageRepositorySettings? Settings
        {
            get => _settings.GetValue();
            set => _settings.SetValue(value);
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _name.SetAccessPath(path, validateHasBeenSet);
            _description.SetAccessPath(path, validateHasBeenSet);
            _public.SetAccessPath(path, validateHasBeenSet);
            _settings.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
