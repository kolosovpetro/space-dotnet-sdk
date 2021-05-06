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

namespace JetBrains.Space.Client.GitCommitInfoWithChangesPartialBuilder
{
    public static class GitCommitInfoWithChangesPartialExtensions
    {
        public static Partial<GitCommitInfoWithChanges> WithCommit(this Partial<GitCommitInfoWithChanges> it)
            => it.AddFieldName("commit");
        
        public static Partial<GitCommitInfoWithChanges> WithCommit(this Partial<GitCommitInfoWithChanges> it, Func<Partial<GitCommitInfo>, Partial<GitCommitInfo>> partialBuilder)
            => it.AddFieldName("commit", partialBuilder(new Partial<GitCommitInfo>(it)));
        
        public static Partial<GitCommitInfoWithChanges> WithChanges(this Partial<GitCommitInfoWithChanges> it)
            => it.AddFieldName("changes");
        
        public static Partial<GitCommitInfoWithChanges> WithChanges(this Partial<GitCommitInfoWithChanges> it, Func<Partial<GitCommitChanges>, Partial<GitCommitChanges>> partialBuilder)
            => it.AddFieldName("changes", partialBuilder(new Partial<GitCommitChanges>(it)));
        
    }
    
}
