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
    public sealed class BillingInfo
         : IPropagatePropertyAccessPath
    {
        public BillingInfo() { }
        
        public BillingInfo(BilledItems billedItems, PlanLimits planLimits, DateTime orgCreationDate, Money? overdraft = null)
        {
            BilledItems = billedItems;
            PlanLimits = planLimits;
            OrgCreationDate = orgCreationDate;
            Overdraft = overdraft;
        }
        
        private PropertyValue<BilledItems> _billedItems = new PropertyValue<BilledItems>(nameof(BillingInfo), nameof(BilledItems));
        
        [Required]
        [JsonPropertyName("billedItems")]
        public BilledItems BilledItems
        {
            get => _billedItems.GetValue();
            set => _billedItems.SetValue(value);
        }
    
        private PropertyValue<PlanLimits> _planLimits = new PropertyValue<PlanLimits>(nameof(BillingInfo), nameof(PlanLimits));
        
        [Required]
        [JsonPropertyName("planLimits")]
        public PlanLimits PlanLimits
        {
            get => _planLimits.GetValue();
            set => _planLimits.SetValue(value);
        }
    
        private PropertyValue<DateTime> _orgCreationDate = new PropertyValue<DateTime>(nameof(BillingInfo), nameof(OrgCreationDate));
        
        [Required]
        [JsonPropertyName("orgCreationDate")]
        [JsonConverter(typeof(SpaceDateConverter))]
        public DateTime OrgCreationDate
        {
            get => _orgCreationDate.GetValue();
            set => _orgCreationDate.SetValue(value);
        }
    
        private PropertyValue<Money?> _overdraft = new PropertyValue<Money?>(nameof(BillingInfo), nameof(Overdraft));
        
        [JsonPropertyName("overdraft")]
        public Money? Overdraft
        {
            get => _overdraft.GetValue();
            set => _overdraft.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _billedItems.SetAccessPath(path, validateHasBeenSet);
            _planLimits.SetAccessPath(path, validateHasBeenSet);
            _orgCreationDate.SetAccessPath(path, validateHasBeenSet);
            _overdraft.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}