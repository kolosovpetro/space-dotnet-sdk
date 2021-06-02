// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS1591
#pragma warning disable CS0108
#pragma warning disable 618

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client.PRProjectPartialBuilder
{
    public static class PRProjectPartialExtensions
    {
        public static Partial<PRProject> WithId(this Partial<PRProject> it)
            => it.AddFieldName("id");
        
        public static Partial<PRProject> WithKey(this Partial<PRProject> it)
            => it.AddFieldName("key");
        
        public static Partial<PRProject> WithKey(this Partial<PRProject> it, Func<Partial<ProjectKey>, Partial<ProjectKey>> partialBuilder)
            => it.AddFieldName("key", partialBuilder(new Partial<ProjectKey>(it)));
        
        public static Partial<PRProject> WithName(this Partial<PRProject> it)
            => it.AddFieldName("name");
        
        public static Partial<PRProject> WithIsPrivate(this Partial<PRProject> it)
            => it.AddFieldName("private");
        
        public static Partial<PRProject> WithDescription(this Partial<PRProject> it)
            => it.AddFieldName("description");
        
        public static Partial<PRProject> WithIcon(this Partial<PRProject> it)
            => it.AddFieldName("icon");
        
        public static Partial<PRProject> WithLatestRepositoryActivity(this Partial<PRProject> it)
            => it.AddFieldName("latestRepositoryActivity");
        
        public static Partial<PRProject> WithIsArchived(this Partial<PRProject> it)
            => it.AddFieldName("archived");
        
        public static Partial<PRProject> WithAdminProfiles(this Partial<PRProject> it)
            => it.AddFieldName("adminProfiles");
        
        public static Partial<PRProject> WithAdminProfiles(this Partial<PRProject> it, Func<Partial<TDMemberProfile>, Partial<TDMemberProfile>> partialBuilder)
            => it.AddFieldName("adminProfiles", partialBuilder(new Partial<TDMemberProfile>(it)));
        
        public static Partial<PRProject> WithAdminTeams(this Partial<PRProject> it)
            => it.AddFieldName("adminTeams");
        
        public static Partial<PRProject> WithAdminTeams(this Partial<PRProject> it, Func<Partial<TDTeam>, Partial<TDTeam>> partialBuilder)
            => it.AddFieldName("adminTeams", partialBuilder(new Partial<TDTeam>(it)));
        
        public static Partial<PRProject> WithBoards(this Partial<PRProject> it)
            => it.AddFieldName("boards");
        
        public static Partial<PRProject> WithBoards(this Partial<PRProject> it, Func<Partial<BoardRecord>, Partial<BoardRecord>> partialBuilder)
            => it.AddFieldName("boards", partialBuilder(new Partial<BoardRecord>(it)));
        
        public static Partial<PRProject> WithCollaboratorsProfiles(this Partial<PRProject> it)
            => it.AddFieldName("collaboratorsProfiles");
        
        public static Partial<PRProject> WithCollaboratorsProfiles(this Partial<PRProject> it, Func<Partial<TDMemberProfile>, Partial<TDMemberProfile>> partialBuilder)
            => it.AddFieldName("collaboratorsProfiles", partialBuilder(new Partial<TDMemberProfile>(it)));
        
        public static Partial<PRProject> WithCollaboratorsTeams(this Partial<PRProject> it)
            => it.AddFieldName("collaboratorsTeams");
        
        public static Partial<PRProject> WithCollaboratorsTeams(this Partial<PRProject> it, Func<Partial<TDTeam>, Partial<TDTeam>> partialBuilder)
            => it.AddFieldName("collaboratorsTeams", partialBuilder(new Partial<TDTeam>(it)));
        
        public static Partial<PRProject> WithMemberProfiles(this Partial<PRProject> it)
            => it.AddFieldName("memberProfiles");
        
        public static Partial<PRProject> WithMemberProfiles(this Partial<PRProject> it, Func<Partial<TDMemberProfile>, Partial<TDMemberProfile>> partialBuilder)
            => it.AddFieldName("memberProfiles", partialBuilder(new Partial<TDMemberProfile>(it)));
        
        public static Partial<PRProject> WithMemberTeams(this Partial<PRProject> it)
            => it.AddFieldName("memberTeams");
        
        public static Partial<PRProject> WithMemberTeams(this Partial<PRProject> it, Func<Partial<TDTeam>, Partial<TDTeam>> partialBuilder)
            => it.AddFieldName("memberTeams", partialBuilder(new Partial<TDTeam>(it)));
        
        public static Partial<PRProject> WithMembers(this Partial<PRProject> it)
            => it.AddFieldName("members");
        
        public static Partial<PRProject> WithMembers(this Partial<PRProject> it, Func<Partial<ProjectTeamMemberRecord>, Partial<ProjectTeamMemberRecord>> partialBuilder)
            => it.AddFieldName("members", partialBuilder(new Partial<ProjectTeamMemberRecord>(it)));
        
        public static Partial<PRProject> WithPackages(this Partial<PRProject> it)
            => it.AddFieldName("packages");
        
        public static Partial<PRProject> WithPackages(this Partial<PRProject> it, Func<Partial<ProjectPackageRepository>, Partial<ProjectPackageRepository>> partialBuilder)
            => it.AddFieldName("packages", partialBuilder(new Partial<ProjectPackageRepository>(it)));
        
        public static Partial<PRProject> WithRepos(this Partial<PRProject> it)
            => it.AddFieldName("repos");
        
        public static Partial<PRProject> WithRepos(this Partial<PRProject> it, Func<Partial<PRRepositoryInfo>, Partial<PRRepositoryInfo>> partialBuilder)
            => it.AddFieldName("repos", partialBuilder(new Partial<PRRepositoryInfo>(it)));
        
        public static Partial<PRProject> WithTags(this Partial<PRProject> it)
            => it.AddFieldName("tags");
        
        public static Partial<PRProject> WithTeam(this Partial<PRProject> it)
            => it.AddFieldName("team");
        
        public static Partial<PRProject> WithTeam(this Partial<PRProject> it, Func<Partial<TDTeam>, Partial<TDTeam>> partialBuilder)
            => it.AddFieldName("team", partialBuilder(new Partial<TDTeam>(it)));
        
        public static Partial<PRProject> WithTeams(this Partial<PRProject> it)
            => it.AddFieldName("teams");
        
        public static Partial<PRProject> WithTeams(this Partial<PRProject> it, Func<Partial<TDTeam>, Partial<TDTeam>> partialBuilder)
            => it.AddFieldName("teams", partialBuilder(new Partial<TDTeam>(it)));
        
        public static Partial<PRProject> WithTrackers(this Partial<PRProject> it)
            => it.AddFieldName("trackers");
        
        public static Partial<PRProject> WithTrackers(this Partial<PRProject> it, Func<Partial<ProjectIssueTrackerItem>, Partial<ProjectIssueTrackerItem>> partialBuilder)
            => it.AddFieldName("trackers", partialBuilder(new Partial<ProjectIssueTrackerItem>(it)));
        
        public static Partial<PRProject> WithType(this Partial<PRProject> it)
            => it.AddFieldName("type");
        
        public static Partial<PRProject> WithType(this Partial<PRProject> it, Func<Partial<ProjectTeamType>, Partial<ProjectTeamType>> partialBuilder)
            => it.AddFieldName("type", partialBuilder(new Partial<ProjectTeamType>(it)));
        
    }
    
}
