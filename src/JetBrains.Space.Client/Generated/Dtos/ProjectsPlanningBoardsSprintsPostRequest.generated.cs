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

public class ProjectsPlanningBoardsSprintsPostRequest
     : IPropagatePropertyAccessPath
{
    public ProjectsPlanningBoardsSprintsPostRequest() { }
    
    public ProjectsPlanningBoardsSprintsPostRequest(BoardIdentifier board, string name, DateTime from, DateTime to, SprintLaunch launch, string? description = null)
    {
        Board = board;
        Name = name;
        Description = description;
        From = from;
        To = to;
        Launch = launch;
    }
    
    private PropertyValue<BoardIdentifier> _board = new PropertyValue<BoardIdentifier>(nameof(ProjectsPlanningBoardsSprintsPostRequest), nameof(Board), "board");
    
    [Required]
    [JsonPropertyName("board")]
    public BoardIdentifier Board
    {
        get => _board.GetValue(InlineErrors);
        set => _board.SetValue(value);
    }

    private PropertyValue<string> _name = new PropertyValue<string>(nameof(ProjectsPlanningBoardsSprintsPostRequest), nameof(Name), "name");
    
    [Required]
    [JsonPropertyName("name")]
    public string Name
    {
        get => _name.GetValue(InlineErrors);
        set => _name.SetValue(value);
    }

    private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(ProjectsPlanningBoardsSprintsPostRequest), nameof(Description), "description");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("description")]
    public string? Description
    {
        get => _description.GetValue(InlineErrors);
        set => _description.SetValue(value);
    }

    private PropertyValue<DateTime> _from = new PropertyValue<DateTime>(nameof(ProjectsPlanningBoardsSprintsPostRequest), nameof(From), "from");
    
    [Required]
    [JsonPropertyName("from")]
    [JsonConverter(typeof(SpaceDateConverter))]
    public DateTime From
    {
        get => _from.GetValue(InlineErrors);
        set => _from.SetValue(value);
    }

    private PropertyValue<DateTime> _to = new PropertyValue<DateTime>(nameof(ProjectsPlanningBoardsSprintsPostRequest), nameof(To), "to");
    
    [Required]
    [JsonPropertyName("to")]
    [JsonConverter(typeof(SpaceDateConverter))]
    public DateTime To
    {
        get => _to.GetValue(InlineErrors);
        set => _to.SetValue(value);
    }

    private PropertyValue<SprintLaunch> _launch = new PropertyValue<SprintLaunch>(nameof(ProjectsPlanningBoardsSprintsPostRequest), nameof(Launch), "launch");
    
    [JsonPropertyName("launch")]
    public SprintLaunch Launch
    {
        get => _launch.GetValue(InlineErrors);
        set => _launch.SetValue(value);
    }

    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _board.SetAccessPath(parentChainPath, validateHasBeenSet);
        _name.SetAccessPath(parentChainPath, validateHasBeenSet);
        _description.SetAccessPath(parentChainPath, validateHasBeenSet);
        _from.SetAccessPath(parentChainPath, validateHasBeenSet);
        _to.SetAccessPath(parentChainPath, validateHasBeenSet);
        _launch.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

