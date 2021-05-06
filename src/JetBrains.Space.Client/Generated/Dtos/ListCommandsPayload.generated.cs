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
    public sealed class ListCommandsPayload
         : ApplicationPayload, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "ListCommandsPayload";
        
        public ListCommandsPayload() { }
        
        public ListCommandsPayload(string? accessToken = null, string? verificationToken = null, string? userId = null, string? serverUrl = null, string? clientId = null, string? orgId = null)
        {
            AccessToken = accessToken;
            VerificationToken = verificationToken;
            UserId = userId;
            ServerUrl = serverUrl;
            ClientId = clientId;
            OrgId = orgId;
        }
        
        private PropertyValue<string?> _accessToken = new PropertyValue<string?>(nameof(ListCommandsPayload), nameof(AccessToken));
        
        [JsonPropertyName("accessToken")]
        public string? AccessToken
        {
            get => _accessToken.GetValue();
            set => _accessToken.SetValue(value);
        }
    
        private PropertyValue<string?> _verificationToken = new PropertyValue<string?>(nameof(ListCommandsPayload), nameof(VerificationToken));
        
        [JsonPropertyName("verificationToken")]
        public string? VerificationToken
        {
            get => _verificationToken.GetValue();
            set => _verificationToken.SetValue(value);
        }
    
        private PropertyValue<string?> _userId = new PropertyValue<string?>(nameof(ListCommandsPayload), nameof(UserId));
        
        [JsonPropertyName("userId")]
        public string? UserId
        {
            get => _userId.GetValue();
            set => _userId.SetValue(value);
        }
    
        private PropertyValue<string?> _serverUrl = new PropertyValue<string?>(nameof(ListCommandsPayload), nameof(ServerUrl));
        
        [JsonPropertyName("serverUrl")]
        public string? ServerUrl
        {
            get => _serverUrl.GetValue();
            set => _serverUrl.SetValue(value);
        }
    
        private PropertyValue<string?> _clientId = new PropertyValue<string?>(nameof(ListCommandsPayload), nameof(ClientId));
        
        [JsonPropertyName("clientId")]
        public string? ClientId
        {
            get => _clientId.GetValue();
            set => _clientId.SetValue(value);
        }
    
        private PropertyValue<string?> _orgId = new PropertyValue<string?>(nameof(ListCommandsPayload), nameof(OrgId));
        
        [JsonPropertyName("orgId")]
        public string? OrgId
        {
            get => _orgId.GetValue();
            set => _orgId.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _accessToken.SetAccessPath(path, validateHasBeenSet);
            _verificationToken.SetAccessPath(path, validateHasBeenSet);
            _userId.SetAccessPath(path, validateHasBeenSet);
            _serverUrl.SetAccessPath(path, validateHasBeenSet);
            _clientId.SetAccessPath(path, validateHasBeenSet);
            _orgId.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
