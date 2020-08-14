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

namespace SpaceDotNet.Client.TextDocumentDtoPartialBuilder
{
    public static class TextDocumentDtoPartialExtensions
    {
        public static Partial<TextDocumentDto> WithId(this Partial<TextDocumentDto> it)
            => it.AddFieldName("id");
        
        public static Partial<TextDocumentDto> WithResetCounter(this Partial<TextDocumentDto> it)
            => it.AddFieldName("resetCounter");
        
        public static Partial<TextDocumentDto> WithVersion(this Partial<TextDocumentDto> it)
            => it.AddFieldName("version");
        
        public static Partial<TextDocumentDto> WithType(this Partial<TextDocumentDto> it)
            => it.AddFieldName("type");
        
        public static Partial<TextDocumentDto> WithType(this Partial<TextDocumentDto> it, Func<Partial<DraftDocumentType>, Partial<DraftDocumentType>> partialBuilder)
            => it.AddFieldName("type", partialBuilder(new Partial<DraftDocumentType>(it)));
        
        public static Partial<TextDocumentDto> WithText(this Partial<TextDocumentDto> it)
            => it.AddFieldName("text");
        
    }
    
}
