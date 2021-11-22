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

public sealed class AccessRecord
     : IPropagatePropertyAccessPath
{
    public AccessRecord() { }
    
    public AccessRecord(DateTime time, string address, string? userAgent = null)
    {
        Time = time;
        Address = address;
        UserAgent = userAgent;
    }
    
    private PropertyValue<DateTime> _time = new PropertyValue<DateTime>(nameof(AccessRecord), nameof(Time), "time");
    
    [Required]
    [JsonPropertyName("time")]
    [JsonConverter(typeof(SpaceDateTimeConverter))]
    public DateTime Time
    {
        get => _time.GetValue(InlineErrors);
        set => _time.SetValue(value);
    }

    private PropertyValue<string> _address = new PropertyValue<string>(nameof(AccessRecord), nameof(Address), "address");
    
    [Required]
    [JsonPropertyName("address")]
    public string Address
    {
        get => _address.GetValue(InlineErrors);
        set => _address.SetValue(value);
    }

    private PropertyValue<string?> _userAgent = new PropertyValue<string?>(nameof(AccessRecord), nameof(UserAgent), "userAgent");
    
    [JsonPropertyName("userAgent")]
    public string? UserAgent
    {
        get => _userAgent.GetValue(InlineErrors);
        set => _userAgent.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _time.SetAccessPath(parentChainPath, validateHasBeenSet);
        _address.SetAccessPath(parentChainPath, validateHasBeenSet);
        _userAgent.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

