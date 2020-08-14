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

namespace SpaceDotNet.Client.ContainerImageConfigDtoPartialBuilder
{
    public static class ContainerImageConfigDtoPartialExtensions
    {
        public static Partial<ContainerImageConfigDto> WithUserName(this Partial<ContainerImageConfigDto> it)
            => it.AddFieldName("userName");
        
        public static Partial<ContainerImageConfigDto> WithPorts(this Partial<ContainerImageConfigDto> it)
            => it.AddFieldName("ports");
        
        public static Partial<ContainerImageConfigDto> WithVolumes(this Partial<ContainerImageConfigDto> it)
            => it.AddFieldName("volumes");
        
        public static Partial<ContainerImageConfigDto> WithEnv(this Partial<ContainerImageConfigDto> it)
            => it.AddFieldName("env");
        
        public static Partial<ContainerImageConfigDto> WithWorkingDir(this Partial<ContainerImageConfigDto> it)
            => it.AddFieldName("workingDir");
        
        public static Partial<ContainerImageConfigDto> WithEntryPoint(this Partial<ContainerImageConfigDto> it)
            => it.AddFieldName("entryPoint");
        
        public static Partial<ContainerImageConfigDto> WithCmd(this Partial<ContainerImageConfigDto> it)
            => it.AddFieldName("cmd");
        
        public static Partial<ContainerImageConfigDto> WithLabels(this Partial<ContainerImageConfigDto> it)
            => it.AddFieldName("labels");
        
    }
    
}
