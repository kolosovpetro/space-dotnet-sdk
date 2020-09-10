// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS0108

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public sealed class CodeReviewParticipantQualityGateSlot
         : IPropagatePropertyAccessPath
    {
        public CodeReviewParticipantQualityGateSlot() { }
        
        public CodeReviewParticipantQualityGateSlot(List<string> rule, int index)
        {
            Rule = rule;
            Index = index;
        }
        
        private PropertyValue<List<string>> _rule = new PropertyValue<List<string>>(nameof(CodeReviewParticipantQualityGateSlot), nameof(Rule));
        
        [Required]
        [JsonPropertyName("rule")]
        public List<string> Rule
        {
            get { return _rule.GetValue(); }
            set { _rule.SetValue(value); }
        }
    
        private PropertyValue<int> _index = new PropertyValue<int>(nameof(CodeReviewParticipantQualityGateSlot), nameof(Index));
        
        [Required]
        [JsonPropertyName("index")]
        public int Index
        {
            get { return _index.GetValue(); }
            set { _index.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _rule.SetAccessPath(path, validateHasBeenSet);
            _index.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}