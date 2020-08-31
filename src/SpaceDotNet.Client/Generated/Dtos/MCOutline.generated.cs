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
    public sealed class MCOutline
         : MCElementDetails, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "MCOutline";
        
        public MCOutline() { }
        
        public MCOutline(MCElement? icon = null, MCText? text = null)
        {
            Icon = icon;
            Text = text;
        }
        
        private PropertyValue<MCElement?> _icon = new PropertyValue<MCElement?>(nameof(MCOutline), nameof(Icon));
        
        [JsonPropertyName("icon")]
        public MCElement? Icon
        {
            get { return _icon.GetValue(); }
            set { _icon.SetValue(value); }
        }
    
        private PropertyValue<MCText?> _text = new PropertyValue<MCText?>(nameof(MCOutline), nameof(Text));
        
        [JsonPropertyName("text")]
        public MCText? Text
        {
            get { return _text.GetValue(); }
            set { _text.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _icon.SetAccessPath(path, validateHasBeenSet);
            _text.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}