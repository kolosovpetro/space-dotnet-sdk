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

namespace SpaceDotNet.Client.MergeRequestBranchRestoredEventDtoPartialBuilder
{
    public static class MergeRequestBranchRestoredEventDtoPartialExtensions
    {
        public static Partial<MergeRequestBranchRestoredEventDto> WithRepository(this Partial<MergeRequestBranchRestoredEventDto> it)
            => it.AddFieldName("repository");
        
        public static Partial<MergeRequestBranchRestoredEventDto> WithBranch(this Partial<MergeRequestBranchRestoredEventDto> it)
            => it.AddFieldName("branch");
        
        public static Partial<MergeRequestBranchRestoredEventDto> WithBranchType(this Partial<MergeRequestBranchRestoredEventDto> it)
            => it.AddFieldName("branchType");
        
        public static Partial<MergeRequestBranchRestoredEventDto> WithBranchType(this Partial<MergeRequestBranchRestoredEventDto> it, Func<Partial<MergeRequestBranchType>, Partial<MergeRequestBranchType>> partialBuilder)
            => it.AddFieldName("branchType", partialBuilder(new Partial<MergeRequestBranchType>(it)));
        
    }
    
}
