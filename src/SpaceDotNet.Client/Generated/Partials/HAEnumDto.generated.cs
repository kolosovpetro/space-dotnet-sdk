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
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client.HAEnumExtensions
{
    public static class HAEnumDtoPartialExtensions
    {
        public static Partial<HAEnumDto> WithId(this Partial<HAEnumDto> it)
            => it.AddFieldName("id");
        
        public static Partial<HAEnumDto> WithName(this Partial<HAEnumDto> it)
            => it.AddFieldName("name");
        
        public static Partial<HAEnumDto> WithValues(this Partial<HAEnumDto> it)
            => it.AddFieldName("values");
        
        public static Partial<HAEnumDto> WithDeprecation(this Partial<HAEnumDto> it)
            => it.AddFieldName("deprecation");
        
        public static Partial<HAEnumDto> WithDeprecation(this Partial<HAEnumDto> it, Func<Partial<HADeprecationDto>, Partial<HADeprecationDto>> partialBuilder)
            => it.AddFieldName("deprecation", partialBuilder(new Partial<HADeprecationDto>()));
        
    }
    
}
