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

namespace SpaceDotNet.Client.TDMergedEventExtensions
{
    public static class TDMergedEventDtoPartialExtensions
    {
        public static Partial<TDMergedEventDto> WithEvents(this Partial<TDMergedEventDto> it)
            => it.AddFieldName("events");
        
        public static Partial<TDMergedEventDto> WithEvents(this Partial<TDMergedEventDto> it, Func<Partial<Pair<TDMembershipDto, int>>, Partial<Pair<TDMembershipDto, int>>> partialBuilder)
            => it.AddFieldName("events", partialBuilder(new Partial<Pair<TDMembershipDto, int>>()));
        
        public static Partial<TDMergedEventDto> WithProfile(this Partial<TDMergedEventDto> it)
            => it.AddFieldName("profile");
        
        public static Partial<TDMergedEventDto> WithProfile(this Partial<TDMergedEventDto> it, Func<Partial<TDMemberProfileDto>, Partial<TDMemberProfileDto>> partialBuilder)
            => it.AddFieldName("profile", partialBuilder(new Partial<TDMemberProfileDto>()));
        
    }
    
}