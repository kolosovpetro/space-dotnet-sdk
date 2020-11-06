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
    public sealed class HAParameter
         : IPropagatePropertyAccessPath
    {
        public HAParameter() { }
        
        public HAParameter(HAField field, bool path)
        {
            Field = field;
            IsPath = path;
        }
        
        private PropertyValue<HAField> _field = new PropertyValue<HAField>(nameof(HAParameter), nameof(Field));
        
        [Required]
        [JsonPropertyName("field")]
        public HAField Field
        {
            get => _field.GetValue();
            set => _field.SetValue(value);
        }
    
        private PropertyValue<bool> _path = new PropertyValue<bool>(nameof(HAParameter), nameof(IsPath));
        
        [Required]
        [JsonPropertyName("path")]
        public bool IsPath
        {
            get => _path.GetValue();
            set => _path.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _field.SetAccessPath(path, validateHasBeenSet);
            _path.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}