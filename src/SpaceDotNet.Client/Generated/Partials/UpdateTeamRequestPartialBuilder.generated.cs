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

namespace SpaceDotNet.Client.UpdateTeamRequestPartialBuilder
{
    public static class UpdateTeamRequestPartialExtensions
    {
        public static Partial<UpdateTeamRequest> WithTeamNameRaw(this Partial<UpdateTeamRequest> it)
            => it.AddFieldName("teamNameRaw");
        
        public static Partial<UpdateTeamRequest> WithTeamDescription(this Partial<UpdateTeamRequest> it)
            => it.AddFieldName("teamDescription");
        
        public static Partial<UpdateTeamRequest> WithTeamEmails(this Partial<UpdateTeamRequest> it)
            => it.AddFieldName("teamEmails");
        
        public static Partial<UpdateTeamRequest> WithParentId(this Partial<UpdateTeamRequest> it)
            => it.AddFieldName("parentId");
        
        public static Partial<UpdateTeamRequest> WithCustomFieldValues(this Partial<UpdateTeamRequest> it)
            => it.AddFieldName("customFieldValues");
        
        public static Partial<UpdateTeamRequest> WithCustomFieldValues(this Partial<UpdateTeamRequest> it, Func<Partial<CustomFieldValueDto>, Partial<CustomFieldValueDto>> partialBuilder)
            => it.AddFieldName("customFieldValues", partialBuilder(new Partial<CustomFieldValueDto>(it)));
        
    }
    
}