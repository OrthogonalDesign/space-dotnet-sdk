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
    public class UpdateIssueRequest
    {
        private PropertyValue<string> _title = new PropertyValue<string>(nameof(UpdateIssueRequest), nameof(Title));
        
        [JsonPropertyName("title")]
        public string Title
        {
            get { return _title.GetValue(); }
            set { _title.SetValue(value); }
        }
    
        private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(UpdateIssueRequest), nameof(Description));
        
        [JsonPropertyName("description")]
        public string? Description
        {
            get { return _description.GetValue(); }
            set { _description.SetValue(value); }
        }
    
        private PropertyValue<string?> _assignee = new PropertyValue<string?>(nameof(UpdateIssueRequest), nameof(Assignee));
        
        [JsonPropertyName("assignee")]
        public string? Assignee
        {
            get { return _assignee.GetValue(); }
            set { _assignee.SetValue(value); }
        }
    
        private PropertyValue<string> _status = new PropertyValue<string>(nameof(UpdateIssueRequest), nameof(Status));
        
        [JsonPropertyName("status")]
        public string Status
        {
            get { return _status.GetValue(); }
            set { _status.SetValue(value); }
        }
    
        private PropertyValue<SpaceDate?> _dueDate = new PropertyValue<SpaceDate?>(nameof(UpdateIssueRequest), nameof(DueDate));
        
        [JsonPropertyName("dueDate")]
        public SpaceDate? DueDate
        {
            get { return _dueDate.GetValue(); }
            set { _dueDate.SetValue(value); }
        }
    
        private PropertyValue<ImportedEntityInfoDto?> _importInfo = new PropertyValue<ImportedEntityInfoDto?>(nameof(UpdateIssueRequest), nameof(ImportInfo));
        
        [JsonPropertyName("importInfo")]
        public ImportedEntityInfoDto? ImportInfo
        {
            get { return _importInfo.GetValue(); }
            set { _importInfo.SetValue(value); }
        }
    
    }
    
}
