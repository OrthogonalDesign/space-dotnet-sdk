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
    public class UpdateProfileRequest
    {
        private PropertyValue<string?> _username = new PropertyValue<string?>(nameof(UpdateProfileRequest), nameof(Username));
        
        [JsonPropertyName("username")]
        public string? Username
        {
            get { return _username.GetValue(); }
            set { _username.SetValue(value); }
        }
    
        private PropertyValue<string?> _firstName = new PropertyValue<string?>(nameof(UpdateProfileRequest), nameof(FirstName));
        
        [JsonPropertyName("firstName")]
        public string? FirstName
        {
            get { return _firstName.GetValue(); }
            set { _firstName.SetValue(value); }
        }
    
        private PropertyValue<string?> _lastName = new PropertyValue<string?>(nameof(UpdateProfileRequest), nameof(LastName));
        
        [JsonPropertyName("lastName")]
        public string? LastName
        {
            get { return _lastName.GetValue(); }
            set { _lastName.SetValue(value); }
        }
    
        private PropertyValue<List<string>?> _emails = new PropertyValue<List<string>?>(nameof(UpdateProfileRequest), nameof(Emails));
        
        [JsonPropertyName("emails")]
        public List<string>? Emails
        {
            get { return _emails.GetValue(); }
            set { _emails.SetValue(value); }
        }
    
        private PropertyValue<List<string>?> _phones = new PropertyValue<List<string>?>(nameof(UpdateProfileRequest), nameof(Phones));
        
        [JsonPropertyName("phones")]
        public List<string>? Phones
        {
            get { return _phones.GetValue(); }
            set { _phones.SetValue(value); }
        }
    
        private PropertyValue<SpaceDate?> _birthday = new PropertyValue<SpaceDate?>(nameof(UpdateProfileRequest), nameof(Birthday));
        
        [JsonPropertyName("birthday")]
        public SpaceDate? Birthday
        {
            get { return _birthday.GetValue(); }
            set { _birthday.SetValue(value); }
        }
    
        private PropertyValue<string?> _about = new PropertyValue<string?>(nameof(UpdateProfileRequest), nameof(About));
        
        [JsonPropertyName("about")]
        public string? About
        {
            get { return _about.GetValue(); }
            set { _about.SetValue(value); }
        }
    
        private PropertyValue<Gender?> _gender = new PropertyValue<Gender?>(nameof(UpdateProfileRequest), nameof(Gender));
        
        [JsonPropertyName("gender")]
        public Gender? Gender
        {
            get { return _gender.GetValue(); }
            set { _gender.SetValue(value); }
        }
    
        private PropertyValue<List<string>?> _messengers = new PropertyValue<List<string>?>(nameof(UpdateProfileRequest), nameof(Messengers));
        
        [JsonPropertyName("messengers")]
        public List<string>? Messengers
        {
            get { return _messengers.GetValue(); }
            set { _messengers.SetValue(value); }
        }
    
        private PropertyValue<List<string>?> _links = new PropertyValue<List<string>?>(nameof(UpdateProfileRequest), nameof(Links));
        
        [JsonPropertyName("links")]
        public List<string>? Links
        {
            get { return _links.GetValue(); }
            set { _links.SetValue(value); }
        }
    
        private PropertyValue<bool?> _notAMember = new PropertyValue<bool?>(nameof(UpdateProfileRequest), nameof(NotAMember));
        
        [JsonPropertyName("notAMember")]
        public bool? NotAMember
        {
            get { return _notAMember.GetValue(); }
            set { _notAMember.SetValue(value); }
        }
    
        private PropertyValue<SpaceDate?> _joined = new PropertyValue<SpaceDate?>(nameof(UpdateProfileRequest), nameof(Joined));
        
        [JsonPropertyName("joined")]
        public SpaceDate? Joined
        {
            get { return _joined.GetValue(); }
            set { _joined.SetValue(value); }
        }
    
        private PropertyValue<SpaceDate?> _left = new PropertyValue<SpaceDate?>(nameof(UpdateProfileRequest), nameof(Left));
        
        [JsonPropertyName("left")]
        public SpaceDate? Left
        {
            get { return _left.GetValue(); }
            set { _left.SetValue(value); }
        }
    
        private PropertyValue<bool?> _speaksEnglish = new PropertyValue<bool?>(nameof(UpdateProfileRequest), nameof(SpeaksEnglish));
        
        [JsonPropertyName("speaksEnglish")]
        public bool? SpeaksEnglish
        {
            get { return _speaksEnglish.GetValue(); }
            set { _speaksEnglish.SetValue(value); }
        }
    
        private PropertyValue<string?> _pictureAttachmentId = new PropertyValue<string?>(nameof(UpdateProfileRequest), nameof(PictureAttachmentId));
        
        [JsonPropertyName("pictureAttachmentId")]
        public string? PictureAttachmentId
        {
            get { return _pictureAttachmentId.GetValue(); }
            set { _pictureAttachmentId.SetValue(value); }
        }
    
        private PropertyValue<AvatarCropSquareDto?> _avatarCropSquare = new PropertyValue<AvatarCropSquareDto?>(nameof(UpdateProfileRequest), nameof(AvatarCropSquare));
        
        [JsonPropertyName("avatarCropSquare")]
        public AvatarCropSquareDto? AvatarCropSquare
        {
            get { return _avatarCropSquare.GetValue(); }
            set { _avatarCropSquare.SetValue(value); }
        }
    
        private PropertyValue<List<CustomFieldValueDto>?> _customFieldValues = new PropertyValue<List<CustomFieldValueDto>?>(nameof(UpdateProfileRequest), nameof(CustomFieldValues));
        
        [JsonPropertyName("customFieldValues")]
        public List<CustomFieldValueDto>? CustomFieldValues
        {
            get { return _customFieldValues.GetValue(); }
            set { _customFieldValues.SetValue(value); }
        }
    
    }
    
}
