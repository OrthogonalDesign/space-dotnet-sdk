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

namespace SpaceDotNet.Client.RecurrenceRuleFreqMonthlyOnLastWeekdayDtoPartialBuilder
{
    public static class RecurrenceRuleFreqMonthlyOnLastWeekdayDtoPartialExtensions
    {
        public static Partial<RecurrenceRuleFreqMonthlyOnLastWeekdayDto> WithWeekday(this Partial<RecurrenceRuleFreqMonthlyOnLastWeekdayDto> it)
            => it.AddFieldName("weekday");
        
        public static Partial<RecurrenceRuleFreqMonthlyOnLastWeekdayDto> WithWeekday(this Partial<RecurrenceRuleFreqMonthlyOnLastWeekdayDto> it, Func<Partial<Weekday>, Partial<Weekday>> partialBuilder)
            => it.AddFieldName("weekday", partialBuilder(new Partial<Weekday>(it)));
        
        public static Partial<RecurrenceRuleFreqMonthlyOnLastWeekdayDto> WithInterval(this Partial<RecurrenceRuleFreqMonthlyOnLastWeekdayDto> it)
            => it.AddFieldName("interval");
        
    }
    
}