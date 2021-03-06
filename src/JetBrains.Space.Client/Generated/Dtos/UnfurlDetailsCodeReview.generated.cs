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
    public sealed class UnfurlDetailsCodeReview
         : UnfurlDetails, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "UnfurlDetailsCodeReview";
        
        public UnfurlDetailsCodeReview() { }
        
        public UnfurlDetailsCodeReview(CodeReviewRecord review)
        {
            Review = review;
        }
        
        private PropertyValue<CodeReviewRecord> _review = new PropertyValue<CodeReviewRecord>(nameof(UnfurlDetailsCodeReview), nameof(Review));
        
        [Required]
        [JsonPropertyName("review")]
        public CodeReviewRecord Review
        {
            get => _review.GetValue();
            set => _review.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _review.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
