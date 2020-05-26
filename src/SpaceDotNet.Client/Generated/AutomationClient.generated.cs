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
    public partial class AutomationClient
    {
        private readonly Connection _connection;
        
        public AutomationClient(Connection connection)
        {
            _connection = connection;
        }
        
        public GraphExecutionClient GraphExecutions => new GraphExecutionClient(_connection);
        
        public partial class GraphExecutionClient
        {
            private readonly Connection _connection;
            
            public GraphExecutionClient(Connection connection)
            {
                _connection = connection;
            }
            
            public ParameterClient Parameters => new ParameterClient(_connection);
            
            public partial class ParameterClient
            {
                private readonly Connection _connection;
                
                public ParameterClient(Connection connection)
                {
                    _connection = connection;
                }
                
                public async Task<string> GetParameter(long id, string key)
                    => await _connection.RequestResourceAsync<string>("GET", $"api/http/automation/graph-executions/{id}/parameters?key={key.ToString()}&");                
                
                public async Task UpdateParameter(long id, UpdateParameterRequestDto data)
                    => await _connection.RequestResourceAsync<UpdateParameterRequestDto>("PATCH", $"api/http/automation/graph-executions/{id}/parameters", data);                
                
                public async Task DeleteParameter(long id, string key)
                    => await _connection.RequestResourceAsync("DELETE", $"api/http/automation/graph-executions/{id}/parameters?key={key.ToString()}");                
                
            }
            
        }
        
    }
    
}
