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

namespace SpaceDotNet.Client.UpdateAuthModuleRequestExtensions
{
    public static class UpdateAuthModuleRequestPartialExtensions
    {
        public static Partial<UpdateAuthModuleRequest> WithKey(this Partial<UpdateAuthModuleRequest> it)
            => it.AddFieldName("key");
        
        public static Partial<UpdateAuthModuleRequest> WithName(this Partial<UpdateAuthModuleRequest> it)
            => it.AddFieldName("name");
        
        public static Partial<UpdateAuthModuleRequest> WithEnabled(this Partial<UpdateAuthModuleRequest> it)
            => it.AddFieldName("enabled");
        
        public static Partial<UpdateAuthModuleRequest> WithSettings(this Partial<UpdateAuthModuleRequest> it)
            => it.AddFieldName("settings");
        
        public static Partial<UpdateAuthModuleRequest> WithSettings(this Partial<UpdateAuthModuleRequest> it, Func<Partial<ESAuthModuleSettingsDto>, Partial<ESAuthModuleSettingsDto>> partialBuilder)
            => it.AddFieldName("settings", partialBuilder(new Partial<ESAuthModuleSettingsDto>(it)));
        
    }
    
}