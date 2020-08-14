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

namespace SpaceDotNet.Client.HAUrlParameterDtoPartialBuilder
{
    public static class HAUrlParameterDtoPartialExtensions
    {
        public static Partial<HAUrlParameterDto> WithId(this Partial<HAUrlParameterDto> it)
            => it.AddFieldName("id");
        
        public static Partial<HAUrlParameterDto> WithName(this Partial<HAUrlParameterDto> it)
            => it.AddFieldName("name");
        
        public static Partial<HAUrlParameterDto> WithOptions(this Partial<HAUrlParameterDto> it)
            => it.AddFieldName("options");
        
        public static Partial<HAUrlParameterDto> WithOptions(this Partial<HAUrlParameterDto> it, Func<Partial<HAUrlParameterOptionDto>, Partial<HAUrlParameterOptionDto>> partialBuilder)
            => it.AddFieldName("options", partialBuilder(new Partial<HAUrlParameterOptionDto>(it)));
        
        public static Partial<HAUrlParameterDto> WithDeprecation(this Partial<HAUrlParameterDto> it)
            => it.AddFieldName("deprecation");
        
        public static Partial<HAUrlParameterDto> WithDeprecation(this Partial<HAUrlParameterDto> it, Func<Partial<HADeprecationDto>, Partial<HADeprecationDto>> partialBuilder)
            => it.AddFieldName("deprecation", partialBuilder(new Partial<HADeprecationDto>(it)));
        
    }
    
}
