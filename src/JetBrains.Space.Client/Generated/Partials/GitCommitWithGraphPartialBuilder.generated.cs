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
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client.GitCommitWithGraphPartialBuilder;

public static class GitCommitWithGraphPartialExtensions
{
    public static Partial<GitCommitWithGraph> WithRepositoryName(this Partial<GitCommitWithGraph> it)
        => it.AddFieldName("repositoryName");
    
    public static Partial<GitCommitWithGraph> WithCommit(this Partial<GitCommitWithGraph> it)
        => it.AddFieldName("commit");
    
    public static Partial<GitCommitWithGraph> WithCommit(this Partial<GitCommitWithGraph> it, Func<Partial<GitCommitInfo>, Partial<GitCommitInfo>> partialBuilder)
        => it.AddFieldName("commit", partialBuilder(new Partial<GitCommitInfo>(it)));
    
    public static Partial<GitCommitWithGraph> WithCommitMessageUnfurls(this Partial<GitCommitWithGraph> it)
        => it.AddFieldName("commitMessageUnfurls");
    
    public static Partial<GitCommitWithGraph> WithCommitMessageUnfurls(this Partial<GitCommitWithGraph> it, Func<Partial<Unfurl>, Partial<Unfurl>> partialBuilder)
        => it.AddFieldName("commitMessageUnfurls", partialBuilder(new Partial<Unfurl>(it)));
    
    public static Partial<GitCommitWithGraph> WithReviews(this Partial<GitCommitWithGraph> it)
        => it.AddFieldName("reviews");
    
    public static Partial<GitCommitWithGraph> WithReviews(this Partial<GitCommitWithGraph> it, Func<Partial<CodeReviewRecord>, Partial<CodeReviewRecord>> partialBuilder)
        => it.AddFieldName("reviews", partialBuilder(new Partial<CodeReviewRecord>(it)));
    
    public static Partial<GitCommitWithGraph> WithIssueIds(this Partial<GitCommitWithGraph> it)
        => it.AddFieldName("issueIds");
    
    public static Partial<GitCommitWithGraph> WithDeployments(this Partial<GitCommitWithGraph> it)
        => it.AddFieldName("deployments");
    
    public static Partial<GitCommitWithGraph> WithLayout(this Partial<GitCommitWithGraph> it)
        => it.AddFieldName("layout");
    
    public static Partial<GitCommitWithGraph> WithLayout(this Partial<GitCommitWithGraph> it, Func<Partial<GitGraphLayoutLine>, Partial<GitGraphLayoutLine>> partialBuilder)
        => it.AddFieldName("layout", partialBuilder(new Partial<GitGraphLayoutLine>(it)));
    
    public static Partial<GitCommitWithGraph> WithIsUnreachable(this Partial<GitCommitWithGraph> it)
        => it.AddFieldName("unreachable");
    
}

