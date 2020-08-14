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

namespace SpaceDotNet.Client.M2ChannelContentRecordDtoPartialBuilder
{
    public static class M2ChannelContentRecordDtoPartialExtensions
    {
        public static Partial<M2ChannelContentRecordDto> WithId(this Partial<M2ChannelContentRecordDto> it)
            => it.AddFieldName("id");
        
        public static Partial<M2ChannelContentRecordDto> WithContent(this Partial<M2ChannelContentRecordDto> it)
            => it.AddFieldName("content");
        
        public static Partial<M2ChannelContentRecordDto> WithContent(this Partial<M2ChannelContentRecordDto> it, Func<Partial<M2ChannelContentInfoDto>, Partial<M2ChannelContentInfoDto>> partialBuilder)
            => it.AddFieldName("content", partialBuilder(new Partial<M2ChannelContentInfoDto>(it)));
        
    }
    
}
