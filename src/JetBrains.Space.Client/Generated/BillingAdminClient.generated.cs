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
using JetBrains.Space.Client.Internal;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client
{
    public partial class BillingAdminClient : ISpaceClient
    {
        private readonly Connection _connection;
        
        public BillingAdminClient(Connection connection)
        {
            _connection = connection;
        }
        
        /// <remarks>
        /// Required permissions:
        /// <list type="bullet">
        /// <item>
        /// <term>Update overdrafts</term>
        /// </item>
        /// </list>
        /// </remarks>
        public async Task SetOverdraftsAsync(int storage, int bandwidth, int ciCredits, CancellationToken cancellationToken = default)
            => await _connection.RequestResourceAsync("POST", $"api/http/billing-admin/overdrafts", 
                new BillingAdminOverdraftsPostRequest { 
                    Storage = storage,
                    Bandwidth = bandwidth,
                    CiCredits = ciCredits,
                }
        , cancellationToken);
    
        /// <remarks>
        /// Required permissions:
        /// <list type="bullet">
        /// <item>
        /// <term>View usage data</term>
        /// </item>
        /// </list>
        /// </remarks>
        public async Task<BillingInfo> GetBillingInfoAsync(string? billingPeriod = null, Func<Partial<BillingInfo>, Partial<BillingInfo>>? partial = null, CancellationToken cancellationToken = default)
            => await _connection.RequestResourceAsync<BillingInfo>("GET", $"api/http/billing-admin/monthly?billingPeriod={billingPeriod?.ToString() ?? "null"}&$fields={(partial != null ? partial(new Partial<BillingInfo>()) : Partial<BillingInfo>.Default())}", cancellationToken);
    
        /// <remarks>
        /// Required permissions:
        /// <list type="bullet">
        /// <item>
        /// <term>View usage data</term>
        /// </item>
        /// </list>
        /// </remarks>
        public async Task<DailyReport> GetBillingReportAsync(BillingReportType type, string billingPeriod, Func<Partial<DailyReport>, Partial<DailyReport>>? partial = null, CancellationToken cancellationToken = default)
            => await _connection.RequestResourceAsync<DailyReport>("GET", $"api/http/billing-admin/report?type={type.ToString()}&billingPeriod={billingPeriod.ToString()}&$fields={(partial != null ? partial(new Partial<DailyReport>()) : Partial<DailyReport>.Default())}", cancellationToken);
    
    }
    
}