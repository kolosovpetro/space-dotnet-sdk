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
using JetBrains.Space.Client.Internal;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client.PlanLimitsPartialBuilder
{
    public static class PlanLimitsPartialExtensions
    {
        public static Partial<PlanLimits> WithStorage(this Partial<PlanLimits> it)
            => it.AddFieldName("storage");
        
        public static Partial<PlanLimits> WithStorage(this Partial<PlanLimits> it, Func<Partial<StoragePlanLimit>, Partial<StoragePlanLimit>> partialBuilder)
            => it.AddFieldName("storage", partialBuilder(new Partial<StoragePlanLimit>(it)));
        
        public static Partial<PlanLimits> WithTraffic(this Partial<PlanLimits> it)
            => it.AddFieldName("traffic");
        
        public static Partial<PlanLimits> WithTraffic(this Partial<PlanLimits> it, Func<Partial<TrafficPlanLimit>, Partial<TrafficPlanLimit>> partialBuilder)
            => it.AddFieldName("traffic", partialBuilder(new Partial<TrafficPlanLimit>(it)));
        
        public static Partial<PlanLimits> WithCiCredits(this Partial<PlanLimits> it)
            => it.AddFieldName("ciCredits");
        
        public static Partial<PlanLimits> WithCiCredits(this Partial<PlanLimits> it, Func<Partial<PlanLimit>, Partial<PlanLimit>> partialBuilder)
            => it.AddFieldName("ciCredits", partialBuilder(new Partial<PlanLimit>(it)));
        
    }
    
}