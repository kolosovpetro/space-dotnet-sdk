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

namespace SpaceDotNet.Client.ESAzureAuthModuleSettingsDtoPartialBuilder
{
    public static class ESAzureAuthModuleSettingsDtoPartialExtensions
    {
        public static Partial<ESAzureAuthModuleSettingsDto> WithTenantId(this Partial<ESAzureAuthModuleSettingsDto> it)
            => it.AddFieldName("tenantId");
        
        public static Partial<ESAzureAuthModuleSettingsDto> WithClientId(this Partial<ESAzureAuthModuleSettingsDto> it)
            => it.AddFieldName("clientId");
        
        public static Partial<ESAzureAuthModuleSettingsDto> WithClientSecret(this Partial<ESAzureAuthModuleSettingsDto> it)
            => it.AddFieldName("clientSecret");
        
        public static Partial<ESAzureAuthModuleSettingsDto> WithRegisterNewUsers(this Partial<ESAzureAuthModuleSettingsDto> it)
            => it.AddFieldName("registerNewUsers");
        
        public static Partial<ESAzureAuthModuleSettingsDto> WithEmailVerified(this Partial<ESAzureAuthModuleSettingsDto> it)
            => it.AddFieldName("emailVerified");
        
    }
    
}
