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
    public sealed class CommitStatusDTODto
    {
        private PropertyValue<string> _repository = new PropertyValue<string>(nameof(CommitStatusDTODto), nameof(Repository));
        
        [Required]
        [JsonPropertyName("repository")]
        public string Repository
        {
            get { return _repository.GetValue(); }
            set { _repository.SetValue(value); }
        }
    
        private PropertyValue<string> _revision = new PropertyValue<string>(nameof(CommitStatusDTODto), nameof(Revision));
        
        [Required]
        [JsonPropertyName("revision")]
        public string Revision
        {
            get { return _revision.GetValue(); }
            set { _revision.SetValue(value); }
        }
    
        private PropertyValue<ExecutionStatus> _executionStatus = new PropertyValue<ExecutionStatus>(nameof(CommitStatusDTODto), nameof(ExecutionStatus));
        
        [Required]
        [JsonPropertyName("executionStatus")]
        public ExecutionStatus ExecutionStatus
        {
            get { return _executionStatus.GetValue(); }
            set { _executionStatus.SetValue(value); }
        }
    
        private PropertyValue<string> _url = new PropertyValue<string>(nameof(CommitStatusDTODto), nameof(Url));
        
        [Required]
        [JsonPropertyName("url")]
        public string Url
        {
            get { return _url.GetValue(); }
            set { _url.SetValue(value); }
        }
    
        private PropertyValue<string> _externalServiceName = new PropertyValue<string>(nameof(CommitStatusDTODto), nameof(ExternalServiceName));
        
        [Required]
        [JsonPropertyName("externalServiceName")]
        public string ExternalServiceName
        {
            get { return _externalServiceName.GetValue(); }
            set { _externalServiceName.SetValue(value); }
        }
    
        private PropertyValue<string> _taskName = new PropertyValue<string>(nameof(CommitStatusDTODto), nameof(TaskName));
        
        [Required]
        [JsonPropertyName("taskName")]
        public string TaskName
        {
            get { return _taskName.GetValue(); }
            set { _taskName.SetValue(value); }
        }
    
        private PropertyValue<string> _taskId = new PropertyValue<string>(nameof(CommitStatusDTODto), nameof(TaskId));
        
        [Required]
        [JsonPropertyName("taskId")]
        public string TaskId
        {
            get { return _taskId.GetValue(); }
            set { _taskId.SetValue(value); }
        }
    
        private PropertyValue<long> _timestamp = new PropertyValue<long>(nameof(CommitStatusDTODto), nameof(Timestamp));
        
        [Required]
        [JsonPropertyName("timestamp")]
        public long Timestamp
        {
            get { return _timestamp.GetValue(); }
            set { _timestamp.SetValue(value); }
        }
    
        private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(CommitStatusDTODto), nameof(Description));
        
        [JsonPropertyName("description")]
        public string? Description
        {
            get { return _description.GetValue(); }
            set { _description.SetValue(value); }
        }
    
    }
    
}
