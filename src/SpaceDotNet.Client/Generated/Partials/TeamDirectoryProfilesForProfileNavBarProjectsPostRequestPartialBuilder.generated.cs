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

namespace SpaceDotNet.Client.TeamDirectoryProfilesForProfileNavBarProjectsPostRequestPartialBuilder
{
    public static class TeamDirectoryProfilesForProfileNavBarProjectsPostRequestPartialExtensions
    {
        public static Partial<TeamDirectoryProfilesForProfileNavBarProjectsPostRequest> WithProject(this Partial<TeamDirectoryProfilesForProfileNavBarProjectsPostRequest> it)
            => it.AddFieldName("project");
        
        public static Partial<TeamDirectoryProfilesForProfileNavBarProjectsPostRequest> WithProject(this Partial<TeamDirectoryProfilesForProfileNavBarProjectsPostRequest> it, Func<Partial<ProjectIdentifier>, Partial<ProjectIdentifier>> partialBuilder)
            => it.AddFieldName("project", partialBuilder(new Partial<ProjectIdentifier>(it)));
        
    }
    
}
