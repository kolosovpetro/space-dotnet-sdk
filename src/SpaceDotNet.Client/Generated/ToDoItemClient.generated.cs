// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS0108

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
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
        
        /// <summary>
        /// Create a new To-Do item, with an optional due date.
        /// </summary>
        public async Task<TodoItemRecord> CreateToDoItemAsync(string text, SpaceDate? dueDate = null, Func<Partial<TodoItemRecord>, Partial<TodoItemRecord>>? partial = null, CancellationToken cancellationToken = default)
            => await _connection.RequestResourceAsync<TodoPostRequest, TodoItemRecord>("POST", $"api/http/todo?$fields={(partial != null ? partial(new Partial<TodoItemRecord>()) : Partial<TodoItemRecord>.Default())}", 
                new TodoPostRequest { 
                    Text = text,
                    DueDate = dueDate,
                }
        , cancellationToken);
    
        /// <summary>
        /// Get all To-Do items that match given parameters. Parameters are applied as 'AND' filters.
        /// </summary>
        public async Task<Batch<TodoItemRecord>> GetAllToDoItemsAsync(string? skip = null, int? top = 100, bool? open = null, SpaceDate? from = null, SpaceDate? till = null, Func<Partial<Batch<TodoItemRecord>>, Partial<Batch<TodoItemRecord>>>? partial = null, CancellationToken cancellationToken = default)
            => await _connection.RequestResourceAsync<Batch<TodoItemRecord>>("GET", $"api/http/todo?$skip={skip?.ToString() ?? "null"}&$top={top?.ToString() ?? "null"}&open={open?.ToString()?.ToLowerInvariant() ?? "null"}&from={from?.ToString() ?? "null"}&till={till?.ToString() ?? "null"}&$fields={(partial != null ? partial(new Partial<Batch<TodoItemRecord>>()) : Partial<Batch<TodoItemRecord>>.Default())}", cancellationToken);
        
        /// <summary>
        /// Get all To-Do items that match given parameters. Parameters are applied as 'AND' filters.
        /// </summary>
        public IAsyncEnumerable<TodoItemRecord> GetAllToDoItemsAsyncEnumerable(string? skip = null, int? top = 100, bool? open = null, SpaceDate? from = null, SpaceDate? till = null, Func<Partial<TodoItemRecord>, Partial<TodoItemRecord>>? partial = null, CancellationToken cancellationToken = default)
            => BatchEnumerator.AllItems((batchSkip, batchCancellationToken) => GetAllToDoItemsAsync(top: top, open: open, from: from, till: till, cancellationToken: cancellationToken, skip: batchSkip, partial: builder => Partial<Batch<TodoItemRecord>>.Default().WithNext().WithTotalCount().WithData(partial != null ? partial : _ => Partial<TodoItemRecord>.Default())), skip, cancellationToken);
    
        /// <summary>
        /// Update an existing To-Do item. Optional parameters will be ignored when not specified, and updated otherwise.
        /// </summary>
        public async Task UpdateToDoItemAsync(string id, string? text = null, SpaceDate? dueDate = null, bool? open = null, CancellationToken cancellationToken = default)
            => await _connection.RequestResourceAsync("PATCH", $"api/http/todo/{id}", 
                new TodoForIdPatchRequest { 
                    Text = text,
                    DueDate = dueDate,
                    IsOpen = open,
                }
        , cancellationToken);
    
        /// <summary>
        /// Delete an existing To-Do item.
        /// </summary>
        public async Task DeleteToDoItemAsync(string id, CancellationToken cancellationToken = default)
            => await _connection.RequestResourceAsync("DELETE", $"api/http/todo/{id}", cancellationToken);
    
    }
    
}
