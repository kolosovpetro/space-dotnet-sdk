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

namespace SpaceDotNet.Client
{
    public class SamlMetadataRequest
    {
        private PropertyValue<string> _idpUrl = new PropertyValue<string>(nameof(SamlMetadataRequest), nameof(IdpUrl));
        
        [Required]
        [JsonPropertyName("idpUrl")]
        public string IdpUrl
        {
            get { return _idpUrl.GetValue(); }
            set { _idpUrl.SetValue(value); }
        }
    
        private PropertyValue<string> _idpEntityId = new PropertyValue<string>(nameof(SamlMetadataRequest), nameof(IdpEntityId));
        
        [Required]
        [JsonPropertyName("idpEntityId")]
        public string IdpEntityId
        {
            get { return _idpEntityId.GetValue(); }
            set { _idpEntityId.SetValue(value); }
        }
    
        private PropertyValue<string> _idpCertificateSHA256 = new PropertyValue<string>(nameof(SamlMetadataRequest), nameof(IdpCertificateSHA256));
        
        [Required]
        [JsonPropertyName("idpCertificateSHA256")]
        public string IdpCertificateSHA256
        {
            get { return _idpCertificateSHA256.GetValue(); }
            set { _idpCertificateSHA256.SetValue(value); }
        }
    
        private PropertyValue<string> _spEntityId = new PropertyValue<string>(nameof(SamlMetadataRequest), nameof(SpEntityId));
        
        [Required]
        [JsonPropertyName("spEntityId")]
        public string SpEntityId
        {
            get { return _spEntityId.GetValue(); }
            set { _spEntityId.SetValue(value); }
        }
    
        private PropertyValue<SSLKeystoreDto?> _sslKeystore = new PropertyValue<SSLKeystoreDto?>(nameof(SamlMetadataRequest), nameof(SslKeystore));
        
        [JsonPropertyName("sslKeystore")]
        public SSLKeystoreDto? SslKeystore
        {
            get { return _sslKeystore.GetValue(); }
            set { _sslKeystore.SetValue(value); }
        }
    
        private PropertyValue<string?> _contactProfileId = new PropertyValue<string?>(nameof(SamlMetadataRequest), nameof(ContactProfileId));
        
        [JsonPropertyName("contactProfileId")]
        public string? ContactProfileId
        {
            get { return _contactProfileId.GetValue(); }
            set { _contactProfileId.SetValue(value); }
        }
    
    }
    
}