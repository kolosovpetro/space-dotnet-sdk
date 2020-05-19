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
    public partial class ToDoItemClient
    {
        private readonly Connection _connection;
        
        public ToDoItemClient(Connection connection)
        {
            _connection = connection;
        }
        
        public async Task<TodoItemRecordDto> CreateToDoItem(CreateToDoItemRequestDto data, Func<Partial<TodoItemRecordDto>, Partial<TodoItemRecordDto>> partialBuilder = null)
            => await _connection.RequestResourceAsync<CreateToDoItemRequestDto, TodoItemRecordDto>("POST", $"api/http/todo?$fields=" + (partialBuilder != null ? partialBuilder(new Partial<TodoItemRecordDto>()) : Partial<TodoItemRecordDto>.Recursive()), data);        
        
        public async Task<Batch<TodoItemRecordDto>> GetAllToDoItems(string? skip = null, int? top = null, bool? open = null, SpaceDate? from = null, SpaceDate? till = null, Func<Partial<Batch<TodoItemRecordDto>>, Partial<Batch<TodoItemRecordDto>>> partialBuilder = null)
            => await _connection.RequestResourceAsync<Batch<TodoItemRecordDto>>("GET", $"api/http/todo?$skip={skip?.ToString() ?? "null"}&$top={top?.ToString() ?? "null"}&open={open?.ToString()?.ToLowerInvariant() ?? "null"}&from={from?.ToString() ?? "null"}&till={till?.ToString() ?? "null"}&$fields=" + (partialBuilder != null ? partialBuilder(new Partial<Batch<TodoItemRecordDto>>()) : Partial<Batch<TodoItemRecordDto>>.Recursive()));        
        
        public async Task UpdateToDoItem(string id, UpdateToDoItemRequestDto data)
            => await _connection.RequestResourceAsync<UpdateToDoItemRequestDto>("PATCH", $"api/http/todo/{id}", data);        
        
        public async Task DeleteToDoItem(string id)
            => await _connection.RequestResourceAsync("DELETE", $"api/http/todo/{id}");        
        
    }
    
}