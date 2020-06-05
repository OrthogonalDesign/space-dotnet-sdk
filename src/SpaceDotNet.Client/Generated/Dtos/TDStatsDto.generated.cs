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
    public sealed class TDStatsDto
    {
        private PropertyValue<int> _totalMembers = new PropertyValue<int>(nameof(TDStatsDto), nameof(TotalMembers));
        
        [Required]
        [JsonPropertyName("totalMembers")]
        public int TotalMembers
        {
            get { return _totalMembers.GetValue(); }
            set { _totalMembers.SetValue(value); }
        }
    
        private PropertyValue<List<Pair<TDTeamDto, int>>> _teams = new PropertyValue<List<Pair<TDTeamDto, int>>>(nameof(TDStatsDto), nameof(Teams));
        
        [Required]
        [JsonPropertyName("teams")]
        public List<Pair<TDTeamDto, int>> Teams
        {
            get { return _teams.GetValue(); }
            set { _teams.SetValue(value); }
        }
    
        private PropertyValue<List<Pair<TDRoleDto, int>>> _roles = new PropertyValue<List<Pair<TDRoleDto, int>>>(nameof(TDStatsDto), nameof(Roles));
        
        [Required]
        [JsonPropertyName("roles")]
        public List<Pair<TDRoleDto, int>> Roles
        {
            get { return _roles.GetValue(); }
            set { _roles.SetValue(value); }
        }
    
        private PropertyValue<List<Pair<TDLocationDto, int>>> _locations = new PropertyValue<List<Pair<TDLocationDto, int>>>(nameof(TDStatsDto), nameof(Locations));
        
        [Required]
        [JsonPropertyName("locations")]
        public List<Pair<TDLocationDto, int>> Locations
        {
            get { return _locations.GetValue(); }
            set { _locations.SetValue(value); }
        }
    
    }
    
}
