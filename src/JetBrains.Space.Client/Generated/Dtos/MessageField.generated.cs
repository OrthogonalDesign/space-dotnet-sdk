// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS1591
#pragma warning disable CS0108

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Client.Internal;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client
{
    public sealed class MessageField
         : MessageFieldElement, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "MessageField";
        
        public MessageField() { }
        
        public MessageField(string first, string second)
        {
            First = first;
            Second = second;
        }
        
        private PropertyValue<string> _first = new PropertyValue<string>(nameof(MessageField), nameof(First));
        
        [Required]
        [JsonPropertyName("first")]
        public string First
        {
            get => _first.GetValue();
            set => _first.SetValue(value);
        }
    
        private PropertyValue<string> _second = new PropertyValue<string>(nameof(MessageField), nameof(Second));
        
        [Required]
        [JsonPropertyName("second")]
        public string Second
        {
            get => _second.GetValue();
            set => _second.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _first.SetAccessPath(path, validateHasBeenSet);
            _second.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}