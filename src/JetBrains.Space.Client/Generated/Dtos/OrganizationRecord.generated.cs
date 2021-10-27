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

public sealed class OrganizationRecord
     : IPropagatePropertyAccessPath
{
    public OrganizationRecord() { }
    
    public OrganizationRecord(string id, string orgId, string name, string? slogan = null, string? logoId = null, bool? onboardingRequired = null, bool? allowDomainsEdit = null, long? createdAt = null, ATimeZone? timezone = null, string? slackWorkspace = null)
    {
        Id = id;
        OrgId = orgId;
        Name = name;
        Slogan = slogan;
        LogoId = logoId;
        IsOnboardingRequired = onboardingRequired;
        IsAllowDomainsEdit = allowDomainsEdit;
        CreatedAt = createdAt;
        Timezone = timezone;
        SlackWorkspace = slackWorkspace;
    }
    
    private PropertyValue<string> _id = new PropertyValue<string>(nameof(OrganizationRecord), nameof(Id));
    
    [Required]
    [JsonPropertyName("id")]
    public string Id
    {
        get => _id.GetValue();
        set => _id.SetValue(value);
    }

    private PropertyValue<string> _orgId = new PropertyValue<string>(nameof(OrganizationRecord), nameof(OrgId));
    
    [Required]
    [JsonPropertyName("orgId")]
    public string OrgId
    {
        get => _orgId.GetValue();
        set => _orgId.SetValue(value);
    }

    private PropertyValue<string> _name = new PropertyValue<string>(nameof(OrganizationRecord), nameof(Name));
    
    [Required]
    [JsonPropertyName("name")]
    public string Name
    {
        get => _name.GetValue();
        set => _name.SetValue(value);
    }

    private PropertyValue<string?> _slogan = new PropertyValue<string?>(nameof(OrganizationRecord), nameof(Slogan));
    
    [JsonPropertyName("slogan")]
    public string? Slogan
    {
        get => _slogan.GetValue();
        set => _slogan.SetValue(value);
    }

    private PropertyValue<string?> _logoId = new PropertyValue<string?>(nameof(OrganizationRecord), nameof(LogoId));
    
    [JsonPropertyName("logoId")]
    public string? LogoId
    {
        get => _logoId.GetValue();
        set => _logoId.SetValue(value);
    }

    private PropertyValue<bool?> _onboardingRequired = new PropertyValue<bool?>(nameof(OrganizationRecord), nameof(IsOnboardingRequired));
    
    [JsonPropertyName("onboardingRequired")]
    public bool? IsOnboardingRequired
    {
        get => _onboardingRequired.GetValue();
        set => _onboardingRequired.SetValue(value);
    }

    private PropertyValue<bool?> _allowDomainsEdit = new PropertyValue<bool?>(nameof(OrganizationRecord), nameof(IsAllowDomainsEdit));
    
    [JsonPropertyName("allowDomainsEdit")]
    public bool? IsAllowDomainsEdit
    {
        get => _allowDomainsEdit.GetValue();
        set => _allowDomainsEdit.SetValue(value);
    }

    private PropertyValue<long?> _createdAt = new PropertyValue<long?>(nameof(OrganizationRecord), nameof(CreatedAt));
    
    [JsonPropertyName("createdAt")]
    public long? CreatedAt
    {
        get => _createdAt.GetValue();
        set => _createdAt.SetValue(value);
    }

    private PropertyValue<ATimeZone?> _timezone = new PropertyValue<ATimeZone?>(nameof(OrganizationRecord), nameof(Timezone));
    
    [JsonPropertyName("timezone")]
    public ATimeZone? Timezone
    {
        get => _timezone.GetValue();
        set => _timezone.SetValue(value);
    }

    private PropertyValue<string?> _slackWorkspace = new PropertyValue<string?>(nameof(OrganizationRecord), nameof(SlackWorkspace));
    
    [Obsolete("Slack integration is no longer supported (since 2021-10-13) (will be removed in a future version)")]
    [JsonPropertyName("slackWorkspace")]
    public string? SlackWorkspace
    {
        get => _slackWorkspace.GetValue();
        set => _slackWorkspace.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _id.SetAccessPath(path, validateHasBeenSet);
        _orgId.SetAccessPath(path, validateHasBeenSet);
        _name.SetAccessPath(path, validateHasBeenSet);
        _slogan.SetAccessPath(path, validateHasBeenSet);
        _logoId.SetAccessPath(path, validateHasBeenSet);
        _onboardingRequired.SetAccessPath(path, validateHasBeenSet);
        _allowDomainsEdit.SetAccessPath(path, validateHasBeenSet);
        _createdAt.SetAccessPath(path, validateHasBeenSet);
        _timezone.SetAccessPath(path, validateHasBeenSet);
        _slackWorkspace.SetAccessPath(path, validateHasBeenSet);
    }

}

