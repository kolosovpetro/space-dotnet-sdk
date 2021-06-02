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
    public sealed class DocumentHistoryUnfurlDetails
         : UnfurlDetails, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "DocumentHistoryUnfurlDetails";
        
        public DocumentHistoryUnfurlDetails() { }
        
        public DocumentHistoryUnfurlDetails(string document, string title, DateTime? version = null, DateTime? @base = null, DateTime? preview = null)
        {
            Document = document;
            Title = title;
            Version = version;
            Base = @base;
            Preview = preview;
        }
        
        private PropertyValue<string> _document = new PropertyValue<string>(nameof(DocumentHistoryUnfurlDetails), nameof(Document));
        
        [Required]
        [JsonPropertyName("document")]
        public string Document
        {
            get => _document.GetValue();
            set => _document.SetValue(value);
        }
    
        private PropertyValue<string> _title = new PropertyValue<string>(nameof(DocumentHistoryUnfurlDetails), nameof(Title));
        
        [Required]
        [JsonPropertyName("title")]
        public string Title
        {
            get => _title.GetValue();
            set => _title.SetValue(value);
        }
    
        private PropertyValue<DateTime?> _version = new PropertyValue<DateTime?>(nameof(DocumentHistoryUnfurlDetails), nameof(Version));
        
        [JsonPropertyName("version")]
        [JsonConverter(typeof(SpaceDateTimeConverter))]
        public DateTime? Version
        {
            get => _version.GetValue();
            set => _version.SetValue(value);
        }
    
        private PropertyValue<DateTime?> _base = new PropertyValue<DateTime?>(nameof(DocumentHistoryUnfurlDetails), nameof(Base));
        
        [JsonPropertyName("base")]
        [JsonConverter(typeof(SpaceDateTimeConverter))]
        public DateTime? Base
        {
            get => _base.GetValue();
            set => _base.SetValue(value);
        }
    
        private PropertyValue<DateTime?> _preview = new PropertyValue<DateTime?>(nameof(DocumentHistoryUnfurlDetails), nameof(Preview));
        
        [JsonPropertyName("preview")]
        [JsonConverter(typeof(SpaceDateTimeConverter))]
        public DateTime? Preview
        {
            get => _preview.GetValue();
            set => _preview.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _document.SetAccessPath(path, validateHasBeenSet);
            _title.SetAccessPath(path, validateHasBeenSet);
            _version.SetAccessPath(path, validateHasBeenSet);
            _base.SetAccessPath(path, validateHasBeenSet);
            _preview.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
