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

namespace SpaceDotNet.Client.ArticleDetailsRecordDtoPartialBuilder
{
    public static class ArticleDetailsRecordDtoPartialExtensions
    {
        public static Partial<ArticleDetailsRecordDto> WithId(this Partial<ArticleDetailsRecordDto> it)
            => it.AddFieldName("id");
        
        public static Partial<ArticleDetailsRecordDto> WithArchived(this Partial<ArticleDetailsRecordDto> it)
            => it.AddFieldName("archived");
        
        public static Partial<ArticleDetailsRecordDto> WithEvent(this Partial<ArticleDetailsRecordDto> it)
            => it.AddFieldName("event");
        
        public static Partial<ArticleDetailsRecordDto> WithEvent(this Partial<ArticleDetailsRecordDto> it, Func<Partial<MeetingRecordDto>, Partial<MeetingRecordDto>> partialBuilder)
            => it.AddFieldName("event", partialBuilder(new Partial<MeetingRecordDto>(it)));
        
        public static Partial<ArticleDetailsRecordDto> WithTeam(this Partial<ArticleDetailsRecordDto> it)
            => it.AddFieldName("team");
        
        public static Partial<ArticleDetailsRecordDto> WithTeam(this Partial<ArticleDetailsRecordDto> it, Func<Partial<TDTeamDto>, Partial<TDTeamDto>> partialBuilder)
            => it.AddFieldName("team", partialBuilder(new Partial<TDTeamDto>(it)));
        
        public static Partial<ArticleDetailsRecordDto> WithProject(this Partial<ArticleDetailsRecordDto> it)
            => it.AddFieldName("project");
        
        public static Partial<ArticleDetailsRecordDto> WithProject(this Partial<ArticleDetailsRecordDto> it, Func<Partial<PRProjectDto>, Partial<PRProjectDto>> partialBuilder)
            => it.AddFieldName("project", partialBuilder(new Partial<PRProjectDto>(it)));
        
        public static Partial<ArticleDetailsRecordDto> WithLocation(this Partial<ArticleDetailsRecordDto> it)
            => it.AddFieldName("location");
        
        public static Partial<ArticleDetailsRecordDto> WithLocation(this Partial<ArticleDetailsRecordDto> it, Func<Partial<TDLocationDto>, Partial<TDLocationDto>> partialBuilder)
            => it.AddFieldName("location", partialBuilder(new Partial<TDLocationDto>(it)));
        
        public static Partial<ArticleDetailsRecordDto> WithTeams(this Partial<ArticleDetailsRecordDto> it)
            => it.AddFieldName("teams");
        
        public static Partial<ArticleDetailsRecordDto> WithTeams(this Partial<ArticleDetailsRecordDto> it, Func<Partial<TDTeamDto>, Partial<TDTeamDto>> partialBuilder)
            => it.AddFieldName("teams", partialBuilder(new Partial<TDTeamDto>(it)));
        
        public static Partial<ArticleDetailsRecordDto> WithLocations(this Partial<ArticleDetailsRecordDto> it)
            => it.AddFieldName("locations");
        
        public static Partial<ArticleDetailsRecordDto> WithLocations(this Partial<ArticleDetailsRecordDto> it, Func<Partial<TDLocationDto>, Partial<TDLocationDto>> partialBuilder)
            => it.AddFieldName("locations", partialBuilder(new Partial<TDLocationDto>(it)));
        
        public static Partial<ArticleDetailsRecordDto> WithExternalEntityInfo(this Partial<ArticleDetailsRecordDto> it)
            => it.AddFieldName("externalEntityInfo");
        
        public static Partial<ArticleDetailsRecordDto> WithExternalEntityInfo(this Partial<ArticleDetailsRecordDto> it, Func<Partial<ExternalEntityInfoRecordDto>, Partial<ExternalEntityInfoRecordDto>> partialBuilder)
            => it.AddFieldName("externalEntityInfo", partialBuilder(new Partial<ExternalEntityInfoRecordDto>(it)));
        
    }
    
}
