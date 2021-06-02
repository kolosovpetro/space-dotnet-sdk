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
    public sealed class IssueCFInputValue
         : CFInputValue, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "IssueCFInputValue";
        
        public IssueCFInputValue() { }
        
        public IssueCFInputValue(IssueIdentifier? issue = null)
        {
            Issue = issue;
        }
        
        private PropertyValue<IssueIdentifier?> _issue = new PropertyValue<IssueIdentifier?>(nameof(IssueCFInputValue), nameof(Issue));
        
        [JsonPropertyName("issue")]
        public IssueIdentifier? Issue
        {
            get => _issue.GetValue();
            set => _issue.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _issue.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
