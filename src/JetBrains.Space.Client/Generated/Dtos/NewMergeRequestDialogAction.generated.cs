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
    public sealed class NewMergeRequestDialogAction
         : ClientSideActionContext, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "NewMergeRequestDialogAction";
        
        public NewMergeRequestDialogAction() { }
        
        public NewMergeRequestDialogAction(string projectKey, string repository, string targetBranch, string sourceBranch, int? linkToIssueNumber = null)
        {
            ProjectKey = projectKey;
            Repository = repository;
            TargetBranch = targetBranch;
            SourceBranch = sourceBranch;
            LinkToIssueNumber = linkToIssueNumber;
        }
        
        private PropertyValue<string> _projectKey = new PropertyValue<string>(nameof(NewMergeRequestDialogAction), nameof(ProjectKey));
        
        [Required]
        [JsonPropertyName("projectKey")]
        public string ProjectKey
        {
            get => _projectKey.GetValue();
            set => _projectKey.SetValue(value);
        }
    
        private PropertyValue<string> _repository = new PropertyValue<string>(nameof(NewMergeRequestDialogAction), nameof(Repository));
        
        [Required]
        [JsonPropertyName("repository")]
        public string Repository
        {
            get => _repository.GetValue();
            set => _repository.SetValue(value);
        }
    
        private PropertyValue<string> _targetBranch = new PropertyValue<string>(nameof(NewMergeRequestDialogAction), nameof(TargetBranch));
        
        [Required]
        [JsonPropertyName("targetBranch")]
        public string TargetBranch
        {
            get => _targetBranch.GetValue();
            set => _targetBranch.SetValue(value);
        }
    
        private PropertyValue<string> _sourceBranch = new PropertyValue<string>(nameof(NewMergeRequestDialogAction), nameof(SourceBranch));
        
        [Required]
        [JsonPropertyName("sourceBranch")]
        public string SourceBranch
        {
            get => _sourceBranch.GetValue();
            set => _sourceBranch.SetValue(value);
        }
    
        private PropertyValue<int?> _linkToIssueNumber = new PropertyValue<int?>(nameof(NewMergeRequestDialogAction), nameof(LinkToIssueNumber));
        
        [JsonPropertyName("linkToIssueNumber")]
        public int? LinkToIssueNumber
        {
            get => _linkToIssueNumber.GetValue();
            set => _linkToIssueNumber.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _projectKey.SetAccessPath(path, validateHasBeenSet);
            _repository.SetAccessPath(path, validateHasBeenSet);
            _targetBranch.SetAccessPath(path, validateHasBeenSet);
            _sourceBranch.SetAccessPath(path, validateHasBeenSet);
            _linkToIssueNumber.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
