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
    public sealed class TodoItemContentMdTextDto
         : TodoItemContentDto, IClassNameConvertible
    {
        [JsonPropertyName("className")]
        public string? ClassName { get; set; }
        
        private PropertyValue<string> _text = new PropertyValue<string>(nameof(TodoItemContentMdTextDto), nameof(Text));
        
        [Required]
        [JsonPropertyName("text")]
        public string Text
        {
            get { return _text.GetValue(); }
            set { _text.SetValue(value); }
        }
    
        private PropertyValue<MdMarkupDto> _mdMarkup = new PropertyValue<MdMarkupDto>(nameof(TodoItemContentMdTextDto), nameof(MdMarkup));
        
        [Required]
        [JsonPropertyName("mdMarkup")]
        public MdMarkupDto MdMarkup
        {
            get { return _mdMarkup.GetValue(); }
            set { _mdMarkup.SetValue(value); }
        }
    
    }
    
}
