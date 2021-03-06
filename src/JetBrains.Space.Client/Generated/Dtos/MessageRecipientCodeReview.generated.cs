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
    public sealed class MessageRecipientCodeReview
         : MessageRecipient, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public override string? ClassName => "MessageRecipient.CodeReview";
        
        public MessageRecipientCodeReview() { }
        
        public MessageRecipientCodeReview(string codeReview)
        {
            CodeReview = codeReview;
        }
        
        private PropertyValue<string> _codeReview = new PropertyValue<string>(nameof(MessageRecipientCodeReview), nameof(CodeReview));
        
        [Required]
        [JsonPropertyName("codeReview")]
        public string CodeReview
        {
            get => _codeReview.GetValue();
            set => _codeReview.SetValue(value);
        }
    
        public override void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _codeReview.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
