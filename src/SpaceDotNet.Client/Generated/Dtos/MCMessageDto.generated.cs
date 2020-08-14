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
    public sealed class MCMessageDto
         : M2ItemContentDetailsDto, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "MCMessage";
        
        public MCMessageDto() { }
        
        public MCMessageDto(string style, List<MCElementDto> content, MCOutlineDto? outline = null, string? serviceId = null, string? supplementaryData = null, M2ItemContentDetailsDto? extension = null)
        {
            Style = style;
            Outline = outline;
            Content = content;
            ServiceId = serviceId;
            SupplementaryData = supplementaryData;
            Extension = extension;
        }
        
        private PropertyValue<string> _style = new PropertyValue<string>(nameof(MCMessageDto), nameof(Style));
        
        [Required]
        [JsonPropertyName("style")]
        public string Style
        {
            get { return _style.GetValue(); }
            set { _style.SetValue(value); }
        }
    
        private PropertyValue<MCOutlineDto?> _outline = new PropertyValue<MCOutlineDto?>(nameof(MCMessageDto), nameof(Outline));
        
        [JsonPropertyName("outline")]
        public MCOutlineDto? Outline
        {
            get { return _outline.GetValue(); }
            set { _outline.SetValue(value); }
        }
    
        private PropertyValue<List<MCElementDto>> _content = new PropertyValue<List<MCElementDto>>(nameof(MCMessageDto), nameof(Content));
        
        [Required]
        [JsonPropertyName("content")]
        public List<MCElementDto> Content
        {
            get { return _content.GetValue(); }
            set { _content.SetValue(value); }
        }
    
        private PropertyValue<string?> _serviceId = new PropertyValue<string?>(nameof(MCMessageDto), nameof(ServiceId));
        
        [JsonPropertyName("serviceId")]
        public string? ServiceId
        {
            get { return _serviceId.GetValue(); }
            set { _serviceId.SetValue(value); }
        }
    
        private PropertyValue<string?> _supplementaryData = new PropertyValue<string?>(nameof(MCMessageDto), nameof(SupplementaryData));
        
        [JsonPropertyName("supplementaryData")]
        public string? SupplementaryData
        {
            get { return _supplementaryData.GetValue(); }
            set { _supplementaryData.SetValue(value); }
        }
    
        private PropertyValue<M2ItemContentDetailsDto?> _extension = new PropertyValue<M2ItemContentDetailsDto?>(nameof(MCMessageDto), nameof(Extension));
        
        [JsonPropertyName("extension")]
        public M2ItemContentDetailsDto? Extension
        {
            get { return _extension.GetValue(); }
            set { _extension.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _style.SetAccessPath(path, validateHasBeenSet);
            _outline.SetAccessPath(path, validateHasBeenSet);
            _content.SetAccessPath(path, validateHasBeenSet);
            _serviceId.SetAccessPath(path, validateHasBeenSet);
            _supplementaryData.SetAccessPath(path, validateHasBeenSet);
            _extension.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
