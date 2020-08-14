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
    public sealed class HATypeDtoDto
         : HATypeDto, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public override string? ClassName => "HA_Type.Dto";
        
        public HATypeDtoDto() { }
        
        public HATypeDtoDto(HADtoDto dto, bool nullable)
        {
            Dto = dto;
            Nullable = nullable;
        }
        
        private PropertyValue<HADtoDto> _dto = new PropertyValue<HADtoDto>(nameof(HATypeDtoDto), nameof(Dto));
        
        [Required]
        [JsonPropertyName("dto")]
        public HADtoDto Dto
        {
            get { return _dto.GetValue(); }
            set { _dto.SetValue(value); }
        }
    
        private PropertyValue<bool> _nullable = new PropertyValue<bool>(nameof(HATypeDtoDto), nameof(Nullable));
        
        [Required]
        [JsonPropertyName("nullable")]
        public bool Nullable
        {
            get { return _nullable.GetValue(); }
            set { _nullable.SetValue(value); }
        }
    
        public override void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _dto.SetAccessPath(path, validateHasBeenSet);
            _nullable.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
