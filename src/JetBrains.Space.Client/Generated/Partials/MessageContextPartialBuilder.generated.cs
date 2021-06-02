// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS1591
#pragma warning disable CS0108
#pragma warning disable 618

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client.MessageContextPartialBuilder
{
    public static class MessageContextPartialExtensions
    {
        public static Partial<MessageContext> WithMessageId(this Partial<MessageContext> it)
            => it.AddFieldName("messageId");
        
        public static Partial<MessageContext> WithChannelId(this Partial<MessageContext> it)
            => it.AddFieldName("channelId");
        
        public static Partial<MessageContext> WithMessageData(this Partial<MessageContext> it)
            => it.AddFieldName("messageData");
        
        public static Partial<MessageContext> WithBody(this Partial<MessageContext> it)
            => it.AddFieldName("body");
        
        public static Partial<MessageContext> WithBody(this Partial<MessageContext> it, Func<Partial<ChatMessage>, Partial<ChatMessage>> partialBuilder)
            => it.AddFieldName("body", partialBuilder(new Partial<ChatMessage>(it)));
        
        public static Partial<MessageContext> WithAttachments(this Partial<MessageContext> it)
            => it.AddFieldName("attachments");
        
        public static Partial<MessageContext> WithAttachments(this Partial<MessageContext> it, Func<Partial<Attachment>, Partial<Attachment>> partialBuilder)
            => it.AddFieldName("attachments", partialBuilder(new Partial<Attachment>(it)));
        
        public static Partial<MessageContext> WithExternalId(this Partial<MessageContext> it)
            => it.AddFieldName("externalId");
        
        public static Partial<MessageContext> WithCreatedTime(this Partial<MessageContext> it)
            => it.AddFieldName("createdTime");
        
    }
    
}
