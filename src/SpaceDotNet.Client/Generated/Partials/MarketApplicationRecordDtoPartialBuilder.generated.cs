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

namespace SpaceDotNet.Client.MarketApplicationRecordDtoPartialBuilder
{
    public static class MarketApplicationRecordDtoPartialExtensions
    {
        public static Partial<MarketApplicationRecordDto> WithId(this Partial<MarketApplicationRecordDto> it)
            => it.AddFieldName("id");
        
        public static Partial<MarketApplicationRecordDto> WithArchived(this Partial<MarketApplicationRecordDto> it)
            => it.AddFieldName("archived");
        
        public static Partial<MarketApplicationRecordDto> WithName(this Partial<MarketApplicationRecordDto> it)
            => it.AddFieldName("name");
        
        public static Partial<MarketApplicationRecordDto> WithDescription(this Partial<MarketApplicationRecordDto> it)
            => it.AddFieldName("description");
        
        public static Partial<MarketApplicationRecordDto> WithLastUpdated(this Partial<MarketApplicationRecordDto> it)
            => it.AddFieldName("lastUpdated");
        
    }
    
}
