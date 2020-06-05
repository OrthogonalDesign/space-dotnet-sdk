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
    public sealed class GitCommitChangeDto
    {
        private PropertyValue<GitCommitChangeType> _changeType = new PropertyValue<GitCommitChangeType>(nameof(GitCommitChangeDto), nameof(ChangeType));
        
        [Required]
        [JsonPropertyName("changeType")]
        public GitCommitChangeType ChangeType
        {
            get { return _changeType.GetValue(); }
            set { _changeType.SetValue(value); }
        }
    
        private PropertyValue<GitFileDto?> _old = new PropertyValue<GitFileDto?>(nameof(GitCommitChangeDto), nameof(Old));
        
        [JsonPropertyName("old")]
        public GitFileDto? Old
        {
            get { return _old.GetValue(); }
            set { _old.SetValue(value); }
        }
    
        private PropertyValue<GitFileDto?> _new = new PropertyValue<GitFileDto?>(nameof(GitCommitChangeDto), nameof(New));
        
        [JsonPropertyName("new")]
        public GitFileDto? New
        {
            get { return _new.GetValue(); }
            set { _new.SetValue(value); }
        }
    
        private PropertyValue<string> _revision = new PropertyValue<string>(nameof(GitCommitChangeDto), nameof(Revision));
        
        [Required]
        [JsonPropertyName("revision")]
        public string Revision
        {
            get { return _revision.GetValue(); }
            set { _revision.SetValue(value); }
        }
    
        private PropertyValue<GitDiffSizeDto?> _diffSize = new PropertyValue<GitDiffSizeDto?>(nameof(GitCommitChangeDto), nameof(DiffSize));
        
        [JsonPropertyName("diffSize")]
        public GitDiffSizeDto? DiffSize
        {
            get { return _diffSize.GetValue(); }
            set { _diffSize.SetValue(value); }
        }
    
    }
    
}
