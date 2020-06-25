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

namespace SpaceDotNet.Client.CodeReviewDetailedInfoDtoPartialBuilder
{
    public static class CodeReviewDetailedInfoDtoPartialExtensions
    {
        public static Partial<CodeReviewDetailedInfoDto> WithShortInfo(this Partial<CodeReviewDetailedInfoDto> it)
            => it.AddFieldName("shortInfo");
        
        public static Partial<CodeReviewDetailedInfoDto> WithShortInfo(this Partial<CodeReviewDetailedInfoDto> it, Func<Partial<CodeReviewRecordDto>, Partial<CodeReviewRecordDto>> partialBuilder)
            => it.AddFieldName("shortInfo", partialBuilder(new Partial<CodeReviewRecordDto>(it)));
        
        public static Partial<CodeReviewDetailedInfoDto> WithCommits(this Partial<CodeReviewDetailedInfoDto> it)
            => it.AddFieldName("commits");
        
        public static Partial<CodeReviewDetailedInfoDto> WithCommits(this Partial<CodeReviewDetailedInfoDto> it, Func<Partial<RevisionsInReviewDto>, Partial<RevisionsInReviewDto>> partialBuilder)
            => it.AddFieldName("commits", partialBuilder(new Partial<RevisionsInReviewDto>(it)));
        
        public static Partial<CodeReviewDetailedInfoDto> WithLostCommits(this Partial<CodeReviewDetailedInfoDto> it)
            => it.AddFieldName("lostCommits");
        
        public static Partial<CodeReviewDetailedInfoDto> WithLostCommits(this Partial<CodeReviewDetailedInfoDto> it, Func<Partial<RevisionsInReviewDto>, Partial<RevisionsInReviewDto>> partialBuilder)
            => it.AddFieldName("lostCommits", partialBuilder(new Partial<RevisionsInReviewDto>(it)));
        
        public static Partial<CodeReviewDetailedInfoDto> WithDiscussionCounter(this Partial<CodeReviewDetailedInfoDto> it)
            => it.AddFieldName("discussionCounter");
        
        public static Partial<CodeReviewDetailedInfoDto> WithDiscussionCounter(this Partial<CodeReviewDetailedInfoDto> it, Func<Partial<CodeReviewDiscussionCounterDto>, Partial<CodeReviewDiscussionCounterDto>> partialBuilder)
            => it.AddFieldName("discussionCounter", partialBuilder(new Partial<CodeReviewDiscussionCounterDto>(it)));
        
        public static Partial<CodeReviewDetailedInfoDto> WithBranches(this Partial<CodeReviewDetailedInfoDto> it)
            => it.AddFieldName("branches");
        
        public static Partial<CodeReviewDetailedInfoDto> WithBranches(this Partial<CodeReviewDetailedInfoDto> it, Func<Partial<TrackedBranchesInReviewDto>, Partial<TrackedBranchesInReviewDto>> partialBuilder)
            => it.AddFieldName("branches", partialBuilder(new Partial<TrackedBranchesInReviewDto>(it)));
        
    }
    
}