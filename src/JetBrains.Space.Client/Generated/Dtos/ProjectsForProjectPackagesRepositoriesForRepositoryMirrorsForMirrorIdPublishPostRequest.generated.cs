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
    public class ProjectsForProjectPackagesRepositoriesForRepositoryMirrorsForMirrorIdPublishPostRequest
         : IPropagatePropertyAccessPath
    {
        public ProjectsForProjectPackagesRepositoriesForRepositoryMirrorsForMirrorIdPublishPostRequest() { }
        
        public ProjectsForProjectPackagesRepositoriesForRepositoryMirrorsForMirrorIdPublishPostRequest(string packageName, string packageVersion)
        {
            PackageName = packageName;
            PackageVersion = packageVersion;
        }
        
        private PropertyValue<string> _packageName = new PropertyValue<string>(nameof(ProjectsForProjectPackagesRepositoriesForRepositoryMirrorsForMirrorIdPublishPostRequest), nameof(PackageName));
        
        [Required]
        [JsonPropertyName("packageName")]
        public string PackageName
        {
            get => _packageName.GetValue();
            set => _packageName.SetValue(value);
        }
    
        private PropertyValue<string> _packageVersion = new PropertyValue<string>(nameof(ProjectsForProjectPackagesRepositoriesForRepositoryMirrorsForMirrorIdPublishPostRequest), nameof(PackageVersion));
        
        [Required]
        [JsonPropertyName("packageVersion")]
        public string PackageVersion
        {
            get => _packageVersion.GetValue();
            set => _packageVersion.SetValue(value);
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _packageName.SetAccessPath(path, validateHasBeenSet);
            _packageVersion.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
