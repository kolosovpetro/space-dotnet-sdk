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
    public sealed class AutomationJobSubscriptionFilter
         : SubscriptionFilter, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "AutomationJobSubscriptionFilter";
        
        public AutomationJobSubscriptionFilter() { }
        
        public AutomationJobSubscriptionFilter(List<PRProject> projects, string? repositoryName = null, List<string>? branchSpec = null, List<string>? jobs = null)
        {
            Projects = projects;
            RepositoryName = repositoryName;
            BranchSpec = branchSpec;
            Jobs = jobs;
        }
        
        private PropertyValue<List<PRProject>> _projects = new PropertyValue<List<PRProject>>(nameof(AutomationJobSubscriptionFilter), nameof(Projects), new List<PRProject>());
        
        [Required]
        [JsonPropertyName("projects")]
        public List<PRProject> Projects
        {
            get => _projects.GetValue();
            set => _projects.SetValue(value);
        }
    
        private PropertyValue<string?> _repositoryName = new PropertyValue<string?>(nameof(AutomationJobSubscriptionFilter), nameof(RepositoryName));
        
        [JsonPropertyName("repositoryName")]
        public string? RepositoryName
        {
            get => _repositoryName.GetValue();
            set => _repositoryName.SetValue(value);
        }
    
        private PropertyValue<List<string>?> _branchSpec = new PropertyValue<List<string>?>(nameof(AutomationJobSubscriptionFilter), nameof(BranchSpec));
        
        [JsonPropertyName("branchSpec")]
        public List<string>? BranchSpec
        {
            get => _branchSpec.GetValue();
            set => _branchSpec.SetValue(value);
        }
    
        private PropertyValue<List<string>?> _jobs = new PropertyValue<List<string>?>(nameof(AutomationJobSubscriptionFilter), nameof(Jobs));
        
        [JsonPropertyName("jobs")]
        public List<string>? Jobs
        {
            get => _jobs.GetValue();
            set => _jobs.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _projects.SetAccessPath(path, validateHasBeenSet);
            _repositoryName.SetAccessPath(path, validateHasBeenSet);
            _branchSpec.SetAccessPath(path, validateHasBeenSet);
            _jobs.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
