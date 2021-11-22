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

public sealed class KbDocumentContainerInfo
     : DocumentContainerInfo, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "KbDocumentContainerInfo";
    
    public KbDocumentContainerInfo() { }
    
    public KbDocumentContainerInfo(KBBook book, KBArticle? article = null)
    {
        Book = book;
        Article = article;
    }
    
    private PropertyValue<KBBook> _book = new PropertyValue<KBBook>(nameof(KbDocumentContainerInfo), nameof(Book), "book");
    
    [Required]
    [JsonPropertyName("book")]
    public KBBook Book
    {
        get => _book.GetValue(InlineErrors);
        set => _book.SetValue(value);
    }

    private PropertyValue<KBArticle?> _article = new PropertyValue<KBArticle?>(nameof(KbDocumentContainerInfo), nameof(Article), "article");
    
    [JsonPropertyName("article")]
    public KBArticle? Article
    {
        get => _article.GetValue(InlineErrors);
        set => _article.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _book.SetAccessPath(parentChainPath, validateHasBeenSet);
        _article.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

