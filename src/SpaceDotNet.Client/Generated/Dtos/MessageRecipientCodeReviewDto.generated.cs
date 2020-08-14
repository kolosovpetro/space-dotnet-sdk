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
    public sealed class MessageRecipientCodeReviewDto
         : MessageRecipientDto, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public override string? ClassName => "MessageRecipient.CodeReview";
        
        public MessageRecipientCodeReviewDto() { }
        
        public MessageRecipientCodeReviewDto(string codeReview)
        {
            CodeReview = codeReview;
        }
        
        private PropertyValue<string> _codeReview = new PropertyValue<string>(nameof(MessageRecipientCodeReviewDto), nameof(CodeReview));
        
        [Required]
        [JsonPropertyName("codeReview")]
        public string CodeReview
        {
            get { return _codeReview.GetValue(); }
            set { _codeReview.SetValue(value); }
        }
    
        public override void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _codeReview.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
