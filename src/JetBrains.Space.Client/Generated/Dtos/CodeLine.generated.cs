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

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Client.Internal;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client
{
    public sealed class CodeLine
         : IPropagatePropertyAccessPath
    {
        public CodeLine() { }
        
        public CodeLine(string text, int offset, int? index = null, List<SyntaxMarkup>? syntax = null)
        {
            Text = text;
            Index = index;
            Offset = offset;
            Syntax = syntax;
        }
        
        private PropertyValue<string> _text = new PropertyValue<string>(nameof(CodeLine), nameof(Text));
        
        [Required]
        [JsonPropertyName("text")]
        public string Text
        {
            get => _text.GetValue();
            set => _text.SetValue(value);
        }
    
        private PropertyValue<int?> _index = new PropertyValue<int?>(nameof(CodeLine), nameof(Index));
        
        [JsonPropertyName("index")]
        public int? Index
        {
            get => _index.GetValue();
            set => _index.SetValue(value);
        }
    
        private PropertyValue<int> _offset = new PropertyValue<int>(nameof(CodeLine), nameof(Offset));
        
        [Required]
        [JsonPropertyName("offset")]
        public int Offset
        {
            get => _offset.GetValue();
            set => _offset.SetValue(value);
        }
    
        private PropertyValue<List<SyntaxMarkup>?> _syntax = new PropertyValue<List<SyntaxMarkup>?>(nameof(CodeLine), nameof(Syntax));
        
        [JsonPropertyName("syntax")]
        public List<SyntaxMarkup>? Syntax
        {
            get => _syntax.GetValue();
            set => _syntax.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _text.SetAccessPath(path, validateHasBeenSet);
            _index.SetAccessPath(path, validateHasBeenSet);
            _offset.SetAccessPath(path, validateHasBeenSet);
            _syntax.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}