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
    public sealed class ArticleDetailsRecordDto
    {
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(ArticleDetailsRecordDto), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(ArticleDetailsRecordDto), nameof(Archived));
        
        [Required]
        [JsonPropertyName("archived")]
        public bool Archived
        {
            get { return _archived.GetValue(); }
            set { _archived.SetValue(value); }
        }
    
        private PropertyValue<MeetingRecordDto?> _event = new PropertyValue<MeetingRecordDto?>(nameof(ArticleDetailsRecordDto), nameof(Event));
        
        [JsonPropertyName("event")]
        public MeetingRecordDto? Event
        {
            get { return _event.GetValue(); }
            set { _event.SetValue(value); }
        }
    
        private PropertyValue<TDTeamDto?> _team = new PropertyValue<TDTeamDto?>(nameof(ArticleDetailsRecordDto), nameof(Team));
        
        [JsonPropertyName("team")]
        public TDTeamDto? Team
        {
            get { return _team.GetValue(); }
            set { _team.SetValue(value); }
        }
    
        private PropertyValue<PRProjectDto?> _project = new PropertyValue<PRProjectDto?>(nameof(ArticleDetailsRecordDto), nameof(Project));
        
        [JsonPropertyName("project")]
        public PRProjectDto? Project
        {
            get { return _project.GetValue(); }
            set { _project.SetValue(value); }
        }
    
        private PropertyValue<TDLocationDto?> _location = new PropertyValue<TDLocationDto?>(nameof(ArticleDetailsRecordDto), nameof(Location));
        
        [JsonPropertyName("location")]
        public TDLocationDto? Location
        {
            get { return _location.GetValue(); }
            set { _location.SetValue(value); }
        }
    
        private PropertyValue<List<TDTeamDto>?> _teams = new PropertyValue<List<TDTeamDto>?>(nameof(ArticleDetailsRecordDto), nameof(Teams));
        
        [JsonPropertyName("teams")]
        public List<TDTeamDto>? Teams
        {
            get { return _teams.GetValue(); }
            set { _teams.SetValue(value); }
        }
    
        private PropertyValue<List<TDLocationDto>?> _locations = new PropertyValue<List<TDLocationDto>?>(nameof(ArticleDetailsRecordDto), nameof(Locations));
        
        [JsonPropertyName("locations")]
        public List<TDLocationDto>? Locations
        {
            get { return _locations.GetValue(); }
            set { _locations.SetValue(value); }
        }
    
        private PropertyValue<ExternalEntityInfoRecordDto?> _externalEntityInfo = new PropertyValue<ExternalEntityInfoRecordDto?>(nameof(ArticleDetailsRecordDto), nameof(ExternalEntityInfo));
        
        [JsonPropertyName("externalEntityInfo")]
        public ExternalEntityInfoRecordDto? ExternalEntityInfo
        {
            get { return _externalEntityInfo.GetValue(); }
            set { _externalEntityInfo.SetValue(value); }
        }
    
    }
    
}
