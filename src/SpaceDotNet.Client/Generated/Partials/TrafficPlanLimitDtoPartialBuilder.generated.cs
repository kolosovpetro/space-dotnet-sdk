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

namespace SpaceDotNet.Client.TrafficPlanLimitDtoPartialBuilder
{
    public static class TrafficPlanLimitDtoPartialExtensions
    {
        public static Partial<TrafficPlanLimitDto> WithFiles(this Partial<TrafficPlanLimitDto> it)
            => it.AddFieldName("files");
        
        public static Partial<TrafficPlanLimitDto> WithFiles(this Partial<TrafficPlanLimitDto> it, Func<Partial<PlanLimitDto>, Partial<PlanLimitDto>> partialBuilder)
            => it.AddFieldName("files", partialBuilder(new Partial<PlanLimitDto>(it)));
        
        public static Partial<TrafficPlanLimitDto> WithPackages(this Partial<TrafficPlanLimitDto> it)
            => it.AddFieldName("packages");
        
        public static Partial<TrafficPlanLimitDto> WithPackages(this Partial<TrafficPlanLimitDto> it, Func<Partial<PlanLimitDto>, Partial<PlanLimitDto>> partialBuilder)
            => it.AddFieldName("packages", partialBuilder(new Partial<PlanLimitDto>(it)));
        
        public static Partial<TrafficPlanLimitDto> WithGit(this Partial<TrafficPlanLimitDto> it)
            => it.AddFieldName("git");
        
        public static Partial<TrafficPlanLimitDto> WithGit(this Partial<TrafficPlanLimitDto> it, Func<Partial<PlanLimitDto>, Partial<PlanLimitDto>> partialBuilder)
            => it.AddFieldName("git", partialBuilder(new Partial<PlanLimitDto>(it)));
        
    }
    
}
