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

public class RdWorkspacesReloadConfigPostRequest
     : IPropagatePropertyAccessPath
{
    public RdWorkspacesReloadConfigPostRequest() { }
    
    public RdWorkspacesReloadConfigPostRequest(WorkspaceIdentifier workspace)
    {
        Workspace = workspace;
    }
    
    private PropertyValue<WorkspaceIdentifier> _workspace = new PropertyValue<WorkspaceIdentifier>(nameof(RdWorkspacesReloadConfigPostRequest), nameof(Workspace), "workspace");
    
    [Required]
    [JsonPropertyName("workspace")]
    public WorkspaceIdentifier Workspace
    {
        get => _workspace.GetValue(InlineErrors);
        set => _workspace.SetValue(value);
    }

    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _workspace.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

