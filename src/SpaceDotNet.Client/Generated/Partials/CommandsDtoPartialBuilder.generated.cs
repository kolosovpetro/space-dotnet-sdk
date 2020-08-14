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

namespace SpaceDotNet.Client.CommandsDtoPartialBuilder
{
    public static class CommandsDtoPartialExtensions
    {
        public static Partial<CommandsDto> WithCommands(this Partial<CommandsDto> it)
            => it.AddFieldName("commands");
        
        public static Partial<CommandsDto> WithCommands(this Partial<CommandsDto> it, Func<Partial<CommandDetailDto>, Partial<CommandDetailDto>> partialBuilder)
            => it.AddFieldName("commands", partialBuilder(new Partial<CommandDetailDto>(it)));
        
    }
    
}
