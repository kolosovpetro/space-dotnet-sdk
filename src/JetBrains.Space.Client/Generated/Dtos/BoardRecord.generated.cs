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
    public sealed class BoardRecord
         : IPropagatePropertyAccessPath
    {
        public BoardRecord() { }
        
        public BoardRecord(string id, bool archived, string name, BoardRecord board, BoardInfo info, BoardWidgetData? data = null, DateTime? from = null, DateTime? to = null)
        {
            Id = id;
            IsArchived = archived;
            Name = name;
            Board = board;
            Data = data;
            From = from;
            Info = info;
            To = to;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(BoardRecord), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get => _id.GetValue();
            set => _id.SetValue(value);
        }
    
        private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(BoardRecord), nameof(IsArchived));
        
        [Required]
        [JsonPropertyName("archived")]
        public bool IsArchived
        {
            get => _archived.GetValue();
            set => _archived.SetValue(value);
        }
    
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(BoardRecord), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get => _name.GetValue();
            set => _name.SetValue(value);
        }
    
        private PropertyValue<BoardRecord> _board = new PropertyValue<BoardRecord>(nameof(BoardRecord), nameof(Board));
        
        [Required]
        [JsonPropertyName("board")]
        public BoardRecord Board
        {
            get => _board.GetValue();
            set => _board.SetValue(value);
        }
    
        private PropertyValue<BoardWidgetData?> _data = new PropertyValue<BoardWidgetData?>(nameof(BoardRecord), nameof(Data));
        
        [JsonPropertyName("data")]
        public BoardWidgetData? Data
        {
            get => _data.GetValue();
            set => _data.SetValue(value);
        }
    
        private PropertyValue<DateTime?> _from = new PropertyValue<DateTime?>(nameof(BoardRecord), nameof(From));
        
        [JsonPropertyName("from")]
        [JsonConverter(typeof(SpaceDateConverter))]
        public DateTime? From
        {
            get => _from.GetValue();
            set => _from.SetValue(value);
        }
    
        private PropertyValue<BoardInfo> _info = new PropertyValue<BoardInfo>(nameof(BoardRecord), nameof(Info));
        
        [Required]
        [JsonPropertyName("info")]
        public BoardInfo Info
        {
            get => _info.GetValue();
            set => _info.SetValue(value);
        }
    
        private PropertyValue<DateTime?> _to = new PropertyValue<DateTime?>(nameof(BoardRecord), nameof(To));
        
        [JsonPropertyName("to")]
        [JsonConverter(typeof(SpaceDateConverter))]
        public DateTime? To
        {
            get => _to.GetValue();
            set => _to.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _archived.SetAccessPath(path, validateHasBeenSet);
            _name.SetAccessPath(path, validateHasBeenSet);
            _board.SetAccessPath(path, validateHasBeenSet);
            _data.SetAccessPath(path, validateHasBeenSet);
            _from.SetAccessPath(path, validateHasBeenSet);
            _info.SetAccessPath(path, validateHasBeenSet);
            _to.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
