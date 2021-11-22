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

public class ProjectsForProjectTopicsPostRequest
     : IPropagatePropertyAccessPath
{
    public ProjectsForProjectTopicsPostRequest() { }
    
    public ProjectsForProjectTopicsPostRequest(string name, string? parentTopicId = null)
    {
        Name = name;
        ParentTopicId = parentTopicId;
    }
    
    private PropertyValue<string> _name = new PropertyValue<string>(nameof(ProjectsForProjectTopicsPostRequest), nameof(Name), "name");
    
    [Required]
    [JsonPropertyName("name")]
    public string Name
    {
        get => _name.GetValue(InlineErrors);
        set => _name.SetValue(value);
    }

    private PropertyValue<string?> _parentTopicId = new PropertyValue<string?>(nameof(ProjectsForProjectTopicsPostRequest), nameof(ParentTopicId), "parentTopicId");
    
    [JsonPropertyName("parentTopicId")]
    public string? ParentTopicId
    {
        get => _parentTopicId.GetValue(InlineErrors);
        set => _parentTopicId.SetValue(value);
    }

    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _name.SetAccessPath(parentChainPath, validateHasBeenSet);
        _parentTopicId.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

