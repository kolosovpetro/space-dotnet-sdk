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

namespace SpaceDotNet.Client.PlainParameterRecordDtoPartialBuilder
{
    public static class PlainParameterRecordDtoPartialExtensions
    {
        public static Partial<PlainParameterRecordDto> WithId(this Partial<PlainParameterRecordDto> it)
            => it.AddFieldName("id");
        
        public static Partial<PlainParameterRecordDto> WithArchived(this Partial<PlainParameterRecordDto> it)
            => it.AddFieldName("archived");
        
        public static Partial<PlainParameterRecordDto> WithBundleId(this Partial<PlainParameterRecordDto> it)
            => it.AddFieldName("bundleId");
        
        public static Partial<PlainParameterRecordDto> WithKey(this Partial<PlainParameterRecordDto> it)
            => it.AddFieldName("key");
        
        public static Partial<PlainParameterRecordDto> WithValue(this Partial<PlainParameterRecordDto> it)
            => it.AddFieldName("value");
        
    }
    
}
