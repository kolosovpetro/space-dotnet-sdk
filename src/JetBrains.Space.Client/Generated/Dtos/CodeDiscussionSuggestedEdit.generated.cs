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

public sealed class CodeDiscussionSuggestedEdit
     : IPropagatePropertyAccessPath
{
    public CodeDiscussionSuggestedEdit() { }
    
    public CodeDiscussionSuggestedEdit(string suggestionCommitId, string filePath, bool hasConflicts, int startLineIndex, int endLineIndexInclusive, CodeDiscussionSuggestedEditState? status = null, CPrincipal? resolvedBy = null)
    {
        SuggestionCommitId = suggestionCommitId;
        Status = status;
        ResolvedBy = resolvedBy;
        FilePath = filePath;
        IsHasConflicts = hasConflicts;
        StartLineIndex = startLineIndex;
        EndLineIndexInclusive = endLineIndexInclusive;
    }
    
    private PropertyValue<string> _suggestionCommitId = new PropertyValue<string>(nameof(CodeDiscussionSuggestedEdit), nameof(SuggestionCommitId));
    
    [Required]
    [JsonPropertyName("suggestionCommitId")]
    public string SuggestionCommitId
    {
        get => _suggestionCommitId.GetValue();
        set => _suggestionCommitId.SetValue(value);
    }

    private PropertyValue<CodeDiscussionSuggestedEditState?> _status = new PropertyValue<CodeDiscussionSuggestedEditState?>(nameof(CodeDiscussionSuggestedEdit), nameof(Status));
    
    [JsonPropertyName("status")]
    public CodeDiscussionSuggestedEditState? Status
    {
        get => _status.GetValue();
        set => _status.SetValue(value);
    }

    private PropertyValue<CPrincipal?> _resolvedBy = new PropertyValue<CPrincipal?>(nameof(CodeDiscussionSuggestedEdit), nameof(ResolvedBy));
    
    [JsonPropertyName("resolvedBy")]
    public CPrincipal? ResolvedBy
    {
        get => _resolvedBy.GetValue();
        set => _resolvedBy.SetValue(value);
    }

    private PropertyValue<string> _filePath = new PropertyValue<string>(nameof(CodeDiscussionSuggestedEdit), nameof(FilePath));
    
    [Required]
    [JsonPropertyName("filePath")]
    public string FilePath
    {
        get => _filePath.GetValue();
        set => _filePath.SetValue(value);
    }

    private PropertyValue<bool> _hasConflicts = new PropertyValue<bool>(nameof(CodeDiscussionSuggestedEdit), nameof(IsHasConflicts));
    
    [Required]
    [JsonPropertyName("hasConflicts")]
    public bool IsHasConflicts
    {
        get => _hasConflicts.GetValue();
        set => _hasConflicts.SetValue(value);
    }

    private PropertyValue<int> _startLineIndex = new PropertyValue<int>(nameof(CodeDiscussionSuggestedEdit), nameof(StartLineIndex));
    
    [Required]
    [JsonPropertyName("startLineIndex")]
    public int StartLineIndex
    {
        get => _startLineIndex.GetValue();
        set => _startLineIndex.SetValue(value);
    }

    private PropertyValue<int> _endLineIndexInclusive = new PropertyValue<int>(nameof(CodeDiscussionSuggestedEdit), nameof(EndLineIndexInclusive));
    
    [Required]
    [JsonPropertyName("endLineIndexInclusive")]
    public int EndLineIndexInclusive
    {
        get => _endLineIndexInclusive.GetValue();
        set => _endLineIndexInclusive.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _suggestionCommitId.SetAccessPath(path, validateHasBeenSet);
        _status.SetAccessPath(path, validateHasBeenSet);
        _resolvedBy.SetAccessPath(path, validateHasBeenSet);
        _filePath.SetAccessPath(path, validateHasBeenSet);
        _hasConflicts.SetAccessPath(path, validateHasBeenSet);
        _startLineIndex.SetAccessPath(path, validateHasBeenSet);
        _endLineIndexInclusive.SetAccessPath(path, validateHasBeenSet);
    }

}

