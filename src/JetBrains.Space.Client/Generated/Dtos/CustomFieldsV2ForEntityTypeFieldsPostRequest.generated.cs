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

public class CustomFieldsV2ForEntityTypeFieldsPostRequest
     : IPropagatePropertyAccessPath
{
    public CustomFieldsV2ForEntityTypeFieldsPostRequest() { }
    
    public CustomFieldsV2ForEntityTypeFieldsPostRequest(string name, CustomFieldType type, bool multivalued = false, bool required = false, CFCreateParameters? parameters = null, CFInputValue? defaultValue = null, CFConstraint? constraint = null, string? description = null, int? order = null)
    {
        Name = name;
        Type = type;
        IsMultivalued = multivalued;
        Parameters = parameters;
        IsRequired = required;
        DefaultValue = defaultValue;
        Constraint = constraint;
        Description = description;
        Order = order;
    }
    
    private PropertyValue<string> _name = new PropertyValue<string>(nameof(CustomFieldsV2ForEntityTypeFieldsPostRequest), nameof(Name), "name");
    
    [Required]
    [JsonPropertyName("name")]
    public string Name
    {
        get => _name.GetValue(InlineErrors);
        set => _name.SetValue(value);
    }

    private PropertyValue<CustomFieldType> _type = new PropertyValue<CustomFieldType>(nameof(CustomFieldsV2ForEntityTypeFieldsPostRequest), nameof(Type), "type");
    
    [Required]
    [JsonPropertyName("type")]
    public CustomFieldType Type
    {
        get => _type.GetValue(InlineErrors);
        set => _type.SetValue(value);
    }

    private PropertyValue<bool> _multivalued = new PropertyValue<bool>(nameof(CustomFieldsV2ForEntityTypeFieldsPostRequest), nameof(IsMultivalued), "multivalued");
    
    [JsonPropertyName("multivalued")]
    public bool IsMultivalued
    {
        get => _multivalued.GetValue(InlineErrors);
        set => _multivalued.SetValue(value);
    }

    private PropertyValue<CFCreateParameters?> _parameters = new PropertyValue<CFCreateParameters?>(nameof(CustomFieldsV2ForEntityTypeFieldsPostRequest), nameof(Parameters), "parameters");
    
    [JsonPropertyName("parameters")]
    public CFCreateParameters? Parameters
    {
        get => _parameters.GetValue(InlineErrors);
        set => _parameters.SetValue(value);
    }

    private PropertyValue<bool> _required = new PropertyValue<bool>(nameof(CustomFieldsV2ForEntityTypeFieldsPostRequest), nameof(IsRequired), "required");
    
    [JsonPropertyName("required")]
    public bool IsRequired
    {
        get => _required.GetValue(InlineErrors);
        set => _required.SetValue(value);
    }

    private PropertyValue<CFInputValue?> _defaultValue = new PropertyValue<CFInputValue?>(nameof(CustomFieldsV2ForEntityTypeFieldsPostRequest), nameof(DefaultValue), "defaultValue");
    
    [JsonPropertyName("defaultValue")]
    public CFInputValue? DefaultValue
    {
        get => _defaultValue.GetValue(InlineErrors);
        set => _defaultValue.SetValue(value);
    }

    private PropertyValue<CFConstraint?> _constraint = new PropertyValue<CFConstraint?>(nameof(CustomFieldsV2ForEntityTypeFieldsPostRequest), nameof(Constraint), "constraint");
    
    [JsonPropertyName("constraint")]
    public CFConstraint? Constraint
    {
        get => _constraint.GetValue(InlineErrors);
        set => _constraint.SetValue(value);
    }

    private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(CustomFieldsV2ForEntityTypeFieldsPostRequest), nameof(Description), "description");
    
    [JsonPropertyName("description")]
    public string? Description
    {
        get => _description.GetValue(InlineErrors);
        set => _description.SetValue(value);
    }

    private PropertyValue<int?> _order = new PropertyValue<int?>(nameof(CustomFieldsV2ForEntityTypeFieldsPostRequest), nameof(Order), "order");
    
    [JsonPropertyName("order")]
    public int? Order
    {
        get => _order.GetValue(InlineErrors);
        set => _order.SetValue(value);
    }

    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _name.SetAccessPath(parentChainPath, validateHasBeenSet);
        _type.SetAccessPath(parentChainPath, validateHasBeenSet);
        _multivalued.SetAccessPath(parentChainPath, validateHasBeenSet);
        _parameters.SetAccessPath(parentChainPath, validateHasBeenSet);
        _required.SetAccessPath(parentChainPath, validateHasBeenSet);
        _defaultValue.SetAccessPath(parentChainPath, validateHasBeenSet);
        _constraint.SetAccessPath(parentChainPath, validateHasBeenSet);
        _description.SetAccessPath(parentChainPath, validateHasBeenSet);
        _order.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

