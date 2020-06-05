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
    public sealed class TDProfileLanguageDto
    {
        private PropertyValue<TDProfileNameDto?> _name = new PropertyValue<TDProfileNameDto?>(nameof(TDProfileLanguageDto), nameof(Name));
        
        [JsonPropertyName("name")]
        public TDProfileNameDto? Name
        {
            get { return _name.GetValue(); }
            set { _name.SetValue(value); }
        }
    
        private PropertyValue<TDLanguageDto> _language = new PropertyValue<TDLanguageDto>(nameof(TDProfileLanguageDto), nameof(Language));
        
        [Required]
        [JsonPropertyName("language")]
        public TDLanguageDto Language
        {
            get { return _language.GetValue(); }
            set { _language.SetValue(value); }
        }
    
        private PropertyValue<string?> _languageCode = new PropertyValue<string?>(nameof(TDProfileLanguageDto), nameof(LanguageCode));
        
        [JsonPropertyName("languageCode")]
        public string? LanguageCode
        {
            get { return _languageCode.GetValue(); }
            set { _languageCode.SetValue(value); }
        }
    
    }
    
}
