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
    public sealed class CodeDiscussionSnippetPlainSnippetDto
         : CodeDiscussionSnippetDto, IClassNameConvertible
    {
        private PropertyValue<List<CodeLineDto>> _lines = new PropertyValue<List<CodeLineDto>>(nameof(CodeDiscussionSnippetPlainSnippetDto), nameof(Lines));
        
        [Required]
        [JsonPropertyName("lines")]
        public List<CodeLineDto> Lines
        {
            get { return _lines.GetValue(); }
            set { _lines.SetValue(value); }
        }
    
    }
    
}
