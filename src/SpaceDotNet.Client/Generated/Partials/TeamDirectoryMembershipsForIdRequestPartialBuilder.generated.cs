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

namespace SpaceDotNet.Client.TeamDirectoryMembershipsForIdRequestPartialBuilder
{
    public static class TeamDirectoryMembershipsForIdRequestPartialExtensions
    {
        public static Partial<TeamDirectoryMembershipsForIdRequest> WithMemberId(this Partial<TeamDirectoryMembershipsForIdRequest> it)
            => it.AddFieldName("memberId");
        
        public static Partial<TeamDirectoryMembershipsForIdRequest> WithTeamId(this Partial<TeamDirectoryMembershipsForIdRequest> it)
            => it.AddFieldName("teamId");
        
        public static Partial<TeamDirectoryMembershipsForIdRequest> WithRoleId(this Partial<TeamDirectoryMembershipsForIdRequest> it)
            => it.AddFieldName("roleId");
        
        public static Partial<TeamDirectoryMembershipsForIdRequest> WithLead(this Partial<TeamDirectoryMembershipsForIdRequest> it)
            => it.AddFieldName("lead");
        
        public static Partial<TeamDirectoryMembershipsForIdRequest> WithManagerId(this Partial<TeamDirectoryMembershipsForIdRequest> it)
            => it.AddFieldName("managerId");
        
        public static Partial<TeamDirectoryMembershipsForIdRequest> WithSince(this Partial<TeamDirectoryMembershipsForIdRequest> it)
            => it.AddFieldName("since");
        
        public static Partial<TeamDirectoryMembershipsForIdRequest> WithTill(this Partial<TeamDirectoryMembershipsForIdRequest> it)
            => it.AddFieldName("till");
        
        public static Partial<TeamDirectoryMembershipsForIdRequest> WithActiveSince(this Partial<TeamDirectoryMembershipsForIdRequest> it)
            => it.AddFieldName("activeSince");
        
        public static Partial<TeamDirectoryMembershipsForIdRequest> WithActiveTill(this Partial<TeamDirectoryMembershipsForIdRequest> it)
            => it.AddFieldName("activeTill");
        
        public static Partial<TeamDirectoryMembershipsForIdRequest> WithPreviousMembershipId(this Partial<TeamDirectoryMembershipsForIdRequest> it)
            => it.AddFieldName("previousMembershipId");
        
        public static Partial<TeamDirectoryMembershipsForIdRequest> WithRequiresApproval(this Partial<TeamDirectoryMembershipsForIdRequest> it)
            => it.AddFieldName("requiresApproval");
        
        public static Partial<TeamDirectoryMembershipsForIdRequest> WithCustomFieldValues(this Partial<TeamDirectoryMembershipsForIdRequest> it)
            => it.AddFieldName("customFieldValues");
        
        public static Partial<TeamDirectoryMembershipsForIdRequest> WithCustomFieldValues(this Partial<TeamDirectoryMembershipsForIdRequest> it, Func<Partial<CustomFieldValueDto>, Partial<CustomFieldValueDto>> partialBuilder)
            => it.AddFieldName("customFieldValues", partialBuilder(new Partial<CustomFieldValueDto>(it)));
        
    }
    
}