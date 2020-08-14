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

namespace SpaceDotNet.Client.MessageButtonDtoPartialBuilder
{
    public static class MessageButtonDtoPartialExtensions
    {
        public static Partial<MessageButtonDto> WithText(this Partial<MessageButtonDto> it)
            => it.AddFieldName("text");
        
        public static Partial<MessageButtonDto> WithStyle(this Partial<MessageButtonDto> it)
            => it.AddFieldName("style");
        
        public static Partial<MessageButtonDto> WithStyle(this Partial<MessageButtonDto> it, Func<Partial<MessageButtonStyle>, Partial<MessageButtonStyle>> partialBuilder)
            => it.AddFieldName("style", partialBuilder(new Partial<MessageButtonStyle>(it)));
        
        public static Partial<MessageButtonDto> WithAction(this Partial<MessageButtonDto> it)
            => it.AddFieldName("action");
        
        public static Partial<MessageButtonDto> WithAction(this Partial<MessageButtonDto> it, Func<Partial<MessageActionDto>, Partial<MessageActionDto>> partialBuilder)
            => it.AddFieldName("action", partialBuilder(new Partial<MessageActionDto>(it)));
        
        public static Partial<MessageButtonDto> WithDisabled(this Partial<MessageButtonDto> it)
            => it.AddFieldName("disabled");
        
    }
    
}
