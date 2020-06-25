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

namespace SpaceDotNet.Client.ExternalEntityInfoRecordDtoPartialBuilder
{
    public static class ExternalEntityInfoRecordDtoPartialExtensions
    {
        public static Partial<ExternalEntityInfoRecordDto> WithId(this Partial<ExternalEntityInfoRecordDto> it)
            => it.AddFieldName("id");
        
        public static Partial<ExternalEntityInfoRecordDto> WithArchived(this Partial<ExternalEntityInfoRecordDto> it)
            => it.AddFieldName("archived");
        
        public static Partial<ExternalEntityInfoRecordDto> WithExternalId(this Partial<ExternalEntityInfoRecordDto> it)
            => it.AddFieldName("externalId");
        
        public static Partial<ExternalEntityInfoRecordDto> WithExternalUrl(this Partial<ExternalEntityInfoRecordDto> it)
            => it.AddFieldName("externalUrl");
        
        public static Partial<ExternalEntityInfoRecordDto> WithTransaction(this Partial<ExternalEntityInfoRecordDto> it)
            => it.AddFieldName("transaction");
        
        public static Partial<ExternalEntityInfoRecordDto> WithTransaction(this Partial<ExternalEntityInfoRecordDto> it, Func<Partial<ImportTransactionRecordDto>, Partial<ImportTransactionRecordDto>> partialBuilder)
            => it.AddFieldName("transaction", partialBuilder(new Partial<ImportTransactionRecordDto>(it)));
        
    }
    
}