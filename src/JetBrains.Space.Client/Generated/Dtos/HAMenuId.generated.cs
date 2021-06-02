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
    public sealed class HAMenuId
         : IPropagatePropertyAccessPath
    {
        public HAMenuId() { }
        
        public HAMenuId(string menuId, HADto context)
        {
            MenuId = menuId;
            Context = context;
        }
        
        private PropertyValue<string> _menuId = new PropertyValue<string>(nameof(HAMenuId), nameof(MenuId));
        
        [Required]
        [JsonPropertyName("menuId")]
        public string MenuId
        {
            get => _menuId.GetValue();
            set => _menuId.SetValue(value);
        }
    
        private PropertyValue<HADto> _context = new PropertyValue<HADto>(nameof(HAMenuId), nameof(Context));
        
        [Required]
        [JsonPropertyName("context")]
        public HADto Context
        {
            get => _context.GetValue();
            set => _context.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _menuId.SetAccessPath(path, validateHasBeenSet);
            _context.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
