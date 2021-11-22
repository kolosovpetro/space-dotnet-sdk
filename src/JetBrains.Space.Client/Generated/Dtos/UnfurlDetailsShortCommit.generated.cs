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

public sealed class UnfurlDetailsShortCommit
     : UnfurlDetails, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "UnfurlDetailsShortCommit";
    
    public UnfurlDetailsShortCommit() { }
    
    public UnfurlDetailsShortCommit(PRProject project, string repository, string commitId, string message, bool strikeThrough)
    {
        Project = project;
        Repository = repository;
        CommitId = commitId;
        Message = message;
        IsStrikeThrough = strikeThrough;
    }
    
    private PropertyValue<PRProject> _project = new PropertyValue<PRProject>(nameof(UnfurlDetailsShortCommit), nameof(Project), "project");
    
    [Required]
    [JsonPropertyName("project")]
    public PRProject Project
    {
        get => _project.GetValue(InlineErrors);
        set => _project.SetValue(value);
    }

    private PropertyValue<string> _repository = new PropertyValue<string>(nameof(UnfurlDetailsShortCommit), nameof(Repository), "repository");
    
    [Required]
    [JsonPropertyName("repository")]
    public string Repository
    {
        get => _repository.GetValue(InlineErrors);
        set => _repository.SetValue(value);
    }

    private PropertyValue<string> _commitId = new PropertyValue<string>(nameof(UnfurlDetailsShortCommit), nameof(CommitId), "commitId");
    
    [Required]
    [JsonPropertyName("commitId")]
    public string CommitId
    {
        get => _commitId.GetValue(InlineErrors);
        set => _commitId.SetValue(value);
    }

    private PropertyValue<string> _message = new PropertyValue<string>(nameof(UnfurlDetailsShortCommit), nameof(Message), "message");
    
    [Required]
    [JsonPropertyName("message")]
    public string Message
    {
        get => _message.GetValue(InlineErrors);
        set => _message.SetValue(value);
    }

    private PropertyValue<bool> _strikeThrough = new PropertyValue<bool>(nameof(UnfurlDetailsShortCommit), nameof(IsStrikeThrough), "strikeThrough");
    
    [Required]
    [JsonPropertyName("strikeThrough")]
    public bool IsStrikeThrough
    {
        get => _strikeThrough.GetValue(InlineErrors);
        set => _strikeThrough.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _project.SetAccessPath(parentChainPath, validateHasBeenSet);
        _repository.SetAccessPath(parentChainPath, validateHasBeenSet);
        _commitId.SetAccessPath(parentChainPath, validateHasBeenSet);
        _message.SetAccessPath(parentChainPath, validateHasBeenSet);
        _strikeThrough.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

