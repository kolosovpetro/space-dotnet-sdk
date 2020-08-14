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
    public sealed class CAutomationTaskPrincipalDetailsDto
         : CPrincipalDetailsDto, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "CAutomationTaskPrincipalDetails";
        
        public CAutomationTaskPrincipalDetailsDto() { }
        
        public CAutomationTaskPrincipalDetailsDto(PRProjectDto project, string name, string id)
        {
            Project = project;
            Name = name;
            Id = id;
        }
        
        private PropertyValue<PRProjectDto> _project = new PropertyValue<PRProjectDto>(nameof(CAutomationTaskPrincipalDetailsDto), nameof(Project));
        
        [Required]
        [JsonPropertyName("project")]
        public PRProjectDto Project
        {
            get { return _project.GetValue(); }
            set { _project.SetValue(value); }
        }
    
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(CAutomationTaskPrincipalDetailsDto), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get { return _name.GetValue(); }
            set { _name.SetValue(value); }
        }
    
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(CAutomationTaskPrincipalDetailsDto), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _project.SetAccessPath(path, validateHasBeenSet);
            _name.SetAccessPath(path, validateHasBeenSet);
            _id.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
