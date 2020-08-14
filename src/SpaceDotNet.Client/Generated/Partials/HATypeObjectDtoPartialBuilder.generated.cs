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

namespace SpaceDotNet.Client.HATypeObjectDtoPartialBuilder
{
    public static class HATypeObjectDtoPartialExtensions
    {
        public static Partial<HATypeObjectDto> WithFields(this Partial<HATypeObjectDto> it)
            => it.AddFieldName("fields");
        
        public static Partial<HATypeObjectDto> WithFields(this Partial<HATypeObjectDto> it, Func<Partial<HAFieldDto>, Partial<HAFieldDto>> partialBuilder)
            => it.AddFieldName("fields", partialBuilder(new Partial<HAFieldDto>(it)));
        
        public static Partial<HATypeObjectDto> WithKind(this Partial<HATypeObjectDto> it)
            => it.AddFieldName("kind");
        
        public static Partial<HATypeObjectDto> WithKind(this Partial<HATypeObjectDto> it, Func<Partial<HATypeObjectKind>, Partial<HATypeObjectKind>> partialBuilder)
            => it.AddFieldName("kind", partialBuilder(new Partial<HATypeObjectKind>(it)));
        
        public static Partial<HATypeObjectDto> WithNullable(this Partial<HATypeObjectDto> it)
            => it.AddFieldName("nullable");
        
    }
    
}
