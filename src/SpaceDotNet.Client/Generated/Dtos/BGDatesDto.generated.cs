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
    public sealed class BGDatesDto
    {
        private PropertyValue<SpaceTime> _first = new PropertyValue<SpaceTime>(nameof(BGDatesDto), nameof(First));
        
        [Required]
        [JsonPropertyName("first")]
        public SpaceTime First
        {
            get { return _first.GetValue(); }
            set { _first.SetValue(value); }
        }
    
        private PropertyValue<SpaceTime> _last = new PropertyValue<SpaceTime>(nameof(BGDatesDto), nameof(Last));
        
        [Required]
        [JsonPropertyName("last")]
        public SpaceTime Last
        {
            get { return _last.GetValue(); }
            set { _last.SetValue(value); }
        }
    
    }
    
}
