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

namespace SpaceDotNet.Client.TeamDirectoryLocationMapMemberPointsPostRequestPartialBuilder
{
    public static class TeamDirectoryLocationMapMemberPointsPostRequestPartialExtensions
    {
        public static Partial<TeamDirectoryLocationMapMemberPointsPostRequest> WithMemberLocationId(this Partial<TeamDirectoryLocationMapMemberPointsPostRequest> it)
            => it.AddFieldName("memberLocationId");
        
        public static Partial<TeamDirectoryLocationMapMemberPointsPostRequest> WithX(this Partial<TeamDirectoryLocationMapMemberPointsPostRequest> it)
            => it.AddFieldName("x");
        
        public static Partial<TeamDirectoryLocationMapMemberPointsPostRequest> WithY(this Partial<TeamDirectoryLocationMapMemberPointsPostRequest> it)
            => it.AddFieldName("y");
        
        public static Partial<TeamDirectoryLocationMapMemberPointsPostRequest> WithMapId(this Partial<TeamDirectoryLocationMapMemberPointsPostRequest> it)
            => it.AddFieldName("mapId");
        
    }
    
}
