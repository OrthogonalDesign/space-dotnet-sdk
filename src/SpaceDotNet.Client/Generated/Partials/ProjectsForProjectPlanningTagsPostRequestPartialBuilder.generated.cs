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

namespace SpaceDotNet.Client.ProjectsForProjectPlanningTagsPostRequestPartialBuilder
{
    public static class ProjectsForProjectPlanningTagsPostRequestPartialExtensions
    {
        public static Partial<ProjectsForProjectPlanningTagsPostRequest> WithParentTagId(this Partial<ProjectsForProjectPlanningTagsPostRequest> it)
            => it.AddFieldName("parentTagId");
        
        public static Partial<ProjectsForProjectPlanningTagsPostRequest> WithPath(this Partial<ProjectsForProjectPlanningTagsPostRequest> it)
            => it.AddFieldName("path");
        
    }
    
}