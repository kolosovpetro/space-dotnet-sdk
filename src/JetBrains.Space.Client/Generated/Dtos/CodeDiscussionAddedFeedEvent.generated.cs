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
    public sealed class CodeDiscussionAddedFeedEvent
         : FeedEvent, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "CodeDiscussionAddedFeedEvent";
        
        public CodeDiscussionAddedFeedEvent() { }
        
        public CodeDiscussionAddedFeedEvent(CodeDiscussionRecord codeDiscussion, CodeReviewRecord codeReview)
        {
            CodeDiscussion = codeDiscussion;
            CodeReview = codeReview;
        }
        
        private PropertyValue<CodeDiscussionRecord> _codeDiscussion = new PropertyValue<CodeDiscussionRecord>(nameof(CodeDiscussionAddedFeedEvent), nameof(CodeDiscussion));
        
        [Required]
        [JsonPropertyName("codeDiscussion")]
        public CodeDiscussionRecord CodeDiscussion
        {
            get => _codeDiscussion.GetValue();
            set => _codeDiscussion.SetValue(value);
        }
    
        private PropertyValue<CodeReviewRecord> _codeReview = new PropertyValue<CodeReviewRecord>(nameof(CodeDiscussionAddedFeedEvent), nameof(CodeReview));
        
        [Required]
        [JsonPropertyName("codeReview")]
        public CodeReviewRecord CodeReview
        {
            get => _codeReview.GetValue();
            set => _codeReview.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _codeDiscussion.SetAccessPath(path, validateHasBeenSet);
            _codeReview.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
