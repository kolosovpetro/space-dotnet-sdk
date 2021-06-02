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
    public sealed class DocumentCustomSubscriptionFilterIn
         : SubscriptionFilterIn, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "DocumentCustomSubscriptionFilterIn";
        
        public DocumentCustomSubscriptionFilterIn() { }
        
        public DocumentCustomSubscriptionFilterIn(List<string> documents, string? project = null, List<string>? books = null, List<string>? folders = null)
        {
            Project = project;
            Books = books;
            Folders = folders;
            Documents = documents;
        }
        
        private PropertyValue<string?> _project = new PropertyValue<string?>(nameof(DocumentCustomSubscriptionFilterIn), nameof(Project));
        
        [JsonPropertyName("project")]
        public string? Project
        {
            get => _project.GetValue();
            set => _project.SetValue(value);
        }
    
        private PropertyValue<List<string>?> _books = new PropertyValue<List<string>?>(nameof(DocumentCustomSubscriptionFilterIn), nameof(Books));
        
        [JsonPropertyName("books")]
        public List<string>? Books
        {
            get => _books.GetValue();
            set => _books.SetValue(value);
        }
    
        private PropertyValue<List<string>?> _folders = new PropertyValue<List<string>?>(nameof(DocumentCustomSubscriptionFilterIn), nameof(Folders));
        
        [JsonPropertyName("folders")]
        public List<string>? Folders
        {
            get => _folders.GetValue();
            set => _folders.SetValue(value);
        }
    
        private PropertyValue<List<string>> _documents = new PropertyValue<List<string>>(nameof(DocumentCustomSubscriptionFilterIn), nameof(Documents), new List<string>());
        
        [Required]
        [JsonPropertyName("documents")]
        public List<string> Documents
        {
            get => _documents.GetValue();
            set => _documents.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _project.SetAccessPath(path, validateHasBeenSet);
            _books.SetAccessPath(path, validateHasBeenSet);
            _folders.SetAccessPath(path, validateHasBeenSet);
            _documents.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
