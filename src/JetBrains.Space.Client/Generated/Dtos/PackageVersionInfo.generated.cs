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
    public sealed class PackageVersionInfo
         : IPropagatePropertyAccessPath
    {
        public PackageVersionInfo() { }
        
        public PackageVersionInfo(PackageType type, string repository, string name, string version, List<string>? tags = null)
        {
            Type = type;
            Repository = repository;
            Name = name;
            Version = version;
            Tags = tags;
        }
        
        private PropertyValue<PackageType> _type = new PropertyValue<PackageType>(nameof(PackageVersionInfo), nameof(Type));
        
        [Required]
        [JsonPropertyName("type")]
        public PackageType Type
        {
            get => _type.GetValue();
            set => _type.SetValue(value);
        }
    
        private PropertyValue<string> _repository = new PropertyValue<string>(nameof(PackageVersionInfo), nameof(Repository));
        
        [Required]
        [JsonPropertyName("repository")]
        public string Repository
        {
            get => _repository.GetValue();
            set => _repository.SetValue(value);
        }
    
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(PackageVersionInfo), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get => _name.GetValue();
            set => _name.SetValue(value);
        }
    
        private PropertyValue<string> _version = new PropertyValue<string>(nameof(PackageVersionInfo), nameof(Version));
        
        [Required]
        [JsonPropertyName("version")]
        public string Version
        {
            get => _version.GetValue();
            set => _version.SetValue(value);
        }
    
        private PropertyValue<List<string>?> _tags = new PropertyValue<List<string>?>(nameof(PackageVersionInfo), nameof(Tags));
        
        [JsonPropertyName("tags")]
        public List<string>? Tags
        {
            get => _tags.GetValue();
            set => _tags.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _type.SetAccessPath(path, validateHasBeenSet);
            _repository.SetAccessPath(path, validateHasBeenSet);
            _name.SetAccessPath(path, validateHasBeenSet);
            _version.SetAccessPath(path, validateHasBeenSet);
            _tags.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
