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
    public sealed class BoardColumnDto
         : IPropagatePropertyAccessPath
    {
        public BoardColumnDto() { }
        
        public BoardColumnDto(string name, List<IssueStatusDto> statuses, bool? @default = null)
        {
            Name = name;
            Statuses = statuses;
            Default = @default;
        }
        
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(BoardColumnDto), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get { return _name.GetValue(); }
            set { _name.SetValue(value); }
        }
    
        private PropertyValue<List<IssueStatusDto>> _statuses = new PropertyValue<List<IssueStatusDto>>(nameof(BoardColumnDto), nameof(Statuses));
        
        [Required]
        [JsonPropertyName("statuses")]
        public List<IssueStatusDto> Statuses
        {
            get { return _statuses.GetValue(); }
            set { _statuses.SetValue(value); }
        }
    
        private PropertyValue<bool?> _default = new PropertyValue<bool?>(nameof(BoardColumnDto), nameof(Default));
        
        [JsonPropertyName("default")]
        public bool? Default
        {
            get { return _default.GetValue(); }
            set { _default.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _name.SetAccessPath(path, validateHasBeenSet);
            _statuses.SetAccessPath(path, validateHasBeenSet);
            _default.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
