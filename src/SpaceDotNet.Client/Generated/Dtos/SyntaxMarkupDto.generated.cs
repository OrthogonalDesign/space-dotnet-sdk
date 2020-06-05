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
    public sealed class SyntaxMarkupDto
    {
        private PropertyValue<SyntaxMarkupType> _type = new PropertyValue<SyntaxMarkupType>(nameof(SyntaxMarkupDto), nameof(Type));
        
        [Required]
        [JsonPropertyName("type")]
        public SyntaxMarkupType Type
        {
            get { return _type.GetValue(); }
            set { _type.SetValue(value); }
        }
    
        private PropertyValue<TextRangeDto> _range = new PropertyValue<TextRangeDto>(nameof(SyntaxMarkupDto), nameof(Range));
        
        [Required]
        [JsonPropertyName("range")]
        public TextRangeDto Range
        {
            get { return _range.GetValue(); }
            set { _range.SetValue(value); }
        }
    
    }
    
}
