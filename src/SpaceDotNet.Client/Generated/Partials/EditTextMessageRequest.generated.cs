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

namespace SpaceDotNet.Client.EditTextMessageRequestExtensions
{
    public static class EditTextMessageRequestPartialExtensions
    {
        public static Partial<EditTextMessageRequest> WithChannelId(this Partial<EditTextMessageRequest> it)
            => it.AddFieldName("channelId");
        
        public static Partial<EditTextMessageRequest> WithText(this Partial<EditTextMessageRequest> it)
            => it.AddFieldName("text");
        
        public static Partial<EditTextMessageRequest> WithMessageId(this Partial<EditTextMessageRequest> it)
            => it.AddFieldName("messageId");
        
    }
    
}
