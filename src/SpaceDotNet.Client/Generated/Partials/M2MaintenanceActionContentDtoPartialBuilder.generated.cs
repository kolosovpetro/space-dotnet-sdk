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

namespace SpaceDotNet.Client.M2MaintenanceActionContentDtoPartialBuilder
{
    public static class M2MaintenanceActionContentDtoPartialExtensions
    {
        public static Partial<M2MaintenanceActionContentDto> WithAction(this Partial<M2MaintenanceActionContentDto> it)
            => it.AddFieldName("action");
        
        public static Partial<M2MaintenanceActionContentDto> WithSuccess(this Partial<M2MaintenanceActionContentDto> it)
            => it.AddFieldName("success");
        
        public static Partial<M2MaintenanceActionContentDto> WithDetails(this Partial<M2MaintenanceActionContentDto> it)
            => it.AddFieldName("details");
        
    }
    
}
