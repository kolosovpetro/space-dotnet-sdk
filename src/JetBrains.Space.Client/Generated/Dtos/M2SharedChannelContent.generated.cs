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

public sealed class M2SharedChannelContent
     : M2ChannelContactInfo, M2ChannelContentInfo, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "M2SharedChannelContent";
    
    public M2SharedChannelContent() { }
    
    public M2SharedChannelContent(string name, string group, M2Access access, string description, ChannelSpecificDefaults notificationDefaults, string? iconId = null, List<TDTeam>? teams = null, bool? canEdit = null, PRProject? project = null)
    {
        Name = name;
        Group = group;
        Access = access;
        Description = description;
        IconId = iconId;
        NotificationDefaults = notificationDefaults;
        Teams = teams;
        CanEdit = canEdit;
        Project = project;
    }
    
    private PropertyValue<string> _name = new PropertyValue<string>(nameof(M2SharedChannelContent), nameof(Name), "name");
    
    [Required]
    [JsonPropertyName("name")]
    public string Name
    {
        get => _name.GetValue(InlineErrors);
        set => _name.SetValue(value);
    }

    private PropertyValue<string> _group = new PropertyValue<string>(nameof(M2SharedChannelContent), nameof(Group), "group");
    
    [Required]
    [JsonPropertyName("group")]
    public string Group
    {
        get => _group.GetValue(InlineErrors);
        set => _group.SetValue(value);
    }

    private PropertyValue<M2Access> _access = new PropertyValue<M2Access>(nameof(M2SharedChannelContent), nameof(Access), "access");
    
    [Required]
    [JsonPropertyName("access")]
    public M2Access Access
    {
        get => _access.GetValue(InlineErrors);
        set => _access.SetValue(value);
    }

    private PropertyValue<string> _description = new PropertyValue<string>(nameof(M2SharedChannelContent), nameof(Description), "description");
    
    [Required]
    [JsonPropertyName("description")]
    public string Description
    {
        get => _description.GetValue(InlineErrors);
        set => _description.SetValue(value);
    }

    private PropertyValue<string?> _iconId = new PropertyValue<string?>(nameof(M2SharedChannelContent), nameof(IconId), "iconId");
    
    [JsonPropertyName("iconId")]
    public string? IconId
    {
        get => _iconId.GetValue(InlineErrors);
        set => _iconId.SetValue(value);
    }

    private PropertyValue<ChannelSpecificDefaults> _notificationDefaults = new PropertyValue<ChannelSpecificDefaults>(nameof(M2SharedChannelContent), nameof(NotificationDefaults), "notificationDefaults");
    
    [Required]
    [JsonPropertyName("notificationDefaults")]
    public ChannelSpecificDefaults NotificationDefaults
    {
        get => _notificationDefaults.GetValue(InlineErrors);
        set => _notificationDefaults.SetValue(value);
    }

    private PropertyValue<List<TDTeam>?> _teams = new PropertyValue<List<TDTeam>?>(nameof(M2SharedChannelContent), nameof(Teams), "teams");
    
    [JsonPropertyName("teams")]
    public List<TDTeam>? Teams
    {
        get => _teams.GetValue(InlineErrors);
        set => _teams.SetValue(value);
    }

    private PropertyValue<bool?> _canEdit = new PropertyValue<bool?>(nameof(M2SharedChannelContent), nameof(CanEdit), "canEdit");
    
    [JsonPropertyName("canEdit")]
    public bool? CanEdit
    {
        get => _canEdit.GetValue(InlineErrors);
        set => _canEdit.SetValue(value);
    }

    private PropertyValue<PRProject?> _project = new PropertyValue<PRProject?>(nameof(M2SharedChannelContent), nameof(Project), "project");
    
    [JsonPropertyName("project")]
    public PRProject? Project
    {
        get => _project.GetValue(InlineErrors);
        set => _project.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _name.SetAccessPath(parentChainPath, validateHasBeenSet);
        _group.SetAccessPath(parentChainPath, validateHasBeenSet);
        _access.SetAccessPath(parentChainPath, validateHasBeenSet);
        _description.SetAccessPath(parentChainPath, validateHasBeenSet);
        _iconId.SetAccessPath(parentChainPath, validateHasBeenSet);
        _notificationDefaults.SetAccessPath(parentChainPath, validateHasBeenSet);
        _teams.SetAccessPath(parentChainPath, validateHasBeenSet);
        _canEdit.SetAccessPath(parentChainPath, validateHasBeenSet);
        _project.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

