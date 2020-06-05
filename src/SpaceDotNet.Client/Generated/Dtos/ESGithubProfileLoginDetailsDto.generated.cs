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
    public sealed class ESGithubProfileLoginDetailsDto
         : ESProfileLoginDetailsDto, IClassNameConvertible
    {
        private PropertyValue<string?> _login = new PropertyValue<string?>(nameof(ESGithubProfileLoginDetailsDto), nameof(Login));
        
        [JsonPropertyName("login")]
        public string? Login
        {
            get { return _login.GetValue(); }
            set { _login.SetValue(value); }
        }
    
        private PropertyValue<string?> _firstName = new PropertyValue<string?>(nameof(ESGithubProfileLoginDetailsDto), nameof(FirstName));
        
        [JsonPropertyName("firstName")]
        public string? FirstName
        {
            get { return _firstName.GetValue(); }
            set { _firstName.SetValue(value); }
        }
    
        private PropertyValue<string?> _lastName = new PropertyValue<string?>(nameof(ESGithubProfileLoginDetailsDto), nameof(LastName));
        
        [JsonPropertyName("lastName")]
        public string? LastName
        {
            get { return _lastName.GetValue(); }
            set { _lastName.SetValue(value); }
        }
    
        private PropertyValue<string?> _email = new PropertyValue<string?>(nameof(ESGithubProfileLoginDetailsDto), nameof(Email));
        
        [JsonPropertyName("email")]
        public string? Email
        {
            get { return _email.GetValue(); }
            set { _email.SetValue(value); }
        }
    
        private PropertyValue<bool> _emailVerified = new PropertyValue<bool>(nameof(ESGithubProfileLoginDetailsDto), nameof(EmailVerified));
        
        [Required]
        [JsonPropertyName("emailVerified")]
        public bool EmailVerified
        {
            get { return _emailVerified.GetValue(); }
            set { _emailVerified.SetValue(value); }
        }
    
        private PropertyValue<string?> _avatarUrl = new PropertyValue<string?>(nameof(ESGithubProfileLoginDetailsDto), nameof(AvatarUrl));
        
        [JsonPropertyName("avatarUrl")]
        public string? AvatarUrl
        {
            get { return _avatarUrl.GetValue(); }
            set { _avatarUrl.SetValue(value); }
        }
    
        private PropertyValue<List<string>?> _organizations = new PropertyValue<List<string>?>(nameof(ESGithubProfileLoginDetailsDto), nameof(Organizations));
        
        [JsonPropertyName("organizations")]
        public List<string>? Organizations
        {
            get { return _organizations.GetValue(); }
            set { _organizations.SetValue(value); }
        }
    
    }
    
}
