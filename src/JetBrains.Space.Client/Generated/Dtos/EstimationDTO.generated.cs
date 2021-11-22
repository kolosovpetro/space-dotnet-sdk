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

public sealed class EstimationDTO
     : IPropagatePropertyAccessPath
{
    public EstimationDTO() { }
    
    public EstimationDTO(DateTime start, long predictedDuration)
    {
        Start = start;
        PredictedDuration = predictedDuration;
    }
    
    private PropertyValue<DateTime> _start = new PropertyValue<DateTime>(nameof(EstimationDTO), nameof(Start), "start");
    
    [Required]
    [JsonPropertyName("start")]
    [JsonConverter(typeof(SpaceDateTimeConverter))]
    public DateTime Start
    {
        get => _start.GetValue(InlineErrors);
        set => _start.SetValue(value);
    }

    private PropertyValue<long> _predictedDuration = new PropertyValue<long>(nameof(EstimationDTO), nameof(PredictedDuration), "predictedDuration");
    
    [Required]
    [JsonPropertyName("predictedDuration")]
    public long PredictedDuration
    {
        get => _predictedDuration.GetValue(InlineErrors);
        set => _predictedDuration.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _start.SetAccessPath(parentChainPath, validateHasBeenSet);
        _predictedDuration.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

