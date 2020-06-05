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
    public sealed class PackageRepositorySettingsDto
    {
        private PropertyValue<long> _id = new PropertyValue<long>(nameof(PackageRepositorySettingsDto), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public long Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(PackageRepositorySettingsDto), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get { return _name.GetValue(); }
            set { _name.SetValue(value); }
        }
    
        private PropertyValue<ESPackageRepositorySettingsDto?> _settings = new PropertyValue<ESPackageRepositorySettingsDto?>(nameof(PackageRepositorySettingsDto), nameof(Settings));
        
        [JsonPropertyName("settings")]
        public ESPackageRepositorySettingsDto? Settings
        {
            get { return _settings.GetValue(); }
            set { _settings.SetValue(value); }
        }
    
        private PropertyValue<List<PackagesPermission>> _permissions = new PropertyValue<List<PackagesPermission>>(nameof(PackageRepositorySettingsDto), nameof(Permissions));
        
        [Required]
        [JsonPropertyName("permissions")]
        public List<PackagesPermission> Permissions
        {
            get { return _permissions.GetValue(); }
            set { _permissions.SetValue(value); }
        }
    
    }
    
}
