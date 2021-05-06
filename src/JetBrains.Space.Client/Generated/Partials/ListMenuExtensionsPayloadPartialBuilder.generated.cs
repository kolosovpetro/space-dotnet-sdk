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

namespace JetBrains.Space.Client.ListMenuExtensionsPayloadPartialBuilder
{
    public static class ListMenuExtensionsPayloadPartialExtensions
    {
        public static Partial<ListMenuExtensionsPayload> WithAccessToken(this Partial<ListMenuExtensionsPayload> it)
            => it.AddFieldName("accessToken");
        
        public static Partial<ListMenuExtensionsPayload> WithVerificationToken(this Partial<ListMenuExtensionsPayload> it)
            => it.AddFieldName("verificationToken");
        
        public static Partial<ListMenuExtensionsPayload> WithUserId(this Partial<ListMenuExtensionsPayload> it)
            => it.AddFieldName("userId");
        
        public static Partial<ListMenuExtensionsPayload> WithServerUrl(this Partial<ListMenuExtensionsPayload> it)
            => it.AddFieldName("serverUrl");
        
        public static Partial<ListMenuExtensionsPayload> WithClientId(this Partial<ListMenuExtensionsPayload> it)
            => it.AddFieldName("clientId");
        
        public static Partial<ListMenuExtensionsPayload> WithOrgId(this Partial<ListMenuExtensionsPayload> it)
            => it.AddFieldName("orgId");
        
    }
    
}
