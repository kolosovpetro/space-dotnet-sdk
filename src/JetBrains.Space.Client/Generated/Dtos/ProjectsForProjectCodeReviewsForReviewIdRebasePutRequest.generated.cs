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

public class ProjectsForProjectCodeReviewsForReviewIdRebasePutRequest
     : IPropagatePropertyAccessPath
{
    public ProjectsForProjectCodeReviewsForReviewIdRebasePutRequest() { }
    
    public ProjectsForProjectCodeReviewsForReviewIdRebasePutRequest(bool deleteSourceBranch, GitRebaseMode rebaseMode, bool squash, string? squashedCommitMessage = null)
    {
        IsDeleteSourceBranch = deleteSourceBranch;
        RebaseMode = rebaseMode;
        IsSquash = squash;
        SquashedCommitMessage = squashedCommitMessage;
    }
    
    private PropertyValue<bool> _deleteSourceBranch = new PropertyValue<bool>(nameof(ProjectsForProjectCodeReviewsForReviewIdRebasePutRequest), nameof(IsDeleteSourceBranch), "deleteSourceBranch");
    
    [Required]
    [JsonPropertyName("deleteSourceBranch")]
    public bool IsDeleteSourceBranch
    {
        get => _deleteSourceBranch.GetValue(InlineErrors);
        set => _deleteSourceBranch.SetValue(value);
    }

    private PropertyValue<GitRebaseMode> _rebaseMode = new PropertyValue<GitRebaseMode>(nameof(ProjectsForProjectCodeReviewsForReviewIdRebasePutRequest), nameof(RebaseMode), "rebaseMode");
    
    [Required]
    [JsonPropertyName("rebaseMode")]
    public GitRebaseMode RebaseMode
    {
        get => _rebaseMode.GetValue(InlineErrors);
        set => _rebaseMode.SetValue(value);
    }

    private PropertyValue<bool> _squash = new PropertyValue<bool>(nameof(ProjectsForProjectCodeReviewsForReviewIdRebasePutRequest), nameof(IsSquash), "squash");
    
    [Required]
    [JsonPropertyName("squash")]
    public bool IsSquash
    {
        get => _squash.GetValue(InlineErrors);
        set => _squash.SetValue(value);
    }

    private PropertyValue<string?> _squashedCommitMessage = new PropertyValue<string?>(nameof(ProjectsForProjectCodeReviewsForReviewIdRebasePutRequest), nameof(SquashedCommitMessage), "squashedCommitMessage");
    
    [JsonPropertyName("squashedCommitMessage")]
    public string? SquashedCommitMessage
    {
        get => _squashedCommitMessage.GetValue(InlineErrors);
        set => _squashedCommitMessage.SetValue(value);
    }

    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _deleteSourceBranch.SetAccessPath(parentChainPath, validateHasBeenSet);
        _rebaseMode.SetAccessPath(parentChainPath, validateHasBeenSet);
        _squash.SetAccessPath(parentChainPath, validateHasBeenSet);
        _squashedCommitMessage.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

