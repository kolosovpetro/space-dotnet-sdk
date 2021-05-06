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
    public sealed class GitDiffSize
         : IPropagatePropertyAccessPath
    {
        public GitDiffSize() { }
        
        public GitDiffSize(int added, int deleted)
        {
            Added = added;
            Deleted = deleted;
        }
        
        private PropertyValue<int> _added = new PropertyValue<int>(nameof(GitDiffSize), nameof(Added));
        
        [Required]
        [JsonPropertyName("added")]
        public int Added
        {
            get => _added.GetValue();
            set => _added.SetValue(value);
        }
    
        private PropertyValue<int> _deleted = new PropertyValue<int>(nameof(GitDiffSize), nameof(Deleted));
        
        [Required]
        [JsonPropertyName("deleted")]
        public int Deleted
        {
            get => _deleted.GetValue();
            set => _deleted.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _added.SetAccessPath(path, validateHasBeenSet);
            _deleted.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
