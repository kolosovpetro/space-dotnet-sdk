// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS1591
#pragma warning disable CS0108
#pragma warning disable 618

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client.TeamDirectoryCalendarEventsMeetingParticipationsForIdPatchRequestPartialBuilder
{
    public static class TeamDirectoryCalendarEventsMeetingParticipationsForIdPatchRequestPartialExtensions
    {
        public static Partial<TeamDirectoryCalendarEventsMeetingParticipationsForIdPatchRequest> WithNewStatus(this Partial<TeamDirectoryCalendarEventsMeetingParticipationsForIdPatchRequest> it)
            => it.AddFieldName("newStatus");
        
        public static Partial<TeamDirectoryCalendarEventsMeetingParticipationsForIdPatchRequest> WithNewStatus(this Partial<TeamDirectoryCalendarEventsMeetingParticipationsForIdPatchRequest> it, Func<Partial<EventParticipationStatus>, Partial<EventParticipationStatus>> partialBuilder)
            => it.AddFieldName("newStatus", partialBuilder(new Partial<EventParticipationStatus>(it)));
        
    }
    
}
