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
    public sealed class DocumentEditorsChangedEvent
         : WebhookEvent, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "DocumentEditorsChangedEvent";
        
        public DocumentEditorsChangedEvent() { }
        
        public DocumentEditorsChangedEvent(KMetaMod meta, string document)
        {
            Meta = meta;
            Document = document;
        }
        
        private PropertyValue<KMetaMod> _meta = new PropertyValue<KMetaMod>(nameof(DocumentEditorsChangedEvent), nameof(Meta));
        
        [Required]
        [JsonPropertyName("meta")]
        public KMetaMod Meta
        {
            get => _meta.GetValue();
            set => _meta.SetValue(value);
        }
    
        private PropertyValue<string> _document = new PropertyValue<string>(nameof(DocumentEditorsChangedEvent), nameof(Document));
        
        [Required]
        [JsonPropertyName("document")]
        public string Document
        {
            get => _document.GetValue();
            set => _document.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _meta.SetAccessPath(path, validateHasBeenSet);
            _document.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
