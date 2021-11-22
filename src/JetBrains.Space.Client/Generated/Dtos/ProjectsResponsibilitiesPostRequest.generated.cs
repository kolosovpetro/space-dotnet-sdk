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

public class ProjectsResponsibilitiesPostRequest
     : IPropagatePropertyAccessPath
{
    public ProjectsResponsibilitiesPostRequest() { }
    
    public ProjectsResponsibilitiesPostRequest(string subjectId, string summary, string? notes = null)
    {
        SubjectId = subjectId;
        Summary = summary;
        Notes = notes;
    }
    
    private PropertyValue<string> _subjectId = new PropertyValue<string>(nameof(ProjectsResponsibilitiesPostRequest), nameof(SubjectId), "subjectId");
    
    [Required]
    [JsonPropertyName("subjectId")]
    public string SubjectId
    {
        get => _subjectId.GetValue(InlineErrors);
        set => _subjectId.SetValue(value);
    }

    private PropertyValue<string> _summary = new PropertyValue<string>(nameof(ProjectsResponsibilitiesPostRequest), nameof(Summary), "summary");
    
    [Required]
    [JsonPropertyName("summary")]
    public string Summary
    {
        get => _summary.GetValue(InlineErrors);
        set => _summary.SetValue(value);
    }

    private PropertyValue<string?> _notes = new PropertyValue<string?>(nameof(ProjectsResponsibilitiesPostRequest), nameof(Notes), "notes");
    
    [JsonPropertyName("notes")]
    public string? Notes
    {
        get => _notes.GetValue(InlineErrors);
        set => _notes.SetValue(value);
    }

    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _subjectId.SetAccessPath(parentChainPath, validateHasBeenSet);
        _summary.SetAccessPath(parentChainPath, validateHasBeenSet);
        _notes.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

