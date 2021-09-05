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

namespace JetBrains.Space.Client.ESAppSettingsPartialBuilder
{
    public static class ESAppSettingsPartialExtensions
    {
        public static Partial<ESAppSettings> WithIsClientCredentialsFlowEnabled(this Partial<ESAppSettings> it)
            => it.AddFieldName("clientCredentialsFlowEnabled");
        
        public static Partial<ESAppSettings> WithIsCodeFlowEnabled(this Partial<ESAppSettings> it)
            => it.AddFieldName("codeFlowEnabled");
        
        public static Partial<ESAppSettings> WithCodeFlowRedirectURIs(this Partial<ESAppSettings> it)
            => it.AddFieldName("codeFlowRedirectURIs");
        
        public static Partial<ESAppSettings> WithIsPkceRequired(this Partial<ESAppSettings> it)
            => it.AddFieldName("pkceRequired");
        
        public static Partial<ESAppSettings> WithIsImplicitFlowEnabled(this Partial<ESAppSettings> it)
            => it.AddFieldName("implicitFlowEnabled");
        
        public static Partial<ESAppSettings> WithImplicitFlowRedirectURIs(this Partial<ESAppSettings> it)
            => it.AddFieldName("implicitFlowRedirectURIs");
        
        public static Partial<ESAppSettings> WithEndpointURI(this Partial<ESAppSettings> it)
            => it.AddFieldName("endpointURI");
        
        public static Partial<ESAppSettings> WithIsHasVerificationToken(this Partial<ESAppSettings> it)
            => it.AddFieldName("hasVerificationToken");
        
        public static Partial<ESAppSettings> WithIsHasSigningKey(this Partial<ESAppSettings> it)
            => it.AddFieldName("hasSigningKey");
        
        public static Partial<ESAppSettings> WithIsHasPublicKeySignature(this Partial<ESAppSettings> it)
            => it.AddFieldName("hasPublicKeySignature");
        
        public static Partial<ESAppSettings> WithIsEndpointSslVerification(this Partial<ESAppSettings> it)
            => it.AddFieldName("endpointSslVerification");
        
        public static Partial<ESAppSettings> WithBasicAuthUsername(this Partial<ESAppSettings> it)
            => it.AddFieldName("basicAuthUsername");
        
        public static Partial<ESAppSettings> WithIsHasBearerToken(this Partial<ESAppSettings> it)
            => it.AddFieldName("hasBearerToken");
        
        public static Partial<ESAppSettings> WithSslKeystoreAuth(this Partial<ESAppSettings> it)
            => it.AddFieldName("sslKeystoreAuth");
        
    }
    
}
