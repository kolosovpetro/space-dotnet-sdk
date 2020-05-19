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
    public partial class PermissionClient
    {
        private readonly Connection _connection;
        
        public PermissionClient(Connection connection)
        {
            _connection = connection;
        }
        
        public async Task<DTORightsWithHierarchyDto> GetAllPermissions(Func<Partial<DTORightsWithHierarchyDto>, Partial<DTORightsWithHierarchyDto>> partialBuilder = null)
            => await _connection.RequestResourceAsync<DTORightsWithHierarchyDto>("GET", $"api/http/permissions?$fields=" + (partialBuilder != null ? partialBuilder(new Partial<DTORightsWithHierarchyDto>()) : Partial<DTORightsWithHierarchyDto>.Recursive()));        
        
        public SnapshotClient Snapshots => new SnapshotClient(_connection);
        
        public partial class SnapshotClient
        {
            private readonly Connection _connection;
            
            public SnapshotClient(Connection connection)
            {
                _connection = connection;
            }
            
            public async Task<PermissionSnapshotDTODto> CreateSnapshot(Func<Partial<PermissionSnapshotDTODto>, Partial<PermissionSnapshotDTODto>> partialBuilder = null)
                => await _connection.RequestResourceAsync<PermissionSnapshotDTODto>("POST", $"api/http/permissions/snapshots?$fields=" + (partialBuilder != null ? partialBuilder(new Partial<PermissionSnapshotDTODto>()) : Partial<PermissionSnapshotDTODto>.Recursive()));            
            
            public async Task<List<PermissionSnapshotDTODto>> GetAllSnapshots(Func<Partial<List<PermissionSnapshotDTODto>>, Partial<List<PermissionSnapshotDTODto>>> partialBuilder = null)
                => await _connection.RequestResourceAsync<List<PermissionSnapshotDTODto>>("GET", $"api/http/permissions/snapshots?$fields=" + (partialBuilder != null ? partialBuilder(new Partial<List<PermissionSnapshotDTODto>>()) : Partial<List<PermissionSnapshotDTODto>>.Recursive()));            
            
            public async Task<PermissionSnapshotContentDTODto> GetSnapshot(string id, string? principal = null, string? right = null, Func<Partial<PermissionSnapshotContentDTODto>, Partial<PermissionSnapshotContentDTODto>> partialBuilder = null)
                => await _connection.RequestResourceAsync<PermissionSnapshotContentDTODto>("GET", $"api/http/permissions/snapshots/{id}?principal={principal?.ToString() ?? "null"}&right={right?.ToString() ?? "null"}&$fields=" + (partialBuilder != null ? partialBuilder(new Partial<PermissionSnapshotContentDTODto>()) : Partial<PermissionSnapshotContentDTODto>.Recursive()));            
            
            public async Task DeleteSnapshot(string id)
                => await _connection.RequestResourceAsync("DELETE", $"api/http/permissions/snapshots/{id}");            
            
            public ComparisonClient Comparison => new ComparisonClient(_connection);
            
            public partial class ComparisonClient
            {
                private readonly Connection _connection;
                
                public ComparisonClient(Connection connection)
                {
                    _connection = connection;
                }
                
                public async Task<PermissionComparisonContentDTODto> GetComparison(string id1, string id2, Func<Partial<PermissionComparisonContentDTODto>, Partial<PermissionComparisonContentDTODto>> partialBuilder = null)
                    => await _connection.RequestResourceAsync<PermissionComparisonContentDTODto>("GET", $"api/http/permissions/snapshots/comparison?id1={id1.ToString()}&id2={id2.ToString()}&$fields=" + (partialBuilder != null ? partialBuilder(new Partial<PermissionComparisonContentDTODto>()) : Partial<PermissionComparisonContentDTODto>.Recursive()));                
                
            }
            
            public PrincipalClient Principals => new PrincipalClient(_connection);
            
            public partial class PrincipalClient
            {
                private readonly Connection _connection;
                
                public PrincipalClient(Connection connection)
                {
                    _connection = connection;
                }
                
                public async Task<List<PermissionSnapshotPrincipalDTODto>> GetPrincipal(string id, Func<Partial<List<PermissionSnapshotPrincipalDTODto>>, Partial<List<PermissionSnapshotPrincipalDTODto>>> partialBuilder = null)
                    => await _connection.RequestResourceAsync<List<PermissionSnapshotPrincipalDTODto>>("GET", $"api/http/permissions/snapshots/{id}/principals?$fields=" + (partialBuilder != null ? partialBuilder(new Partial<List<PermissionSnapshotPrincipalDTODto>>()) : Partial<List<PermissionSnapshotPrincipalDTODto>>.Recursive()));                
                
            }
            
            public RightClient Rights => new RightClient(_connection);
            
            public partial class RightClient
            {
                private readonly Connection _connection;
                
                public RightClient(Connection connection)
                {
                    _connection = connection;
                }
                
                public async Task<List<PermissionSnapshotRightDTODto>> GetRight(string id, Func<Partial<List<PermissionSnapshotRightDTODto>>, Partial<List<PermissionSnapshotRightDTODto>>> partialBuilder = null)
                    => await _connection.RequestResourceAsync<List<PermissionSnapshotRightDTODto>>("GET", $"api/http/permissions/snapshots/{id}/rights?$fields=" + (partialBuilder != null ? partialBuilder(new Partial<List<PermissionSnapshotRightDTODto>>()) : Partial<List<PermissionSnapshotRightDTODto>>.Recursive()));                
                
            }
            
        }
        
    }
    
}
