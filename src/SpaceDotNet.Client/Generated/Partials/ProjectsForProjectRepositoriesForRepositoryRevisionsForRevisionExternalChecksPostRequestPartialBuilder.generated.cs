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

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client.ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionExternalChecksPostRequestPartialBuilder
{
    public static class ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionExternalChecksPostRequestPartialExtensions
    {
        public static Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionExternalChecksPostRequest> WithBranch(this Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionExternalChecksPostRequest> it)
            => it.AddFieldName("branch");
        
        public static Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionExternalChecksPostRequest> WithChanges(this Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionExternalChecksPostRequest> it)
            => it.AddFieldName("changes");
        
        public static Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionExternalChecksPostRequest> WithExecutionStatus(this Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionExternalChecksPostRequest> it)
            => it.AddFieldName("executionStatus");
        
        public static Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionExternalChecksPostRequest> WithExecutionStatus(this Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionExternalChecksPostRequest> it, Func<Partial<CommitExecutionStatus>, Partial<CommitExecutionStatus>> partialBuilder)
            => it.AddFieldName("executionStatus", partialBuilder(new Partial<CommitExecutionStatus>(it)));
        
        public static Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionExternalChecksPostRequest> WithUrl(this Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionExternalChecksPostRequest> it)
            => it.AddFieldName("url");
        
        public static Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionExternalChecksPostRequest> WithExternalServiceName(this Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionExternalChecksPostRequest> it)
            => it.AddFieldName("externalServiceName");
        
        public static Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionExternalChecksPostRequest> WithTaskName(this Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionExternalChecksPostRequest> it)
            => it.AddFieldName("taskName");
        
        public static Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionExternalChecksPostRequest> WithTaskId(this Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionExternalChecksPostRequest> it)
            => it.AddFieldName("taskId");
        
        public static Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionExternalChecksPostRequest> WithTimestamp(this Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionExternalChecksPostRequest> it)
            => it.AddFieldName("timestamp");
        
        public static Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionExternalChecksPostRequest> WithDescription(this Partial<ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionExternalChecksPostRequest> it)
            => it.AddFieldName("description");
        
    }
    
}