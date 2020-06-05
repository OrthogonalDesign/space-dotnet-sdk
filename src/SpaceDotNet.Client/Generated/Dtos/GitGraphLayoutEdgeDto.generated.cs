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
    public sealed class GitGraphLayoutEdgeDto
    {
        private PropertyValue<int> _from = new PropertyValue<int>(nameof(GitGraphLayoutEdgeDto), nameof(From));
        
        [Required]
        [JsonPropertyName("from")]
        public int From
        {
            get { return _from.GetValue(); }
            set { _from.SetValue(value); }
        }
    
        private PropertyValue<int> _to = new PropertyValue<int>(nameof(GitGraphLayoutEdgeDto), nameof(To));
        
        [Required]
        [JsonPropertyName("to")]
        public int To
        {
            get { return _to.GetValue(); }
            set { _to.SetValue(value); }
        }
    
        private PropertyValue<GitGraphEdgeType> _type = new PropertyValue<GitGraphEdgeType>(nameof(GitGraphLayoutEdgeDto), nameof(Type));
        
        [Required]
        [JsonPropertyName("type")]
        public GitGraphEdgeType Type
        {
            get { return _type.GetValue(); }
            set { _type.SetValue(value); }
        }
    
        private PropertyValue<GitGraphEdgeLineStyle> _style = new PropertyValue<GitGraphEdgeLineStyle>(nameof(GitGraphLayoutEdgeDto), nameof(Style));
        
        [Required]
        [JsonPropertyName("style")]
        public GitGraphEdgeLineStyle Style
        {
            get { return _style.GetValue(); }
            set { _style.SetValue(value); }
        }
    
        private PropertyValue<bool> _hasArrow = new PropertyValue<bool>(nameof(GitGraphLayoutEdgeDto), nameof(HasArrow));
        
        [Required]
        [JsonPropertyName("hasArrow")]
        public bool HasArrow
        {
            get { return _hasArrow.GetValue(); }
            set { _hasArrow.SetValue(value); }
        }
    
        private PropertyValue<int> _color = new PropertyValue<int>(nameof(GitGraphLayoutEdgeDto), nameof(Color));
        
        [Required]
        [JsonPropertyName("color")]
        public int Color
        {
            get { return _color.GetValue(); }
            set { _color.SetValue(value); }
        }
    
    }
    
}
