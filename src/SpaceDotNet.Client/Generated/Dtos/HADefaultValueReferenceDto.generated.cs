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
    public sealed class HADefaultValueReferenceDto
         : HADefaultValueDto, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public override string? ClassName => "HA_DefaultValue.Reference";
        
        public HADefaultValueReferenceDto() { }
        
        public HADefaultValueReferenceDto(string paramName)
        {
            ParamName = paramName;
        }
        
        private PropertyValue<string> _paramName = new PropertyValue<string>(nameof(HADefaultValueReferenceDto), nameof(ParamName));
        
        [Required]
        [JsonPropertyName("paramName")]
        public string ParamName
        {
            get { return _paramName.GetValue(); }
            set { _paramName.SetValue(value); }
        }
    
        public override void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _paramName.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
