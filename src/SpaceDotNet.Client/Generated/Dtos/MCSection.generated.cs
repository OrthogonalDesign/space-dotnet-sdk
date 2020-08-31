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
    public sealed class MCSection
         : MCElementDetails, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "MCSection";
        
        public MCSection() { }
        
        public MCSection(List<MCElement> elements, MCText? header = null, MCText? footer = null)
        {
            Header = header;
            Elements = elements;
            Footer = footer;
        }
        
        private PropertyValue<MCText?> _header = new PropertyValue<MCText?>(nameof(MCSection), nameof(Header));
        
        [JsonPropertyName("header")]
        public MCText? Header
        {
            get { return _header.GetValue(); }
            set { _header.SetValue(value); }
        }
    
        private PropertyValue<List<MCElement>> _elements = new PropertyValue<List<MCElement>>(nameof(MCSection), nameof(Elements));
        
        [Required]
        [JsonPropertyName("elements")]
        public List<MCElement> Elements
        {
            get { return _elements.GetValue(); }
            set { _elements.SetValue(value); }
        }
    
        private PropertyValue<MCText?> _footer = new PropertyValue<MCText?>(nameof(MCSection), nameof(Footer));
        
        [JsonPropertyName("footer")]
        public MCText? Footer
        {
            get { return _footer.GetValue(); }
            set { _footer.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _header.SetAccessPath(path, validateHasBeenSet);
            _elements.SetAccessPath(path, validateHasBeenSet);
            _footer.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}