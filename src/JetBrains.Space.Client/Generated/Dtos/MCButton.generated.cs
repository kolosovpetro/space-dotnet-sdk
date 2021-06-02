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
    public sealed class MCButton
         : MCElementDetails, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "MCButton";
        
        public MCButton() { }
        
        public MCButton(string text, string style, MCAction action, bool? disabled = null)
        {
            Text = text;
            Style = style;
            Action = action;
            IsDisabled = disabled;
        }
        
        private PropertyValue<string> _text = new PropertyValue<string>(nameof(MCButton), nameof(Text));
        
        [Required]
        [JsonPropertyName("text")]
        public string Text
        {
            get => _text.GetValue();
            set => _text.SetValue(value);
        }
    
        private PropertyValue<string> _style = new PropertyValue<string>(nameof(MCButton), nameof(Style));
        
        [Required]
        [JsonPropertyName("style")]
        public string Style
        {
            get => _style.GetValue();
            set => _style.SetValue(value);
        }
    
        private PropertyValue<MCAction> _action = new PropertyValue<MCAction>(nameof(MCButton), nameof(Action));
        
        [Required]
        [JsonPropertyName("action")]
        public MCAction Action
        {
            get => _action.GetValue();
            set => _action.SetValue(value);
        }
    
        private PropertyValue<bool?> _disabled = new PropertyValue<bool?>(nameof(MCButton), nameof(IsDisabled));
        
        [JsonPropertyName("disabled")]
        public bool? IsDisabled
        {
            get => _disabled.GetValue();
            set => _disabled.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _text.SetAccessPath(path, validateHasBeenSet);
            _style.SetAccessPath(path, validateHasBeenSet);
            _action.SetAccessPath(path, validateHasBeenSet);
            _disabled.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
