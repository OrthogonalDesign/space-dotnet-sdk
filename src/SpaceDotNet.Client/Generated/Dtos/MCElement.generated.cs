// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS0108

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public sealed class MCElement
         : IPropagatePropertyAccessPath
    {
        public MCElement() { }
        
        public MCElement(string defaultText, MCElementDetails? details = null)
        {
            DefaultText = defaultText;
            Details = details;
        }
        
        private PropertyValue<string> _defaultText = new PropertyValue<string>(nameof(MCElement), nameof(DefaultText));
        
        [Required]
        [JsonPropertyName("defaultText")]
        public string DefaultText
        {
            get { return _defaultText.GetValue(); }
            set { _defaultText.SetValue(value); }
        }
    
        private PropertyValue<MCElementDetails?> _details = new PropertyValue<MCElementDetails?>(nameof(MCElement), nameof(Details));
        
        [JsonPropertyName("details")]
        public MCElementDetails? Details
        {
            get { return _details.GetValue(); }
            set { _details.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _defaultText.SetAccessPath(path, validateHasBeenSet);
            _details.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}