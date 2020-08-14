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

namespace SpaceDotNet.Client
{
    public interface ApplicationPayloadDto
         : IClassNameConvertible, IPropagatePropertyAccessPath
    {
        public static ListCommandsPayloadDto ListCommandsPayload(string accessToken, string? verificationToken = null, string? userId = null)
            => new ListCommandsPayloadDto(accessToken: accessToken, verificationToken: null, userId: null);
        
        public static MessageActionPayloadDto MessageActionPayload(string actionId, string actionValue, MessageContextDto message, string accessToken, string userId, string? verificationToken = null)
            => new MessageActionPayloadDto(actionId: actionId, actionValue: actionValue, message: message, accessToken: accessToken, userId: userId, verificationToken: null);
        
        public static MessagePayloadDto MessagePayload(MessageContextDto message, string accessToken, string userId, string? verificationToken = null)
            => new MessagePayloadDto(message: message, accessToken: accessToken, userId: userId, verificationToken: null);
        
    }
    
}
