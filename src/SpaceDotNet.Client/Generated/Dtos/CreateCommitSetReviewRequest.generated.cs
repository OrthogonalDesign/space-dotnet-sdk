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
    public class CreateCommitSetReviewRequest
    {
        private PropertyValue<List<string>> _revisions = new PropertyValue<List<string>>(nameof(CreateCommitSetReviewRequest), nameof(Revisions));
        
        [Required]
        [JsonPropertyName("revisions")]
        public List<string> Revisions
        {
            get { return _revisions.GetValue(); }
            set { _revisions.SetValue(value); }
        }
    
        private PropertyValue<string?> _title = new PropertyValue<string?>(nameof(CreateCommitSetReviewRequest), nameof(Title));
        
        [JsonPropertyName("title")]
        public string? Title
        {
            get { return _title.GetValue(); }
            set { _title.SetValue(value); }
        }
    
    }
    
}