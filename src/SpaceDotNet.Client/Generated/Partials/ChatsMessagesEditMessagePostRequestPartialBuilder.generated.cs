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

namespace SpaceDotNet.Client.ChatsMessagesEditMessagePostRequestPartialBuilder
{
    public static class ChatsMessagesEditMessagePostRequestPartialExtensions
    {
        public static Partial<ChatsMessagesEditMessagePostRequest> WithChannel(this Partial<ChatsMessagesEditMessagePostRequest> it)
            => it.AddFieldName("channel");
        
        public static Partial<ChatsMessagesEditMessagePostRequest> WithMessage(this Partial<ChatsMessagesEditMessagePostRequest> it)
            => it.AddFieldName("message");
        
        public static Partial<ChatsMessagesEditMessagePostRequest> WithMessage(this Partial<ChatsMessagesEditMessagePostRequest> it, Func<Partial<ChatMessageIdentifier>, Partial<ChatMessageIdentifier>> partialBuilder)
            => it.AddFieldName("message", partialBuilder(new Partial<ChatMessageIdentifier>(it)));
        
        public static Partial<ChatsMessagesEditMessagePostRequest> WithContent(this Partial<ChatsMessagesEditMessagePostRequest> it)
            => it.AddFieldName("content");
        
        public static Partial<ChatsMessagesEditMessagePostRequest> WithContent(this Partial<ChatsMessagesEditMessagePostRequest> it, Func<Partial<ChatMessageDto>, Partial<ChatMessageDto>> partialBuilder)
            => it.AddFieldName("content", partialBuilder(new Partial<ChatMessageDto>(it)));
        
        public static Partial<ChatsMessagesEditMessagePostRequest> WithUnfurlLinks(this Partial<ChatsMessagesEditMessagePostRequest> it)
            => it.AddFieldName("unfurlLinks");
        
    }
    
}
