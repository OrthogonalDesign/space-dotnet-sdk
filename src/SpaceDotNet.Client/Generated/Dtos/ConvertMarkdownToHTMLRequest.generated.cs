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
    public class ConvertMarkdownToHTMLRequest
    {
        private PropertyValue<string> _markdown = new PropertyValue<string>(nameof(ConvertMarkdownToHTMLRequest), nameof(Markdown));
        
        [Required]
        [JsonPropertyName("markdown")]
        public string Markdown
        {
            get { return _markdown.GetValue(); }
            set { _markdown.SetValue(value); }
        }
    
    }
    
}
