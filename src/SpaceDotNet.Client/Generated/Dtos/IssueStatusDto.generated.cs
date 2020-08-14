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
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public sealed class IssueStatusDto
         : IPropagatePropertyAccessPath
    {
        public IssueStatusDto() { }
        
        public IssueStatusDto(string id, bool archived, string name, bool resolved, string color)
        {
            Id = id;
            Archived = archived;
            Name = name;
            Resolved = resolved;
            Color = color;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(IssueStatusDto), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(IssueStatusDto), nameof(Archived));
        
        [Required]
        [JsonPropertyName("archived")]
        public bool Archived
        {
            get { return _archived.GetValue(); }
            set { _archived.SetValue(value); }
        }
    
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(IssueStatusDto), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get { return _name.GetValue(); }
            set { _name.SetValue(value); }
        }
    
        private PropertyValue<bool> _resolved = new PropertyValue<bool>(nameof(IssueStatusDto), nameof(Resolved));
        
        [Required]
        [JsonPropertyName("resolved")]
        public bool Resolved
        {
            get { return _resolved.GetValue(); }
            set { _resolved.SetValue(value); }
        }
    
        private PropertyValue<string> _color = new PropertyValue<string>(nameof(IssueStatusDto), nameof(Color));
        
        [Required]
        [JsonPropertyName("color")]
        public string Color
        {
            get { return _color.GetValue(); }
            set { _color.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _archived.SetAccessPath(path, validateHasBeenSet);
            _name.SetAccessPath(path, validateHasBeenSet);
            _resolved.SetAccessPath(path, validateHasBeenSet);
            _color.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
