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
    public sealed class KbPublicationDetailsDto
         : PublicationDetailsDto, IClassNameConvertible
    {
        [JsonPropertyName("className")]
        public string? ClassName { get; set; }
        
        private PropertyValue<KBBookDto?> _book = new PropertyValue<KBBookDto?>(nameof(KbPublicationDetailsDto), nameof(Book));
        
        [JsonPropertyName("book")]
        public KBBookDto? Book
        {
            get { return _book.GetValue(); }
            set { _book.SetValue(value); }
        }
    
        private PropertyValue<KBFolderDto?> _folder = new PropertyValue<KBFolderDto?>(nameof(KbPublicationDetailsDto), nameof(Folder));
        
        [JsonPropertyName("folder")]
        public KBFolderDto? Folder
        {
            get { return _folder.GetValue(); }
            set { _folder.SetValue(value); }
        }
    
        private PropertyValue<KBArticleDto?> _articleId = new PropertyValue<KBArticleDto?>(nameof(KbPublicationDetailsDto), nameof(ArticleId));
        
        [JsonPropertyName("articleId")]
        public KBArticleDto? ArticleId
        {
            get { return _articleId.GetValue(); }
            set { _articleId.SetValue(value); }
        }
    
    }
    
}
