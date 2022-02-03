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

public class ChatsChannelsForChannelSubscribersTeamsPostRequest
     : IPropagatePropertyAccessPath
{
    public ChatsChannelsForChannelSubscribersTeamsPostRequest() { }
    
    public ChatsChannelsForChannelSubscribersTeamsPostRequest(List<TeamIdentifier> teams)
    {
        Teams = teams;
    }
    
    private PropertyValue<List<TeamIdentifier>> _teams = new PropertyValue<List<TeamIdentifier>>(nameof(ChatsChannelsForChannelSubscribersTeamsPostRequest), nameof(Teams), "teams", new List<TeamIdentifier>());
    
    [Required]
    [JsonPropertyName("teams")]
    public List<TeamIdentifier> Teams
    {
        get => _teams.GetValue(InlineErrors);
        set => _teams.SetValue(value);
    }

    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _teams.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}
