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

public sealed class PlainParameterRecord
     : IPropagatePropertyAccessPath
{
    public PlainParameterRecord() { }
    
    public PlainParameterRecord(string id, bool archived, string bundleId, string key, string value, string? description = null, DateTime? createdAt = null, CPrincipal? createdBy = null, DateTime? updatedAt = null, CPrincipal? updatedBy = null)
    {
        Id = id;
        IsArchived = archived;
        BundleId = bundleId;
        Key = key;
        Description = description;
        CreatedAt = createdAt;
        CreatedBy = createdBy;
        UpdatedAt = updatedAt;
        UpdatedBy = updatedBy;
        Value = value;
    }
    
    private PropertyValue<string> _id = new PropertyValue<string>(nameof(PlainParameterRecord), nameof(Id), "id");
    
    [Required]
    [JsonPropertyName("id")]
    public string Id
    {
        get => _id.GetValue(InlineErrors);
        set => _id.SetValue(value);
    }

    private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(PlainParameterRecord), nameof(IsArchived), "archived");
    
    [Required]
    [JsonPropertyName("archived")]
    public bool IsArchived
    {
        get => _archived.GetValue(InlineErrors);
        set => _archived.SetValue(value);
    }

    private PropertyValue<string> _bundleId = new PropertyValue<string>(nameof(PlainParameterRecord), nameof(BundleId), "bundleId");
    
    [Required]
    [JsonPropertyName("bundleId")]
    public string BundleId
    {
        get => _bundleId.GetValue(InlineErrors);
        set => _bundleId.SetValue(value);
    }

    private PropertyValue<string> _key = new PropertyValue<string>(nameof(PlainParameterRecord), nameof(Key), "key");
    
    [Required]
    [JsonPropertyName("key")]
    public string Key
    {
        get => _key.GetValue(InlineErrors);
        set => _key.SetValue(value);
    }

    private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(PlainParameterRecord), nameof(Description), "description");
    
    [JsonPropertyName("description")]
    public string? Description
    {
        get => _description.GetValue(InlineErrors);
        set => _description.SetValue(value);
    }

    private PropertyValue<DateTime?> _createdAt = new PropertyValue<DateTime?>(nameof(PlainParameterRecord), nameof(CreatedAt), "createdAt");
    
    [JsonPropertyName("createdAt")]
    [JsonConverter(typeof(SpaceDateTimeConverter))]
    public DateTime? CreatedAt
    {
        get => _createdAt.GetValue(InlineErrors);
        set => _createdAt.SetValue(value);
    }

    private PropertyValue<CPrincipal?> _createdBy = new PropertyValue<CPrincipal?>(nameof(PlainParameterRecord), nameof(CreatedBy), "createdBy");
    
    [JsonPropertyName("createdBy")]
    public CPrincipal? CreatedBy
    {
        get => _createdBy.GetValue(InlineErrors);
        set => _createdBy.SetValue(value);
    }

    private PropertyValue<DateTime?> _updatedAt = new PropertyValue<DateTime?>(nameof(PlainParameterRecord), nameof(UpdatedAt), "updatedAt");
    
    [JsonPropertyName("updatedAt")]
    [JsonConverter(typeof(SpaceDateTimeConverter))]
    public DateTime? UpdatedAt
    {
        get => _updatedAt.GetValue(InlineErrors);
        set => _updatedAt.SetValue(value);
    }

    private PropertyValue<CPrincipal?> _updatedBy = new PropertyValue<CPrincipal?>(nameof(PlainParameterRecord), nameof(UpdatedBy), "updatedBy");
    
    [JsonPropertyName("updatedBy")]
    public CPrincipal? UpdatedBy
    {
        get => _updatedBy.GetValue(InlineErrors);
        set => _updatedBy.SetValue(value);
    }

    private PropertyValue<string> _value = new PropertyValue<string>(nameof(PlainParameterRecord), nameof(Value), "value");
    
    [Required]
    [JsonPropertyName("value")]
    public string Value
    {
        get => _value.GetValue(InlineErrors);
        set => _value.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _id.SetAccessPath(parentChainPath, validateHasBeenSet);
        _archived.SetAccessPath(parentChainPath, validateHasBeenSet);
        _bundleId.SetAccessPath(parentChainPath, validateHasBeenSet);
        _key.SetAccessPath(parentChainPath, validateHasBeenSet);
        _description.SetAccessPath(parentChainPath, validateHasBeenSet);
        _createdAt.SetAccessPath(parentChainPath, validateHasBeenSet);
        _createdBy.SetAccessPath(parentChainPath, validateHasBeenSet);
        _updatedAt.SetAccessPath(parentChainPath, validateHasBeenSet);
        _updatedBy.SetAccessPath(parentChainPath, validateHasBeenSet);
        _value.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

