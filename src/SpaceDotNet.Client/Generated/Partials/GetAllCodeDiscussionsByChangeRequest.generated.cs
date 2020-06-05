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

namespace SpaceDotNet.Client.GetAllCodeDiscussionsByChangeRequestExtensions
{
    public static class GetAllCodeDiscussionsByChangeRequestPartialExtensions
    {
        public static Partial<GetAllCodeDiscussionsByChangeRequest> WithProjectKey(this Partial<GetAllCodeDiscussionsByChangeRequest> it)    => it.AddFieldName("projectKey");
        
        public static Partial<GetAllCodeDiscussionsByChangeRequest> WithProjectKey(this Partial<GetAllCodeDiscussionsByChangeRequest> it, Func<Partial<ProjectKeyDto>, Partial<ProjectKeyDto>> partialBuilder)    => it.AddFieldName("projectKey", partialBuilder(new Partial<ProjectKeyDto>()));
        
        public static Partial<GetAllCodeDiscussionsByChangeRequest> WithRepository(this Partial<GetAllCodeDiscussionsByChangeRequest> it)    => it.AddFieldName("repository");
        
        public static Partial<GetAllCodeDiscussionsByChangeRequest> WithRevisions(this Partial<GetAllCodeDiscussionsByChangeRequest> it)    => it.AddFieldName("revisions");
        
        public static Partial<GetAllCodeDiscussionsByChangeRequest> WithChange(this Partial<GetAllCodeDiscussionsByChangeRequest> it)    => it.AddFieldName("change");
        
        public static Partial<GetAllCodeDiscussionsByChangeRequest> WithChange(this Partial<GetAllCodeDiscussionsByChangeRequest> it, Func<Partial<GitCommitChangeDto>, Partial<GitCommitChangeDto>> partialBuilder)    => it.AddFieldName("change", partialBuilder(new Partial<GitCommitChangeDto>()));
        
    }
    
}