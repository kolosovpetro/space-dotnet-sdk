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

namespace SpaceDotNet.Client.ERepositorySettingsExtensions
{
    public static class ERepositorySettingsDtoPartialExtensions
    {
        public static Partial<ERepositorySettingsDto> WithId(this Partial<ERepositorySettingsDto> it)
            => it.AddFieldName("id");
        
        public static Partial<ERepositorySettingsDto> WithName(this Partial<ERepositorySettingsDto> it)
            => it.AddFieldName("name");
        
        public static Partial<ERepositorySettingsDto> WithImmutableTags(this Partial<ERepositorySettingsDto> it)
            => it.AddFieldName("immutableTags");
        
        public static Partial<ERepositorySettingsDto> WithPermissions(this Partial<ERepositorySettingsDto> it)
            => it.AddFieldName("permissions");
        
        public static Partial<ERepositorySettingsDto> WithPermissions(this Partial<ERepositorySettingsDto> it, Func<Partial<string>, Partial<string>> partialBuilder)
            => it.AddFieldName("permissions", partialBuilder(new Partial<string>()));
        
    }
    
}