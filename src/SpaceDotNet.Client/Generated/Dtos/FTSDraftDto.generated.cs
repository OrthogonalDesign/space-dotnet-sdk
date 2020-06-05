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
    public sealed class FTSDraftDto
    {
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(FTSDraftDto), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<string> _title = new PropertyValue<string>(nameof(FTSDraftDto), nameof(Title));
        
        [Required]
        [JsonPropertyName("title")]
        public string Title
        {
            get { return _title.GetValue(); }
            set { _title.SetValue(value); }
        }
    
        private PropertyValue<TDMemberProfileDto> _author = new PropertyValue<TDMemberProfileDto>(nameof(FTSDraftDto), nameof(Author));
        
        [Required]
        [JsonPropertyName("author")]
        public TDMemberProfileDto Author
        {
            get { return _author.GetValue(); }
            set { _author.SetValue(value); }
        }
    
        private PropertyValue<SpaceTime> _date = new PropertyValue<SpaceTime>(nameof(FTSDraftDto), nameof(Date));
        
        [Required]
        [JsonPropertyName("date")]
        public SpaceTime Date
        {
            get { return _date.GetValue(); }
            set { _date.SetValue(value); }
        }
    
        private PropertyValue<List<FTSSnippetDto>> _snippets = new PropertyValue<List<FTSSnippetDto>>(nameof(FTSDraftDto), nameof(Snippets));
        
        [Required]
        [JsonPropertyName("snippets")]
        public List<FTSSnippetDto> Snippets
        {
            get { return _snippets.GetValue(); }
            set { _snippets.SetValue(value); }
        }
    
    }
    
}
