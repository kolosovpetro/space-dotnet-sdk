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

namespace SpaceDotNet.Client.GitCommitChangeExtensions
{
    public static class GitCommitChangeDtoPartialExtensions
    {
        public static Partial<GitCommitChangeDto> WithChangeType(this Partial<GitCommitChangeDto> it)
            => it.AddFieldName("changeType");
        
        public static Partial<GitCommitChangeDto> WithOld(this Partial<GitCommitChangeDto> it)
            => it.AddFieldName("old");
        
        public static Partial<GitCommitChangeDto> WithOld(this Partial<GitCommitChangeDto> it, Func<Partial<GitFileDto>, Partial<GitFileDto>> partialBuilder)
            => it.AddFieldName("old", partialBuilder(new Partial<GitFileDto>()));
        
        public static Partial<GitCommitChangeDto> WithNew(this Partial<GitCommitChangeDto> it)
            => it.AddFieldName("new");
        
        public static Partial<GitCommitChangeDto> WithNew(this Partial<GitCommitChangeDto> it, Func<Partial<GitFileDto>, Partial<GitFileDto>> partialBuilder)
            => it.AddFieldName("new", partialBuilder(new Partial<GitFileDto>()));
        
        public static Partial<GitCommitChangeDto> WithRevision(this Partial<GitCommitChangeDto> it)
            => it.AddFieldName("revision");
        
        public static Partial<GitCommitChangeDto> WithDiffSize(this Partial<GitCommitChangeDto> it)
            => it.AddFieldName("diffSize");
        
        public static Partial<GitCommitChangeDto> WithDiffSize(this Partial<GitCommitChangeDto> it, Func<Partial<GitDiffSizeDto>, Partial<GitDiffSizeDto>> partialBuilder)
            => it.AddFieldName("diffSize", partialBuilder(new Partial<GitDiffSizeDto>()));
        
    }
    
}