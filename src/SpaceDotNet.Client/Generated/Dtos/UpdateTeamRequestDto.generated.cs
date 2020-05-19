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

namespace SpaceDotNet.Client
{
    public class UpdateTeamRequestDto
    {
        [JsonPropertyName("teamNameRaw")]
        public string? TeamNameRaw { get; set; }        
        
        [JsonPropertyName("teamDescription")]
        public string? TeamDescription { get; set; }        
        
        [JsonPropertyName("teamEmails")]
        public List<string>? TeamEmails { get; set; }        
        
        [JsonPropertyName("parentId")]
        public string? ParentId { get; set; }        
        
        [JsonPropertyName("customFieldValues")]
        public List<CustomFieldValueDto>? CustomFieldValues { get; set; }        
        
    }
    
}