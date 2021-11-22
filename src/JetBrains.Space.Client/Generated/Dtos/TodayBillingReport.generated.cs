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
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client;

public sealed class TodayBillingReport
     : IPropagatePropertyAccessPath
{
    public TodayBillingReport() { }
    
    public TodayBillingReport(PurchasedBillingPlan plan, int activeUsers, int userUsage, double userCost, long storageTotalUsage, double storageCost, long bandwidthTotalUsage, double bandwidthCost, long ciUsage, double ciCost, long appUsage, long chatUsage, double totalCost, long? storageAllocationB = null)
    {
        Plan = plan;
        ActiveUsers = activeUsers;
        UserUsage = userUsage;
        UserCost = userCost;
        StorageAllocationB = storageAllocationB;
        StorageTotalUsage = storageTotalUsage;
        StorageCost = storageCost;
        BandwidthTotalUsage = bandwidthTotalUsage;
        BandwidthCost = bandwidthCost;
        CiUsage = ciUsage;
        CiCost = ciCost;
        AppUsage = appUsage;
        ChatUsage = chatUsage;
        TotalCost = totalCost;
    }
    
    private PropertyValue<PurchasedBillingPlan> _plan = new PropertyValue<PurchasedBillingPlan>(nameof(TodayBillingReport), nameof(Plan), "plan");
    
    [Required]
    [JsonPropertyName("plan")]
    public PurchasedBillingPlan Plan
    {
        get => _plan.GetValue(InlineErrors);
        set => _plan.SetValue(value);
    }

    private PropertyValue<int> _activeUsers = new PropertyValue<int>(nameof(TodayBillingReport), nameof(ActiveUsers), "activeUsers");
    
    [Required]
    [JsonPropertyName("activeUsers")]
    public int ActiveUsers
    {
        get => _activeUsers.GetValue(InlineErrors);
        set => _activeUsers.SetValue(value);
    }

    private PropertyValue<int> _userUsage = new PropertyValue<int>(nameof(TodayBillingReport), nameof(UserUsage), "userUsage");
    
    [Required]
    [JsonPropertyName("userUsage")]
    public int UserUsage
    {
        get => _userUsage.GetValue(InlineErrors);
        set => _userUsage.SetValue(value);
    }

    private PropertyValue<double> _userCost = new PropertyValue<double>(nameof(TodayBillingReport), nameof(UserCost), "userCost");
    
    [Required]
    [JsonPropertyName("userCost")]
    public double UserCost
    {
        get => _userCost.GetValue(InlineErrors);
        set => _userCost.SetValue(value);
    }

    private PropertyValue<long?> _storageAllocationB = new PropertyValue<long?>(nameof(TodayBillingReport), nameof(StorageAllocationB), "storageAllocationB");
    
    [JsonPropertyName("storageAllocationB")]
    public long? StorageAllocationB
    {
        get => _storageAllocationB.GetValue(InlineErrors);
        set => _storageAllocationB.SetValue(value);
    }

    private PropertyValue<long> _storageTotalUsage = new PropertyValue<long>(nameof(TodayBillingReport), nameof(StorageTotalUsage), "storageTotalUsage");
    
    [Required]
    [JsonPropertyName("storageTotalUsage")]
    public long StorageTotalUsage
    {
        get => _storageTotalUsage.GetValue(InlineErrors);
        set => _storageTotalUsage.SetValue(value);
    }

    private PropertyValue<double> _storageCost = new PropertyValue<double>(nameof(TodayBillingReport), nameof(StorageCost), "storageCost");
    
    [Required]
    [JsonPropertyName("storageCost")]
    public double StorageCost
    {
        get => _storageCost.GetValue(InlineErrors);
        set => _storageCost.SetValue(value);
    }

    private PropertyValue<long> _bandwidthTotalUsage = new PropertyValue<long>(nameof(TodayBillingReport), nameof(BandwidthTotalUsage), "bandwidthTotalUsage");
    
    [Required]
    [JsonPropertyName("bandwidthTotalUsage")]
    public long BandwidthTotalUsage
    {
        get => _bandwidthTotalUsage.GetValue(InlineErrors);
        set => _bandwidthTotalUsage.SetValue(value);
    }

    private PropertyValue<double> _bandwidthCost = new PropertyValue<double>(nameof(TodayBillingReport), nameof(BandwidthCost), "bandwidthCost");
    
    [Required]
    [JsonPropertyName("bandwidthCost")]
    public double BandwidthCost
    {
        get => _bandwidthCost.GetValue(InlineErrors);
        set => _bandwidthCost.SetValue(value);
    }

    private PropertyValue<long> _ciUsage = new PropertyValue<long>(nameof(TodayBillingReport), nameof(CiUsage), "ciUsage");
    
    [Required]
    [JsonPropertyName("ciUsage")]
    public long CiUsage
    {
        get => _ciUsage.GetValue(InlineErrors);
        set => _ciUsage.SetValue(value);
    }

    private PropertyValue<double> _ciCost = new PropertyValue<double>(nameof(TodayBillingReport), nameof(CiCost), "ciCost");
    
    [Required]
    [JsonPropertyName("ciCost")]
    public double CiCost
    {
        get => _ciCost.GetValue(InlineErrors);
        set => _ciCost.SetValue(value);
    }

    private PropertyValue<long> _appUsage = new PropertyValue<long>(nameof(TodayBillingReport), nameof(AppUsage), "appUsage");
    
    [Required]
    [JsonPropertyName("appUsage")]
    public long AppUsage
    {
        get => _appUsage.GetValue(InlineErrors);
        set => _appUsage.SetValue(value);
    }

    private PropertyValue<long> _chatUsage = new PropertyValue<long>(nameof(TodayBillingReport), nameof(ChatUsage), "chatUsage");
    
    [Required]
    [JsonPropertyName("chatUsage")]
    public long ChatUsage
    {
        get => _chatUsage.GetValue(InlineErrors);
        set => _chatUsage.SetValue(value);
    }

    private PropertyValue<double> _totalCost = new PropertyValue<double>(nameof(TodayBillingReport), nameof(TotalCost), "totalCost");
    
    [Required]
    [JsonPropertyName("totalCost")]
    public double TotalCost
    {
        get => _totalCost.GetValue(InlineErrors);
        set => _totalCost.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _plan.SetAccessPath(parentChainPath, validateHasBeenSet);
        _activeUsers.SetAccessPath(parentChainPath, validateHasBeenSet);
        _userUsage.SetAccessPath(parentChainPath, validateHasBeenSet);
        _userCost.SetAccessPath(parentChainPath, validateHasBeenSet);
        _storageAllocationB.SetAccessPath(parentChainPath, validateHasBeenSet);
        _storageTotalUsage.SetAccessPath(parentChainPath, validateHasBeenSet);
        _storageCost.SetAccessPath(parentChainPath, validateHasBeenSet);
        _bandwidthTotalUsage.SetAccessPath(parentChainPath, validateHasBeenSet);
        _bandwidthCost.SetAccessPath(parentChainPath, validateHasBeenSet);
        _ciUsage.SetAccessPath(parentChainPath, validateHasBeenSet);
        _ciCost.SetAccessPath(parentChainPath, validateHasBeenSet);
        _appUsage.SetAccessPath(parentChainPath, validateHasBeenSet);
        _chatUsage.SetAccessPath(parentChainPath, validateHasBeenSet);
        _totalCost.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

