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
    public class ProjectsParamsDefaultBundlePostRequest
         : IPropagatePropertyAccessPath
    {
        public ProjectsParamsDefaultBundlePostRequest() { }
        
        public ProjectsParamsDefaultBundlePostRequest(ProjectIdentifier project, string key, string value)
        {
            Project = project;
            Key = key;
            Value = value;
        }
        
        private PropertyValue<ProjectIdentifier> _project = new PropertyValue<ProjectIdentifier>(nameof(ProjectsParamsDefaultBundlePostRequest), nameof(Project));
        
        [Required]
        [JsonPropertyName("project")]
        public ProjectIdentifier Project
        {
            get => _project.GetValue();
            set => _project.SetValue(value);
        }
    
        private PropertyValue<string> _key = new PropertyValue<string>(nameof(ProjectsParamsDefaultBundlePostRequest), nameof(Key));
        
        [Required]
        [JsonPropertyName("key")]
        public string Key
        {
            get => _key.GetValue();
            set => _key.SetValue(value);
        }
    
        private PropertyValue<string> _value = new PropertyValue<string>(nameof(ProjectsParamsDefaultBundlePostRequest), nameof(Value));
        
        [Required]
        [JsonPropertyName("value")]
        public string Value
        {
            get => _value.GetValue();
            set => _value.SetValue(value);
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _project.SetAccessPath(path, validateHasBeenSet);
            _key.SetAccessPath(path, validateHasBeenSet);
            _value.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
