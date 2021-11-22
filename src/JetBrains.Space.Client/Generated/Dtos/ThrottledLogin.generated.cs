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

public sealed class ThrottledLogin
     : IPropagatePropertyAccessPath
{
    public ThrottledLogin() { }
    
    public ThrottledLogin(string login, DateTime throttledUntil)
    {
        Login = login;
        ThrottledUntil = throttledUntil;
    }
    
    private PropertyValue<string> _login = new PropertyValue<string>(nameof(ThrottledLogin), nameof(Login), "login");
    
    [Required]
    [JsonPropertyName("login")]
    public string Login
    {
        get => _login.GetValue(InlineErrors);
        set => _login.SetValue(value);
    }

    private PropertyValue<DateTime> _throttledUntil = new PropertyValue<DateTime>(nameof(ThrottledLogin), nameof(ThrottledUntil), "throttledUntil");
    
    [Required]
    [JsonPropertyName("throttledUntil")]
    [JsonConverter(typeof(SpaceDateTimeConverter))]
    public DateTime ThrottledUntil
    {
        get => _throttledUntil.GetValue(InlineErrors);
        set => _throttledUntil.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _login.SetAccessPath(parentChainPath, validateHasBeenSet);
        _throttledUntil.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

