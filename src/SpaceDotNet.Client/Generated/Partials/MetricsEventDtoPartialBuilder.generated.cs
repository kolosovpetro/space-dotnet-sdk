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

namespace SpaceDotNet.Client.MetricsEventDtoPartialBuilder
{
    public static class MetricsEventDtoPartialExtensions
    {
        public static Partial<MetricsEventDto> WithId(this Partial<MetricsEventDto> it)
            => it.AddFieldName("id");
        
        public static Partial<MetricsEventDto> WithTime(this Partial<MetricsEventDto> it)
            => it.AddFieldName("time");
        
        public static Partial<MetricsEventDto> WithProps(this Partial<MetricsEventDto> it)
            => it.AddFieldName("props");
        
        public static Partial<MetricsEventDto> WithProps(this Partial<MetricsEventDto> it, Func<Partial<MetricsPropDto>, Partial<MetricsPropDto>> partialBuilder)
            => it.AddFieldName("props", partialBuilder(new Partial<MetricsPropDto>(it)));
        
        public static Partial<MetricsEventDto> WithPoints(this Partial<MetricsEventDto> it)
            => it.AddFieldName("points");
        
        public static Partial<MetricsEventDto> WithPoints(this Partial<MetricsEventDto> it, Func<Partial<MetricsPointDto>, Partial<MetricsPointDto>> partialBuilder)
            => it.AddFieldName("points", partialBuilder(new Partial<MetricsPointDto>(it)));
        
    }
    
}