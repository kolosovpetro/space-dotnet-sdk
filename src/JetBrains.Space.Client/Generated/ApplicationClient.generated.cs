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
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Client.Internal;
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
        
        public async Task RefreshMenuAsync(string? id = null, CancellationToken cancellationToken = default)
            => await _connection.RequestResourceAsync("POST", $"api/http/applications/refresh-menu", 
                new ApplicationsRefreshMenuPostRequest { 
                    Id = id,
                }
        , cancellationToken);
    
    }
    
}
