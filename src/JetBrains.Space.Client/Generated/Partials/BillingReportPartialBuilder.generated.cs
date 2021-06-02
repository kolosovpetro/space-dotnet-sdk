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

namespace JetBrains.Space.Client.BillingReportPartialBuilder
{
    public static class BillingReportPartialExtensions
    {
        public static Partial<BillingReport> WithPlans(this Partial<BillingReport> it)
            => it.AddFieldName("plans");
        
        public static Partial<BillingReport> WithPlans(this Partial<BillingReport> it, Func<Partial<PurchasedBillingPlan>, Partial<PurchasedBillingPlan>> partialBuilder)
            => it.AddFieldName("plans", partialBuilder(new Partial<PurchasedBillingPlan>(it)));
        
        public static Partial<BillingReport> WithReportDays(this Partial<BillingReport> it)
            => it.AddFieldName("reportDays");
        
        public static Partial<BillingReport> WithReportDays(this Partial<BillingReport> it, Func<Partial<BillingReportDay>, Partial<BillingReportDay>> partialBuilder)
            => it.AddFieldName("reportDays", partialBuilder(new Partial<BillingReportDay>(it)));
        
        public static Partial<BillingReport> WithEarliestBillingDate(this Partial<BillingReport> it)
            => it.AddFieldName("earliestBillingDate");
        
    }
    
}
