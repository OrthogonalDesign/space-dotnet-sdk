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
    public class CreateSubscriptionRequest
    {
        private PropertyValue<string?> _locationId = new PropertyValue<string?>(nameof(CreateSubscriptionRequest), nameof(LocationId));
        
        [JsonPropertyName("locationId")]
        public string? LocationId
        {
            get { return _locationId.GetValue(); }
            set { _locationId.SetValue(value); }
        }
    
        private PropertyValue<string?> _teamId = new PropertyValue<string?>(nameof(CreateSubscriptionRequest), nameof(TeamId));
        
        [JsonPropertyName("teamId")]
        public string? TeamId
        {
            get { return _teamId.GetValue(); }
            set { _teamId.SetValue(value); }
        }
    
        private PropertyValue<string?> _reasonId = new PropertyValue<string?>(nameof(CreateSubscriptionRequest), nameof(ReasonId));
        
        [JsonPropertyName("reasonId")]
        public string? ReasonId
        {
            get { return _reasonId.GetValue(); }
            set { _reasonId.SetValue(value); }
        }
    
    }
    
}