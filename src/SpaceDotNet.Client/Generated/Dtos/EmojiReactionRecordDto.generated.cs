// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T10:16:39.3065820+00:00
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
    public class EmojiReactionRecordDto
    {
        [Required]
        [JsonPropertyName("id")]
        public string Id { get; set; }        
        
        [Required]
        [JsonPropertyName("itemId")]
        public string ItemId { get; set; }        
        
        [Required]
        [JsonPropertyName("emoji")]
        public string Emoji { get; set; }        
        
        [Required]
        [JsonPropertyName("count")]
        public int Count { get; set; }        
        
        [Required]
        [JsonPropertyName("meReacted")]
        public bool MeReacted { get; set; }        
        
        [Required]
        [JsonPropertyName("order")]
        public long Order { get; set; }        
        
    }
    
}