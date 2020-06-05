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
    public sealed class AccessRecordDto
    {
        private PropertyValue<SpaceTime> _time = new PropertyValue<SpaceTime>(nameof(AccessRecordDto), nameof(Time));
        
        [Required]
        [JsonPropertyName("time")]
        public SpaceTime Time
        {
            get { return _time.GetValue(); }
            set { _time.SetValue(value); }
        }
    
        private PropertyValue<string> _address = new PropertyValue<string>(nameof(AccessRecordDto), nameof(Address));
        
        [Required]
        [JsonPropertyName("address")]
        public string Address
        {
            get { return _address.GetValue(); }
            set { _address.SetValue(value); }
        }
    
        private PropertyValue<string?> _userAgent = new PropertyValue<string?>(nameof(AccessRecordDto), nameof(UserAgent));
        
        [JsonPropertyName("userAgent")]
        public string? UserAgent
        {
            get { return _userAgent.GetValue(); }
            set { _userAgent.SetValue(value); }
        }
    
    }
    
}
