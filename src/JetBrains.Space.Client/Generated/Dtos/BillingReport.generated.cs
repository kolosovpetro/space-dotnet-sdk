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

namespace JetBrains.Space.Client
{
    public sealed class BillingReport
         : IPropagatePropertyAccessPath
    {
        public BillingReport() { }
        
        public BillingReport(List<PurchasedBillingPlan> plans, List<BillingReportDay> reportDays, DateTime earliestBillingDate)
        {
            Plans = plans;
            ReportDays = reportDays;
            EarliestBillingDate = earliestBillingDate;
        }
        
        private PropertyValue<List<PurchasedBillingPlan>> _plans = new PropertyValue<List<PurchasedBillingPlan>>(nameof(BillingReport), nameof(Plans), new List<PurchasedBillingPlan>());
        
        [Required]
        [JsonPropertyName("plans")]
        public List<PurchasedBillingPlan> Plans
        {
            get => _plans.GetValue();
            set => _plans.SetValue(value);
        }
    
        private PropertyValue<List<BillingReportDay>> _reportDays = new PropertyValue<List<BillingReportDay>>(nameof(BillingReport), nameof(ReportDays), new List<BillingReportDay>());
        
        [Required]
        [JsonPropertyName("reportDays")]
        public List<BillingReportDay> ReportDays
        {
            get => _reportDays.GetValue();
            set => _reportDays.SetValue(value);
        }
    
        private PropertyValue<DateTime> _earliestBillingDate = new PropertyValue<DateTime>(nameof(BillingReport), nameof(EarliestBillingDate));
        
        [Required]
        [JsonPropertyName("earliestBillingDate")]
        [JsonConverter(typeof(SpaceDateConverter))]
        public DateTime EarliestBillingDate
        {
            get => _earliestBillingDate.GetValue();
            set => _earliestBillingDate.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _plans.SetAccessPath(path, validateHasBeenSet);
            _reportDays.SetAccessPath(path, validateHasBeenSet);
            _earliestBillingDate.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
