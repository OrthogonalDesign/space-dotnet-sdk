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

namespace SpaceDotNet.Client.TeamDirectoryProfilesForIdSpokenLanguagesRequestPartialBuilder
{
    public static class TeamDirectoryProfilesForIdSpokenLanguagesRequestPartialExtensions
    {
        public static Partial<TeamDirectoryProfilesForIdSpokenLanguagesRequest> WithLanguage(this Partial<TeamDirectoryProfilesForIdSpokenLanguagesRequest> it)
            => it.AddFieldName("language");
        
        public static Partial<TeamDirectoryProfilesForIdSpokenLanguagesRequest> WithFirstName(this Partial<TeamDirectoryProfilesForIdSpokenLanguagesRequest> it)
            => it.AddFieldName("firstName");
        
        public static Partial<TeamDirectoryProfilesForIdSpokenLanguagesRequest> WithLastName(this Partial<TeamDirectoryProfilesForIdSpokenLanguagesRequest> it)
            => it.AddFieldName("lastName");
        
    }
    
}