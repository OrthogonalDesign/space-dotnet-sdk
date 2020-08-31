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
    public sealed class IssueImportResult
         : IPropagatePropertyAccessPath
    {
        public IssueImportResult() { }
        
        public IssueImportResult(bool success, string message)
        {
            IsSuccess = success;
            Message = message;
        }
        
        private PropertyValue<bool> _success = new PropertyValue<bool>(nameof(IssueImportResult), nameof(IsSuccess));
        
        [Required]
        [JsonPropertyName("success")]
        public bool IsSuccess
        {
            get { return _success.GetValue(); }
            set { _success.SetValue(value); }
        }
    
        private PropertyValue<string> _message = new PropertyValue<string>(nameof(IssueImportResult), nameof(Message));
        
        [Required]
        [JsonPropertyName("message")]
        public string Message
        {
            get { return _message.GetValue(); }
            set { _message.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _success.SetAccessPath(path, validateHasBeenSet);
            _message.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}