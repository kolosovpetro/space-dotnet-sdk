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

public sealed class TDWorkingDays
     : IPropagatePropertyAccessPath
{
    public TDWorkingDays() { }
    
    public TDWorkingDays(string id, WorkingDaysSpec workingDaysSpec, DateTime? dateStart = null, DateTime? dateEnd = null)
    {
        Id = id;
        DateStart = dateStart;
        DateEnd = dateEnd;
        WorkingDaysSpec = workingDaysSpec;
    }
    
    private PropertyValue<string> _id = new PropertyValue<string>(nameof(TDWorkingDays), nameof(Id), "id");
    
    [Required]
    [JsonPropertyName("id")]
    public string Id
    {
        get => _id.GetValue(InlineErrors);
        set => _id.SetValue(value);
    }

    private PropertyValue<DateTime?> _dateStart = new PropertyValue<DateTime?>(nameof(TDWorkingDays), nameof(DateStart), "dateStart");
    
    [JsonPropertyName("dateStart")]
    [JsonConverter(typeof(SpaceDateConverter))]
    public DateTime? DateStart
    {
        get => _dateStart.GetValue(InlineErrors);
        set => _dateStart.SetValue(value);
    }

    private PropertyValue<DateTime?> _dateEnd = new PropertyValue<DateTime?>(nameof(TDWorkingDays), nameof(DateEnd), "dateEnd");
    
    [JsonPropertyName("dateEnd")]
    [JsonConverter(typeof(SpaceDateConverter))]
    public DateTime? DateEnd
    {
        get => _dateEnd.GetValue(InlineErrors);
        set => _dateEnd.SetValue(value);
    }

    private PropertyValue<WorkingDaysSpec> _workingDaysSpec = new PropertyValue<WorkingDaysSpec>(nameof(TDWorkingDays), nameof(WorkingDaysSpec), "workingDaysSpec");
    
    [Required]
    [JsonPropertyName("workingDaysSpec")]
    public WorkingDaysSpec WorkingDaysSpec
    {
        get => _workingDaysSpec.GetValue(InlineErrors);
        set => _workingDaysSpec.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _id.SetAccessPath(parentChainPath, validateHasBeenSet);
        _dateStart.SetAccessPath(parentChainPath, validateHasBeenSet);
        _dateEnd.SetAccessPath(parentChainPath, validateHasBeenSet);
        _workingDaysSpec.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

