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

namespace SpaceDotNet.Client
{
    [JsonConverter(typeof(EnumerationConverter))]
    public sealed class BillingReportType : Enumeration
    {
        private BillingReportType(string value) : base(value) { }
        
        public static readonly BillingReportType ACTIVEUSERS = new BillingReportType("ACTIVE_USERS");
        public static readonly BillingReportType STORAGEALL = new BillingReportType("STORAGE_ALL");
        public static readonly BillingReportType STORAGEFILES = new BillingReportType("STORAGE_FILES");
        public static readonly BillingReportType STORAGEPACKAGES = new BillingReportType("STORAGE_PACKAGES");
        public static readonly BillingReportType STORAGEGIT = new BillingReportType("STORAGE_GIT");
        public static readonly BillingReportType TRAFFICALL = new BillingReportType("TRAFFIC_ALL");
        public static readonly BillingReportType TRAFFICFILES = new BillingReportType("TRAFFIC_FILES");
        public static readonly BillingReportType TRAFFICPACKAGES = new BillingReportType("TRAFFIC_PACKAGES");
        public static readonly BillingReportType TRAFFICGIT = new BillingReportType("TRAFFIC_GIT");
        public static readonly BillingReportType CICREDITS = new BillingReportType("CI_CREDITS");
    }
    
}