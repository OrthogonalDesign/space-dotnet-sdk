// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//     Generated: 2020-05-18T10:16:39.2577115+00:00
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
    [JsonConverter(typeof(EnumerationConverter))]
    public sealed class HAPrimitive : Enumeration
    {
        private HAPrimitive(string value) : base(value) { }
        
        public static readonly HAPrimitive Byte = new HAPrimitive("Byte");
        public static readonly HAPrimitive Short = new HAPrimitive("Short");
        public static readonly HAPrimitive Int = new HAPrimitive("Int");
        public static readonly HAPrimitive Long = new HAPrimitive("Long");
        public static readonly HAPrimitive Float = new HAPrimitive("Float");
        public static readonly HAPrimitive Double = new HAPrimitive("Double");
        public static readonly HAPrimitive Boolean = new HAPrimitive("Boolean");
        public static readonly HAPrimitive String = new HAPrimitive("String");
        public static readonly HAPrimitive Date = new HAPrimitive("Date");
        public static readonly HAPrimitive DateTime = new HAPrimitive("DateTime");
    }
    
}