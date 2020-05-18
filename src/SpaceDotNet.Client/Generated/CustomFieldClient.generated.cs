// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T10:16:39.4714048+00:00
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
    public partial class CustomFieldClient
    {
        private readonly Connection _connection;
        
        public CustomFieldClient(Connection connection)
        {
            _connection = connection;
        }
        
        public ExtendedTypeClient ExtendedTypes => new ExtendedTypeClient(_connection);
        
        public partial class ExtendedTypeClient
        {
            private readonly Connection _connection;
            
            public ExtendedTypeClient(Connection connection)
            {
                _connection = connection;
            }
            
            public async Task<List<ExtendedTypeDto>> GetAllExtendedTypes()
                => await _connection.RequestResourceAsync<List<ExtendedTypeDto>>("GET", $"api/http/custom-fields/extended-types?$fields=" + ObjectToFieldDescriptor.FieldsFor(typeof(List<ExtendedTypeDto>)));            
            
        }
        
        public AllValueClient AllValues => new AllValueClient(_connection);
        
        public partial class AllValueClient
        {
            private readonly Connection _connection;
            
            public AllValueClient(Connection connection)
            {
                _connection = connection;
            }
            
            public async Task<Batch<CustomFieldsRecordDto>> GetAllAllValues(string typeKey, string? skip = null, int? top = null, List<string>? extendedEntityIds = null)
                => await _connection.RequestResourceAsync<Batch<CustomFieldsRecordDto>>("GET", $"api/http/custom-fields/{typeKey}/all-values?$skip={skip?.ToString() ?? "null"}&$top={top?.ToString() ?? "null"}&extendedEntityIds={extendedEntityIds?.JoinToString("extendedEntityIds", it => it.ToString()) ?? "null"}&$fields=" + ObjectToFieldDescriptor.FieldsFor(typeof(Batch<CustomFieldsRecordDto>)));            
            
        }
        
        public FieldClient Fields => new FieldClient(_connection);
        
        public partial class FieldClient
        {
            private readonly Connection _connection;
            
            public FieldClient(Connection connection)
            {
                _connection = connection;
            }
            
            public async Task<CustomFieldDto> CreateField(string typeKey, CreateFieldRequestDto data)
                => await _connection.RequestResourceAsync<CreateFieldRequestDto, CustomFieldDto>("POST", $"api/http/custom-fields/{typeKey}/fields?$fields=" + ObjectToFieldDescriptor.FieldsFor(typeof(CustomFieldDto)), data);            
            
            public async Task Reorder(string typeKey, ReorderRequestDto data)
                => await _connection.RequestResourceAsync<ReorderRequestDto>("POST", $"api/http/custom-fields/{typeKey}/fields/reorder", data);            
            
            public async Task Archive(string typeKey, string id)
                => await _connection.RequestResourceAsync("POST", $"api/http/custom-fields/{typeKey}/fields/{id}/archive");            
            
            public async Task Restore(string typeKey, string id)
                => await _connection.RequestResourceAsync("POST", $"api/http/custom-fields/{typeKey}/fields/{id}/restore");            
            
            public async Task<List<CustomFieldDto>> GetAllFields(string typeKey, bool withArchived)
                => await _connection.RequestResourceAsync<List<CustomFieldDto>>("GET", $"api/http/custom-fields/{typeKey}/fields?withArchived={withArchived.ToString().ToLowerInvariant()}&$fields=" + ObjectToFieldDescriptor.FieldsFor(typeof(List<CustomFieldDto>)));            
            
            public async Task UpdateField(string typeKey, string id, UpdateFieldRequestDto data)
                => await _connection.RequestResourceAsync<UpdateFieldRequestDto>("PATCH", $"api/http/custom-fields/{typeKey}/fields/{id}", data);            
            
            public async Task DeleteField(string typeKey, string id)
                => await _connection.RequestResourceAsync("DELETE", $"api/http/custom-fields/{typeKey}/fields/{id}");            
            
        }
        
        public ValueClient Values => new ValueClient(_connection);
        
        public partial class ValueClient
        {
            private readonly Connection _connection;
            
            public ValueClient(Connection connection)
            {
                _connection = connection;
            }
            
            public async Task<CustomFieldsRecordDto> GetValue(string typeKey, string entityId)
                => await _connection.RequestResourceAsync<CustomFieldsRecordDto>("GET", $"api/http/custom-fields/{typeKey}/{entityId}/values?$fields=" + ObjectToFieldDescriptor.FieldsFor(typeof(CustomFieldsRecordDto)));            
            
            public async Task UpdateValue(string entityId, string typeKey, UpdateValueRequestDto data)
                => await _connection.RequestResourceAsync<UpdateValueRequestDto>("PATCH", $"api/http/custom-fields/{typeKey}/{entityId}/values", data);            
            
        }
        
    }
    
}