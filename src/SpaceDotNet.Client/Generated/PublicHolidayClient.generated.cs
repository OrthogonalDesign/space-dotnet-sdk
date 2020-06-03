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
    public partial class PublicHolidayClient
    {
        private readonly Connection _connection;
        
        public PublicHolidayClient(Connection connection)
        {
            _connection = connection;
        }
        
        public CalendarClient Calendars => new CalendarClient(_connection);
        
        public partial class CalendarClient
        {
            private readonly Connection _connection;
            
            public CalendarClient(Connection connection)
            {
                _connection = connection;
            }
            
            public async Task<PublicHolidayCalendarRecordDto> CreateCalendarAsync(CreateCalendarRequestDto data, Func<Partial<PublicHolidayCalendarRecordDto>, Partial<PublicHolidayCalendarRecordDto>> partialBuilder = null)
                => await _connection.RequestResourceAsync<CreateCalendarRequestDto, PublicHolidayCalendarRecordDto>("POST", $"api/http/public-holidays/calendars?$fields=" + (partialBuilder != null ? partialBuilder(new Partial<PublicHolidayCalendarRecordDto>()) : Partial<PublicHolidayCalendarRecordDto>.Default()), data);            
            
            public async Task<string> ImportAsync(ImportRequestDto data)
                => await _connection.RequestResourceAsync<ImportRequestDto, string>("POST", $"api/http/public-holidays/calendars/import?", data);            
            
            public async Task<Batch<PublicHolidayCalendarRecordDto>> GetAllCalendarsAsync(string? skip = null, int? top = null, Func<Partial<Batch<PublicHolidayCalendarRecordDto>>, Partial<Batch<PublicHolidayCalendarRecordDto>>> partialBuilder = null)
                => await _connection.RequestResourceAsync<Batch<PublicHolidayCalendarRecordDto>>("GET", $"api/http/public-holidays/calendars?$skip={skip?.ToString() ?? "null"}&$top={top?.ToString() ?? "null"}&$fields=" + (partialBuilder != null ? partialBuilder(new Partial<Batch<PublicHolidayCalendarRecordDto>>()) : Partial<Batch<PublicHolidayCalendarRecordDto>>.Default()));            
            
            public IAsyncEnumerable<PublicHolidayCalendarRecordDto> GetAllCalendarsAsyncEnumerable(string? skip = null, int? top = null, Func<Partial<PublicHolidayCalendarRecordDto>, Partial<PublicHolidayCalendarRecordDto>> partialBuilder = null)
                => BatchEnumerator.AllItems(batchSkip => GetAllCalendarsAsync(skip: batchSkip, top, builder => Partial<Batch<PublicHolidayCalendarRecordDto>>.Default().WithNext().WithTotalCount().WithData(partialBuilder != null ? partialBuilder : _ => Partial<PublicHolidayCalendarRecordDto>.Default())), skip);            
            
            public async Task<PublicHolidayCalendarRecordDto> UpdateCalendarAsync(string id, CreateCalendarRequestDto data, Func<Partial<PublicHolidayCalendarRecordDto>, Partial<PublicHolidayCalendarRecordDto>> partialBuilder = null)
                => await _connection.RequestResourceAsync<CreateCalendarRequestDto, PublicHolidayCalendarRecordDto>("PATCH", $"api/http/public-holidays/calendars/{id}?$fields=" + (partialBuilder != null ? partialBuilder(new Partial<PublicHolidayCalendarRecordDto>()) : Partial<PublicHolidayCalendarRecordDto>.Default()), data);            
            
            public async Task DeleteCalendarAsync(string id)
                => await _connection.RequestResourceAsync("DELETE", $"api/http/public-holidays/calendars/{id}");            
            
        }
        
        public HolidayClient Holidays => new HolidayClient(_connection);
        
        public partial class HolidayClient
        {
            private readonly Connection _connection;
            
            public HolidayClient(Connection connection)
            {
                _connection = connection;
            }
            
            public async Task<PublicHolidayDto> CreateHolidayAsync(CreateHolidayRequestDto data, Func<Partial<PublicHolidayDto>, Partial<PublicHolidayDto>> partialBuilder = null)
                => await _connection.RequestResourceAsync<CreateHolidayRequestDto, PublicHolidayDto>("POST", $"api/http/public-holidays/holidays?$fields=" + (partialBuilder != null ? partialBuilder(new Partial<PublicHolidayDto>()) : Partial<PublicHolidayDto>.Default()), data);            
            
            public async Task<Batch<PublicHolidayDto>> GetAllHolidaysAsync(string? skip = null, int? top = null, string? calendar = null, string? location = null, SpaceDate? startDate = null, SpaceDate? endDate = null, Func<Partial<Batch<PublicHolidayDto>>, Partial<Batch<PublicHolidayDto>>> partialBuilder = null)
                => await _connection.RequestResourceAsync<Batch<PublicHolidayDto>>("GET", $"api/http/public-holidays/holidays?$skip={skip?.ToString() ?? "null"}&$top={top?.ToString() ?? "null"}&calendar={calendar?.ToString() ?? "null"}&location={location?.ToString() ?? "null"}&startDate={startDate?.ToString() ?? "null"}&endDate={endDate?.ToString() ?? "null"}&$fields=" + (partialBuilder != null ? partialBuilder(new Partial<Batch<PublicHolidayDto>>()) : Partial<Batch<PublicHolidayDto>>.Default()));            
            
            public IAsyncEnumerable<PublicHolidayDto> GetAllHolidaysAsyncEnumerable(string? skip = null, int? top = null, string? calendar = null, string? location = null, SpaceDate? startDate = null, SpaceDate? endDate = null, Func<Partial<PublicHolidayDto>, Partial<PublicHolidayDto>> partialBuilder = null)
                => BatchEnumerator.AllItems(batchSkip => GetAllHolidaysAsync(skip: batchSkip, top, calendar, location, startDate, endDate, builder => Partial<Batch<PublicHolidayDto>>.Default().WithNext().WithTotalCount().WithData(partialBuilder != null ? partialBuilder : _ => Partial<PublicHolidayDto>.Default())), skip);            
            
            public async Task<PublicHolidayDto> UpdateHolidayAsync(string id, UpdateHolidayRequestDto data, Func<Partial<PublicHolidayDto>, Partial<PublicHolidayDto>> partialBuilder = null)
                => await _connection.RequestResourceAsync<UpdateHolidayRequestDto, PublicHolidayDto>("PATCH", $"api/http/public-holidays/holidays/{id}?$fields=" + (partialBuilder != null ? partialBuilder(new Partial<PublicHolidayDto>()) : Partial<PublicHolidayDto>.Default()), data);            
            
            public async Task DeleteHolidayAsync(string id)
                => await _connection.RequestResourceAsync("DELETE", $"api/http/public-holidays/holidays/{id}");            
            
            public ProfileHolidayClient ProfileHolidays => new ProfileHolidayClient(_connection);
            
            public partial class ProfileHolidayClient
            {
                private readonly Connection _connection;
                
                public ProfileHolidayClient(Connection connection)
                {
                    _connection = connection;
                }
                
                /// <summary>
                /// Get holidays observed in the location(s) of this profile during the selected period
                /// </summary>
                public async Task<List<PublicHolidayDto>> GetAllProfileHolidaysAsync(SpaceDate startDate, SpaceDate endDate, string profile, bool? workingDays = null, Func<Partial<PublicHolidayDto>, Partial<PublicHolidayDto>> partialBuilder = null)
                    => await _connection.RequestResourceAsync<List<PublicHolidayDto>>("GET", $"api/http/public-holidays/holidays/profile-holidays?startDate={startDate.ToString()}&endDate={endDate.ToString()}&profile={profile.ToString()}&workingDays={workingDays?.ToString()?.ToLowerInvariant() ?? "null"}&$fields=" + (partialBuilder != null ? partialBuilder(new Partial<PublicHolidayDto>()) : Partial<PublicHolidayDto>.Default()));                
                
            }
            
            public RelatedHolidayClient RelatedHolidays => new RelatedHolidayClient(_connection);
            
            public partial class RelatedHolidayClient
            {
                private readonly Connection _connection;
                
                public RelatedHolidayClient(Connection connection)
                {
                    _connection = connection;
                }
                
                public async Task<Batch<PublicHolidayDto>> GetAllRelatedHolidaysAsync(string? skip = null, int? top = null, SpaceDate? startDate = null, SpaceDate? endDate = null, Func<Partial<Batch<PublicHolidayDto>>, Partial<Batch<PublicHolidayDto>>> partialBuilder = null)
                    => await _connection.RequestResourceAsync<Batch<PublicHolidayDto>>("GET", $"api/http/public-holidays/holidays/related-holidays?$skip={skip?.ToString() ?? "null"}&$top={top?.ToString() ?? "null"}&startDate={startDate?.ToString() ?? "null"}&endDate={endDate?.ToString() ?? "null"}&$fields=" + (partialBuilder != null ? partialBuilder(new Partial<Batch<PublicHolidayDto>>()) : Partial<Batch<PublicHolidayDto>>.Default()));                
                
                public IAsyncEnumerable<PublicHolidayDto> GetAllRelatedHolidaysAsyncEnumerable(string? skip = null, int? top = null, SpaceDate? startDate = null, SpaceDate? endDate = null, Func<Partial<PublicHolidayDto>, Partial<PublicHolidayDto>> partialBuilder = null)
                    => BatchEnumerator.AllItems(batchSkip => GetAllRelatedHolidaysAsync(skip: batchSkip, top, startDate, endDate, builder => Partial<Batch<PublicHolidayDto>>.Default().WithNext().WithTotalCount().WithData(partialBuilder != null ? partialBuilder : _ => Partial<PublicHolidayDto>.Default())), skip);                
                
            }
            
        }
        
        public ProfileHolidayClient ProfileHolidays => new ProfileHolidayClient(_connection);
        
        public partial class ProfileHolidayClient
        {
            private readonly Connection _connection;
            
            public ProfileHolidayClient(Connection connection)
            {
                _connection = connection;
            }
            
            /// <summary>
            /// Get holidays observed in the location(s) of this profile during the selected period
            /// </summary>
            public async Task<List<PublicHolidayDto>> GetAllProfileHolidaysAsync(SpaceDate startDate, SpaceDate endDate, string profile, bool? workingDays = null, Func<Partial<PublicHolidayDto>, Partial<PublicHolidayDto>> partialBuilder = null)
                => await _connection.RequestResourceAsync<List<PublicHolidayDto>>("GET", $"api/http/public-holidays/profile-holidays?startDate={startDate.ToString()}&endDate={endDate.ToString()}&profile={profile.ToString()}&workingDays={workingDays?.ToString()?.ToLowerInvariant() ?? "null"}&$fields=" + (partialBuilder != null ? partialBuilder(new Partial<PublicHolidayDto>()) : Partial<PublicHolidayDto>.Default()));            
            
        }
        
        public RelatedHolidayClient RelatedHolidays => new RelatedHolidayClient(_connection);
        
        public partial class RelatedHolidayClient
        {
            private readonly Connection _connection;
            
            public RelatedHolidayClient(Connection connection)
            {
                _connection = connection;
            }
            
            public async Task<Batch<PublicHolidayDto>> GetAllRelatedHolidaysAsync(string? skip = null, int? top = null, SpaceDate? startDate = null, SpaceDate? endDate = null, Func<Partial<Batch<PublicHolidayDto>>, Partial<Batch<PublicHolidayDto>>> partialBuilder = null)
                => await _connection.RequestResourceAsync<Batch<PublicHolidayDto>>("GET", $"api/http/public-holidays/related-holidays?$skip={skip?.ToString() ?? "null"}&$top={top?.ToString() ?? "null"}&startDate={startDate?.ToString() ?? "null"}&endDate={endDate?.ToString() ?? "null"}&$fields=" + (partialBuilder != null ? partialBuilder(new Partial<Batch<PublicHolidayDto>>()) : Partial<Batch<PublicHolidayDto>>.Default()));            
            
            public IAsyncEnumerable<PublicHolidayDto> GetAllRelatedHolidaysAsyncEnumerable(string? skip = null, int? top = null, SpaceDate? startDate = null, SpaceDate? endDate = null, Func<Partial<PublicHolidayDto>, Partial<PublicHolidayDto>> partialBuilder = null)
                => BatchEnumerator.AllItems(batchSkip => GetAllRelatedHolidaysAsync(skip: batchSkip, top, startDate, endDate, builder => Partial<Batch<PublicHolidayDto>>.Default().WithNext().WithTotalCount().WithData(partialBuilder != null ? partialBuilder : _ => Partial<PublicHolidayDto>.Default())), skip);            
            
        }
        
    }
    
}
