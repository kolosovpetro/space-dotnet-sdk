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

namespace JetBrains.Space.Client.PlanLimitPartialBuilder
{
    public static class PlanLimitPartialExtensions
    {
        public static Partial<PlanLimit> WithUnit(this Partial<PlanLimit> it)
            => it.AddFieldName("unit");
        
        public static Partial<PlanLimit> WithUnit(this Partial<PlanLimit> it, Func<Partial<LimitUnit>, Partial<LimitUnit>> partialBuilder)
            => it.AddFieldName("unit", partialBuilder(new Partial<LimitUnit>(it)));
        
        public static Partial<PlanLimit> WithUsage(this Partial<PlanLimit> it)
            => it.AddFieldName("usage");
        
        public static Partial<PlanLimit> WithSoftCap(this Partial<PlanLimit> it)
            => it.AddFieldName("softCap");
        
        public static Partial<PlanLimit> WithHardCap(this Partial<PlanLimit> it)
            => it.AddFieldName("hardCap");
        
        public static Partial<PlanLimit> WithOverdraftPrice(this Partial<PlanLimit> it)
            => it.AddFieldName("overdraftPrice");
        
        public static Partial<PlanLimit> WithOverdraftPrice(this Partial<PlanLimit> it, Func<Partial<Money>, Partial<Money>> partialBuilder)
            => it.AddFieldName("overdraftPrice", partialBuilder(new Partial<Money>(it)));
        
    }
    
}