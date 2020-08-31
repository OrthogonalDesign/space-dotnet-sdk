// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
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
    public interface IssueChangedM2Details
         : M2ItemContentDetails, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        public static IssueAssigneeChangedDetails IssueAssigneeChangedDetails(TDMemberProfile? oldAssignee = null, TDMemberProfile? newAssignee = null)
            => new IssueAssigneeChangedDetails(oldAssignee: null, newAssignee: null);
        
        public static IssueAttachmentsChangedDetails IssueAttachmentsChangedDetails(List<string>? addedNames = null, List<string>? removedNames = null)
            => new IssueAttachmentsChangedDetails(addedNames: null, removedNames: null);
        
        public static IssueChecklistsChangedDetails IssueChecklistsChangedDetails(List<Checklist>? addedChecklists = null, List<Checklist>? removedChecklists = null)
            => new IssueChecklistsChangedDetails(addedChecklists: null, removedChecklists: null);
        
        public static IssueCreatedDetails IssueCreatedDetails(Issue? issue = null)
            => new IssueCreatedDetails(issue: null);
        
        public static IssueDeletedDetails IssueDeletedDetails()
            => new IssueDeletedDetails();
        
        public static IssueDescriptionChangedDetails IssueDescriptionChangedDetails(string? oldDescription = null, string? newDescription = null)
            => new IssueDescriptionChangedDetails(oldDescription: null, newDescription: null);
        
        public static IssueDueDateChangedDetails IssueDueDateChangedDetails(SpaceDate? oldDueDate = null, SpaceDate? newDueDate = null)
            => new IssueDueDateChangedDetails(oldDueDate: null, newDueDate: null);
        
        public static IssueMCExtension IssueMCExtension()
            => new IssueMCExtension();
        
        public static IssueStatusChangedDetails IssueStatusChangedDetails(IssueStatus oldStatus, IssueStatus newStatus)
            => new IssueStatusChangedDetails(oldStatus: oldStatus, newStatus: newStatus);
        
        public static IssueTagsChangedDetails IssueTagsChangedDetails(List<PlanningTag>? addedTags = null, List<PlanningTag>? removedTags = null)
            => new IssueTagsChangedDetails(addedTags: null, removedTags: null);
        
        public static IssueTitleChangedDetails IssueTitleChangedDetails(string oldTitle, string newTitle)
            => new IssueTitleChangedDetails(oldTitle: oldTitle, newTitle: newTitle);
        
    }
    
}