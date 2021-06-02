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
    public sealed class SprintRecord
         : IPropagatePropertyAccessPath
    {
        public SprintRecord() { }
        
        public SprintRecord(string id, bool archived, BoardRecord board, string name, SprintState state, DateTime from, DateTime to, bool @default, string? description = null)
        {
            Id = id;
            IsArchived = archived;
            Board = board;
            Name = name;
            State = state;
            From = from;
            To = to;
            IsDefault = @default;
            Description = description;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(SprintRecord), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get => _id.GetValue();
            set => _id.SetValue(value);
        }
    
        private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(SprintRecord), nameof(IsArchived));
        
        [Required]
        [JsonPropertyName("archived")]
        public bool IsArchived
        {
            get => _archived.GetValue();
            set => _archived.SetValue(value);
        }
    
        private PropertyValue<BoardRecord> _board = new PropertyValue<BoardRecord>(nameof(SprintRecord), nameof(Board));
        
        [Required]
        [JsonPropertyName("board")]
        public BoardRecord Board
        {
            get => _board.GetValue();
            set => _board.SetValue(value);
        }
    
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(SprintRecord), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get => _name.GetValue();
            set => _name.SetValue(value);
        }
    
        private PropertyValue<SprintState> _state = new PropertyValue<SprintState>(nameof(SprintRecord), nameof(State));
        
        [Required]
        [JsonPropertyName("state")]
        public SprintState State
        {
            get => _state.GetValue();
            set => _state.SetValue(value);
        }
    
        private PropertyValue<DateTime> _from = new PropertyValue<DateTime>(nameof(SprintRecord), nameof(From));
        
        [Required]
        [JsonPropertyName("from")]
        [JsonConverter(typeof(SpaceDateConverter))]
        public DateTime From
        {
            get => _from.GetValue();
            set => _from.SetValue(value);
        }
    
        private PropertyValue<DateTime> _to = new PropertyValue<DateTime>(nameof(SprintRecord), nameof(To));
        
        [Required]
        [JsonPropertyName("to")]
        [JsonConverter(typeof(SpaceDateConverter))]
        public DateTime To
        {
            get => _to.GetValue();
            set => _to.SetValue(value);
        }
    
        private PropertyValue<bool> _default = new PropertyValue<bool>(nameof(SprintRecord), nameof(IsDefault));
        
        [Required]
        [JsonPropertyName("default")]
        public bool IsDefault
        {
            get => _default.GetValue();
            set => _default.SetValue(value);
        }
    
        private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(SprintRecord), nameof(Description));
        
        [JsonPropertyName("description")]
        public string? Description
        {
            get => _description.GetValue();
            set => _description.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _archived.SetAccessPath(path, validateHasBeenSet);
            _board.SetAccessPath(path, validateHasBeenSet);
            _name.SetAccessPath(path, validateHasBeenSet);
            _state.SetAccessPath(path, validateHasBeenSet);
            _from.SetAccessPath(path, validateHasBeenSet);
            _to.SetAccessPath(path, validateHasBeenSet);
            _default.SetAccessPath(path, validateHasBeenSet);
            _description.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
