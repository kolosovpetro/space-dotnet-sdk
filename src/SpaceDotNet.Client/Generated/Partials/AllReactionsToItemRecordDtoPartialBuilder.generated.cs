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

namespace SpaceDotNet.Client.AllReactionsToItemRecordDtoPartialBuilder
{
    public static class AllReactionsToItemRecordDtoPartialExtensions
    {
        public static Partial<AllReactionsToItemRecordDto> WithId(this Partial<AllReactionsToItemRecordDto> it)
            => it.AddFieldName("id");
        
        public static Partial<AllReactionsToItemRecordDto> WithReactions(this Partial<AllReactionsToItemRecordDto> it)
            => it.AddFieldName("reactions");
        
        public static Partial<AllReactionsToItemRecordDto> WithReactions(this Partial<AllReactionsToItemRecordDto> it, Func<Partial<CertainReactionToItemRecordDto>, Partial<CertainReactionToItemRecordDto>> partialBuilder)
            => it.AddFieldName("reactions", partialBuilder(new Partial<CertainReactionToItemRecordDto>(it)));
        
        public static Partial<AllReactionsToItemRecordDto> WithEmojiReactions(this Partial<AllReactionsToItemRecordDto> it)
            => it.AddFieldName("emojiReactions");
        
        public static Partial<AllReactionsToItemRecordDto> WithEmojiReactions(this Partial<AllReactionsToItemRecordDto> it, Func<Partial<EmojiReactionRecordDto>, Partial<EmojiReactionRecordDto>> partialBuilder)
            => it.AddFieldName("emojiReactions", partialBuilder(new Partial<EmojiReactionRecordDto>(it)));
        
    }
    
}
