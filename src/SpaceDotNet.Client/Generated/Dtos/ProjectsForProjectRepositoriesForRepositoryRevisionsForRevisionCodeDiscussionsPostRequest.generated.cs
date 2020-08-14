// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public class ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCodeDiscussionsPostRequest
         : IPropagatePropertyAccessPath
    {
        public ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCodeDiscussionsPostRequest() { }
        
        public ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCodeDiscussionsPostRequest(string text, bool pending = false, DiffContextDto? diffContext = null, string? filename = null, int? line = null, int? oldLine = null)
        {
            Text = text;
            DiffContext = diffContext;
            Filename = filename;
            Line = line;
            OldLine = oldLine;
            Pending = pending;
        }
        
        private PropertyValue<string> _text = new PropertyValue<string>(nameof(ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCodeDiscussionsPostRequest), nameof(Text));
        
        [Required]
        [JsonPropertyName("text")]
        public string Text
        {
            get { return _text.GetValue(); }
            set { _text.SetValue(value); }
        }
    
        private PropertyValue<DiffContextDto?> _diffContext = new PropertyValue<DiffContextDto?>(nameof(ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCodeDiscussionsPostRequest), nameof(DiffContext));
        
        [JsonPropertyName("diffContext")]
        public DiffContextDto? DiffContext
        {
            get { return _diffContext.GetValue(); }
            set { _diffContext.SetValue(value); }
        }
    
        private PropertyValue<string?> _filename = new PropertyValue<string?>(nameof(ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCodeDiscussionsPostRequest), nameof(Filename));
        
        [JsonPropertyName("filename")]
        public string? Filename
        {
            get { return _filename.GetValue(); }
            set { _filename.SetValue(value); }
        }
    
        private PropertyValue<int?> _line = new PropertyValue<int?>(nameof(ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCodeDiscussionsPostRequest), nameof(Line));
        
        [JsonPropertyName("line")]
        public int? Line
        {
            get { return _line.GetValue(); }
            set { _line.SetValue(value); }
        }
    
        private PropertyValue<int?> _oldLine = new PropertyValue<int?>(nameof(ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCodeDiscussionsPostRequest), nameof(OldLine));
        
        [JsonPropertyName("oldLine")]
        public int? OldLine
        {
            get { return _oldLine.GetValue(); }
            set { _oldLine.SetValue(value); }
        }
    
        private PropertyValue<bool> _pending = new PropertyValue<bool>(nameof(ProjectsForProjectRepositoriesForRepositoryRevisionsForRevisionCodeDiscussionsPostRequest), nameof(Pending));
        
        [JsonPropertyName("pending")]
        public bool Pending
        {
            get { return _pending.GetValue(); }
            set { _pending.SetValue(value); }
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _text.SetAccessPath(path, validateHasBeenSet);
            _diffContext.SetAccessPath(path, validateHasBeenSet);
            _filename.SetAccessPath(path, validateHasBeenSet);
            _line.SetAccessPath(path, validateHasBeenSet);
            _oldLine.SetAccessPath(path, validateHasBeenSet);
            _pending.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
