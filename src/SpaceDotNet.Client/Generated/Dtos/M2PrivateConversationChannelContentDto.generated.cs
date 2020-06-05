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
    public sealed class M2PrivateConversationChannelContentDto
         : M2ChannelContactInfoDto, M2ChannelContentInfoDto, IClassNameConvertible
    {
        [JsonPropertyName("className")]
        public string? ClassName { get; set; }
        
        private PropertyValue<string> _channelId = new PropertyValue<string>(nameof(M2PrivateConversationChannelContentDto), nameof(ChannelId));
        
        [Required]
        [JsonPropertyName("channelId")]
        public string ChannelId
        {
            get { return _channelId.GetValue(); }
            set { _channelId.SetValue(value); }
        }
    
        private PropertyValue<string?> _subject = new PropertyValue<string?>(nameof(M2PrivateConversationChannelContentDto), nameof(Subject));
        
        [JsonPropertyName("subject")]
        public string? Subject
        {
            get { return _subject.GetValue(); }
            set { _subject.SetValue(value); }
        }
    
        private PropertyValue<List<TDMemberProfileDto>> _members = new PropertyValue<List<TDMemberProfileDto>>(nameof(M2PrivateConversationChannelContentDto), nameof(Members));
        
        [Required]
        [JsonPropertyName("members")]
        public List<TDMemberProfileDto> Members
        {
            get { return _members.GetValue(); }
            set { _members.SetValue(value); }
        }
    
        private PropertyValue<ChannelSpecificDefaultsDto?> _notificationDefaults = new PropertyValue<ChannelSpecificDefaultsDto?>(nameof(M2PrivateConversationChannelContentDto), nameof(NotificationDefaults));
        
        [JsonPropertyName("notificationDefaults")]
        public ChannelSpecificDefaultsDto? NotificationDefaults
        {
            get { return _notificationDefaults.GetValue(); }
            set { _notificationDefaults.SetValue(value); }
        }
    
    }
    
}
