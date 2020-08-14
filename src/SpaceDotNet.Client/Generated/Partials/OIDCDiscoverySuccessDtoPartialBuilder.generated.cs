// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client.OIDCDiscoverySuccessDtoPartialBuilder
{
    public static class OIDCDiscoverySuccessDtoPartialExtensions
    {
        public static Partial<OIDCDiscoverySuccessDto> WithIssuer(this Partial<OIDCDiscoverySuccessDto> it)
            => it.AddFieldName("issuer");
        
        public static Partial<OIDCDiscoverySuccessDto> WithAuthorizationEndpoint(this Partial<OIDCDiscoverySuccessDto> it)
            => it.AddFieldName("authorizationEndpoint");
        
        public static Partial<OIDCDiscoverySuccessDto> WithDeviceAuthorizationEndpoint(this Partial<OIDCDiscoverySuccessDto> it)
            => it.AddFieldName("deviceAuthorizationEndpoint");
        
        public static Partial<OIDCDiscoverySuccessDto> WithTokenEndpoint(this Partial<OIDCDiscoverySuccessDto> it)
            => it.AddFieldName("tokenEndpoint");
        
        public static Partial<OIDCDiscoverySuccessDto> WithUserinfoEndpoint(this Partial<OIDCDiscoverySuccessDto> it)
            => it.AddFieldName("userinfoEndpoint");
        
        public static Partial<OIDCDiscoverySuccessDto> WithRevocationEndpoint(this Partial<OIDCDiscoverySuccessDto> it)
            => it.AddFieldName("revocationEndpoint");
        
        public static Partial<OIDCDiscoverySuccessDto> WithJwksUri(this Partial<OIDCDiscoverySuccessDto> it)
            => it.AddFieldName("jwksUri");
        
    }
    
}
