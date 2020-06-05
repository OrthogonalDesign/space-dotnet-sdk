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
    public class CreateApplicationPasswordRequest
    {
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(CreateApplicationPasswordRequest), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get { return _name.GetValue(); }
            set { _name.SetValue(value); }
        }
    
        private PropertyValue<string> _scope = new PropertyValue<string>(nameof(CreateApplicationPasswordRequest), nameof(Scope));
        
        [Required]
        [JsonPropertyName("scope")]
        public string Scope
        {
            get { return _scope.GetValue(); }
            set { _scope.SetValue(value); }
        }
    
    }
    
}
