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
    public sealed class SubjectResponsibilitiesTableDto
         : IPropagatePropertyAccessPath
    {
        public SubjectResponsibilitiesTableDto() { }
        
        public SubjectResponsibilitiesTableDto(string subjectId, List<string> reusedInProjects, List<ResponsibilityRecordDto> responsibilityRecords, string? name = null)
        {
            SubjectId = subjectId;
            Name = name;
            ReusedInProjects = reusedInProjects;
            ResponsibilityRecords = responsibilityRecords;
        }
        
        private PropertyValue<string> _subjectId = new PropertyValue<string>(nameof(SubjectResponsibilitiesTableDto), nameof(SubjectId));
        
        [Required]
        [JsonPropertyName("subjectId")]
        public string SubjectId
        {
            get { return _subjectId.GetValue(); }
            set { _subjectId.SetValue(value); }
        }
    
        private PropertyValue<string?> _name = new PropertyValue<string?>(nameof(SubjectResponsibilitiesTableDto), nameof(Name));
        
        [JsonPropertyName("name")]
        public string? Name
        {
            get { return _name.GetValue(); }
            set { _name.SetValue(value); }
        }
    
        private PropertyValue<List<string>> _reusedInProjects = new PropertyValue<List<string>>(nameof(SubjectResponsibilitiesTableDto), nameof(ReusedInProjects));
        
        [Required]
        [JsonPropertyName("reusedInProjects")]
        public List<string> ReusedInProjects
        {
            get { return _reusedInProjects.GetValue(); }
            set { _reusedInProjects.SetValue(value); }
        }
    
        private PropertyValue<List<ResponsibilityRecordDto>> _responsibilityRecords = new PropertyValue<List<ResponsibilityRecordDto>>(nameof(SubjectResponsibilitiesTableDto), nameof(ResponsibilityRecords));
        
        [Required]
        [JsonPropertyName("responsibilityRecords")]
        public List<ResponsibilityRecordDto> ResponsibilityRecords
        {
            get { return _responsibilityRecords.GetValue(); }
            set { _responsibilityRecords.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _subjectId.SetAccessPath(path, validateHasBeenSet);
            _name.SetAccessPath(path, validateHasBeenSet);
            _reusedInProjects.SetAccessPath(path, validateHasBeenSet);
            _responsibilityRecords.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
