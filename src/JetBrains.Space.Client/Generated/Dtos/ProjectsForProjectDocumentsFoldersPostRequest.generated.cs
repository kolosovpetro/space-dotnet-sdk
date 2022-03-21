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

public class ProjectsForProjectDocumentsFoldersPostRequest
     : IPropagatePropertyAccessPath
{
    public ProjectsForProjectDocumentsFoldersPostRequest() { }
    
    public ProjectsForProjectDocumentsFoldersPostRequest(string name, FolderIdentifier parentFolder)
    {
        Name = name;
        ParentFolder = parentFolder;
    }
    
    private PropertyValue<string> _name = new PropertyValue<string>(nameof(ProjectsForProjectDocumentsFoldersPostRequest), nameof(Name), "name");
    
    [Required]
    [JsonPropertyName("name")]
    public string Name
    {
        get => _name.GetValue(InlineErrors);
        set => _name.SetValue(value);
    }

    private PropertyValue<FolderIdentifier> _parentFolder = new PropertyValue<FolderIdentifier>(nameof(ProjectsForProjectDocumentsFoldersPostRequest), nameof(ParentFolder), "parentFolder");
    
    [Required]
    [JsonPropertyName("parentFolder")]
    public FolderIdentifier ParentFolder
    {
        get => _parentFolder.GetValue(InlineErrors);
        set => _parentFolder.SetValue(value);
    }

    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _name.SetAccessPath(parentChainPath, validateHasBeenSet);
        _parentFolder.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

