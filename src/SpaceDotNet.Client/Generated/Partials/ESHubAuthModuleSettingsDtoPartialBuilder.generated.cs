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

namespace SpaceDotNet.Client.ESHubAuthModuleSettingsDtoPartialBuilder
{
    public static class ESHubAuthModuleSettingsDtoPartialExtensions
    {
        public static Partial<ESHubAuthModuleSettingsDto> WithHubUrl(this Partial<ESHubAuthModuleSettingsDto> it)
            => it.AddFieldName("hubUrl");
        
        public static Partial<ESHubAuthModuleSettingsDto> WithClientId(this Partial<ESHubAuthModuleSettingsDto> it)
            => it.AddFieldName("clientId");
        
        public static Partial<ESHubAuthModuleSettingsDto> WithClientSecret(this Partial<ESHubAuthModuleSettingsDto> it)
            => it.AddFieldName("clientSecret");
        
        public static Partial<ESHubAuthModuleSettingsDto> WithRegisterNewUsers(this Partial<ESHubAuthModuleSettingsDto> it)
            => it.AddFieldName("registerNewUsers");
        
        public static Partial<ESHubAuthModuleSettingsDto> WithOrgAuthProviderName(this Partial<ESHubAuthModuleSettingsDto> it)
            => it.AddFieldName("orgAuthProviderName");
        
        public static Partial<ESHubAuthModuleSettingsDto> WithGroups(this Partial<ESHubAuthModuleSettingsDto> it)
            => it.AddFieldName("groups");
        
    }
    
}
