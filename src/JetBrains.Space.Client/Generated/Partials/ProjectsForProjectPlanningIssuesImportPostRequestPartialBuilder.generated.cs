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

namespace JetBrains.Space.Client.ProjectsForProjectPlanningIssuesImportPostRequestPartialBuilder
{
    public static class ProjectsForProjectPlanningIssuesImportPostRequestPartialExtensions
    {
        public static Partial<ProjectsForProjectPlanningIssuesImportPostRequest> WithMetadata(this Partial<ProjectsForProjectPlanningIssuesImportPostRequest> it)
            => it.AddFieldName("metadata");
        
        public static Partial<ProjectsForProjectPlanningIssuesImportPostRequest> WithMetadata(this Partial<ProjectsForProjectPlanningIssuesImportPostRequest> it, Func<Partial<ImportMetadata>, Partial<ImportMetadata>> partialBuilder)
            => it.AddFieldName("metadata", partialBuilder(new Partial<ImportMetadata>(it)));
        
        public static Partial<ProjectsForProjectPlanningIssuesImportPostRequest> WithIssues(this Partial<ProjectsForProjectPlanningIssuesImportPostRequest> it)
            => it.AddFieldName("issues");
        
        public static Partial<ProjectsForProjectPlanningIssuesImportPostRequest> WithIssues(this Partial<ProjectsForProjectPlanningIssuesImportPostRequest> it, Func<Partial<ExternalIssue>, Partial<ExternalIssue>> partialBuilder)
            => it.AddFieldName("issues", partialBuilder(new Partial<ExternalIssue>(it)));
        
        public static Partial<ProjectsForProjectPlanningIssuesImportPostRequest> WithAssigneeMissingPolicy(this Partial<ProjectsForProjectPlanningIssuesImportPostRequest> it)
            => it.AddFieldName("assigneeMissingPolicy");
        
        public static Partial<ProjectsForProjectPlanningIssuesImportPostRequest> WithAssigneeMissingPolicy(this Partial<ProjectsForProjectPlanningIssuesImportPostRequest> it, Func<Partial<ImportMissingPolicy>, Partial<ImportMissingPolicy>> partialBuilder)
            => it.AddFieldName("assigneeMissingPolicy", partialBuilder(new Partial<ImportMissingPolicy>(it)));
        
        public static Partial<ProjectsForProjectPlanningIssuesImportPostRequest> WithStatusMissingPolicy(this Partial<ProjectsForProjectPlanningIssuesImportPostRequest> it)
            => it.AddFieldName("statusMissingPolicy");
        
        public static Partial<ProjectsForProjectPlanningIssuesImportPostRequest> WithStatusMissingPolicy(this Partial<ProjectsForProjectPlanningIssuesImportPostRequest> it, Func<Partial<ImportMissingPolicy>, Partial<ImportMissingPolicy>> partialBuilder)
            => it.AddFieldName("statusMissingPolicy", partialBuilder(new Partial<ImportMissingPolicy>(it)));
        
        public static Partial<ProjectsForProjectPlanningIssuesImportPostRequest> WithOnExistsPolicy(this Partial<ProjectsForProjectPlanningIssuesImportPostRequest> it)
            => it.AddFieldName("onExistsPolicy");
        
        public static Partial<ProjectsForProjectPlanningIssuesImportPostRequest> WithOnExistsPolicy(this Partial<ProjectsForProjectPlanningIssuesImportPostRequest> it, Func<Partial<ImportExistsPolicy>, Partial<ImportExistsPolicy>> partialBuilder)
            => it.AddFieldName("onExistsPolicy", partialBuilder(new Partial<ImportExistsPolicy>(it)));
        
        public static Partial<ProjectsForProjectPlanningIssuesImportPostRequest> WithIsDryRun(this Partial<ProjectsForProjectPlanningIssuesImportPostRequest> it)
            => it.AddFieldName("dryRun");
        
    }
    
}
