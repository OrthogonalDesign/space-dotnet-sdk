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

namespace JetBrains.Space.Client.ESAppPartialBuilder
{
    public static class ESAppPartialExtensions
    {
        public static Partial<ESApp> WithId(this Partial<ESApp> it)
            => it.AddFieldName("id");
        
        public static Partial<ESApp> WithOwner(this Partial<ESApp> it)
            => it.AddFieldName("owner");
        
        public static Partial<ESApp> WithOwner(this Partial<ESApp> it, Func<Partial<TDMemberProfile>, Partial<TDMemberProfile>> partialBuilder)
            => it.AddFieldName("owner", partialBuilder(new Partial<TDMemberProfile>(it)));
        
        public static Partial<ESApp> WithClientId(this Partial<ESApp> it)
            => it.AddFieldName("clientId");
        
        public static Partial<ESApp> WithName(this Partial<ESApp> it)
            => it.AddFieldName("name");
        
        public static Partial<ESApp> WithApplicationType(this Partial<ESApp> it)
            => it.AddFieldName("applicationType");
        
        public static Partial<ESApp> WithApplicationType(this Partial<ESApp> it, Func<Partial<ApplicationType>, Partial<ApplicationType>> partialBuilder)
            => it.AddFieldName("applicationType", partialBuilder(new Partial<ApplicationType>(it)));
        
        public static Partial<ESApp> WithIsClientCredentialsFlowEnabled(this Partial<ESApp> it)
            => it.AddFieldName("clientCredentialsFlowEnabled");
        
        public static Partial<ESApp> WithIsCodeFlowEnabled(this Partial<ESApp> it)
            => it.AddFieldName("codeFlowEnabled");
        
        public static Partial<ESApp> WithCodeFlowRedirectURIs(this Partial<ESApp> it)
            => it.AddFieldName("codeFlowRedirectURIs");
        
        public static Partial<ESApp> WithIsImplicitFlowEnabled(this Partial<ESApp> it)
            => it.AddFieldName("implicitFlowEnabled");
        
        public static Partial<ESApp> WithImplicitFlowRedirectURIs(this Partial<ESApp> it)
            => it.AddFieldName("implicitFlowRedirectURIs");
        
        public static Partial<ESApp> WithEndpointURI(this Partial<ESApp> it)
            => it.AddFieldName("endpointURI");
        
        public static Partial<ESApp> WithIsHasVerificationToken(this Partial<ESApp> it)
            => it.AddFieldName("hasVerificationToken");
        
        public static Partial<ESApp> WithIsHasSigningKey(this Partial<ESApp> it)
            => it.AddFieldName("hasSigningKey");
        
        public static Partial<ESApp> WithIsArchived(this Partial<ESApp> it)
            => it.AddFieldName("archived");
        
    }
    
}
