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

namespace SpaceDotNet.Client.TrackedBranchesInReviewDtoPartialBuilder
{
    public static class TrackedBranchesInReviewDtoPartialExtensions
    {
        public static Partial<TrackedBranchesInReviewDto> WithRepository(this Partial<TrackedBranchesInReviewDto> it)
            => it.AddFieldName("repository");
        
        public static Partial<TrackedBranchesInReviewDto> WithBranches(this Partial<TrackedBranchesInReviewDto> it)
            => it.AddFieldName("branches");
        
        public static Partial<TrackedBranchesInReviewDto> WithBranches(this Partial<TrackedBranchesInReviewDto> it, Func<Partial<BranchInfoDto>, Partial<BranchInfoDto>> partialBuilder)
            => it.AddFieldName("branches", partialBuilder(new Partial<BranchInfoDto>(it)));
        
    }
    
}
