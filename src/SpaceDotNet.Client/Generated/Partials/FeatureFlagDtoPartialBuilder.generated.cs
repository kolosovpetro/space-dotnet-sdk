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

namespace SpaceDotNet.Client.FeatureFlagDtoPartialBuilder
{
    public static class FeatureFlagDtoPartialExtensions
    {
        public static Partial<FeatureFlagDto> WithName(this Partial<FeatureFlagDto> it)
            => it.AddFieldName("name");
        
        public static Partial<FeatureFlagDto> WithDescription(this Partial<FeatureFlagDto> it)
            => it.AddFieldName("description");
        
        public static Partial<FeatureFlagDto> WithStatus(this Partial<FeatureFlagDto> it)
            => it.AddFieldName("status");
        
        public static Partial<FeatureFlagDto> WithStatus(this Partial<FeatureFlagDto> it, Func<Partial<FeatureFlagStatus>, Partial<FeatureFlagStatus>> partialBuilder)
            => it.AddFieldName("status", partialBuilder(new Partial<FeatureFlagStatus>(it)));
        
        public static Partial<FeatureFlagDto> WithOwner(this Partial<FeatureFlagDto> it)
            => it.AddFieldName("owner");
        
        public static Partial<FeatureFlagDto> WithIntroduced(this Partial<FeatureFlagDto> it)
            => it.AddFieldName("introduced");
        
    }
    
}
