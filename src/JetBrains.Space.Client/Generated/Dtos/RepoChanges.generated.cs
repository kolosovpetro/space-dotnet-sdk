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

namespace JetBrains.Space.Client;

public sealed class RepoChanges
     : IPropagatePropertyAccessPath
{
    public RepoChanges() { }
    
    public RepoChanges(List<RepoHeadsChange> heads, List<GitCommitInfoWithChanges> commits, int totalNewCommits)
    {
        Heads = heads;
        Commits = commits;
        TotalNewCommits = totalNewCommits;
    }
    
    private PropertyValue<List<RepoHeadsChange>> _heads = new PropertyValue<List<RepoHeadsChange>>(nameof(RepoChanges), nameof(Heads), "heads", new List<RepoHeadsChange>());
    
    [Required]
    [JsonPropertyName("heads")]
    public List<RepoHeadsChange> Heads
    {
        get => _heads.GetValue(InlineErrors);
        set => _heads.SetValue(value);
    }

    private PropertyValue<List<GitCommitInfoWithChanges>> _commits = new PropertyValue<List<GitCommitInfoWithChanges>>(nameof(RepoChanges), nameof(Commits), "commits", new List<GitCommitInfoWithChanges>());
    
    [Required]
    [JsonPropertyName("commits")]
    public List<GitCommitInfoWithChanges> Commits
    {
        get => _commits.GetValue(InlineErrors);
        set => _commits.SetValue(value);
    }

    private PropertyValue<int> _totalNewCommits = new PropertyValue<int>(nameof(RepoChanges), nameof(TotalNewCommits), "totalNewCommits");
    
    [Required]
    [JsonPropertyName("totalNewCommits")]
    public int TotalNewCommits
    {
        get => _totalNewCommits.GetValue(InlineErrors);
        set => _totalNewCommits.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _heads.SetAccessPath(parentChainPath, validateHasBeenSet);
        _commits.SetAccessPath(parentChainPath, validateHasBeenSet);
        _totalNewCommits.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

