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

namespace SpaceDotNet.Client
{
    public class ProjectsForProjectCodeReviewsForReviewIdStateRequest
         : IPropagatePropertyAccessPath
    {
        private PropertyValue<CodeReviewState> _state = new PropertyValue<CodeReviewState>(nameof(ProjectsForProjectCodeReviewsForReviewIdStateRequest), nameof(State));
        
        [Required]
        [JsonPropertyName("state")]
        public CodeReviewState State
        {
            get { return _state.GetValue(); }
            set { _state.SetValue(value); }
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _state.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}