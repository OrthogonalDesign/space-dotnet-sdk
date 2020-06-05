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
    public class UpdateAbsenceRequest
    {
        private PropertyValue<string?> _member = new PropertyValue<string?>(nameof(UpdateAbsenceRequest), nameof(Member));
        
        [JsonPropertyName("member")]
        public string? Member
        {
            get { return _member.GetValue(); }
            set { _member.SetValue(value); }
        }
    
        private PropertyValue<string?> _reason = new PropertyValue<string?>(nameof(UpdateAbsenceRequest), nameof(Reason));
        
        [JsonPropertyName("reason")]
        public string? Reason
        {
            get { return _reason.GetValue(); }
            set { _reason.SetValue(value); }
        }
    
        private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(UpdateAbsenceRequest), nameof(Description));
        
        [JsonPropertyName("description")]
        public string? Description
        {
            get { return _description.GetValue(); }
            set { _description.SetValue(value); }
        }
    
        private PropertyValue<string?> _location = new PropertyValue<string?>(nameof(UpdateAbsenceRequest), nameof(Location));
        
        [JsonPropertyName("location")]
        public string? Location
        {
            get { return _location.GetValue(); }
            set { _location.SetValue(value); }
        }
    
        private PropertyValue<SpaceDate?> _since = new PropertyValue<SpaceDate?>(nameof(UpdateAbsenceRequest), nameof(Since));
        
        [JsonPropertyName("since")]
        public SpaceDate? Since
        {
            get { return _since.GetValue(); }
            set { _since.SetValue(value); }
        }
    
        private PropertyValue<SpaceDate?> _till = new PropertyValue<SpaceDate?>(nameof(UpdateAbsenceRequest), nameof(Till));
        
        [JsonPropertyName("till")]
        public SpaceDate? Till
        {
            get { return _till.GetValue(); }
            set { _till.SetValue(value); }
        }
    
        private PropertyValue<bool> _available = new PropertyValue<bool>(nameof(UpdateAbsenceRequest), nameof(Available));
        
        [Required]
        [JsonPropertyName("available")]
        public bool Available
        {
            get { return _available.GetValue(); }
            set { _available.SetValue(value); }
        }
    
        private PropertyValue<string?> _icon = new PropertyValue<string?>(nameof(UpdateAbsenceRequest), nameof(Icon));
        
        [JsonPropertyName("icon")]
        public string? Icon
        {
            get { return _icon.GetValue(); }
            set { _icon.SetValue(value); }
        }
    
        private PropertyValue<List<CustomFieldValueDto>?> _customFieldValues = new PropertyValue<List<CustomFieldValueDto>?>(nameof(UpdateAbsenceRequest), nameof(CustomFieldValues));
        
        [JsonPropertyName("customFieldValues")]
        public List<CustomFieldValueDto>? CustomFieldValues
        {
            get { return _customFieldValues.GetValue(); }
            set { _customFieldValues.SetValue(value); }
        }
    
    }
    
}
