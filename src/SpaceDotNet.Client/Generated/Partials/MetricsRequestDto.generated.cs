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

namespace SpaceDotNet.Client.MetricsRequestExtensions
{
    public static class MetricsRequestDtoPartialExtensions
    {
        public static Partial<MetricsRequestDto> WithClient(this Partial<MetricsRequestDto> it)
            => it.AddFieldName("client");
        
        public static Partial<MetricsRequestDto> WithClient(this Partial<MetricsRequestDto> it, Func<Partial<ClientInfoDto>, Partial<ClientInfoDto>> partialBuilder)
            => it.AddFieldName("client", partialBuilder(new Partial<ClientInfoDto>()));
        
        public static Partial<MetricsRequestDto> WithEvents(this Partial<MetricsRequestDto> it)
            => it.AddFieldName("events");
        
        public static Partial<MetricsRequestDto> WithEvents(this Partial<MetricsRequestDto> it, Func<Partial<MetricsEventDto>, Partial<MetricsEventDto>> partialBuilder)
            => it.AddFieldName("events", partialBuilder(new Partial<MetricsEventDto>()));
        
    }
    
}