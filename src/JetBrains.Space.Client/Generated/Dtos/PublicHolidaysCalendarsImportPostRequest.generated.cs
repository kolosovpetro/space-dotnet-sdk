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

public class PublicHolidaysCalendarsImportPostRequest
     : IPropagatePropertyAccessPath
{
    public PublicHolidaysCalendarsImportPostRequest() { }
    
    public PublicHolidaysCalendarsImportPostRequest(string calendar, string attachmentId)
    {
        Calendar = calendar;
        AttachmentId = attachmentId;
    }
    
    private PropertyValue<string> _calendar = new PropertyValue<string>(nameof(PublicHolidaysCalendarsImportPostRequest), nameof(Calendar), "calendar");
    
    [Required]
    [JsonPropertyName("calendar")]
    public string Calendar
    {
        get => _calendar.GetValue(InlineErrors);
        set => _calendar.SetValue(value);
    }

    private PropertyValue<string> _attachmentId = new PropertyValue<string>(nameof(PublicHolidaysCalendarsImportPostRequest), nameof(AttachmentId), "attachmentId");
    
    [Required]
    [JsonPropertyName("attachmentId")]
    public string AttachmentId
    {
        get => _attachmentId.GetValue(InlineErrors);
        set => _attachmentId.SetValue(value);
    }

    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _calendar.SetAccessPath(parentChainPath, validateHasBeenSet);
        _attachmentId.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

