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

namespace SpaceDotNet.Client.UpdateLocationRequestExtensions
{
    public static class UpdateLocationRequestDtoPartialExtensions
    {
        public static Partial<UpdateLocationRequestDto> WithName(this Partial<UpdateLocationRequestDto> it)
            => it.AddFieldName("name");
        
        public static Partial<UpdateLocationRequestDto> WithTimezone(this Partial<UpdateLocationRequestDto> it)
            => it.AddFieldName("timezone");
        
        public static Partial<UpdateLocationRequestDto> WithCustomWorkdays(this Partial<UpdateLocationRequestDto> it)
            => it.AddFieldName("customWorkdays");
        
        public static Partial<UpdateLocationRequestDto> WithWorkdays(this Partial<UpdateLocationRequestDto> it)
            => it.AddFieldName("workdays");
        
        public static Partial<UpdateLocationRequestDto> WithPhones(this Partial<UpdateLocationRequestDto> it)
            => it.AddFieldName("phones");
        
        public static Partial<UpdateLocationRequestDto> WithEmails(this Partial<UpdateLocationRequestDto> it)
            => it.AddFieldName("emails");
        
        public static Partial<UpdateLocationRequestDto> WithEquipment(this Partial<UpdateLocationRequestDto> it)
            => it.AddFieldName("equipment");
        
        public static Partial<UpdateLocationRequestDto> WithDescription(this Partial<UpdateLocationRequestDto> it)
            => it.AddFieldName("description");
        
        public static Partial<UpdateLocationRequestDto> WithAddress(this Partial<UpdateLocationRequestDto> it)
            => it.AddFieldName("address");
        
        public static Partial<UpdateLocationRequestDto> WithType(this Partial<UpdateLocationRequestDto> it)
            => it.AddFieldName("type");
        
        public static Partial<UpdateLocationRequestDto> WithParentId(this Partial<UpdateLocationRequestDto> it)
            => it.AddFieldName("parentId");
        
        public static Partial<UpdateLocationRequestDto> WithMapId(this Partial<UpdateLocationRequestDto> it)
            => it.AddFieldName("mapId");
        
    }
    
}