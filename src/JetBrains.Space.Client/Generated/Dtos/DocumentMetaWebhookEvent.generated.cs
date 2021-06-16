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
    public sealed class DocumentMetaWebhookEvent
         : WebhookEvent, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "DocumentMetaWebhookEvent";
        
        public DocumentMetaWebhookEvent() { }
        
        public DocumentMetaWebhookEvent(KMetaMod meta, string document, Modification<bool>? deleted = null, Modification<bool>? published = null)
        {
            Meta = meta;
            Document = document;
            Deleted = deleted;
            Published = published;
        }
        
        private PropertyValue<KMetaMod> _meta = new PropertyValue<KMetaMod>(nameof(DocumentMetaWebhookEvent), nameof(Meta));
        
        [Required]
        [JsonPropertyName("meta")]
        public KMetaMod Meta
        {
            get => _meta.GetValue();
            set => _meta.SetValue(value);
        }
    
        private PropertyValue<string> _document = new PropertyValue<string>(nameof(DocumentMetaWebhookEvent), nameof(Document));
        
        [Required]
        [JsonPropertyName("document")]
        public string Document
        {
            get => _document.GetValue();
            set => _document.SetValue(value);
        }
    
        private PropertyValue<Modification<bool>?> _deleted = new PropertyValue<Modification<bool>?>(nameof(DocumentMetaWebhookEvent), nameof(Deleted));
        
        [JsonPropertyName("deleted")]
        public Modification<bool>? Deleted
        {
            get => _deleted.GetValue();
            set => _deleted.SetValue(value);
        }
    
        private PropertyValue<Modification<bool>?> _published = new PropertyValue<Modification<bool>?>(nameof(DocumentMetaWebhookEvent), nameof(Published));
        
        [JsonPropertyName("published")]
        public Modification<bool>? Published
        {
            get => _published.GetValue();
            set => _published.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _meta.SetAccessPath(path, validateHasBeenSet);
            _document.SetAccessPath(path, validateHasBeenSet);
            _deleted.SetAccessPath(path, validateHasBeenSet);
            _published.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}