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

namespace SpaceDotNet.Client.TeamDirectoryMemberLocationsForMemberLocationIdPatchRequestPartialBuilder
{
    public static class TeamDirectoryMemberLocationsForMemberLocationIdPatchRequestPartialExtensions
    {
        public static Partial<TeamDirectoryMemberLocationsForMemberLocationIdPatchRequest> WithLocation(this Partial<TeamDirectoryMemberLocationsForMemberLocationIdPatchRequest> it)
            => it.AddFieldName("location");
        
        public static Partial<TeamDirectoryMemberLocationsForMemberLocationIdPatchRequest> WithSince(this Partial<TeamDirectoryMemberLocationsForMemberLocationIdPatchRequest> it)
            => it.AddFieldName("since");
        
        public static Partial<TeamDirectoryMemberLocationsForMemberLocationIdPatchRequest> WithTill(this Partial<TeamDirectoryMemberLocationsForMemberLocationIdPatchRequest> it)
            => it.AddFieldName("till");
        
    }
    
}
