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

namespace JetBrains.Space.Client.UnfurlActionPayloadPartialBuilder;

public static class UnfurlActionPayloadPartialExtensions
{
    public static Partial<UnfurlActionPayload> WithActionId(this Partial<UnfurlActionPayload> it)
        => it.AddFieldName("actionId");
    
    public static Partial<UnfurlActionPayload> WithActionValue(this Partial<UnfurlActionPayload> it)
        => it.AddFieldName("actionValue");
    
    public static Partial<UnfurlActionPayload> WithLink(this Partial<UnfurlActionPayload> it)
        => it.AddFieldName("link");
    
    public static Partial<UnfurlActionPayload> WithContext(this Partial<UnfurlActionPayload> it)
        => it.AddFieldName("context");
    
    public static Partial<UnfurlActionPayload> WithContext(this Partial<UnfurlActionPayload> it, Func<Partial<ApplicationUnfurlContext>, Partial<ApplicationUnfurlContext>> partialBuilder)
        => it.AddFieldName("context", partialBuilder(new Partial<ApplicationUnfurlContext>(it)));
    
    public static Partial<UnfurlActionPayload> WithClientId(this Partial<UnfurlActionPayload> it)
        => it.AddFieldName("clientId");
    
    public static Partial<UnfurlActionPayload> WithUserId(this Partial<UnfurlActionPayload> it)
        => it.AddFieldName("userId");
    
    public static Partial<UnfurlActionPayload> WithVerificationToken(this Partial<UnfurlActionPayload> it)
        => it.AddFieldName("verificationToken");
    
}

