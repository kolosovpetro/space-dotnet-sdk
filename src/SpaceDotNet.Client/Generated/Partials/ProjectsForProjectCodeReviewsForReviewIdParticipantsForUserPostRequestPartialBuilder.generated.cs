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

namespace SpaceDotNet.Client.ProjectsForProjectCodeReviewsForReviewIdParticipantsForUserPostRequestPartialBuilder
{
    public static class ProjectsForProjectCodeReviewsForReviewIdParticipantsForUserPostRequestPartialExtensions
    {
        public static Partial<ProjectsForProjectCodeReviewsForReviewIdParticipantsForUserPostRequest> WithRole(this Partial<ProjectsForProjectCodeReviewsForReviewIdParticipantsForUserPostRequest> it)
            => it.AddFieldName("role");
        
        public static Partial<ProjectsForProjectCodeReviewsForReviewIdParticipantsForUserPostRequest> WithRole(this Partial<ProjectsForProjectCodeReviewsForReviewIdParticipantsForUserPostRequest> it, Func<Partial<CodeReviewParticipantRole>, Partial<CodeReviewParticipantRole>> partialBuilder)
            => it.AddFieldName("role", partialBuilder(new Partial<CodeReviewParticipantRole>(it)));
        
    }
    
}
