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

namespace SpaceDotNet.Client.CAutomationTaskPrincipalDetailsDtoPartialBuilder
{
    public static class CAutomationTaskPrincipalDetailsDtoPartialExtensions
    {
        public static Partial<CAutomationTaskPrincipalDetailsDto> WithProject(this Partial<CAutomationTaskPrincipalDetailsDto> it)
            => it.AddFieldName("project");
        
        public static Partial<CAutomationTaskPrincipalDetailsDto> WithProject(this Partial<CAutomationTaskPrincipalDetailsDto> it, Func<Partial<PRProjectDto>, Partial<PRProjectDto>> partialBuilder)
            => it.AddFieldName("project", partialBuilder(new Partial<PRProjectDto>(it)));
        
        public static Partial<CAutomationTaskPrincipalDetailsDto> WithName(this Partial<CAutomationTaskPrincipalDetailsDto> it)
            => it.AddFieldName("name");
        
        public static Partial<CAutomationTaskPrincipalDetailsDto> WithId(this Partial<CAutomationTaskPrincipalDetailsDto> it)
            => it.AddFieldName("id");
        
    }
    
}
