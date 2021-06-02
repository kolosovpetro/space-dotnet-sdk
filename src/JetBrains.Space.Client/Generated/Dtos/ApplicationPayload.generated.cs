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

namespace JetBrains.Space.Client
{
    public interface ApplicationPayload
         : IClassNameConvertible, IPropagatePropertyAccessPath
    {
        public static InitPayload InitPayload(string userId, string? clientSecret = null, string? state = null, string? accessToken = null, string? verificationToken = null, string? serverUrl = null, string? clientId = null, string? orgId = null)
            => new InitPayload(userId: userId, clientSecret: clientSecret, state: state, accessToken: accessToken, verificationToken: verificationToken, serverUrl: serverUrl, clientId: clientId, orgId: orgId);
        
        public static ListCommandsPayload ListCommandsPayload(string? accessToken = null, string? verificationToken = null, string? userId = null, string? serverUrl = null, string? clientId = null, string? orgId = null)
            => new ListCommandsPayload(accessToken: accessToken, verificationToken: verificationToken, userId: userId, serverUrl: serverUrl, clientId: clientId, orgId: orgId);
        
        public static ListMenuExtensionsPayload ListMenuExtensionsPayload(string? accessToken = null, string? verificationToken = null, string? userId = null, string? serverUrl = null, string? clientId = null, string? orgId = null)
            => new ListMenuExtensionsPayload(accessToken: accessToken, verificationToken: verificationToken, userId: userId, serverUrl: serverUrl, clientId: clientId, orgId: orgId);
        
        public static MenuActionPayload MenuActionPayload(string extensionName, MenuActionContext context, string userId, string? accessToken = null, string? verificationToken = null, string? serverUrl = null, string? clientId = null, string? orgId = null)
            => new MenuActionPayload(extensionName: extensionName, context: context, userId: userId, accessToken: accessToken, verificationToken: verificationToken, serverUrl: serverUrl, clientId: clientId, orgId: orgId);
        
        public static MessageActionPayload MessageActionPayload(string actionId, string actionValue, MessageContext message, string userId, string? accessToken = null, string? verificationToken = null, string? serverUrl = null, string? clientId = null, string? orgId = null)
            => new MessageActionPayload(actionId: actionId, actionValue: actionValue, message: message, userId: userId, accessToken: accessToken, verificationToken: verificationToken, serverUrl: serverUrl, clientId: clientId, orgId: orgId);
        
        public static MessagePayload MessagePayload(MessageContext message, string userId, string? accessToken = null, string? verificationToken = null, string? serverUrl = null, string? clientId = null, string? orgId = null)
            => new MessagePayload(message: message, userId: userId, accessToken: accessToken, verificationToken: verificationToken, serverUrl: serverUrl, clientId: clientId, orgId: orgId);
        
        public static WebhookRequestPayload WebhookRequestPayload(WebhookEvent payload, string? accessToken = null, string? verificationToken = null, string? serverUrl = null, string? clientId = null, string? orgId = null)
            => new WebhookRequestPayload(payload: payload, accessToken: accessToken, verificationToken: verificationToken, serverUrl: serverUrl, clientId: clientId, orgId: orgId);
        
    }
    
}
