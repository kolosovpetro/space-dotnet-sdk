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
    public class ProjectsForProjectCodeReviewsForReviewIdStatePatchRequest
         : IPropagatePropertyAccessPath
    {
        public ProjectsForProjectCodeReviewsForReviewIdStatePatchRequest() { }
        
        public ProjectsForProjectCodeReviewsForReviewIdStatePatchRequest(CodeReviewState state)
        {
            State = state;
        }
        
        private PropertyValue<CodeReviewState> _state = new PropertyValue<CodeReviewState>(nameof(ProjectsForProjectCodeReviewsForReviewIdStatePatchRequest), nameof(State));
        
        [Required]
        [JsonPropertyName("state")]
        public CodeReviewState State
        {
            get => _state.GetValue();
            set => _state.SetValue(value);
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _state.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}