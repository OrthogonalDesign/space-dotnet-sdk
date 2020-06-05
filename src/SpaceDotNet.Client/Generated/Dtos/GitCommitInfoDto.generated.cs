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
    public sealed class GitCommitInfoDto
    {
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(GitCommitInfoDto), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<string> _message = new PropertyValue<string>(nameof(GitCommitInfoDto), nameof(Message));
        
        [Required]
        [JsonPropertyName("message")]
        public string Message
        {
            get { return _message.GetValue(); }
            set { _message.SetValue(value); }
        }
    
        private PropertyValue<long> _authorDate = new PropertyValue<long>(nameof(GitCommitInfoDto), nameof(AuthorDate));
        
        [Required]
        [JsonPropertyName("authorDate")]
        public long AuthorDate
        {
            get { return _authorDate.GetValue(); }
            set { _authorDate.SetValue(value); }
        }
    
        private PropertyValue<long> _commitDate = new PropertyValue<long>(nameof(GitCommitInfoDto), nameof(CommitDate));
        
        [Required]
        [JsonPropertyName("commitDate")]
        public long CommitDate
        {
            get { return _commitDate.GetValue(); }
            set { _commitDate.SetValue(value); }
        }
    
        private PropertyValue<GitAuthorInfoDto> _author = new PropertyValue<GitAuthorInfoDto>(nameof(GitCommitInfoDto), nameof(Author));
        
        [Required]
        [JsonPropertyName("author")]
        public GitAuthorInfoDto Author
        {
            get { return _author.GetValue(); }
            set { _author.SetValue(value); }
        }
    
        private PropertyValue<GitAuthorInfoDto> _committer = new PropertyValue<GitAuthorInfoDto>(nameof(GitCommitInfoDto), nameof(Committer));
        
        [Required]
        [JsonPropertyName("committer")]
        public GitAuthorInfoDto Committer
        {
            get { return _committer.GetValue(); }
            set { _committer.SetValue(value); }
        }
    
        private PropertyValue<TDMemberProfileDto?> _authorProfile = new PropertyValue<TDMemberProfileDto?>(nameof(GitCommitInfoDto), nameof(AuthorProfile));
        
        [JsonPropertyName("authorProfile")]
        public TDMemberProfileDto? AuthorProfile
        {
            get { return _authorProfile.GetValue(); }
            set { _authorProfile.SetValue(value); }
        }
    
        private PropertyValue<List<string>> _parents = new PropertyValue<List<string>>(nameof(GitCommitInfoDto), nameof(Parents));
        
        [Required]
        [JsonPropertyName("parents")]
        public List<string> Parents
        {
            get { return _parents.GetValue(); }
            set { _parents.SetValue(value); }
        }
    
        private PropertyValue<List<string>> _tags = new PropertyValue<List<string>>(nameof(GitCommitInfoDto), nameof(Tags));
        
        [Required]
        [JsonPropertyName("tags")]
        public List<string> Tags
        {
            get { return _tags.GetValue(); }
            set { _tags.SetValue(value); }
        }
    
        private PropertyValue<List<BranchInfoDto>> _branches = new PropertyValue<List<BranchInfoDto>>(nameof(GitCommitInfoDto), nameof(Branches));
        
        [Required]
        [JsonPropertyName("branches")]
        public List<BranchInfoDto> Branches
        {
            get { return _branches.GetValue(); }
            set { _branches.SetValue(value); }
        }
    
        private PropertyValue<List<string>> _heads = new PropertyValue<List<string>>(nameof(GitCommitInfoDto), nameof(Heads));
        
        [Required]
        [JsonPropertyName("heads")]
        public List<string> Heads
        {
            get { return _heads.GetValue(); }
            set { _heads.SetValue(value); }
        }
    
    }
    
}
