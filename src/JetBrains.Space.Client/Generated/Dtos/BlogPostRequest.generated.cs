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
    public class BlogPostRequest
         : IPropagatePropertyAccessPath
    {
        public BlogPostRequest() { }
        
        public BlogPostRequest(string title, string content, List<string>? locations = null, List<string>? teams = null, BlogCalendarEvent? @event = null)
        {
            Title = title;
            Content = content;
            Locations = locations;
            Teams = teams;
            Event = @event;
        }
        
        private PropertyValue<string> _title = new PropertyValue<string>(nameof(BlogPostRequest), nameof(Title));
        
        [Required]
        [JsonPropertyName("title")]
        public string Title
        {
            get => _title.GetValue();
            set => _title.SetValue(value);
        }
    
        private PropertyValue<string> _content = new PropertyValue<string>(nameof(BlogPostRequest), nameof(Content));
        
        [Required]
        [JsonPropertyName("content")]
        public string Content
        {
            get => _content.GetValue();
            set => _content.SetValue(value);
        }
    
        private PropertyValue<List<string>?> _locations = new PropertyValue<List<string>?>(nameof(BlogPostRequest), nameof(Locations));
        
        [JsonPropertyName("locations")]
        public List<string>? Locations
        {
            get => _locations.GetValue();
            set => _locations.SetValue(value);
        }
    
        private PropertyValue<List<string>?> _teams = new PropertyValue<List<string>?>(nameof(BlogPostRequest), nameof(Teams));
        
        [JsonPropertyName("teams")]
        public List<string>? Teams
        {
            get => _teams.GetValue();
            set => _teams.SetValue(value);
        }
    
        private PropertyValue<BlogCalendarEvent?> _event = new PropertyValue<BlogCalendarEvent?>(nameof(BlogPostRequest), nameof(Event));
        
        [JsonPropertyName("event")]
        public BlogCalendarEvent? Event
        {
            get => _event.GetValue();
            set => _event.SetValue(value);
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _title.SetAccessPath(path, validateHasBeenSet);
            _content.SetAccessPath(path, validateHasBeenSet);
            _locations.SetAccessPath(path, validateHasBeenSet);
            _teams.SetAccessPath(path, validateHasBeenSet);
            _event.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
