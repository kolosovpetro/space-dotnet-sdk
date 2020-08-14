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
    public sealed class M2AbsenceItemUpdatedContentDto
         : M2ItemContentDetailsDto, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "M2AbsenceItemUpdatedContent";
        
        public M2AbsenceItemUpdatedContentDto() { }
        
        public M2AbsenceItemUpdatedContentDto(AbsenceRecordDto absence, Modification<AbsenceReasonRecordDto>? reason = null, Modification<string>? description = null, Modification<SpaceDate>? since = null, Modification<SpaceDate>? till = null, TDMemberProfileDto? by = null)
        {
            Absence = absence;
            Reason = reason;
            Description = description;
            Since = since;
            Till = till;
            By = by;
        }
        
        private PropertyValue<AbsenceRecordDto> _absence = new PropertyValue<AbsenceRecordDto>(nameof(M2AbsenceItemUpdatedContentDto), nameof(Absence));
        
        [Required]
        [JsonPropertyName("absence")]
        public AbsenceRecordDto Absence
        {
            get { return _absence.GetValue(); }
            set { _absence.SetValue(value); }
        }
    
        private PropertyValue<Modification<AbsenceReasonRecordDto>?> _reason = new PropertyValue<Modification<AbsenceReasonRecordDto>?>(nameof(M2AbsenceItemUpdatedContentDto), nameof(Reason));
        
        [JsonPropertyName("reason")]
        public Modification<AbsenceReasonRecordDto>? Reason
        {
            get { return _reason.GetValue(); }
            set { _reason.SetValue(value); }
        }
    
        private PropertyValue<Modification<string>?> _description = new PropertyValue<Modification<string>?>(nameof(M2AbsenceItemUpdatedContentDto), nameof(Description));
        
        [JsonPropertyName("description")]
        public Modification<string>? Description
        {
            get { return _description.GetValue(); }
            set { _description.SetValue(value); }
        }
    
        private PropertyValue<Modification<SpaceDate>?> _since = new PropertyValue<Modification<SpaceDate>?>(nameof(M2AbsenceItemUpdatedContentDto), nameof(Since));
        
        [JsonPropertyName("since")]
        public Modification<SpaceDate>? Since
        {
            get { return _since.GetValue(); }
            set { _since.SetValue(value); }
        }
    
        private PropertyValue<Modification<SpaceDate>?> _till = new PropertyValue<Modification<SpaceDate>?>(nameof(M2AbsenceItemUpdatedContentDto), nameof(Till));
        
        [JsonPropertyName("till")]
        public Modification<SpaceDate>? Till
        {
            get { return _till.GetValue(); }
            set { _till.SetValue(value); }
        }
    
        private PropertyValue<TDMemberProfileDto?> _by = new PropertyValue<TDMemberProfileDto?>(nameof(M2AbsenceItemUpdatedContentDto), nameof(By));
        
        [JsonPropertyName("by")]
        public TDMemberProfileDto? By
        {
            get { return _by.GetValue(); }
            set { _by.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _absence.SetAccessPath(path, validateHasBeenSet);
            _reason.SetAccessPath(path, validateHasBeenSet);
            _description.SetAccessPath(path, validateHasBeenSet);
            _since.SetAccessPath(path, validateHasBeenSet);
            _till.SetAccessPath(path, validateHasBeenSet);
            _by.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
