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
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client.SubjectResponsibilitiesTableExtensions
{
    public static class SubjectResponsibilitiesTableDtoPartialExtensions
    {
        public static Partial<SubjectResponsibilitiesTableDto> WithSubjectId(this Partial<SubjectResponsibilitiesTableDto> it)
            => it.AddFieldName("subjectId");
        
        public static Partial<SubjectResponsibilitiesTableDto> WithName(this Partial<SubjectResponsibilitiesTableDto> it)
            => it.AddFieldName("name");
        
        public static Partial<SubjectResponsibilitiesTableDto> WithReusedInProjects(this Partial<SubjectResponsibilitiesTableDto> it)
            => it.AddFieldName("reusedInProjects");
        
        public static Partial<SubjectResponsibilitiesTableDto> WithResponsibilityRecords(this Partial<SubjectResponsibilitiesTableDto> it)
            => it.AddFieldName("responsibilityRecords");
        
        public static Partial<SubjectResponsibilitiesTableDto> WithResponsibilityRecords(this Partial<SubjectResponsibilitiesTableDto> it, Func<Partial<ResponsibilityRecordDto>, Partial<ResponsibilityRecordDto>> partialBuilder)
            => it.AddFieldName("responsibilityRecords", partialBuilder(new Partial<ResponsibilityRecordDto>()));
        
    }
    
}
