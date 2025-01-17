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

public class UploadsPostRequest
     : IPropagatePropertyAccessPath
{
    public UploadsPostRequest() { }
    
    public UploadsPostRequest(string storagePrefix, string? mediaType = null)
    {
        StoragePrefix = storagePrefix;
        MediaType = mediaType;
    }
    
    private PropertyValue<string> _storagePrefix = new PropertyValue<string>(nameof(UploadsPostRequest), nameof(StoragePrefix), "storagePrefix");
    
    [Required]
    [JsonPropertyName("storagePrefix")]
    public string StoragePrefix
    {
        get => _storagePrefix.GetValue(InlineErrors);
        set => _storagePrefix.SetValue(value);
    }

    private PropertyValue<string?> _mediaType = new PropertyValue<string?>(nameof(UploadsPostRequest), nameof(MediaType), "mediaType");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("mediaType")]
    public string? MediaType
    {
        get => _mediaType.GetValue(InlineErrors);
        set => _mediaType.SetValue(value);
    }

    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _storagePrefix.SetAccessPath(parentChainPath, validateHasBeenSet);
        _mediaType.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

