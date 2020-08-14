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
    public sealed class MCOutlineDto
         : MCElementDetailsDto, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "MCOutline";
        
        public MCOutlineDto() { }
        
        public MCOutlineDto(MCElementDto? icon = null, MCTextDto? text = null)
        {
            Icon = icon;
            Text = text;
        }
        
        private PropertyValue<MCElementDto?> _icon = new PropertyValue<MCElementDto?>(nameof(MCOutlineDto), nameof(Icon));
        
        [JsonPropertyName("icon")]
        public MCElementDto? Icon
        {
            get { return _icon.GetValue(); }
            set { _icon.SetValue(value); }
        }
    
        private PropertyValue<MCTextDto?> _text = new PropertyValue<MCTextDto?>(nameof(MCOutlineDto), nameof(Text));
        
        [JsonPropertyName("text")]
        public MCTextDto? Text
        {
            get { return _text.GetValue(); }
            set { _text.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _icon.SetAccessPath(path, validateHasBeenSet);
            _text.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
