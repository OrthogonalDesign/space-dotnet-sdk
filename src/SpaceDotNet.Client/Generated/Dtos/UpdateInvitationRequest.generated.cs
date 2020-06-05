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
    public class UpdateInvitationRequest
    {
        private PropertyValue<string?> _inviteeEmail = new PropertyValue<string?>(nameof(UpdateInvitationRequest), nameof(InviteeEmail));
        
        [JsonPropertyName("inviteeEmail")]
        public string? InviteeEmail
        {
            get { return _inviteeEmail.GetValue(); }
            set { _inviteeEmail.SetValue(value); }
        }
    
        private PropertyValue<string?> _inviteeFirstName = new PropertyValue<string?>(nameof(UpdateInvitationRequest), nameof(InviteeFirstName));
        
        [JsonPropertyName("inviteeFirstName")]
        public string? InviteeFirstName
        {
            get { return _inviteeFirstName.GetValue(); }
            set { _inviteeFirstName.SetValue(value); }
        }
    
        private PropertyValue<string?> _inviteeLastName = new PropertyValue<string?>(nameof(UpdateInvitationRequest), nameof(InviteeLastName));
        
        [JsonPropertyName("inviteeLastName")]
        public string? InviteeLastName
        {
            get { return _inviteeLastName.GetValue(); }
            set { _inviteeLastName.SetValue(value); }
        }
    
        private PropertyValue<TDTeamDto?> _team = new PropertyValue<TDTeamDto?>(nameof(UpdateInvitationRequest), nameof(Team));
        
        [JsonPropertyName("team")]
        public TDTeamDto? Team
        {
            get { return _team.GetValue(); }
            set { _team.SetValue(value); }
        }
    
        private PropertyValue<TDRoleDto?> _role = new PropertyValue<TDRoleDto?>(nameof(UpdateInvitationRequest), nameof(Role));
        
        [JsonPropertyName("role")]
        public TDRoleDto? Role
        {
            get { return _role.GetValue(); }
            set { _role.SetValue(value); }
        }
    
    }
    
}
