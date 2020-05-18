// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T10:16:39.2754707+00:00
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
    public class AbsenceRecordDto
    {
        [Required]
        [JsonPropertyName("id")]
        public string Id { get; set; }        
        
        [Required]
        [JsonPropertyName("archived")]
        public bool Archived { get; set; }        
        
        [Required]
        [JsonPropertyName("member")]
        public TDMemberProfileDto Member { get; set; }        
        
        [Required]
        [JsonPropertyName("icon")]
        public string Icon { get; set; }        
        
        [JsonPropertyName("reason")]
        public AbsenceReasonRecordDto? Reason { get; set; }        
        
        [JsonPropertyName("description")]
        public string? Description { get; set; }        
        
        [Required]
        [JsonPropertyName("since")]
        public SpaceDate Since { get; set; }        
        
        [Required]
        [JsonPropertyName("till")]
        public SpaceDate Till { get; set; }        
        
        [JsonPropertyName("location")]
        public TDLocationDto? Location { get; set; }        
        
        [Required]
        [JsonPropertyName("available")]
        public bool Available { get; set; }        
        
        [JsonPropertyName("approval")]
        public AbsenceApprovalDto? Approval { get; set; }        
        
        [JsonPropertyName("customFields")]
        public List<CustomColumnValuesWithSchemaDataDto>? CustomFields { get; set; }        
        
    }
    
}