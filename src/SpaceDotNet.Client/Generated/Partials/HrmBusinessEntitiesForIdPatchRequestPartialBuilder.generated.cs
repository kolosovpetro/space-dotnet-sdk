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

namespace SpaceDotNet.Client.HrmBusinessEntitiesForIdPatchRequestPartialBuilder
{
    public static class HrmBusinessEntitiesForIdPatchRequestPartialExtensions
    {
        public static Partial<HrmBusinessEntitiesForIdPatchRequest> WithName(this Partial<HrmBusinessEntitiesForIdPatchRequest> it)
            => it.AddFieldName("name");
        
        public static Partial<HrmBusinessEntitiesForIdPatchRequest> WithLocationId(this Partial<HrmBusinessEntitiesForIdPatchRequest> it)
            => it.AddFieldName("locationId");
        
        public static Partial<HrmBusinessEntitiesForIdPatchRequest> WithVacationAllowance(this Partial<HrmBusinessEntitiesForIdPatchRequest> it)
            => it.AddFieldName("vacationAllowance");
        
    }
    
}
