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

namespace SpaceDotNet.Client.ContainerImageLayerDtoPartialBuilder
{
    public static class ContainerImageLayerDtoPartialExtensions
    {
        public static Partial<ContainerImageLayerDto> WithId(this Partial<ContainerImageLayerDto> it)
            => it.AddFieldName("id");
        
        public static Partial<ContainerImageLayerDto> WithCreated(this Partial<ContainerImageLayerDto> it)
            => it.AddFieldName("created");
        
        public static Partial<ContainerImageLayerDto> WithStatement(this Partial<ContainerImageLayerDto> it)
            => it.AddFieldName("statement");
        
        public static Partial<ContainerImageLayerDto> WithCommand(this Partial<ContainerImageLayerDto> it)
            => it.AddFieldName("command");
        
        public static Partial<ContainerImageLayerDto> WithSize(this Partial<ContainerImageLayerDto> it)
            => it.AddFieldName("size");
        
    }
    
}
