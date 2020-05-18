// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T10:16:39.6751622+00:00
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
    public class CreateIssueRequestDto
    {
        [Required]
        [JsonPropertyName("title")]
        public string Title { get; set; }        
        
        [JsonPropertyName("description")]
        public string? Description { get; set; }        
        
        [JsonPropertyName("assignee")]
        public string? Assignee { get; set; }        
        
        [Required]
        [JsonPropertyName("status")]
        public string Status { get; set; }        
        
        [JsonPropertyName("dueDate")]
        public SpaceDate? DueDate { get; set; }        
        
        [Required]
        [JsonPropertyName("tags")]
        public List<string> Tags { get; set; }        
        
        [Required]
        [JsonPropertyName("checklists")]
        public List<string> Checklists { get; set; }        
        
        [JsonPropertyName("attachments")]
        public List<AttachmentDto>? Attachments { get; set; }        
        
        [JsonPropertyName("importInfo")]
        public ImportedEntityInfoDto? ImportInfo { get; set; }        
        
    }
    
}