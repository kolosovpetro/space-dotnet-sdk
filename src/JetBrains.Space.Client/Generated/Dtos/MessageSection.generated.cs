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

public sealed class MessageSection
     : MessageSectionElement, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "MessageSection";
    
    public MessageSection() { }
    
    public MessageSection(List<MessageElement> elements, string? header = null, string? footer = null)
    {
        Header = header;
        Elements = elements;
        Footer = footer;
    }
    
    private PropertyValue<string?> _header = new PropertyValue<string?>(nameof(MessageSection), nameof(Header), "header");
    
    [JsonPropertyName("header")]
    public string? Header
    {
        get => _header.GetValue(InlineErrors);
        set => _header.SetValue(value);
    }

    private PropertyValue<List<MessageElement>> _elements = new PropertyValue<List<MessageElement>>(nameof(MessageSection), nameof(Elements), "elements", new List<MessageElement>());
    
    [Required]
    [JsonPropertyName("elements")]
    public List<MessageElement> Elements
    {
        get => _elements.GetValue(InlineErrors);
        set => _elements.SetValue(value);
    }

    private PropertyValue<string?> _footer = new PropertyValue<string?>(nameof(MessageSection), nameof(Footer), "footer");
    
    [JsonPropertyName("footer")]
    public string? Footer
    {
        get => _footer.GetValue(InlineErrors);
        set => _footer.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _header.SetAccessPath(parentChainPath, validateHasBeenSet);
        _elements.SetAccessPath(parentChainPath, validateHasBeenSet);
        _footer.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

