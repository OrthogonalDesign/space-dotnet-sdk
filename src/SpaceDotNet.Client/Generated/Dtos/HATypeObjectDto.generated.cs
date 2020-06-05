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
    public sealed class HATypeObjectDto
         : HATypeDto, IClassNameConvertible
    {
        private PropertyValue<List<HAFieldDto>> _fields = new PropertyValue<List<HAFieldDto>>(nameof(HATypeObjectDto), nameof(Fields));
        
        [Required]
        [JsonPropertyName("fields")]
        public List<HAFieldDto> Fields
        {
            get { return _fields.GetValue(); }
            set { _fields.SetValue(value); }
        }
    
        private PropertyValue<HATypeObjectKind> _kind = new PropertyValue<HATypeObjectKind>(nameof(HATypeObjectDto), nameof(Kind));
        
        [Required]
        [JsonPropertyName("kind")]
        public HATypeObjectKind Kind
        {
            get { return _kind.GetValue(); }
            set { _kind.SetValue(value); }
        }
    
        private PropertyValue<bool> _nullable = new PropertyValue<bool>(nameof(HATypeObjectDto), nameof(Nullable));
        
        [Required]
        [JsonPropertyName("nullable")]
        public bool Nullable
        {
            get { return _nullable.GetValue(); }
            set { _nullable.SetValue(value); }
        }
    
        private PropertyValue<bool> _optional = new PropertyValue<bool>(nameof(HATypeObjectDto), nameof(Optional));
        
        [Required]
        [JsonPropertyName("optional")]
        public bool Optional
        {
            get { return _optional.GetValue(); }
            set { _optional.SetValue(value); }
        }
    
    }
    
}
