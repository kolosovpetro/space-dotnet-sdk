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

namespace SpaceDotNet.Client.JobExecutionDTODtoPartialBuilder
{
    public static class JobExecutionDTODtoPartialExtensions
    {
        public static Partial<JobExecutionDTODto> WithExecutionId(this Partial<JobExecutionDTODto> it)
            => it.AddFieldName("executionId");
        
        public static Partial<JobExecutionDTODto> WithExecutionNumber(this Partial<JobExecutionDTODto> it)
            => it.AddFieldName("executionNumber");
        
        public static Partial<JobExecutionDTODto> WithJobId(this Partial<JobExecutionDTODto> it)
            => it.AddFieldName("jobId");
        
        public static Partial<JobExecutionDTODto> WithJobName(this Partial<JobExecutionDTODto> it)
            => it.AddFieldName("jobName");
        
        public static Partial<JobExecutionDTODto> WithBranch(this Partial<JobExecutionDTODto> it)
            => it.AddFieldName("branch");
        
        public static Partial<JobExecutionDTODto> WithStatus(this Partial<JobExecutionDTODto> it)
            => it.AddFieldName("status");
        
        public static Partial<JobExecutionDTODto> WithStatus(this Partial<JobExecutionDTODto> it, Func<Partial<ExecutionStatus>, Partial<ExecutionStatus>> partialBuilder)
            => it.AddFieldName("status", partialBuilder(new Partial<ExecutionStatus>(it)));
        
        public static Partial<JobExecutionDTODto> WithTriggeredTime(this Partial<JobExecutionDTODto> it)
            => it.AddFieldName("triggeredTime");
        
        public static Partial<JobExecutionDTODto> WithStartedTime(this Partial<JobExecutionDTODto> it)
            => it.AddFieldName("startedTime");
        
        public static Partial<JobExecutionDTODto> WithFinishedTime(this Partial<JobExecutionDTODto> it)
            => it.AddFieldName("finishedTime");
        
        public static Partial<JobExecutionDTODto> WithChangesFromExclude(this Partial<JobExecutionDTODto> it)
            => it.AddFieldName("changesFromExclude");
        
        public static Partial<JobExecutionDTODto> WithChangesCount(this Partial<JobExecutionDTODto> it)
            => it.AddFieldName("changesCount");
        
        public static Partial<JobExecutionDTODto> WithNumber(this Partial<JobExecutionDTODto> it)
            => it.AddFieldName("number");
        
        public static Partial<JobExecutionDTODto> WithPredictedEndTime(this Partial<JobExecutionDTODto> it)
            => it.AddFieldName("predictedEndTime");
        
        public static Partial<JobExecutionDTODto> WithPredictedEndTime(this Partial<JobExecutionDTODto> it, Func<Partial<EstimationDTODto>, Partial<EstimationDTODto>> partialBuilder)
            => it.AddFieldName("predictedEndTime", partialBuilder(new Partial<EstimationDTODto>(it)));
        
        public static Partial<JobExecutionDTODto> WithFailureConditions(this Partial<JobExecutionDTODto> it)
            => it.AddFieldName("failureConditions");
        
        public static Partial<JobExecutionDTODto> WithFailureConditions(this Partial<JobExecutionDTODto> it, Func<Partial<FailureConditionDTODto>, Partial<FailureConditionDTODto>> partialBuilder)
            => it.AddFieldName("failureConditions", partialBuilder(new Partial<FailureConditionDTODto>(it)));
        
    }
    
}
