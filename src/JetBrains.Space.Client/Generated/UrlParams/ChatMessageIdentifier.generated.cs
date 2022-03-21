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
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client;

[JsonConverter(typeof(UrlParameterConverter))]
public abstract class ChatMessageIdentifier : IUrlParameter
{
    public static ChatMessageIdentifier ExternalId(string externalId)
        => new ChatMessageIdentifierExternalId(externalId);
    
    public static ChatMessageIdentifier InternalId(string id)
        => new ChatMessageIdentifierInternalId(id);
    
    public class ChatMessageIdentifierExternalId : ChatMessageIdentifier
    {
        [Required]
        [JsonPropertyName("externalId")]
#if NET6_0_OR_GREATER
        public string ExternalId { get; init; }
#else
        public string ExternalId { get; set; }
#endif
        
#if !NET6_0_OR_GREATER
#pragma warning disable CS8618
        public ChatMessageIdentifierExternalId() { }
#pragma warning restore CS8618
#endif
        
        public ChatMessageIdentifierExternalId(string externalId)
        {
            ExternalId = externalId;
        }
        
        public override string ToString()
            => $"externalId:{ExternalId}";
    }
    
    public class ChatMessageIdentifierInternalId : ChatMessageIdentifier
    {
        [Required]
        [JsonPropertyName("id")]
#if NET6_0_OR_GREATER
        public string Id { get; init; }
#else
        public string Id { get; set; }
#endif
        
#if !NET6_0_OR_GREATER
#pragma warning disable CS8618
        public ChatMessageIdentifierInternalId() { }
#pragma warning restore CS8618
#endif
        
        public ChatMessageIdentifierInternalId(string id)
        {
            Id = id;
        }
        
        public override string ToString()
            => $"id:{Id}";
    }
    
}

