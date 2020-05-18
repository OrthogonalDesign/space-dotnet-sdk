// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T10:16:39.2871599+00:00
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
    public class CodeDiscussionRecordDto
    {
        [Required]
        [JsonPropertyName("id")]
        public string Id { get; set; }        
        
        [Required]
        [JsonPropertyName("projectId")]
        public string ProjectId { get; set; }        
        
        [Required]
        [JsonPropertyName("anchor")]
        public CodeDiscussionAnchorDto Anchor { get; set; }        
        
        [Required]
        [JsonPropertyName("created")]
        public SpaceTime Created { get; set; }        
        
        [Required]
        [JsonPropertyName("channel")]
        public M2ChannelRecordDto Channel { get; set; }        
        
        [Required]
        [JsonPropertyName("resolved")]
        public bool Resolved { get; set; }        
        
        [JsonPropertyName("snippet")]
        public CodeDiscussionSnippetDto? Snippet { get; set; }        
        
        [JsonPropertyName("pending")]
        public bool? Pending { get; set; }        
        
        [JsonPropertyName("review")]
        public CodeReviewRecordDto? Review { get; set; }        
        
        [JsonPropertyName("reviews")]
        public List<CodeReviewRecordDto>? Reviews { get; set; }        
        
        [Required]
        [JsonPropertyName("archived")]
        public bool Archived { get; set; }        
        
    }
    
}