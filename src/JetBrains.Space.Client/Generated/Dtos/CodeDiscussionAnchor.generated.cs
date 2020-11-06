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
    public sealed class CodeDiscussionAnchor
         : IPropagatePropertyAccessPath
    {
        public CodeDiscussionAnchor() { }
        
        public CodeDiscussionAnchor(ProjectKey project, string repository, string revision, string? filename = null, int? line = null, int? oldLine = null, InterpolatedLineState? interpolatedLineState = null)
        {
            Project = project;
            Repository = repository;
            Revision = revision;
            Filename = filename;
            Line = line;
            OldLine = oldLine;
            InterpolatedLineState = interpolatedLineState;
        }
        
        private PropertyValue<ProjectKey> _project = new PropertyValue<ProjectKey>(nameof(CodeDiscussionAnchor), nameof(Project));
        
        [Required]
        [JsonPropertyName("project")]
        public ProjectKey Project
        {
            get => _project.GetValue();
            set => _project.SetValue(value);
        }
    
        private PropertyValue<string> _repository = new PropertyValue<string>(nameof(CodeDiscussionAnchor), nameof(Repository));
        
        [Required]
        [JsonPropertyName("repository")]
        public string Repository
        {
            get => _repository.GetValue();
            set => _repository.SetValue(value);
        }
    
        private PropertyValue<string> _revision = new PropertyValue<string>(nameof(CodeDiscussionAnchor), nameof(Revision));
        
        [Required]
        [JsonPropertyName("revision")]
        public string Revision
        {
            get => _revision.GetValue();
            set => _revision.SetValue(value);
        }
    
        private PropertyValue<string?> _filename = new PropertyValue<string?>(nameof(CodeDiscussionAnchor), nameof(Filename));
        
        [JsonPropertyName("filename")]
        public string? Filename
        {
            get => _filename.GetValue();
            set => _filename.SetValue(value);
        }
    
        private PropertyValue<int?> _line = new PropertyValue<int?>(nameof(CodeDiscussionAnchor), nameof(Line));
        
        [JsonPropertyName("line")]
        public int? Line
        {
            get => _line.GetValue();
            set => _line.SetValue(value);
        }
    
        private PropertyValue<int?> _oldLine = new PropertyValue<int?>(nameof(CodeDiscussionAnchor), nameof(OldLine));
        
        [JsonPropertyName("oldLine")]
        public int? OldLine
        {
            get => _oldLine.GetValue();
            set => _oldLine.SetValue(value);
        }
    
        private PropertyValue<InterpolatedLineState?> _interpolatedLineState = new PropertyValue<InterpolatedLineState?>(nameof(CodeDiscussionAnchor), nameof(InterpolatedLineState));
        
        [JsonPropertyName("interpolatedLineState")]
        public InterpolatedLineState? InterpolatedLineState
        {
            get => _interpolatedLineState.GetValue();
            set => _interpolatedLineState.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _project.SetAccessPath(path, validateHasBeenSet);
            _repository.SetAccessPath(path, validateHasBeenSet);
            _revision.SetAccessPath(path, validateHasBeenSet);
            _filename.SetAccessPath(path, validateHasBeenSet);
            _line.SetAccessPath(path, validateHasBeenSet);
            _oldLine.SetAccessPath(path, validateHasBeenSet);
            _interpolatedLineState.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}