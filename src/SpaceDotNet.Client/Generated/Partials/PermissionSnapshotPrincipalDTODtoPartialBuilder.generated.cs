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

namespace SpaceDotNet.Client.PermissionSnapshotPrincipalDTODtoPartialBuilder
{
    public static class PermissionSnapshotPrincipalDTODtoPartialExtensions
    {
        public static Partial<PermissionSnapshotPrincipalDTODto> WithId(this Partial<PermissionSnapshotPrincipalDTODto> it)
            => it.AddFieldName("id");
        
        public static Partial<PermissionSnapshotPrincipalDTODto> WithType(this Partial<PermissionSnapshotPrincipalDTODto> it)
            => it.AddFieldName("type");
        
        public static Partial<PermissionSnapshotPrincipalDTODto> WithName(this Partial<PermissionSnapshotPrincipalDTODto> it)
            => it.AddFieldName("name");
        
    }
    
}
