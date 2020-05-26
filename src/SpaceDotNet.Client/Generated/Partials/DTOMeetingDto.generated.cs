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

namespace SpaceDotNet.Client.DTOMeetingExtensions
{
    public static class DTOMeetingDtoPartialExtensions
    {
        public static Partial<DTOMeetingDto> WithId(this Partial<DTOMeetingDto> it)
            => it.AddFieldName("id");
        
        public static Partial<DTOMeetingDto> WithArchived(this Partial<DTOMeetingDto> it)
            => it.AddFieldName("archived");
        
        public static Partial<DTOMeetingDto> WithSummary(this Partial<DTOMeetingDto> it)
            => it.AddFieldName("summary");
        
        public static Partial<DTOMeetingDto> WithDescription(this Partial<DTOMeetingDto> it)
            => it.AddFieldName("description");
        
        public static Partial<DTOMeetingDto> WithLocations(this Partial<DTOMeetingDto> it)
            => it.AddFieldName("locations");
        
        public static Partial<DTOMeetingDto> WithLocations(this Partial<DTOMeetingDto> it, Func<Partial<TDLocationDto>, Partial<TDLocationDto>> partialBuilder)
            => it.AddFieldName("locations", partialBuilder(new Partial<TDLocationDto>()));
        
        public static Partial<DTOMeetingDto> WithProfiles(this Partial<DTOMeetingDto> it)
            => it.AddFieldName("profiles");
        
        public static Partial<DTOMeetingDto> WithProfiles(this Partial<DTOMeetingDto> it, Func<Partial<TDMemberProfileDto>, Partial<TDMemberProfileDto>> partialBuilder)
            => it.AddFieldName("profiles", partialBuilder(new Partial<TDMemberProfileDto>()));
        
        public static Partial<DTOMeetingDto> WithTeams(this Partial<DTOMeetingDto> it)
            => it.AddFieldName("teams");
        
        public static Partial<DTOMeetingDto> WithTeams(this Partial<DTOMeetingDto> it, Func<Partial<TDTeamDto>, Partial<TDTeamDto>> partialBuilder)
            => it.AddFieldName("teams", partialBuilder(new Partial<TDTeamDto>()));
        
        public static Partial<DTOMeetingDto> WithOccurrenceRule(this Partial<DTOMeetingDto> it)
            => it.AddFieldName("occurrenceRule");
        
        public static Partial<DTOMeetingDto> WithOccurrenceRule(this Partial<DTOMeetingDto> it, Func<Partial<CalendarEventSpecDto>, Partial<CalendarEventSpecDto>> partialBuilder)
            => it.AddFieldName("occurrenceRule", partialBuilder(new Partial<CalendarEventSpecDto>()));
        
        public static Partial<DTOMeetingDto> WithOrigin(this Partial<DTOMeetingDto> it)
            => it.AddFieldName("origin");
        
        public static Partial<DTOMeetingDto> WithConferenceLink(this Partial<DTOMeetingDto> it)
            => it.AddFieldName("conferenceLink");
        
        public static Partial<DTOMeetingDto> WithVisibility(this Partial<DTOMeetingDto> it)
            => it.AddFieldName("visibility");
        
        public static Partial<DTOMeetingDto> WithModificationPreference(this Partial<DTOMeetingDto> it)
            => it.AddFieldName("modificationPreference");
        
        public static Partial<DTOMeetingDto> WithJoiningPreference(this Partial<DTOMeetingDto> it)
            => it.AddFieldName("joiningPreference");
        
        public static Partial<DTOMeetingDto> WithOrganizer(this Partial<DTOMeetingDto> it)
            => it.AddFieldName("organizer");
        
        public static Partial<DTOMeetingDto> WithOrganizer(this Partial<DTOMeetingDto> it, Func<Partial<MeetingOrganizerDto>, Partial<MeetingOrganizerDto>> partialBuilder)
            => it.AddFieldName("organizer", partialBuilder(new Partial<MeetingOrganizerDto>()));
        
        public static Partial<DTOMeetingDto> WithEtag(this Partial<DTOMeetingDto> it)
            => it.AddFieldName("etag");
        
        public static Partial<DTOMeetingDto> WithPrivateDataSubstituted(this Partial<DTOMeetingDto> it)
            => it.AddFieldName("privateDataSubstituted");
        
        public static Partial<DTOMeetingDto> WithCanModify(this Partial<DTOMeetingDto> it)
            => it.AddFieldName("canModify");
        
        public static Partial<DTOMeetingDto> WithCanDelete(this Partial<DTOMeetingDto> it)
            => it.AddFieldName("canDelete");
        
        public static Partial<DTOMeetingDto> WithCanJoin(this Partial<DTOMeetingDto> it)
            => it.AddFieldName("canJoin");
        
        public static Partial<DTOMeetingDto> WithExternalParticipants(this Partial<DTOMeetingDto> it)
            => it.AddFieldName("externalParticipants");
        
        public static Partial<DTOMeetingDto> WithLinkToExternalSource(this Partial<DTOMeetingDto> it)
            => it.AddFieldName("linkToExternalSource");
        
        public static Partial<DTOMeetingDto> WithEventAttachments(this Partial<DTOMeetingDto> it)
            => it.AddFieldName("eventAttachments");
        
        public static Partial<DTOMeetingDto> WithEventAttachments(this Partial<DTOMeetingDto> it, Func<Partial<MeetingAttachmentDto>, Partial<MeetingAttachmentDto>> partialBuilder)
            => it.AddFieldName("eventAttachments", partialBuilder(new Partial<MeetingAttachmentDto>()));
        
    }
    
}
