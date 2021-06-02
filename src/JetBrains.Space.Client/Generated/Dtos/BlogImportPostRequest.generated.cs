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
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client
{
    public class BlogImportPostRequest
         : IPropagatePropertyAccessPath
    {
        public BlogImportPostRequest() { }
        
        public BlogImportPostRequest(ImportMetadata metadata, List<ExternalArticle> articles)
        {
            Metadata = metadata;
            Articles = articles;
        }
        
        private PropertyValue<ImportMetadata> _metadata = new PropertyValue<ImportMetadata>(nameof(BlogImportPostRequest), nameof(Metadata));
        
        [Required]
        [JsonPropertyName("metadata")]
        public ImportMetadata Metadata
        {
            get => _metadata.GetValue();
            set => _metadata.SetValue(value);
        }
    
        private PropertyValue<List<ExternalArticle>> _articles = new PropertyValue<List<ExternalArticle>>(nameof(BlogImportPostRequest), nameof(Articles), new List<ExternalArticle>());
        
        [Required]
        [JsonPropertyName("articles")]
        public List<ExternalArticle> Articles
        {
            get => _articles.GetValue();
            set => _articles.SetValue(value);
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _metadata.SetAccessPath(path, validateHasBeenSet);
            _articles.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
