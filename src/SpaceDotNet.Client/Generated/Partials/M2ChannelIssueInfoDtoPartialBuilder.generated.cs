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

namespace SpaceDotNet.Client.M2ChannelIssueInfoDtoPartialBuilder
{
    public static class M2ChannelIssueInfoDtoPartialExtensions
    {
        public static Partial<M2ChannelIssueInfoDto> WithProjectKey(this Partial<M2ChannelIssueInfoDto> it)
            => it.AddFieldName("projectKey");
        
        public static Partial<M2ChannelIssueInfoDto> WithProjectKey(this Partial<M2ChannelIssueInfoDto> it, Func<Partial<ProjectKeyDto>, Partial<ProjectKeyDto>> partialBuilder)
            => it.AddFieldName("projectKey", partialBuilder(new Partial<ProjectKeyDto>(it)));
        
        public static Partial<M2ChannelIssueInfoDto> WithIssue(this Partial<M2ChannelIssueInfoDto> it)
            => it.AddFieldName("issue");
        
        public static Partial<M2ChannelIssueInfoDto> WithIssue(this Partial<M2ChannelIssueInfoDto> it, Func<Partial<IssueDto>, Partial<IssueDto>> partialBuilder)
            => it.AddFieldName("issue", partialBuilder(new Partial<IssueDto>(it)));
        
        public static Partial<M2ChannelIssueInfoDto> WithNotificationDefaults(this Partial<M2ChannelIssueInfoDto> it)
            => it.AddFieldName("notificationDefaults");
        
        public static Partial<M2ChannelIssueInfoDto> WithNotificationDefaults(this Partial<M2ChannelIssueInfoDto> it, Func<Partial<ChannelSpecificDefaultsDto>, Partial<ChannelSpecificDefaultsDto>> partialBuilder)
            => it.AddFieldName("notificationDefaults", partialBuilder(new Partial<ChannelSpecificDefaultsDto>(it)));
        
    }
    
}
