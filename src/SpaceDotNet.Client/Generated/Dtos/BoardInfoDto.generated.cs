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
    public sealed class BoardInfoDto
         : IPropagatePropertyAccessPath
    {
        public BoardInfoDto() { }
        
        public BoardInfoDto(BoardOwnersDto owners, BoardColumnsDto columns, string? description = null)
        {
            Owners = owners;
            Columns = columns;
            Description = description;
        }
        
        private PropertyValue<BoardOwnersDto> _owners = new PropertyValue<BoardOwnersDto>(nameof(BoardInfoDto), nameof(Owners));
        
        [Required]
        [JsonPropertyName("owners")]
        public BoardOwnersDto Owners
        {
            get { return _owners.GetValue(); }
            set { _owners.SetValue(value); }
        }
    
        private PropertyValue<BoardColumnsDto> _columns = new PropertyValue<BoardColumnsDto>(nameof(BoardInfoDto), nameof(Columns));
        
        [Required]
        [JsonPropertyName("columns")]
        public BoardColumnsDto Columns
        {
            get { return _columns.GetValue(); }
            set { _columns.SetValue(value); }
        }
    
        private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(BoardInfoDto), nameof(Description));
        
        [JsonPropertyName("description")]
        public string? Description
        {
            get { return _description.GetValue(); }
            set { _description.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _owners.SetAccessPath(path, validateHasBeenSet);
            _columns.SetAccessPath(path, validateHasBeenSet);
            _description.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
