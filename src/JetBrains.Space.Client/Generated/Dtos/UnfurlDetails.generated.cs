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
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client
{
    public interface UnfurlDetails
         : IClassNameConvertible, IPropagatePropertyAccessPath
    {
        public static AutomationJobExecutionUnfurlDetails AutomationJobExecution(string jobExecutionId, PRProject projectRef, string repoName)
            => new AutomationJobExecutionUnfurlDetails(jobExecutionId: jobExecutionId, projectRef: projectRef, repoName: repoName);
        
        public static AutomationJobUnfurlDetails AutomationJob(string jobId, string jobName, PRProject projectRef, string repoName, ExecutionDisplayStatus? jobExecutionDisplayStatusFilter = null, JobTriggerType? jobTriggerFilter = null, Branch? branch = null)
            => new AutomationJobUnfurlDetails(jobId: jobId, jobName: jobName, projectRef: projectRef, repoName: repoName, jobExecutionDisplayStatusFilter: jobExecutionDisplayStatusFilter, jobTriggerFilter: jobTriggerFilter, branch: branch);
        
        public static ChannelItemSnapshot ChannelItemSnapshot(string id, string text, CPrincipal author, DateTime created, long time, string? channelId = null, M2ItemContentDetails? details = null, List<AttachmentInfo>? attachments = null)
            => new ChannelItemSnapshot(id: id, text: text, author: author, created: created, time: time, channelId: channelId, details: details, attachments: attachments);
        
        public static UnfurlDetailsArticle Article(ArticleRecord article, ArticleContentRecord content, ArticleChannelRecord channel, ArticleDetailsRecord? details = null)
            => new UnfurlDetailsArticle(article: article, content: content, channel: channel, details: details);
        
        public static UnfurlDetailsChecklist Checklist(Checklist checklist)
            => new UnfurlDetailsChecklist(checklist: checklist);
        
        public static UnfurlDetailsCodeReview CodeReview(CodeReviewRecord review)
            => new UnfurlDetailsCodeReview(review: review);
        
        public static UnfurlDetailsCodeSnippet CodeSnippet(CodeSnippetAnchor anchor, List<CodeLine> lines)
            => new UnfurlDetailsCodeSnippet(anchor: anchor, lines: lines);
        
        public static UnfurlDetailsDateTime DateTime(long utcMilliseconds, DateTimeViewParams? @params = null)
            => new UnfurlDetailsDateTime(utcMilliseconds: utcMilliseconds, @params: @params);
        
        public static UnfurlDetailsDateTimeRange DateTimeRange(long since, long till, DateTimeViewParams? @params = null)
            => new UnfurlDetailsDateTimeRange(since: since, till: till, @params: @params);
        
        public static UnfurlDetailsDraft Draft(string draft, string title)
            => new UnfurlDetailsDraft(draft: draft, title: title);
        
        public static UnfurlDetailsIssue Issue(Issue issue)
            => new UnfurlDetailsIssue(issue: issue);
        
        public static UnfurlDetailsIssueStatus IssueStatus(IssueStatus status)
            => new UnfurlDetailsIssueStatus(status: status);
        
        public static UnfurlDetailsIssueTag IssueTag(PlanningTag tag, bool strikeThrough)
            => new UnfurlDetailsIssueTag(tag: tag, strikeThrough: strikeThrough);
        
        public static UnfurlDetailsLocation Location(TDLocation location)
            => new UnfurlDetailsLocation(location: location);
        
        public static UnfurlDetailsMC MC(MCMessage message, List<AttachmentInfo>? inlineUnfurls = null)
            => new UnfurlDetailsMC(message: message, inlineUnfurls: inlineUnfurls);
        
        public static UnfurlDetailsMeeting Meeting(Meeting meeting)
            => new UnfurlDetailsMeeting(meeting: meeting);
        
        public static UnfurlDetailsProfile Profile(TDMemberProfile profile)
            => new UnfurlDetailsProfile(profile: profile);
        
        public static UnfurlDetailsRepositoryBranch RepositoryBranch(PRProject project, string repository, string branchHead, bool deleted)
            => new UnfurlDetailsRepositoryBranch(project: project, repository: repository, branchHead: branchHead, deleted: deleted);
        
        public static UnfurlDetailsSprint Sprint(PRProject project, SprintRecord sprint)
            => new UnfurlDetailsSprint(project: project, sprint: sprint);
        
        public static UnfurlDetailsTeam Team(TDTeam team)
            => new UnfurlDetailsTeam(team: team);
        
    }
    
}
