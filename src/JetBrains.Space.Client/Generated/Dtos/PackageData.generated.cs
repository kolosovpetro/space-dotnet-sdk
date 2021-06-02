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
    public sealed class PackageData
         : IPropagatePropertyAccessPath
    {
        public PackageData() { }
        
        public PackageData(PackageType type, string repository, string name, long versions, long updated, string lastVersion)
        {
            Type = type;
            Repository = repository;
            Name = name;
            Versions = versions;
            Updated = updated;
            LastVersion = lastVersion;
        }
        
        private PropertyValue<PackageType> _type = new PropertyValue<PackageType>(nameof(PackageData), nameof(Type));
        
        [Required]
        [JsonPropertyName("type")]
        public PackageType Type
        {
            get => _type.GetValue();
            set => _type.SetValue(value);
        }
    
        private PropertyValue<string> _repository = new PropertyValue<string>(nameof(PackageData), nameof(Repository));
        
        [Required]
        [JsonPropertyName("repository")]
        public string Repository
        {
            get => _repository.GetValue();
            set => _repository.SetValue(value);
        }
    
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(PackageData), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get => _name.GetValue();
            set => _name.SetValue(value);
        }
    
        private PropertyValue<long> _versions = new PropertyValue<long>(nameof(PackageData), nameof(Versions));
        
        [Required]
        [JsonPropertyName("versions")]
        public long Versions
        {
            get => _versions.GetValue();
            set => _versions.SetValue(value);
        }
    
        private PropertyValue<long> _updated = new PropertyValue<long>(nameof(PackageData), nameof(Updated));
        
        [Required]
        [JsonPropertyName("updated")]
        public long Updated
        {
            get => _updated.GetValue();
            set => _updated.SetValue(value);
        }
    
        private PropertyValue<string> _lastVersion = new PropertyValue<string>(nameof(PackageData), nameof(LastVersion));
        
        [Required]
        [JsonPropertyName("lastVersion")]
        public string LastVersion
        {
            get => _lastVersion.GetValue();
            set => _lastVersion.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _type.SetAccessPath(path, validateHasBeenSet);
            _repository.SetAccessPath(path, validateHasBeenSet);
            _name.SetAccessPath(path, validateHasBeenSet);
            _versions.SetAccessPath(path, validateHasBeenSet);
            _updated.SetAccessPath(path, validateHasBeenSet);
            _lastVersion.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
