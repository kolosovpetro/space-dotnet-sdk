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
    public sealed class UnfurlDetailsIssueDto
         : UnfurlDetailsDto, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "UnfurlDetailsIssue";
        
        public UnfurlDetailsIssueDto() { }
        
        public UnfurlDetailsIssueDto(IssueDto issue)
        {
            Issue = issue;
        }
        
        private PropertyValue<IssueDto> _issue = new PropertyValue<IssueDto>(nameof(UnfurlDetailsIssueDto), nameof(Issue));
        
        [Required]
        [JsonPropertyName("issue")]
        public IssueDto Issue
        {
            get { return _issue.GetValue(); }
            set { _issue.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _issue.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
