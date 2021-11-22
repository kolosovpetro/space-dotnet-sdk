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

public class TeamDirectoryInvitationLinksForInvitationLinkIdPatchRequest
     : IPropagatePropertyAccessPath
{
    public TeamDirectoryInvitationLinksForInvitationLinkIdPatchRequest() { }
    
    public TeamDirectoryInvitationLinksForInvitationLinkIdPatchRequest(string? name = null, DateTime? expiresAt = null, int? inviteeLimit = null, string? team = null, string? position = null)
    {
        Name = name;
        ExpiresAt = expiresAt;
        InviteeLimit = inviteeLimit;
        Team = team;
        Position = position;
    }
    
    private PropertyValue<string?> _name = new PropertyValue<string?>(nameof(TeamDirectoryInvitationLinksForInvitationLinkIdPatchRequest), nameof(Name), "name");
    
    [JsonPropertyName("name")]
    public string? Name
    {
        get => _name.GetValue(InlineErrors);
        set => _name.SetValue(value);
    }

    private PropertyValue<DateTime?> _expiresAt = new PropertyValue<DateTime?>(nameof(TeamDirectoryInvitationLinksForInvitationLinkIdPatchRequest), nameof(ExpiresAt), "expiresAt");
    
    [JsonPropertyName("expiresAt")]
    [JsonConverter(typeof(SpaceDateTimeConverter))]
    public DateTime? ExpiresAt
    {
        get => _expiresAt.GetValue(InlineErrors);
        set => _expiresAt.SetValue(value);
    }

    private PropertyValue<int?> _inviteeLimit = new PropertyValue<int?>(nameof(TeamDirectoryInvitationLinksForInvitationLinkIdPatchRequest), nameof(InviteeLimit), "inviteeLimit");
    
    [JsonPropertyName("inviteeLimit")]
    public int? InviteeLimit
    {
        get => _inviteeLimit.GetValue(InlineErrors);
        set => _inviteeLimit.SetValue(value);
    }

    private PropertyValue<string?> _team = new PropertyValue<string?>(nameof(TeamDirectoryInvitationLinksForInvitationLinkIdPatchRequest), nameof(Team), "team");
    
    [JsonPropertyName("team")]
    public string? Team
    {
        get => _team.GetValue(InlineErrors);
        set => _team.SetValue(value);
    }

    private PropertyValue<string?> _position = new PropertyValue<string?>(nameof(TeamDirectoryInvitationLinksForInvitationLinkIdPatchRequest), nameof(Position), "position");
    
    [JsonPropertyName("position")]
    public string? Position
    {
        get => _position.GetValue(InlineErrors);
        set => _position.SetValue(value);
    }

    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _name.SetAccessPath(parentChainPath, validateHasBeenSet);
        _expiresAt.SetAccessPath(parentChainPath, validateHasBeenSet);
        _inviteeLimit.SetAccessPath(parentChainPath, validateHasBeenSet);
        _team.SetAccessPath(parentChainPath, validateHasBeenSet);
        _position.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

