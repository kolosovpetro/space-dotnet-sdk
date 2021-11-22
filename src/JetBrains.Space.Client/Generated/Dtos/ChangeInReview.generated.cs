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

public sealed class ChangeInReview
     : IPropagatePropertyAccessPath
{
    public ChangeInReview() { }
    
    public ChangeInReview(string repository, GitCommitChange change, bool read)
    {
        Repository = repository;
        Change = change;
        IsRead = read;
    }
    
    private PropertyValue<string> _repository = new PropertyValue<string>(nameof(ChangeInReview), nameof(Repository), "repository");
    
    [Required]
    [JsonPropertyName("repository")]
    public string Repository
    {
        get => _repository.GetValue(InlineErrors);
        set => _repository.SetValue(value);
    }

    private PropertyValue<GitCommitChange> _change = new PropertyValue<GitCommitChange>(nameof(ChangeInReview), nameof(Change), "change");
    
    [Required]
    [JsonPropertyName("change")]
    public GitCommitChange Change
    {
        get => _change.GetValue(InlineErrors);
        set => _change.SetValue(value);
    }

    private PropertyValue<bool> _read = new PropertyValue<bool>(nameof(ChangeInReview), nameof(IsRead), "read");
    
    [Required]
    [JsonPropertyName("read")]
    public bool IsRead
    {
        get => _read.GetValue(InlineErrors);
        set => _read.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _repository.SetAccessPath(parentChainPath, validateHasBeenSet);
        _change.SetAccessPath(parentChainPath, validateHasBeenSet);
        _read.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

