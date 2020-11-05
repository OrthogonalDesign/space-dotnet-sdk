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

namespace JetBrains.Space.Client
{
    public sealed class ProfileHitDetails
         : EntityHitDetails, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "ProfileHitDetails";
        
        public ProfileHitDetails() { }
        
        public ProfileHitDetails(TDMemberProfile @ref, ProfileAbsencesRecord absencesRef, ProfileMembershipRecord membershipRef, ProfileLocationsRecord locationsRef)
        {
            Ref = @ref;
            AbsencesRef = absencesRef;
            MembershipRef = membershipRef;
            LocationsRef = locationsRef;
        }
        
        private PropertyValue<TDMemberProfile> _ref = new PropertyValue<TDMemberProfile>(nameof(ProfileHitDetails), nameof(Ref));
        
        [Required]
        [JsonPropertyName("ref")]
        public TDMemberProfile Ref
        {
            get => _ref.GetValue();
            set => _ref.SetValue(value);
        }
    
        private PropertyValue<ProfileAbsencesRecord> _absencesRef = new PropertyValue<ProfileAbsencesRecord>(nameof(ProfileHitDetails), nameof(AbsencesRef));
        
        [Required]
        [JsonPropertyName("absencesRef")]
        public ProfileAbsencesRecord AbsencesRef
        {
            get => _absencesRef.GetValue();
            set => _absencesRef.SetValue(value);
        }
    
        private PropertyValue<ProfileMembershipRecord> _membershipRef = new PropertyValue<ProfileMembershipRecord>(nameof(ProfileHitDetails), nameof(MembershipRef));
        
        [Required]
        [JsonPropertyName("membershipRef")]
        public ProfileMembershipRecord MembershipRef
        {
            get => _membershipRef.GetValue();
            set => _membershipRef.SetValue(value);
        }
    
        private PropertyValue<ProfileLocationsRecord> _locationsRef = new PropertyValue<ProfileLocationsRecord>(nameof(ProfileHitDetails), nameof(LocationsRef));
        
        [Required]
        [JsonPropertyName("locationsRef")]
        public ProfileLocationsRecord LocationsRef
        {
            get => _locationsRef.GetValue();
            set => _locationsRef.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _ref.SetAccessPath(path, validateHasBeenSet);
            _absencesRef.SetAccessPath(path, validateHasBeenSet);
            _membershipRef.SetAccessPath(path, validateHasBeenSet);
            _locationsRef.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}