// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T10:16:39.3717953+00:00
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
    public class PollRecordDto
    {
        [Required]
        [JsonPropertyName("id")]
        public string Id { get; set; }        
        
        [Required]
        [JsonPropertyName("owner")]
        public TDMemberProfileDto Owner { get; set; }        
        
        [Required]
        [JsonPropertyName("question")]
        public string Question { get; set; }        
        
        [Required]
        [JsonPropertyName("meVote")]
        public bool MeVote { get; set; }        
        
        [Required]
        [JsonPropertyName("countPeople")]
        public int CountPeople { get; set; }        
        
        [Required]
        [JsonPropertyName("anonymous")]
        public bool Anonymous { get; set; }        
        
        [Required]
        [JsonPropertyName("closed")]
        public bool Closed { get; set; }        
        
        [Required]
        [JsonPropertyName("extendable")]
        public bool Extendable { get; set; }        
        
        [Required]
        [JsonPropertyName("multiChoice")]
        public bool MultiChoice { get; set; }        
        
        [Required]
        [JsonPropertyName("ended")]
        public bool Ended { get; set; }        
        
        [JsonPropertyName("expirationTime")]
        public SpaceTime? ExpirationTime { get; set; }        
        
        [Required]
        [JsonPropertyName("votes")]
        public List<VoteGroupDto> Votes { get; set; }        
        
    }
    
}