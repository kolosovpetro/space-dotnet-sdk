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
    public partial class PackageClient
    {
        private readonly Connection _connection;
        
        public PackageClient(Connection connection)
        {
            _connection = connection;
        }
        
        public ContainerRegistryClient ContainerRegistry => new ContainerRegistryClient(_connection);
        
        public partial class ContainerRegistryClient
        {
            private readonly Connection _connection;
            
            public ContainerRegistryClient(Connection connection)
            {
                _connection = connection;
            }
            
            public SettingClient Settings => new SettingClient(_connection);
            
            public partial class SettingClient
            {
                private readonly Connection _connection;
                
                public SettingClient(Connection connection)
                {
                    _connection = connection;
                }
                
                public async Task<ERegistrySettingsDto> GetAllSettings(string method, string? name = null, bool? all = null, Func<Partial<ERegistrySettingsDto>, Partial<ERegistrySettingsDto>> partialBuilder = null)
                    => await _connection.RequestResourceAsync<ERegistrySettingsDto>("GET", $"api/http/packages/container-registry/settings?method={method.ToString()}&name={name?.ToString() ?? "null"}&all={all?.ToString()?.ToLowerInvariant() ?? "null"}&$fields=" + (partialBuilder != null ? partialBuilder(new Partial<ERegistrySettingsDto>()) : Partial<ERegistrySettingsDto>.Recursive()));                
                
            }
            
        }
        
        public SettingClient Settings => new SettingClient(_connection);
        
        public partial class SettingClient
        {
            private readonly Connection _connection;
            
            public SettingClient(Connection connection)
            {
                _connection = connection;
            }
            
            public async Task<PackagesSettingsDto> GetAllSettings(string type, string method, string? repository = null, Func<Partial<PackagesSettingsDto>, Partial<PackagesSettingsDto>> partialBuilder = null)
                => await _connection.RequestResourceAsync<PackagesSettingsDto>("GET", $"api/http/packages/settings?type={type.ToString()}&method={method.ToString()}&repository={repository?.ToString() ?? "null"}&$fields=" + (partialBuilder != null ? partialBuilder(new Partial<PackagesSettingsDto>()) : Partial<PackagesSettingsDto>.Recursive()));            
            
        }
        
    }
    
}
