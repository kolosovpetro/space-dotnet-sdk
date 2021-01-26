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
    public sealed class ESApp
         : IPropagatePropertyAccessPath
    {
        public ESApp() { }
        
        public ESApp(string id, string clientId, string name, bool clientCredentialsFlowEnabled, bool codeFlowEnabled, bool implicitFlowEnabled, bool hasVerificationToken, bool hasSigningKey, bool archived, TDMemberProfile? owner = null, ApplicationType? applicationType = null, string? codeFlowRedirectURIs = null, string? implicitFlowRedirectURIs = null, string? endpointURI = null)
        {
            Id = id;
            Owner = owner;
            ClientId = clientId;
            Name = name;
            ApplicationType = applicationType;
            IsClientCredentialsFlowEnabled = clientCredentialsFlowEnabled;
            IsCodeFlowEnabled = codeFlowEnabled;
            CodeFlowRedirectURIs = codeFlowRedirectURIs;
            IsImplicitFlowEnabled = implicitFlowEnabled;
            ImplicitFlowRedirectURIs = implicitFlowRedirectURIs;
            EndpointURI = endpointURI;
            IsHasVerificationToken = hasVerificationToken;
            IsHasSigningKey = hasSigningKey;
            IsArchived = archived;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(ESApp), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get => _id.GetValue();
            set => _id.SetValue(value);
        }
    
        private PropertyValue<TDMemberProfile?> _owner = new PropertyValue<TDMemberProfile?>(nameof(ESApp), nameof(Owner));
        
        [JsonPropertyName("owner")]
        public TDMemberProfile? Owner
        {
            get => _owner.GetValue();
            set => _owner.SetValue(value);
        }
    
        private PropertyValue<string> _clientId = new PropertyValue<string>(nameof(ESApp), nameof(ClientId));
        
        [Required]
        [JsonPropertyName("clientId")]
        public string ClientId
        {
            get => _clientId.GetValue();
            set => _clientId.SetValue(value);
        }
    
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(ESApp), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get => _name.GetValue();
            set => _name.SetValue(value);
        }
    
        private PropertyValue<ApplicationType?> _applicationType = new PropertyValue<ApplicationType?>(nameof(ESApp), nameof(ApplicationType));
        
        [JsonPropertyName("applicationType")]
        public ApplicationType? ApplicationType
        {
            get => _applicationType.GetValue();
            set => _applicationType.SetValue(value);
        }
    
        private PropertyValue<bool> _clientCredentialsFlowEnabled = new PropertyValue<bool>(nameof(ESApp), nameof(IsClientCredentialsFlowEnabled));
        
        [Required]
        [JsonPropertyName("clientCredentialsFlowEnabled")]
        public bool IsClientCredentialsFlowEnabled
        {
            get => _clientCredentialsFlowEnabled.GetValue();
            set => _clientCredentialsFlowEnabled.SetValue(value);
        }
    
        private PropertyValue<bool> _codeFlowEnabled = new PropertyValue<bool>(nameof(ESApp), nameof(IsCodeFlowEnabled));
        
        [Required]
        [JsonPropertyName("codeFlowEnabled")]
        public bool IsCodeFlowEnabled
        {
            get => _codeFlowEnabled.GetValue();
            set => _codeFlowEnabled.SetValue(value);
        }
    
        private PropertyValue<string?> _codeFlowRedirectURIs = new PropertyValue<string?>(nameof(ESApp), nameof(CodeFlowRedirectURIs));
        
        [JsonPropertyName("codeFlowRedirectURIs")]
        public string? CodeFlowRedirectURIs
        {
            get => _codeFlowRedirectURIs.GetValue();
            set => _codeFlowRedirectURIs.SetValue(value);
        }
    
        private PropertyValue<bool> _implicitFlowEnabled = new PropertyValue<bool>(nameof(ESApp), nameof(IsImplicitFlowEnabled));
        
        [Required]
        [JsonPropertyName("implicitFlowEnabled")]
        public bool IsImplicitFlowEnabled
        {
            get => _implicitFlowEnabled.GetValue();
            set => _implicitFlowEnabled.SetValue(value);
        }
    
        private PropertyValue<string?> _implicitFlowRedirectURIs = new PropertyValue<string?>(nameof(ESApp), nameof(ImplicitFlowRedirectURIs));
        
        [JsonPropertyName("implicitFlowRedirectURIs")]
        public string? ImplicitFlowRedirectURIs
        {
            get => _implicitFlowRedirectURIs.GetValue();
            set => _implicitFlowRedirectURIs.SetValue(value);
        }
    
        private PropertyValue<string?> _endpointURI = new PropertyValue<string?>(nameof(ESApp), nameof(EndpointURI));
        
        [JsonPropertyName("endpointURI")]
        public string? EndpointURI
        {
            get => _endpointURI.GetValue();
            set => _endpointURI.SetValue(value);
        }
    
        private PropertyValue<bool> _hasVerificationToken = new PropertyValue<bool>(nameof(ESApp), nameof(IsHasVerificationToken));
        
        [Required]
        [JsonPropertyName("hasVerificationToken")]
        public bool IsHasVerificationToken
        {
            get => _hasVerificationToken.GetValue();
            set => _hasVerificationToken.SetValue(value);
        }
    
        private PropertyValue<bool> _hasSigningKey = new PropertyValue<bool>(nameof(ESApp), nameof(IsHasSigningKey));
        
        [Required]
        [JsonPropertyName("hasSigningKey")]
        public bool IsHasSigningKey
        {
            get => _hasSigningKey.GetValue();
            set => _hasSigningKey.SetValue(value);
        }
    
        private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(ESApp), nameof(IsArchived));
        
        [Required]
        [JsonPropertyName("archived")]
        public bool IsArchived
        {
            get => _archived.GetValue();
            set => _archived.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _owner.SetAccessPath(path, validateHasBeenSet);
            _clientId.SetAccessPath(path, validateHasBeenSet);
            _name.SetAccessPath(path, validateHasBeenSet);
            _applicationType.SetAccessPath(path, validateHasBeenSet);
            _clientCredentialsFlowEnabled.SetAccessPath(path, validateHasBeenSet);
            _codeFlowEnabled.SetAccessPath(path, validateHasBeenSet);
            _codeFlowRedirectURIs.SetAccessPath(path, validateHasBeenSet);
            _implicitFlowEnabled.SetAccessPath(path, validateHasBeenSet);
            _implicitFlowRedirectURIs.SetAccessPath(path, validateHasBeenSet);
            _endpointURI.SetAccessPath(path, validateHasBeenSet);
            _hasVerificationToken.SetAccessPath(path, validateHasBeenSet);
            _hasSigningKey.SetAccessPath(path, validateHasBeenSet);
            _archived.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
