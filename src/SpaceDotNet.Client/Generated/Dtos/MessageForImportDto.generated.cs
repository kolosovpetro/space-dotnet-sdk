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
    public sealed class MessageForImportDto
         : IPropagatePropertyAccessPath
    {
        public MessageForImportDto() { }
        
        public MessageForImportDto(string authorPrincipalId, string text, long createdAtUtc, List<AttachmentDto>? attachments = null)
        {
            AuthorPrincipalId = authorPrincipalId;
            Text = text;
            CreatedAtUtc = createdAtUtc;
            Attachments = attachments;
        }
        
        private PropertyValue<string> _authorPrincipalId = new PropertyValue<string>(nameof(MessageForImportDto), nameof(AuthorPrincipalId));
        
        [Required]
        [JsonPropertyName("authorPrincipalId")]
        public string AuthorPrincipalId
        {
            get { return _authorPrincipalId.GetValue(); }
            set { _authorPrincipalId.SetValue(value); }
        }
    
        private PropertyValue<string> _text = new PropertyValue<string>(nameof(MessageForImportDto), nameof(Text));
        
        [Required]
        [JsonPropertyName("text")]
        public string Text
        {
            get { return _text.GetValue(); }
            set { _text.SetValue(value); }
        }
    
        private PropertyValue<long> _createdAtUtc = new PropertyValue<long>(nameof(MessageForImportDto), nameof(CreatedAtUtc));
        
        [Required]
        [JsonPropertyName("createdAtUtc")]
        public long CreatedAtUtc
        {
            get { return _createdAtUtc.GetValue(); }
            set { _createdAtUtc.SetValue(value); }
        }
    
        private PropertyValue<List<AttachmentDto>?> _attachments = new PropertyValue<List<AttachmentDto>?>(nameof(MessageForImportDto), nameof(Attachments));
        
        [JsonPropertyName("attachments")]
        public List<AttachmentDto>? Attachments
        {
            get { return _attachments.GetValue(); }
            set { _attachments.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _authorPrincipalId.SetAccessPath(path, validateHasBeenSet);
            _text.SetAccessPath(path, validateHasBeenSet);
            _createdAtUtc.SetAccessPath(path, validateHasBeenSet);
            _attachments.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
