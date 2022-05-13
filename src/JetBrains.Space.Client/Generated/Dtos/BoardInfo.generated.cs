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

public sealed class BoardInfo
     : IPropagatePropertyAccessPath
{
    public BoardInfo() { }
    
    public BoardInfo(BoardOwners owners, BoardColumns columns, List<BoardIssueField> issueFields, string? description = null, string? swimlaneKey = null)
    {
        Owners = owners;
        Columns = columns;
        Description = description;
        SwimlaneKey = swimlaneKey;
        IssueFields = issueFields;
    }
    
    private PropertyValue<BoardOwners> _owners = new PropertyValue<BoardOwners>(nameof(BoardInfo), nameof(Owners), "owners");
    
    [Required]
    [JsonPropertyName("owners")]
    public BoardOwners Owners
    {
        get => _owners.GetValue(InlineErrors);
        set => _owners.SetValue(value);
    }

    private PropertyValue<BoardColumns> _columns = new PropertyValue<BoardColumns>(nameof(BoardInfo), nameof(Columns), "columns");
    
    [Required]
    [JsonPropertyName("columns")]
    public BoardColumns Columns
    {
        get => _columns.GetValue(InlineErrors);
        set => _columns.SetValue(value);
    }

    private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(BoardInfo), nameof(Description), "description");
    
    [JsonPropertyName("description")]
    public string? Description
    {
        get => _description.GetValue(InlineErrors);
        set => _description.SetValue(value);
    }

    private PropertyValue<string?> _swimlaneKey = new PropertyValue<string?>(nameof(BoardInfo), nameof(SwimlaneKey), "swimlaneKey");
    
    [JsonPropertyName("swimlaneKey")]
    public string? SwimlaneKey
    {
        get => _swimlaneKey.GetValue(InlineErrors);
        set => _swimlaneKey.SetValue(value);
    }

    private PropertyValue<List<BoardIssueField>> _issueFields = new PropertyValue<List<BoardIssueField>>(nameof(BoardInfo), nameof(IssueFields), "issueFields", new List<BoardIssueField>());
    
    [Required]
    [JsonPropertyName("issueFields")]
    public List<BoardIssueField> IssueFields
    {
        get => _issueFields.GetValue(InlineErrors);
        set => _issueFields.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _owners.SetAccessPath(parentChainPath, validateHasBeenSet);
        _columns.SetAccessPath(parentChainPath, validateHasBeenSet);
        _description.SetAccessPath(parentChainPath, validateHasBeenSet);
        _swimlaneKey.SetAccessPath(parentChainPath, validateHasBeenSet);
        _issueFields.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

