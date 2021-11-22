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

public sealed class ReviewRevisionsChangedEvent
     : FeedEvent, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "ReviewRevisionsChangedEvent";
    
    public ReviewRevisionsChangedEvent() { }
    
    public ReviewRevisionsChangedEvent(List<RepositoryCommitRecord> commits, ReviewRevisionsChangedType changeType, string? projectKey = null, CodeReviewRecord? review = null)
    {
        Commits = commits;
        ChangeType = changeType;
        ProjectKey = projectKey;
        Review = review;
    }
    
    private PropertyValue<List<RepositoryCommitRecord>> _commits = new PropertyValue<List<RepositoryCommitRecord>>(nameof(ReviewRevisionsChangedEvent), nameof(Commits), "commits", new List<RepositoryCommitRecord>());
    
    [Required]
    [JsonPropertyName("commits")]
    public List<RepositoryCommitRecord> Commits
    {
        get => _commits.GetValue(InlineErrors);
        set => _commits.SetValue(value);
    }

    private PropertyValue<ReviewRevisionsChangedType> _changeType = new PropertyValue<ReviewRevisionsChangedType>(nameof(ReviewRevisionsChangedEvent), nameof(ChangeType), "changeType");
    
    [Required]
    [JsonPropertyName("changeType")]
    public ReviewRevisionsChangedType ChangeType
    {
        get => _changeType.GetValue(InlineErrors);
        set => _changeType.SetValue(value);
    }

    private PropertyValue<string?> _projectKey = new PropertyValue<string?>(nameof(ReviewRevisionsChangedEvent), nameof(ProjectKey), "projectKey");
    
    [JsonPropertyName("projectKey")]
    public string? ProjectKey
    {
        get => _projectKey.GetValue(InlineErrors);
        set => _projectKey.SetValue(value);
    }

    private PropertyValue<CodeReviewRecord?> _review = new PropertyValue<CodeReviewRecord?>(nameof(ReviewRevisionsChangedEvent), nameof(Review), "review");
    
    [JsonPropertyName("review")]
    public CodeReviewRecord? Review
    {
        get => _review.GetValue(InlineErrors);
        set => _review.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _commits.SetAccessPath(parentChainPath, validateHasBeenSet);
        _changeType.SetAccessPath(parentChainPath, validateHasBeenSet);
        _projectKey.SetAccessPath(parentChainPath, validateHasBeenSet);
        _review.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

