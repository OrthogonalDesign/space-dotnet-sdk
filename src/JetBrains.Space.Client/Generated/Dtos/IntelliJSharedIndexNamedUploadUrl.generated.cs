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
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client
{
    public sealed class IntelliJSharedIndexNamedUploadUrl
         : IPropagatePropertyAccessPath
    {
        public IntelliJSharedIndexNamedUploadUrl() { }
        
        public IntelliJSharedIndexNamedUploadUrl(string name, IntelliJSharedIndexUploadUrl url)
        {
            Name = name;
            Url = url;
        }
        
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(IntelliJSharedIndexNamedUploadUrl), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get => _name.GetValue();
            set => _name.SetValue(value);
        }
    
        private PropertyValue<IntelliJSharedIndexUploadUrl> _url = new PropertyValue<IntelliJSharedIndexUploadUrl>(nameof(IntelliJSharedIndexNamedUploadUrl), nameof(Url));
        
        [Required]
        [JsonPropertyName("url")]
        public IntelliJSharedIndexUploadUrl Url
        {
            get => _url.GetValue();
            set => _url.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _name.SetAccessPath(path, validateHasBeenSet);
            _url.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}