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
    public sealed class NavBarMenuItemDto
    {
        private PropertyValue<string> _item = new PropertyValue<string>(nameof(NavBarMenuItemDto), nameof(Item));
        
        [Required]
        [JsonPropertyName("item")]
        public string Item
        {
            get { return _item.GetValue(); }
            set { _item.SetValue(value); }
        }
    
        private PropertyValue<bool> _enabled = new PropertyValue<bool>(nameof(NavBarMenuItemDto), nameof(Enabled));
        
        [Required]
        [JsonPropertyName("enabled")]
        public bool Enabled
        {
            get { return _enabled.GetValue(); }
            set { _enabled.SetValue(value); }
        }
    
    }
    
}
