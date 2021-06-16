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
    public sealed class ProjectReposRecord
         : IPropagatePropertyAccessPath
    {
        public ProjectReposRecord() { }
        
        public ProjectReposRecord(string id, List<PRRepositoryInfo> repos)
        {
            Id = id;
            Repos = repos;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(ProjectReposRecord), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get => _id.GetValue();
            set => _id.SetValue(value);
        }
    
        private PropertyValue<List<PRRepositoryInfo>> _repos = new PropertyValue<List<PRRepositoryInfo>>(nameof(ProjectReposRecord), nameof(Repos), new List<PRRepositoryInfo>());
        
        [Required]
        [JsonPropertyName("repos")]
        public List<PRRepositoryInfo> Repos
        {
            get => _repos.GetValue();
            set => _repos.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _repos.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
