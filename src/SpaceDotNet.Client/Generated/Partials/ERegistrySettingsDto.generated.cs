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

namespace SpaceDotNet.Client.ERegistrySettingsExtensions
{
    public static class ERegistrySettingsDtoPartialExtensions
    {
        public static Partial<ERegistrySettingsDto> WithOrganizationId(this Partial<ERegistrySettingsDto> it)
            => it.AddFieldName("organizationId");
        
        public static Partial<ERegistrySettingsDto> WithPrincipalName(this Partial<ERegistrySettingsDto> it)
            => it.AddFieldName("principalName");
        
        public static Partial<ERegistrySettingsDto> WithPrincipalInfo(this Partial<ERegistrySettingsDto> it)
            => it.AddFieldName("principalInfo");
        
        public static Partial<ERegistrySettingsDto> WithRepositories(this Partial<ERegistrySettingsDto> it)
            => it.AddFieldName("repositories");
        
        public static Partial<ERegistrySettingsDto> WithRepositories(this Partial<ERegistrySettingsDto> it, Func<Partial<MapEntry<string, ERepositorySettingsDto>>, Partial<MapEntry<string, ERepositorySettingsDto>>> partialBuilder)
            => it.AddFieldName("repositories", partialBuilder(new Partial<MapEntry<string, ERepositorySettingsDto>>()));
        
        public static Partial<ERegistrySettingsDto> WithStorageLimit(this Partial<ERegistrySettingsDto> it)
            => it.AddFieldName("storageLimit");
        
        public static Partial<ERegistrySettingsDto> WithStorageLimit(this Partial<ERegistrySettingsDto> it, Func<Partial<DTOLimitDto>, Partial<DTOLimitDto>> partialBuilder)
            => it.AddFieldName("storageLimit", partialBuilder(new Partial<DTOLimitDto>()));
        
        public static Partial<ERegistrySettingsDto> WithDownloadLimit(this Partial<ERegistrySettingsDto> it)
            => it.AddFieldName("downloadLimit");
        
        public static Partial<ERegistrySettingsDto> WithDownloadLimit(this Partial<ERegistrySettingsDto> it, Func<Partial<DTOLimitDto>, Partial<DTOLimitDto>> partialBuilder)
            => it.AddFieldName("downloadLimit", partialBuilder(new Partial<DTOLimitDto>()));
        
        public static Partial<ERegistrySettingsDto> WithUploadLimit(this Partial<ERegistrySettingsDto> it)
            => it.AddFieldName("uploadLimit");
        
        public static Partial<ERegistrySettingsDto> WithUploadLimit(this Partial<ERegistrySettingsDto> it, Func<Partial<DTOLimitDto>, Partial<DTOLimitDto>> partialBuilder)
            => it.AddFieldName("uploadLimit", partialBuilder(new Partial<DTOLimitDto>()));
        
    }
    
}