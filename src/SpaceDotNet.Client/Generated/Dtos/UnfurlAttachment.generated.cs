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
    public sealed class UnfurlAttachment
         : Attachment, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "UnfurlAttachment";
        
        public UnfurlAttachment() { }
        
        public UnfurlAttachment(Unfurl unfurl, string? id = null)
        {
            Unfurl = unfurl;
            Id = id;
        }
        
        private PropertyValue<Unfurl> _unfurl = new PropertyValue<Unfurl>(nameof(UnfurlAttachment), nameof(Unfurl));
        
        [Required]
        [JsonPropertyName("unfurl")]
        public Unfurl Unfurl
        {
            get { return _unfurl.GetValue(); }
            set { _unfurl.SetValue(value); }
        }
    
        private PropertyValue<string?> _id = new PropertyValue<string?>(nameof(UnfurlAttachment), nameof(Id));
        
        [JsonPropertyName("id")]
        public string? Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _unfurl.SetAccessPath(path, validateHasBeenSet);
            _id.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}