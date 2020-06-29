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
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client.AuthModulesRequestPartialBuilder
{
    public static class AuthModulesRequestPartialExtensions
    {
        public static Partial<AuthModulesRequest> WithKey(this Partial<AuthModulesRequest> it)
            => it.AddFieldName("key");
        
        public static Partial<AuthModulesRequest> WithName(this Partial<AuthModulesRequest> it)
            => it.AddFieldName("name");
        
        public static Partial<AuthModulesRequest> WithEnabled(this Partial<AuthModulesRequest> it)
            => it.AddFieldName("enabled");
        
        public static Partial<AuthModulesRequest> WithSettings(this Partial<AuthModulesRequest> it)
            => it.AddFieldName("settings");
        
        public static Partial<AuthModulesRequest> WithSettings(this Partial<AuthModulesRequest> it, Func<Partial<ESAuthModuleSettingsDto>, Partial<ESAuthModuleSettingsDto>> partialBuilder)
            => it.AddFieldName("settings", partialBuilder(new Partial<ESAuthModuleSettingsDto>(it)));
        
    }
    
}