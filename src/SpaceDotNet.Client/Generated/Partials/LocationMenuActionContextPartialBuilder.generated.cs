// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS1591
#pragma warning disable CS0108

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client.LocationMenuActionContextPartialBuilder
{
    public static class LocationMenuActionContextPartialExtensions
    {
        public static Partial<LocationMenuActionContext> WithMenuId(this Partial<LocationMenuActionContext> it)
            => it.AddFieldName("menuId");
        
        public static Partial<LocationMenuActionContext> WithLocation(this Partial<LocationMenuActionContext> it)
            => it.AddFieldName("location");
        
        public static Partial<LocationMenuActionContext> WithLocation(this Partial<LocationMenuActionContext> it, Func<Partial<TDLocation>, Partial<TDLocation>> partialBuilder)
            => it.AddFieldName("location", partialBuilder(new Partial<TDLocation>(it)));
        
    }
    
}