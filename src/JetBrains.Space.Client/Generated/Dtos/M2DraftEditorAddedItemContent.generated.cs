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
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Client.Internal;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client
{
    public sealed class M2DraftEditorAddedItemContent
         : M2ItemContentDetails, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "M2DraftEditorAddedItemContent";
        
        public M2DraftEditorAddedItemContent() { }
        
        public M2DraftEditorAddedItemContent(string id, string title)
        {
            Id = id;
            Title = title;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(M2DraftEditorAddedItemContent), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get => _id.GetValue();
            set => _id.SetValue(value);
        }
    
        private PropertyValue<string> _title = new PropertyValue<string>(nameof(M2DraftEditorAddedItemContent), nameof(Title));
        
        [Required]
        [JsonPropertyName("title")]
        public string Title
        {
            get => _title.GetValue();
            set => _title.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _title.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}