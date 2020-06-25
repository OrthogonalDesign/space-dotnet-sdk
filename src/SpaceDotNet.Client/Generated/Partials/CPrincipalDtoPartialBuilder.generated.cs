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

namespace SpaceDotNet.Client.CPrincipalDtoPartialBuilder
{
    public static class CPrincipalDtoPartialExtensions
    {
        public static Partial<CPrincipalDto> WithName(this Partial<CPrincipalDto> it)
            => it.AddFieldName("name");
        
        public static Partial<CPrincipalDto> WithDetails(this Partial<CPrincipalDto> it)
            => it.AddFieldName("details");
        
        public static Partial<CPrincipalDto> WithDetails(this Partial<CPrincipalDto> it, Func<Partial<CPrincipalDetailsDto>, Partial<CPrincipalDetailsDto>> partialBuilder)
            => it.AddFieldName("details", partialBuilder(new Partial<CPrincipalDetailsDto>(it)));
        
    }
    
}