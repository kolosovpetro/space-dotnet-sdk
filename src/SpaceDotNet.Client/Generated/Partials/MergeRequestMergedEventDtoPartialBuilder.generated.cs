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

namespace SpaceDotNet.Client.MergeRequestMergedEventDtoPartialBuilder
{
    public static class MergeRequestMergedEventDtoPartialExtensions
    {
        public static Partial<MergeRequestMergedEventDto> WithRepository(this Partial<MergeRequestMergedEventDto> it)
            => it.AddFieldName("repository");
        
        public static Partial<MergeRequestMergedEventDto> WithSourceBranch(this Partial<MergeRequestMergedEventDto> it)
            => it.AddFieldName("sourceBranch");
        
        public static Partial<MergeRequestMergedEventDto> WithTargetBranch(this Partial<MergeRequestMergedEventDto> it)
            => it.AddFieldName("targetBranch");
        
    }
    
}
