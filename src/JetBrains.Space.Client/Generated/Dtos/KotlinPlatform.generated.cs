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
    public sealed class KotlinPlatform
         : IPropagatePropertyAccessPath
    {
        public KotlinPlatform() { }
        
        public KotlinPlatform(string name, List<string> targets)
        {
            Name = name;
            Targets = targets;
        }
        
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(KotlinPlatform), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get => _name.GetValue();
            set => _name.SetValue(value);
        }
    
        private PropertyValue<List<string>> _targets = new PropertyValue<List<string>>(nameof(KotlinPlatform), nameof(Targets), new List<string>());
        
        [Required]
        [JsonPropertyName("targets")]
        public List<string> Targets
        {
            get => _targets.GetValue();
            set => _targets.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _name.SetAccessPath(path, validateHasBeenSet);
            _targets.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
