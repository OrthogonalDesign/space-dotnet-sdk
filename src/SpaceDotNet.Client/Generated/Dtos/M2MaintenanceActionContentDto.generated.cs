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
    public sealed class M2MaintenanceActionContentDto
         : M2ItemContentDetailsDto, IClassNameConvertible
    {
        [JsonPropertyName("className")]
        public string? ClassName { get; set; }
        
        private PropertyValue<string> _action = new PropertyValue<string>(nameof(M2MaintenanceActionContentDto), nameof(Action));
        
        [Required]
        [JsonPropertyName("action")]
        public string Action
        {
            get { return _action.GetValue(); }
            set { _action.SetValue(value); }
        }
    
        private PropertyValue<bool> _success = new PropertyValue<bool>(nameof(M2MaintenanceActionContentDto), nameof(Success));
        
        [Required]
        [JsonPropertyName("success")]
        public bool Success
        {
            get { return _success.GetValue(); }
            set { _success.SetValue(value); }
        }
    
        private PropertyValue<string> _details = new PropertyValue<string>(nameof(M2MaintenanceActionContentDto), nameof(Details));
        
        [Required]
        [JsonPropertyName("details")]
        public string Details
        {
            get { return _details.GetValue(); }
            set { _details.SetValue(value); }
        }
    
    }
    
}
