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

namespace SpaceDotNet.Client.MessageFieldDtoExtensions
{
    public static class MessageFieldDtoPartialExtensions
    {
        public static Partial<MessageFieldDto> WithFirst(this Partial<MessageFieldDto> it)
            => it.AddFieldName("first");
        
        public static Partial<MessageFieldDto> WithSecond(this Partial<MessageFieldDto> it)
            => it.AddFieldName("second");
        
    }
    
}