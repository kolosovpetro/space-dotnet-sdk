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

public sealed class CommitInfo
     : IPropagatePropertyAccessPath
{
    public CommitInfo() { }
    
    public CommitInfo(PRProject project, string repository, string commitId, string message, DateTime commitDate, string authorName, string authorEmail, TDMemberProfile? authorProfile = null)
    {
        Project = project;
        Repository = repository;
        CommitId = commitId;
        Message = message;
        CommitDate = commitDate;
        AuthorName = authorName;
        AuthorEmail = authorEmail;
        AuthorProfile = authorProfile;
    }
    
    private PropertyValue<PRProject> _project = new PropertyValue<PRProject>(nameof(CommitInfo), nameof(Project), "project");
    
    [Required]
    [JsonPropertyName("project")]
    public PRProject Project
    {
        get => _project.GetValue(InlineErrors);
        set => _project.SetValue(value);
    }

    private PropertyValue<string> _repository = new PropertyValue<string>(nameof(CommitInfo), nameof(Repository), "repository");
    
    [Required]
    [JsonPropertyName("repository")]
    public string Repository
    {
        get => _repository.GetValue(InlineErrors);
        set => _repository.SetValue(value);
    }

    private PropertyValue<string> _commitId = new PropertyValue<string>(nameof(CommitInfo), nameof(CommitId), "commitId");
    
    [Required]
    [JsonPropertyName("commitId")]
    public string CommitId
    {
        get => _commitId.GetValue(InlineErrors);
        set => _commitId.SetValue(value);
    }

    private PropertyValue<string> _message = new PropertyValue<string>(nameof(CommitInfo), nameof(Message), "message");
    
    [Required]
    [JsonPropertyName("message")]
    public string Message
    {
        get => _message.GetValue(InlineErrors);
        set => _message.SetValue(value);
    }

    private PropertyValue<DateTime> _commitDate = new PropertyValue<DateTime>(nameof(CommitInfo), nameof(CommitDate), "commitDate");
    
    [Required]
    [JsonPropertyName("commitDate")]
    [JsonConverter(typeof(SpaceDateTimeConverter))]
    public DateTime CommitDate
    {
        get => _commitDate.GetValue(InlineErrors);
        set => _commitDate.SetValue(value);
    }

    private PropertyValue<string> _authorName = new PropertyValue<string>(nameof(CommitInfo), nameof(AuthorName), "authorName");
    
    [Required]
    [JsonPropertyName("authorName")]
    public string AuthorName
    {
        get => _authorName.GetValue(InlineErrors);
        set => _authorName.SetValue(value);
    }

    private PropertyValue<string> _authorEmail = new PropertyValue<string>(nameof(CommitInfo), nameof(AuthorEmail), "authorEmail");
    
    [Required]
    [JsonPropertyName("authorEmail")]
    public string AuthorEmail
    {
        get => _authorEmail.GetValue(InlineErrors);
        set => _authorEmail.SetValue(value);
    }

    private PropertyValue<TDMemberProfile?> _authorProfile = new PropertyValue<TDMemberProfile?>(nameof(CommitInfo), nameof(AuthorProfile), "authorProfile");
    
    [JsonPropertyName("authorProfile")]
    public TDMemberProfile? AuthorProfile
    {
        get => _authorProfile.GetValue(InlineErrors);
        set => _authorProfile.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _project.SetAccessPath(parentChainPath, validateHasBeenSet);
        _repository.SetAccessPath(parentChainPath, validateHasBeenSet);
        _commitId.SetAccessPath(parentChainPath, validateHasBeenSet);
        _message.SetAccessPath(parentChainPath, validateHasBeenSet);
        _commitDate.SetAccessPath(parentChainPath, validateHasBeenSet);
        _authorName.SetAccessPath(parentChainPath, validateHasBeenSet);
        _authorEmail.SetAccessPath(parentChainPath, validateHasBeenSet);
        _authorProfile.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

