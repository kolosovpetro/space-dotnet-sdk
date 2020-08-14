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
    public sealed class IntCFValueDto
         : CFValueDto, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public override string? ClassName => "IntCFValue";
        
        public IntCFValueDto() { }
        
        public IntCFValueDto(int? value = null)
        {
            Value = value;
        }
        
        private PropertyValue<int?> _value = new PropertyValue<int?>(nameof(IntCFValueDto), nameof(Value));
        
        [JsonPropertyName("value")]
        public int? Value
        {
            get { return _value.GetValue(); }
            set { _value.SetValue(value); }
        }
    
        public override void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _value.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
