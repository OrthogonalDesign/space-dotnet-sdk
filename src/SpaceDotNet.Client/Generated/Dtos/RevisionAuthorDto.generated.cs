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
    public sealed class RevisionAuthorDto
    {
        private PropertyValue<string> _authorName = new PropertyValue<string>(nameof(RevisionAuthorDto), nameof(AuthorName));
        
        [Required]
        [JsonPropertyName("authorName")]
        public string AuthorName
        {
            get { return _authorName.GetValue(); }
            set { _authorName.SetValue(value); }
        }
    
        private PropertyValue<TDMemberProfileDto?> _profile = new PropertyValue<TDMemberProfileDto?>(nameof(RevisionAuthorDto), nameof(Profile));
        
        [JsonPropertyName("profile")]
        public TDMemberProfileDto? Profile
        {
            get { return _profile.GetValue(); }
            set { _profile.SetValue(value); }
        }
    
    }
    
}
