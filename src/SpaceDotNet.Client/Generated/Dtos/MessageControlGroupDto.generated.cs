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
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public sealed class MessageControlGroupDto
         : MessageElementDto, IClassNameConvertible
    {
        [JsonPropertyName("className")]
        public string? ClassName { get; set; }
        
        private PropertyValue<List<MessageControlElementDto>> _elements = new PropertyValue<List<MessageControlElementDto>>(nameof(MessageControlGroupDto), nameof(Elements));
        
        [Required]
        [JsonPropertyName("elements")]
        public List<MessageControlElementDto> Elements
        {
            get { return _elements.GetValue(); }
            set { _elements.SetValue(value); }
        }
    
    }
    
}
