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
    public sealed class KBArticleDto
    {
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(KBArticleDto), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(KBArticleDto), nameof(Archived));
        
        [Required]
        [JsonPropertyName("archived")]
        public bool Archived
        {
            get { return _archived.GetValue(); }
            set { _archived.SetValue(value); }
        }
    
        private PropertyValue<string> _title = new PropertyValue<string>(nameof(KBArticleDto), nameof(Title));
        
        [Required]
        [JsonPropertyName("title")]
        public string Title
        {
            get { return _title.GetValue(); }
            set { _title.SetValue(value); }
        }
    
        private PropertyValue<KBBookDto> _book = new PropertyValue<KBBookDto>(nameof(KBArticleDto), nameof(Book));
        
        [Required]
        [JsonPropertyName("book")]
        public KBBookDto Book
        {
            get { return _book.GetValue(); }
            set { _book.SetValue(value); }
        }
    
        private PropertyValue<KBFolderDto> _folder = new PropertyValue<KBFolderDto>(nameof(KBArticleDto), nameof(Folder));
        
        [Required]
        [JsonPropertyName("folder")]
        public KBFolderDto Folder
        {
            get { return _folder.GetValue(); }
            set { _folder.SetValue(value); }
        }
    
        private PropertyValue<PublicationItemDto> _item = new PropertyValue<PublicationItemDto>(nameof(KBArticleDto), nameof(Item));
        
        [Required]
        [JsonPropertyName("item")]
        public PublicationItemDto Item
        {
            get { return _item.GetValue(); }
            set { _item.SetValue(value); }
        }
    
        private PropertyValue<SpaceTime> _created = new PropertyValue<SpaceTime>(nameof(KBArticleDto), nameof(Created));
        
        [Required]
        [JsonPropertyName("created")]
        public SpaceTime Created
        {
            get { return _created.GetValue(); }
            set { _created.SetValue(value); }
        }
    
        private PropertyValue<string> _alias = new PropertyValue<string>(nameof(KBArticleDto), nameof(Alias));
        
        [Required]
        [JsonPropertyName("alias")]
        public string Alias
        {
            get { return _alias.GetValue(); }
            set { _alias.SetValue(value); }
        }
    
    }
    
}
