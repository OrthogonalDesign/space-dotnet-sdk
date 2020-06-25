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

namespace SpaceDotNet.Client.M2TaskExecutionFailureItemContentDtoPartialBuilder
{
    public static class M2TaskExecutionFailureItemContentDtoPartialExtensions
    {
        public static Partial<M2TaskExecutionFailureItemContentDto> WithTaskExecutionId(this Partial<M2TaskExecutionFailureItemContentDto> it)
            => it.AddFieldName("taskExecutionId");
        
        public static Partial<M2TaskExecutionFailureItemContentDto> WithTaskExecutionName(this Partial<M2TaskExecutionFailureItemContentDto> it)
            => it.AddFieldName("taskExecutionName");
        
        public static Partial<M2TaskExecutionFailureItemContentDto> WithRepoName(this Partial<M2TaskExecutionFailureItemContentDto> it)
            => it.AddFieldName("repoName");
        
        public static Partial<M2TaskExecutionFailureItemContentDto> WithBranchName(this Partial<M2TaskExecutionFailureItemContentDto> it)
            => it.AddFieldName("branchName");
        
        public static Partial<M2TaskExecutionFailureItemContentDto> WithCommit(this Partial<M2TaskExecutionFailureItemContentDto> it)
            => it.AddFieldName("commit");
        
        public static Partial<M2TaskExecutionFailureItemContentDto> WithShortCommitMessage(this Partial<M2TaskExecutionFailureItemContentDto> it)
            => it.AddFieldName("shortCommitMessage");
        
        public static Partial<M2TaskExecutionFailureItemContentDto> WithProject(this Partial<M2TaskExecutionFailureItemContentDto> it)
            => it.AddFieldName("project");
        
        public static Partial<M2TaskExecutionFailureItemContentDto> WithProject(this Partial<M2TaskExecutionFailureItemContentDto> it, Func<Partial<ProjectKeyDto>, Partial<ProjectKeyDto>> partialBuilder)
            => it.AddFieldName("project", partialBuilder(new Partial<ProjectKeyDto>(it)));
        
        public static Partial<M2TaskExecutionFailureItemContentDto> WithFinishDateTime(this Partial<M2TaskExecutionFailureItemContentDto> it)
            => it.AddFieldName("finishDateTime");
        
        public static Partial<M2TaskExecutionFailureItemContentDto> WithTriggerInfo(this Partial<M2TaskExecutionFailureItemContentDto> it)
            => it.AddFieldName("triggerInfo");
        
        public static Partial<M2TaskExecutionFailureItemContentDto> WithDetails(this Partial<M2TaskExecutionFailureItemContentDto> it)
            => it.AddFieldName("details");
        
    }
    
}