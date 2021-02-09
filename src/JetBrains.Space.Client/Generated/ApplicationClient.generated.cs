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
    public partial class ApplicationClient : ISpaceClient
    {
        private readonly Connection _connection;
        
        public ApplicationClient(Connection connection)
        {
            _connection = connection;
        }
        
        /// <remarks>
        /// Required permissions:
        /// <list type="bullet">
        /// <item>
        /// <term>Create application</term>
        /// </item>
        /// </list>
        /// </remarks>
        public async Task<ESApp> CreateApplicationAsync(string name, string? clientId = null, string? clientSecret = null, bool? clientCredentialsFlowEnabled = null, bool? codeFlowEnabled = null, string? codeFlowRedirectURIs = null, bool? implicitFlowEnabled = null, string? implicitFlowRedirectURIs = null, string? endpointUri = null, Func<Partial<ESApp>, Partial<ESApp>>? partial = null, CancellationToken cancellationToken = default)
        {
            var queryParameters = new NameValueCollection();
            queryParameters.Append("$fields", (partial != null ? partial(new Partial<ESApp>()) : Partial<ESApp>.Default()).ToString());
            
            return await _connection.RequestResourceAsync<ApplicationsPostRequest, ESApp>("POST", $"api/http/applications{queryParameters.ToQueryString()}", 
                new ApplicationsPostRequest
                { 
                    Name = name,
                    ClientId = clientId,
                    ClientSecret = clientSecret,
                    IsClientCredentialsFlowEnabled = clientCredentialsFlowEnabled,
                    IsCodeFlowEnabled = codeFlowEnabled,
                    CodeFlowRedirectURIs = codeFlowRedirectURIs,
                    IsImplicitFlowEnabled = implicitFlowEnabled,
                    ImplicitFlowRedirectURIs = implicitFlowRedirectURIs,
                    EndpointUri = endpointUri,
                }, cancellationToken);
        }
        
    
        public async Task RefreshMenuAsync(string? appId = null, CancellationToken cancellationToken = default)
        {
            var queryParameters = new NameValueCollection();
            
            await _connection.RequestResourceAsync("POST", $"api/http/applications/refresh-menu{queryParameters.ToQueryString()}", 
                new ApplicationsRefreshMenuPostRequest
                { 
                    AppId = appId,
                }, cancellationToken);
        }
        
    
        /// <remarks>
        /// Required permissions:
        /// <list type="bullet">
        /// <item>
        /// <term>Edit application</term>
        /// </item>
        /// </list>
        /// </remarks>
        public async Task RestoreApplicationAsync(string id, CancellationToken cancellationToken = default)
        {
            var queryParameters = new NameValueCollection();
            
            await _connection.RequestResourceAsync("POST", $"api/http/applications/{id}/restore{queryParameters.ToQueryString()}", cancellationToken);
        }
        
    
        /// <remarks>
        /// Required permissions:
        /// <list type="bullet">
        /// <item>
        /// <term>View application</term>
        /// </item>
        /// </list>
        /// </remarks>
        public async Task<List<ESApp>> GetAllApplicationsAsync(string query, bool withArchived = false, Func<Partial<ESApp>, Partial<ESApp>>? partial = null, CancellationToken cancellationToken = default)
        {
            var queryParameters = new NameValueCollection();
            queryParameters.Append("query", query);
            queryParameters.Append("withArchived", withArchived.ToString("l"));
            queryParameters.Append("$fields", (partial != null ? partial(new Partial<ESApp>()) : Partial<ESApp>.Default()).ToString());
            
            return await _connection.RequestResourceAsync<List<ESApp>>("GET", $"api/http/applications{queryParameters.ToQueryString()}", cancellationToken);
        }
        
    
        /// <remarks>
        /// Required permissions:
        /// <list type="bullet">
        /// <item>
        /// <term>View application</term>
        /// </item>
        /// </list>
        /// </remarks>
        public async Task<ESApp> GetApplicationAsync(string id, Func<Partial<ESApp>, Partial<ESApp>>? partial = null, CancellationToken cancellationToken = default)
        {
            var queryParameters = new NameValueCollection();
            queryParameters.Append("$fields", (partial != null ? partial(new Partial<ESApp>()) : Partial<ESApp>.Default()).ToString());
            
            return await _connection.RequestResourceAsync<ESApp>("GET", $"api/http/applications/{id}{queryParameters.ToQueryString()}", cancellationToken);
        }
        
    
        /// <remarks>
        /// Required permissions:
        /// <list type="bullet">
        /// <item>
        /// <term>View application</term>
        /// </item>
        /// </list>
        /// </remarks>
        public async Task<AccessRecord> GetLastClientCredentialsAccessInfoAsync(string id, Func<Partial<AccessRecord>, Partial<AccessRecord>>? partial = null, CancellationToken cancellationToken = default)
        {
            var queryParameters = new NameValueCollection();
            queryParameters.Append("$fields", (partial != null ? partial(new Partial<AccessRecord>()) : Partial<AccessRecord>.Default()).ToString());
            
            return await _connection.RequestResourceAsync<AccessRecord>("GET", $"api/http/applications/{id}/last-client-credentials-access{queryParameters.ToQueryString()}", cancellationToken);
        }
        
    
        /// <remarks>
        /// Required permissions:
        /// <list type="bullet">
        /// <item>
        /// <term>Edit application</term>
        /// </item>
        /// </list>
        /// </remarks>
        public async Task<ESApp> UpdateApplicationAsync(string id, string? name = null, string? clientSecret = null, bool? clientCredentialsFlowEnabled = null, bool? codeFlowEnabled = null, string? codeFlowRedirectURIs = null, bool? implicitFlowEnabled = null, string? implicitFlowRedirectURIs = null, string? endpointUri = null, Func<Partial<ESApp>, Partial<ESApp>>? partial = null, CancellationToken cancellationToken = default)
        {
            var queryParameters = new NameValueCollection();
            queryParameters.Append("$fields", (partial != null ? partial(new Partial<ESApp>()) : Partial<ESApp>.Default()).ToString());
            
            return await _connection.RequestResourceAsync<ApplicationsForIdPatchRequest, ESApp>("PATCH", $"api/http/applications/{id}{queryParameters.ToQueryString()}", 
                new ApplicationsForIdPatchRequest
                { 
                    Name = name,
                    ClientSecret = clientSecret,
                    IsClientCredentialsFlowEnabled = clientCredentialsFlowEnabled,
                    IsCodeFlowEnabled = codeFlowEnabled,
                    CodeFlowRedirectURIs = codeFlowRedirectURIs,
                    IsImplicitFlowEnabled = implicitFlowEnabled,
                    ImplicitFlowRedirectURIs = implicitFlowRedirectURIs,
                    EndpointUri = endpointUri,
                }, cancellationToken);
        }
        
    
        /// <remarks>
        /// Required permissions:
        /// <list type="bullet">
        /// <item>
        /// <term>Delete application</term>
        /// </item>
        /// </list>
        /// </remarks>
        public async Task DeleteApplicationAsync(string id, CancellationToken cancellationToken = default)
        {
            var queryParameters = new NameValueCollection();
            
            await _connection.RequestResourceAsync("DELETE", $"api/http/applications/{id}{queryParameters.ToQueryString()}", cancellationToken);
        }
        
    
        public ClientSecretClient ClientSecret => new ClientSecretClient(_connection);
        
        public partial class ClientSecretClient : ISpaceClient
        {
            private readonly Connection _connection;
            
            public ClientSecretClient(Connection connection)
            {
                _connection = connection;
            }
            
            /// <remarks>
            /// Required permissions:
            /// <list type="bullet">
            /// <item>
            /// <term>Edit application</term>
            /// </item>
            /// </list>
            /// </remarks>
            public async Task RegenerateAsync(string id, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                
                await _connection.RequestResourceAsync("POST", $"api/http/applications/{id}/client-secret/regenerate{queryParameters.ToQueryString()}", cancellationToken);
            }
            
        
            /// <remarks>
            /// Required permissions:
            /// <list type="bullet">
            /// <item>
            /// <term>View application secrets</term>
            /// </item>
            /// </list>
            /// </remarks>
            public async Task<string> GetClientSecretAsync(string id, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                
                return await _connection.RequestResourceAsync<string>("GET", $"api/http/applications/{id}/client-secret{queryParameters.ToQueryString()}", cancellationToken);
            }
            
        
        }
    
        public SigningKeyClient SigningKey => new SigningKeyClient(_connection);
        
        public partial class SigningKeyClient : ISpaceClient
        {
            private readonly Connection _connection;
            
            public SigningKeyClient(Connection connection)
            {
                _connection = connection;
            }
            
            /// <remarks>
            /// Required permissions:
            /// <list type="bullet">
            /// <item>
            /// <term>Edit application</term>
            /// </item>
            /// </list>
            /// </remarks>
            public async Task RegenerateAsync(string id, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                
                await _connection.RequestResourceAsync("POST", $"api/http/applications/{id}/signing-key/regenerate{queryParameters.ToQueryString()}", cancellationToken);
            }
            
        
            /// <remarks>
            /// Required permissions:
            /// <list type="bullet">
            /// <item>
            /// <term>View application secrets</term>
            /// </item>
            /// </list>
            /// </remarks>
            public async Task<string> GetSigningKeyAsync(string id, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                
                return await _connection.RequestResourceAsync<string>("GET", $"api/http/applications/{id}/signing-key{queryParameters.ToQueryString()}", cancellationToken);
            }
            
        
        }
    
        public SshKeyClient SshKeys => new SshKeyClient(_connection);
        
        public partial class SshKeyClient : ISpaceClient
        {
            private readonly Connection _connection;
            
            public SshKeyClient(Connection connection)
            {
                _connection = connection;
            }
            
            /// <remarks>
            /// Required permissions:
            /// <list type="bullet">
            /// <item>
            /// <term>Edit application</term>
            /// </item>
            /// </list>
            /// </remarks>
            public async Task AddSshKeyAsync(string id, string publicKey, string comment, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                
                await _connection.RequestResourceAsync("POST", $"api/http/applications/{id}/ssh-keys{queryParameters.ToQueryString()}", 
                    new ApplicationsForIdSshKeysPostRequest
                    { 
                        PublicKey = publicKey,
                        Comment = comment,
                    }, cancellationToken);
            }
            
        
            /// <remarks>
            /// Required permissions:
            /// <list type="bullet">
            /// <item>
            /// <term>View application</term>
            /// </item>
            /// </list>
            /// </remarks>
            public async Task<List<ESSshKey>> GetSshKeyAsync(string id, Func<Partial<ESSshKey>, Partial<ESSshKey>>? partial = null, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                queryParameters.Append("$fields", (partial != null ? partial(new Partial<ESSshKey>()) : Partial<ESSshKey>.Default()).ToString());
                
                return await _connection.RequestResourceAsync<List<ESSshKey>>("GET", $"api/http/applications/{id}/ssh-keys{queryParameters.ToQueryString()}", cancellationToken);
            }
            
        
            /// <remarks>
            /// Required permissions:
            /// <list type="bullet">
            /// <item>
            /// <term>Edit application</term>
            /// </item>
            /// </list>
            /// </remarks>
            public async Task DeleteSshKeyAsync(string id, string fingerprint, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                
                await _connection.RequestResourceAsync("DELETE", $"api/http/applications/{id}/ssh-keys/{fingerprint}{queryParameters.ToQueryString()}", cancellationToken);
            }
            
        
        }
    
        public VerificationTokenClient VerificationToken => new VerificationTokenClient(_connection);
        
        public partial class VerificationTokenClient : ISpaceClient
        {
            private readonly Connection _connection;
            
            public VerificationTokenClient(Connection connection)
            {
                _connection = connection;
            }
            
            /// <remarks>
            /// Required permissions:
            /// <list type="bullet">
            /// <item>
            /// <term>Edit application</term>
            /// </item>
            /// </list>
            /// </remarks>
            public async Task RegenerateAsync(string id, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                
                await _connection.RequestResourceAsync("POST", $"api/http/applications/{id}/verification-token/regenerate{queryParameters.ToQueryString()}", cancellationToken);
            }
            
        
            /// <remarks>
            /// Required permissions:
            /// <list type="bullet">
            /// <item>
            /// <term>View application secrets</term>
            /// </item>
            /// </list>
            /// </remarks>
            public async Task<string> GetVerificationTokenAsync(string id, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                
                return await _connection.RequestResourceAsync<string>("GET", $"api/http/applications/{id}/verification-token{queryParameters.ToQueryString()}", cancellationToken);
            }
            
        
        }
    
    }
    
}
