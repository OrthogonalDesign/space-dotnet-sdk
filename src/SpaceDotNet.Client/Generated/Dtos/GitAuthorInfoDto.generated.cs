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
    public sealed class GitAuthorInfoDto
    {
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(GitAuthorInfoDto), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get { return _name.GetValue(); }
            set { _name.SetValue(value); }
        }
    
        private PropertyValue<string> _email = new PropertyValue<string>(nameof(GitAuthorInfoDto), nameof(Email));
        
        [Required]
        [JsonPropertyName("email")]
        public string Email
        {
            get { return _email.GetValue(); }
            set { _email.SetValue(value); }
        }
    
    }
    
}
