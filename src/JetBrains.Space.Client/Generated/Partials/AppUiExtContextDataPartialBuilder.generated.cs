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

namespace JetBrains.Space.Client.AppUiExtContextDataPartialBuilder;

public static class AppUiExtContextDataPartialExtensions
{
    public static Partial<AppUiExtContextData> WithContext(this Partial<AppUiExtContextData> it)
        => it.AddFieldName("context");
    
    public static Partial<AppUiExtContextData> WithContext(this Partial<AppUiExtContextData> it, Func<Partial<PermissionContextApi>, Partial<PermissionContextApi>> partialBuilder)
        => it.AddFieldName("context", partialBuilder(new Partial<PermissionContextApi>(it)));
    
    public static Partial<AppUiExtContextData> WithExtensions(this Partial<AppUiExtContextData> it)
        => it.AddFieldName("extensions");
    
    public static Partial<AppUiExtContextData> WithExtensions(this Partial<AppUiExtContextData> it, Func<Partial<AppUiExtensionApi>, Partial<AppUiExtensionApi>> partialBuilder)
        => it.AddFieldName("extensions", partialBuilder(new Partial<AppUiExtensionApi>(it)));
    
    public static Partial<AppUiExtContextData> WithAppUiEnabledState(this Partial<AppUiExtContextData> it)
        => it.AddFieldName("appUiEnabledState");
    
    public static Partial<AppUiExtContextData> WithAppUiEnabledState(this Partial<AppUiExtContextData> it, Func<Partial<AppUiEnabledState>, Partial<AppUiEnabledState>> partialBuilder)
        => it.AddFieldName("appUiEnabledState", partialBuilder(new Partial<AppUiEnabledState>(it)));
    
}

