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

namespace SpaceDotNet.Client.TeamAddedItemDetailsDtoPartialBuilder
{
    public static class TeamAddedItemDetailsDtoPartialExtensions
    {
        public static Partial<TeamAddedItemDetailsDto> WithTeam(this Partial<TeamAddedItemDetailsDto> it)
            => it.AddFieldName("team");
        
        public static Partial<TeamAddedItemDetailsDto> WithTeam(this Partial<TeamAddedItemDetailsDto> it, Func<Partial<TDTeamDto>, Partial<TDTeamDto>> partialBuilder)
            => it.AddFieldName("team", partialBuilder(new Partial<TDTeamDto>(it)));
        
    }
    
}
