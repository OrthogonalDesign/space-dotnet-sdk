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

namespace SpaceDotNet.Client.CreateAbsenceReasonRequestExtensions
{
    public static class CreateAbsenceReasonRequestDtoPartialExtensions
    {
        public static Partial<CreateAbsenceReasonRequestDto> WithName(this Partial<CreateAbsenceReasonRequestDto> it)
            => it.AddFieldName("name");
        
        public static Partial<CreateAbsenceReasonRequestDto> WithDescription(this Partial<CreateAbsenceReasonRequestDto> it)
            => it.AddFieldName("description");
        
        public static Partial<CreateAbsenceReasonRequestDto> WithDefaultAvailability(this Partial<CreateAbsenceReasonRequestDto> it)
            => it.AddFieldName("defaultAvailability");
        
        public static Partial<CreateAbsenceReasonRequestDto> WithApprovalRequired(this Partial<CreateAbsenceReasonRequestDto> it)
            => it.AddFieldName("approvalRequired");
        
        public static Partial<CreateAbsenceReasonRequestDto> WithIcon(this Partial<CreateAbsenceReasonRequestDto> it)
            => it.AddFieldName("icon");
        
    }
    
}