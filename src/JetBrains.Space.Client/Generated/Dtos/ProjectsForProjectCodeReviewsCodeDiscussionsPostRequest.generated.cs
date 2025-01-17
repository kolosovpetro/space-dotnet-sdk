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

public class ProjectsForProjectCodeReviewsCodeDiscussionsPostRequest
     : IPropagatePropertyAccessPath
{
    public ProjectsForProjectCodeReviewsCodeDiscussionsPostRequest() { }
    
    public ProjectsForProjectCodeReviewsCodeDiscussionsPostRequest(string text, string repository, string revision, bool pending = false, DiffContext? diffContext = null, string? filename = null, int? line = null, int? oldLine = null, ReviewIdentifier? reviewId = null)
    {
        Text = text;
        DiffContext = diffContext;
        Repository = repository;
        Revision = revision;
        Filename = filename;
        Line = line;
        OldLine = oldLine;
        IsPending = pending;
        ReviewId = reviewId;
    }
    
    private PropertyValue<string> _text = new PropertyValue<string>(nameof(ProjectsForProjectCodeReviewsCodeDiscussionsPostRequest), nameof(Text), "text");
    
    [Required]
    [JsonPropertyName("text")]
    public string Text
    {
        get => _text.GetValue(InlineErrors);
        set => _text.SetValue(value);
    }

    private PropertyValue<DiffContext?> _diffContext = new PropertyValue<DiffContext?>(nameof(ProjectsForProjectCodeReviewsCodeDiscussionsPostRequest), nameof(DiffContext), "diffContext");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("diffContext")]
    public DiffContext? DiffContext
    {
        get => _diffContext.GetValue(InlineErrors);
        set => _diffContext.SetValue(value);
    }

    private PropertyValue<string> _repository = new PropertyValue<string>(nameof(ProjectsForProjectCodeReviewsCodeDiscussionsPostRequest), nameof(Repository), "repository");
    
    [Required]
    [JsonPropertyName("repository")]
    public string Repository
    {
        get => _repository.GetValue(InlineErrors);
        set => _repository.SetValue(value);
    }

    private PropertyValue<string> _revision = new PropertyValue<string>(nameof(ProjectsForProjectCodeReviewsCodeDiscussionsPostRequest), nameof(Revision), "revision");
    
    [Required]
    [JsonPropertyName("revision")]
    public string Revision
    {
        get => _revision.GetValue(InlineErrors);
        set => _revision.SetValue(value);
    }

    private PropertyValue<string?> _filename = new PropertyValue<string?>(nameof(ProjectsForProjectCodeReviewsCodeDiscussionsPostRequest), nameof(Filename), "filename");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("filename")]
    public string? Filename
    {
        get => _filename.GetValue(InlineErrors);
        set => _filename.SetValue(value);
    }

    private PropertyValue<int?> _line = new PropertyValue<int?>(nameof(ProjectsForProjectCodeReviewsCodeDiscussionsPostRequest), nameof(Line), "line");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("line")]
    public int? Line
    {
        get => _line.GetValue(InlineErrors);
        set => _line.SetValue(value);
    }

    private PropertyValue<int?> _oldLine = new PropertyValue<int?>(nameof(ProjectsForProjectCodeReviewsCodeDiscussionsPostRequest), nameof(OldLine), "oldLine");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("oldLine")]
    public int? OldLine
    {
        get => _oldLine.GetValue(InlineErrors);
        set => _oldLine.SetValue(value);
    }

    private PropertyValue<bool> _pending = new PropertyValue<bool>(nameof(ProjectsForProjectCodeReviewsCodeDiscussionsPostRequest), nameof(IsPending), "pending");
    
    [JsonPropertyName("pending")]
    public bool IsPending
    {
        get => _pending.GetValue(InlineErrors);
        set => _pending.SetValue(value);
    }

    private PropertyValue<ReviewIdentifier?> _reviewId = new PropertyValue<ReviewIdentifier?>(nameof(ProjectsForProjectCodeReviewsCodeDiscussionsPostRequest), nameof(ReviewId), "reviewId");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("reviewId")]
    public ReviewIdentifier? ReviewId
    {
        get => _reviewId.GetValue(InlineErrors);
        set => _reviewId.SetValue(value);
    }

    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _text.SetAccessPath(parentChainPath, validateHasBeenSet);
        _diffContext.SetAccessPath(parentChainPath, validateHasBeenSet);
        _repository.SetAccessPath(parentChainPath, validateHasBeenSet);
        _revision.SetAccessPath(parentChainPath, validateHasBeenSet);
        _filename.SetAccessPath(parentChainPath, validateHasBeenSet);
        _line.SetAccessPath(parentChainPath, validateHasBeenSet);
        _oldLine.SetAccessPath(parentChainPath, validateHasBeenSet);
        _pending.SetAccessPath(parentChainPath, validateHasBeenSet);
        _reviewId.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

