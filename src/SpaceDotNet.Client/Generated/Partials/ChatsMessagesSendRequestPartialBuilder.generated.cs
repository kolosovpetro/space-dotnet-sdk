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

namespace SpaceDotNet.Client.ChatsMessagesSendRequestPartialBuilder
{
    public static class ChatsMessagesSendRequestPartialExtensions
    {
        public static Partial<ChatsMessagesSendRequest> WithChannel(this Partial<ChatsMessagesSendRequest> it)
            => it.AddFieldName("channel");
        
        public static Partial<ChatsMessagesSendRequest> WithText(this Partial<ChatsMessagesSendRequest> it)
            => it.AddFieldName("text");
        
        public static Partial<ChatsMessagesSendRequest> WithPending(this Partial<ChatsMessagesSendRequest> it)
            => it.AddFieldName("pending");
        
        public static Partial<ChatsMessagesSendRequest> WithTemporaryId(this Partial<ChatsMessagesSendRequest> it)
            => it.AddFieldName("temporaryId");
        
    }
    
}