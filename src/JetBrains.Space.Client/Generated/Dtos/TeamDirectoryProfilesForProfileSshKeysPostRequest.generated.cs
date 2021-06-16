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
    public class TeamDirectoryProfilesForProfileSshKeysPostRequest
         : IPropagatePropertyAccessPath
    {
        public TeamDirectoryProfilesForProfileSshKeysPostRequest() { }
        
        public TeamDirectoryProfilesForProfileSshKeysPostRequest(string key, string? comment = null)
        {
            Key = key;
            Comment = (comment ?? string.Empty);
        }
        
        private PropertyValue<string> _key = new PropertyValue<string>(nameof(TeamDirectoryProfilesForProfileSshKeysPostRequest), nameof(Key));
        
        [Required]
        [JsonPropertyName("key")]
        public string Key
        {
            get => _key.GetValue();
            set => _key.SetValue(value);
        }
    
        private PropertyValue<string> _comment = new PropertyValue<string>(nameof(TeamDirectoryProfilesForProfileSshKeysPostRequest), nameof(Comment), string.Empty);
        
        [JsonPropertyName("comment")]
        public string Comment
        {
            get => _comment.GetValue();
            set => _comment.SetValue(value);
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _key.SetAccessPath(path, validateHasBeenSet);
            _comment.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
