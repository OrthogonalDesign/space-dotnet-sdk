// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T10:16:39.2830521+00:00
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
    public class CalendarEventSpecDto
    {
        [Required]
        [JsonPropertyName("start")]
        public SpaceTime Start { get; set; }        
        
        [Required]
        [JsonPropertyName("end")]
        public SpaceTime End { get; set; }        
        
        [JsonPropertyName("recurrenceRule")]
        public RecurrenceRuleDto? RecurrenceRule { get; set; }        
        
        [Required]
        [JsonPropertyName("allDay")]
        public bool AllDay { get; set; }        
        
        [Required]
        [JsonPropertyName("timezone")]
        public ATimeZoneDto Timezone { get; set; }        
        
        [JsonPropertyName("parentId")]
        public string? ParentId { get; set; }        
        
    }
    
}