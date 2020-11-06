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
    public class ProjectsForProjectAutomationJobsForJobIdStartPostRequest
         : IPropagatePropertyAccessPath
    {
        public ProjectsForProjectAutomationJobsForJobIdStartPostRequest() { }
        
        public ProjectsForProjectAutomationJobsForJobIdStartPostRequest(Branch branch)
        {
            Branch = branch;
        }
        
        private PropertyValue<Branch> _branch = new PropertyValue<Branch>(nameof(ProjectsForProjectAutomationJobsForJobIdStartPostRequest), nameof(Branch));
        
        [Required]
        [JsonPropertyName("branch")]
        public Branch Branch
        {
            get => _branch.GetValue();
            set => _branch.SetValue(value);
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _branch.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}