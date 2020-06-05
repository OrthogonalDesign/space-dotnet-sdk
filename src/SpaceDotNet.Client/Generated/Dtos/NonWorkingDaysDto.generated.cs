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
    public sealed class NonWorkingDaysDto
    {
        private PropertyValue<SpaceDate> _since = new PropertyValue<SpaceDate>(nameof(NonWorkingDaysDto), nameof(Since));
        
        [Required]
        [JsonPropertyName("since")]
        public SpaceDate Since
        {
            get { return _since.GetValue(); }
            set { _since.SetValue(value); }
        }
    
        private PropertyValue<SpaceDate> _till = new PropertyValue<SpaceDate>(nameof(NonWorkingDaysDto), nameof(Till));
        
        [Required]
        [JsonPropertyName("till")]
        public SpaceDate Till
        {
            get { return _till.GetValue(); }
            set { _till.SetValue(value); }
        }
    
        private PropertyValue<bool> _startsEarlier = new PropertyValue<bool>(nameof(NonWorkingDaysDto), nameof(StartsEarlier));
        
        [Required]
        [JsonPropertyName("startsEarlier")]
        public bool StartsEarlier
        {
            get { return _startsEarlier.GetValue(); }
            set { _startsEarlier.SetValue(value); }
        }
    
        private PropertyValue<bool> _endsLater = new PropertyValue<bool>(nameof(NonWorkingDaysDto), nameof(EndsLater));
        
        [Required]
        [JsonPropertyName("endsLater")]
        public bool EndsLater
        {
            get { return _endsLater.GetValue(); }
            set { _endsLater.SetValue(value); }
        }
    
    }
    
}
