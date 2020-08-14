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
    public sealed class UnfurlDetailsMCDto
         : UnfurlDetailsDto, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "UnfurlDetailsMC";
        
        public UnfurlDetailsMCDto() { }
        
        public UnfurlDetailsMCDto(MCMessageDto message, List<AttachmentInfoDto>? inlineUnfurls = null)
        {
            Message = message;
            InlineUnfurls = inlineUnfurls;
        }
        
        private PropertyValue<MCMessageDto> _message = new PropertyValue<MCMessageDto>(nameof(UnfurlDetailsMCDto), nameof(Message));
        
        [Required]
        [JsonPropertyName("message")]
        public MCMessageDto Message
        {
            get { return _message.GetValue(); }
            set { _message.SetValue(value); }
        }
    
        private PropertyValue<List<AttachmentInfoDto>?> _inlineUnfurls = new PropertyValue<List<AttachmentInfoDto>?>(nameof(UnfurlDetailsMCDto), nameof(InlineUnfurls));
        
        [JsonPropertyName("inlineUnfurls")]
        public List<AttachmentInfoDto>? InlineUnfurls
        {
            get { return _inlineUnfurls.GetValue(); }
            set { _inlineUnfurls.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _message.SetAccessPath(path, validateHasBeenSet);
            _inlineUnfurls.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
