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
    [JsonConverter(typeof(UrlParameterConverter))]
    public abstract class ChatMessageIdentifier : IUrlParameter
    {
        public static ChatMessageIdentifier InternalId(string id)
            => new ChatMessageIdentifierInternalId(id);
        
        public static ChatMessageIdentifier ExternalId(string externalId)
            => new ChatMessageIdentifierExternalId(externalId);
        
        private class ChatMessageIdentifierInternalId : ChatMessageIdentifier
        {
            public readonly string _id;
            
            public ChatMessageIdentifierInternalId(string id)
            {
                _id = id;
            }
            
            public override string ToString()
            {
                return $"id:{_id}";
            }
        }
        
        private class ChatMessageIdentifierExternalId : ChatMessageIdentifier
        {
            public readonly string _externalId;
            
            public ChatMessageIdentifierExternalId(string externalId)
            {
                _externalId = externalId;
            }
            
            public override string ToString()
            {
                return $"externalId:{_externalId}";
            }
        }
        
    }
    
}
