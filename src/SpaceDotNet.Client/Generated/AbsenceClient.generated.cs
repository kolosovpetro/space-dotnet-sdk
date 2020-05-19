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
    public partial class AbsenceClient
    {
        private readonly Connection _connection;
        
        public AbsenceClient(Connection connection)
        {
            _connection = connection;
        }
        
        public async Task<AbsenceRecordDto> CreateAbsence(CreateAbsenceRequestDto data, Func<Partial<AbsenceRecordDto>, Partial<AbsenceRecordDto>> partialBuilder = null)
            => await _connection.RequestResourceAsync<CreateAbsenceRequestDto, AbsenceRecordDto>("POST", $"api/http/absences?$fields=" + (partialBuilder != null ? partialBuilder(new Partial<AbsenceRecordDto>()) : Partial<AbsenceRecordDto>.Recursive()), data);        
        
        public async Task ApproveAbsence(string id, ApproveAbsenceRequestDto data)
            => await _connection.RequestResourceAsync<ApproveAbsenceRequestDto>("POST", $"api/http/absences/{id}/approve", data);        
        
        public async Task<Batch<AbsenceRecordDto>> GetAllAbsences(AbsenceListMode viewMode, string? skip = null, int? top = null, string? member = null, string? location = null, string? team = null, SpaceDate? since = null, SpaceDate? till = null, string? reason = null, Func<Partial<Batch<AbsenceRecordDto>>, Partial<Batch<AbsenceRecordDto>>> partialBuilder = null)
            => await _connection.RequestResourceAsync<Batch<AbsenceRecordDto>>("GET", $"api/http/absences?$skip={skip?.ToString() ?? "null"}&$top={top?.ToString() ?? "null"}&member={member?.ToString() ?? "null"}&location={location?.ToString() ?? "null"}&team={team?.ToString() ?? "null"}&since={since?.ToString() ?? "null"}&till={till?.ToString() ?? "null"}&viewMode={viewMode.ToString()}&reason={reason?.ToString() ?? "null"}&$fields=" + (partialBuilder != null ? partialBuilder(new Partial<Batch<AbsenceRecordDto>>()) : Partial<Batch<AbsenceRecordDto>>.Recursive()));        
        
        public async Task<List<AbsenceRecordDto>> GetAllAbsencesByMember(string member, Func<Partial<List<AbsenceRecordDto>>, Partial<List<AbsenceRecordDto>>> partialBuilder = null)
            => await _connection.RequestResourceAsync<List<AbsenceRecordDto>>("GET", $"api/http/absences/member:{member}?$fields=" + (partialBuilder != null ? partialBuilder(new Partial<List<AbsenceRecordDto>>()) : Partial<List<AbsenceRecordDto>>.Recursive()));        
        
        public async Task<AbsenceRecordDto> GetAbsence(string id, Func<Partial<AbsenceRecordDto>, Partial<AbsenceRecordDto>> partialBuilder = null)
            => await _connection.RequestResourceAsync<AbsenceRecordDto>("GET", $"api/http/absences/{id}?$fields=" + (partialBuilder != null ? partialBuilder(new Partial<AbsenceRecordDto>()) : Partial<AbsenceRecordDto>.Recursive()));        
        
        public async Task<AbsenceRecordDto> UpdateAbsence(string id, UpdateAbsenceRequestDto data, Func<Partial<AbsenceRecordDto>, Partial<AbsenceRecordDto>> partialBuilder = null)
            => await _connection.RequestResourceAsync<UpdateAbsenceRequestDto, AbsenceRecordDto>("PATCH", $"api/http/absences/{id}?$fields=" + (partialBuilder != null ? partialBuilder(new Partial<AbsenceRecordDto>()) : Partial<AbsenceRecordDto>.Recursive()), data);        
        
        public async Task DeleteAbsence(string id, bool delete)
            => await _connection.RequestResourceAsync("DELETE", $"api/http/absences/{id}?delete={delete.ToString().ToLowerInvariant()}");        
        
        public async Task DeleteAbsenceApproval(string id)
            => await _connection.RequestResourceAsync("DELETE", $"api/http/absences/{id}/delete-approval");        
        
        public AbsenceReasonClient AbsenceReasons => new AbsenceReasonClient(_connection);
        
        public partial class AbsenceReasonClient
        {
            private readonly Connection _connection;
            
            public AbsenceReasonClient(Connection connection)
            {
                _connection = connection;
            }
            
            public async Task<AbsenceReasonRecordDto> CreateAbsenceReason(CreateAbsenceReasonRequestDto data, Func<Partial<AbsenceReasonRecordDto>, Partial<AbsenceReasonRecordDto>> partialBuilder = null)
                => await _connection.RequestResourceAsync<CreateAbsenceReasonRequestDto, AbsenceReasonRecordDto>("POST", $"api/http/absences/absence-reasons?$fields=" + (partialBuilder != null ? partialBuilder(new Partial<AbsenceReasonRecordDto>()) : Partial<AbsenceReasonRecordDto>.Recursive()), data);            
            
            public async Task<AbsenceReasonRecordDto> CreateAbsenceReason(string id, CreateAbsenceReasonRequestDto data, Func<Partial<AbsenceReasonRecordDto>, Partial<AbsenceReasonRecordDto>> partialBuilder = null)
                => await _connection.RequestResourceAsync<CreateAbsenceReasonRequestDto, AbsenceReasonRecordDto>("POST", $"api/http/absences/absence-reasons/{id}?$fields=" + (partialBuilder != null ? partialBuilder(new Partial<AbsenceReasonRecordDto>()) : Partial<AbsenceReasonRecordDto>.Recursive()), data);            
            
            public async Task<List<AbsenceReasonRecordDto>> GetAllAbsenceReasons(bool withArchived, Func<Partial<List<AbsenceReasonRecordDto>>, Partial<List<AbsenceReasonRecordDto>>> partialBuilder = null)
                => await _connection.RequestResourceAsync<List<AbsenceReasonRecordDto>>("GET", $"api/http/absences/absence-reasons?withArchived={withArchived.ToString().ToLowerInvariant()}&$fields=" + (partialBuilder != null ? partialBuilder(new Partial<List<AbsenceReasonRecordDto>>()) : Partial<List<AbsenceReasonRecordDto>>.Recursive()));            
            
            public async Task<AbsenceReasonRecordDto> GetAbsenceReason(string id, Func<Partial<AbsenceReasonRecordDto>, Partial<AbsenceReasonRecordDto>> partialBuilder = null)
                => await _connection.RequestResourceAsync<AbsenceReasonRecordDto>("GET", $"api/http/absences/absence-reasons/{id}?$fields=" + (partialBuilder != null ? partialBuilder(new Partial<AbsenceReasonRecordDto>()) : Partial<AbsenceReasonRecordDto>.Recursive()));            
            
            public async Task DeleteAbsenceReason(string id, bool delete)
                => await _connection.RequestResourceAsync("DELETE", $"api/http/absences/absence-reasons/{id}?delete={delete.ToString().ToLowerInvariant()}");            
            
        }
        
        public SubscriptionClient Subscriptions => new SubscriptionClient(_connection);
        
        public partial class SubscriptionClient
        {
            private readonly Connection _connection;
            
            public SubscriptionClient(Connection connection)
            {
                _connection = connection;
            }
            
            public async Task<DTOAbsenceSubscriptionDto> CreateSubscription(CreateSubscriptionRequestDto data, Func<Partial<DTOAbsenceSubscriptionDto>, Partial<DTOAbsenceSubscriptionDto>> partialBuilder = null)
                => await _connection.RequestResourceAsync<CreateSubscriptionRequestDto, DTOAbsenceSubscriptionDto>("POST", $"api/http/absences/subscriptions?$fields=" + (partialBuilder != null ? partialBuilder(new Partial<DTOAbsenceSubscriptionDto>()) : Partial<DTOAbsenceSubscriptionDto>.Recursive()), data);            
            
            public async Task<List<DTOAbsenceSubscriptionDto>> GetAllSubscriptions(Func<Partial<List<DTOAbsenceSubscriptionDto>>, Partial<List<DTOAbsenceSubscriptionDto>>> partialBuilder = null)
                => await _connection.RequestResourceAsync<List<DTOAbsenceSubscriptionDto>>("GET", $"api/http/absences/subscriptions?$fields=" + (partialBuilder != null ? partialBuilder(new Partial<List<DTOAbsenceSubscriptionDto>>()) : Partial<List<DTOAbsenceSubscriptionDto>>.Recursive()));            
            
            public async Task<DTOAbsenceSubscriptionDto> UpdateSubscription(string id, UpdateSubscriptionRequestDto data, Func<Partial<DTOAbsenceSubscriptionDto>, Partial<DTOAbsenceSubscriptionDto>> partialBuilder = null)
                => await _connection.RequestResourceAsync<UpdateSubscriptionRequestDto, DTOAbsenceSubscriptionDto>("PATCH", $"api/http/absences/subscriptions/{id}?$fields=" + (partialBuilder != null ? partialBuilder(new Partial<DTOAbsenceSubscriptionDto>()) : Partial<DTOAbsenceSubscriptionDto>.Recursive()), data);            
            
            public async Task DeleteSubscription(string id)
                => await _connection.RequestResourceAsync("DELETE", $"api/http/absences/subscriptions/{id}");            
            
        }
        
    }
    
}