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

namespace SpaceDotNet.Client.HATypeRefDtoPartialBuilder
{
    public static class HATypeRefDtoPartialExtensions
    {
        public static Partial<HATypeRefDto> WithDto(this Partial<HATypeRefDto> it)
            => it.AddFieldName("dto");
        
        public static Partial<HATypeRefDto> WithDto(this Partial<HATypeRefDto> it, Func<Partial<HADtoDto>, Partial<HADtoDto>> partialBuilder)
            => it.AddFieldName("dto", partialBuilder(new Partial<HADtoDto>(it)));
        
        public static Partial<HATypeRefDto> WithNullable(this Partial<HATypeRefDto> it)
            => it.AddFieldName("nullable");
        
    }
    
}
