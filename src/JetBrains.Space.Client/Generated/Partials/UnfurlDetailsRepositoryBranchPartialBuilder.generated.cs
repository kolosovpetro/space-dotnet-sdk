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

namespace JetBrains.Space.Client.UnfurlDetailsRepositoryBranchPartialBuilder
{
    public static class UnfurlDetailsRepositoryBranchPartialExtensions
    {
        public static Partial<UnfurlDetailsRepositoryBranch> WithProject(this Partial<UnfurlDetailsRepositoryBranch> it)
            => it.AddFieldName("project");
        
        public static Partial<UnfurlDetailsRepositoryBranch> WithProject(this Partial<UnfurlDetailsRepositoryBranch> it, Func<Partial<PRProject>, Partial<PRProject>> partialBuilder)
            => it.AddFieldName("project", partialBuilder(new Partial<PRProject>(it)));
        
        public static Partial<UnfurlDetailsRepositoryBranch> WithRepository(this Partial<UnfurlDetailsRepositoryBranch> it)
            => it.AddFieldName("repository");
        
        public static Partial<UnfurlDetailsRepositoryBranch> WithBranchHead(this Partial<UnfurlDetailsRepositoryBranch> it)
            => it.AddFieldName("branchHead");
        
        public static Partial<UnfurlDetailsRepositoryBranch> WithIsDeleted(this Partial<UnfurlDetailsRepositoryBranch> it)
            => it.AddFieldName("deleted");
        
    }
    
}
