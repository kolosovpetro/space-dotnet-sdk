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

namespace SpaceDotNet.Client.RevisionsInReviewDtoPartialBuilder
{
    public static class RevisionsInReviewDtoPartialExtensions
    {
        public static Partial<RevisionsInReviewDto> WithRepository(this Partial<RevisionsInReviewDto> it)
            => it.AddFieldName("repository");
        
        public static Partial<RevisionsInReviewDto> WithRepository(this Partial<RevisionsInReviewDto> it, Func<Partial<RepositoryInReviewDto>, Partial<RepositoryInReviewDto>> partialBuilder)
            => it.AddFieldName("repository", partialBuilder(new Partial<RepositoryInReviewDto>(it)));
        
        public static Partial<RevisionsInReviewDto> WithCommits(this Partial<RevisionsInReviewDto> it)
            => it.AddFieldName("commits");
        
        public static Partial<RevisionsInReviewDto> WithCommits(this Partial<RevisionsInReviewDto> it, Func<Partial<GitCommitWithGraphDto>, Partial<GitCommitWithGraphDto>> partialBuilder)
            => it.AddFieldName("commits", partialBuilder(new Partial<GitCommitWithGraphDto>(it)));
        
    }
    
}
