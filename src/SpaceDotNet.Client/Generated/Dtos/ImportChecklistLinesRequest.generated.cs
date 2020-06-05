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
    public class ImportChecklistLinesRequest
    {
        private PropertyValue<string> _targetParentId = new PropertyValue<string>(nameof(ImportChecklistLinesRequest), nameof(TargetParentId));
        
        [Required]
        [JsonPropertyName("targetParentId")]
        public string TargetParentId
        {
            get { return _targetParentId.GetValue(); }
            set { _targetParentId.SetValue(value); }
        }
    
        private PropertyValue<string?> _afterItemId = new PropertyValue<string?>(nameof(ImportChecklistLinesRequest), nameof(AfterItemId));
        
        [JsonPropertyName("afterItemId")]
        public string? AfterItemId
        {
            get { return _afterItemId.GetValue(); }
            set { _afterItemId.SetValue(value); }
        }
    
        private PropertyValue<string> _tabIndentedLines = new PropertyValue<string>(nameof(ImportChecklistLinesRequest), nameof(TabIndentedLines));
        
        [Required]
        [JsonPropertyName("tabIndentedLines")]
        public string TabIndentedLines
        {
            get { return _tabIndentedLines.GetValue(); }
            set { _tabIndentedLines.SetValue(value); }
        }
    
    }
    
}