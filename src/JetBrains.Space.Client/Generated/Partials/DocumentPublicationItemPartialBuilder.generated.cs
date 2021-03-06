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

namespace JetBrains.Space.Client.DocumentPublicationItemPartialBuilder
{
    public static class DocumentPublicationItemPartialExtensions
    {
        public static Partial<DocumentPublicationItem> WithDocumentId(this Partial<DocumentPublicationItem> it)
            => it.AddFieldName("documentId");
        
        public static Partial<DocumentPublicationItem> WithDocumentType(this Partial<DocumentPublicationItem> it)
            => it.AddFieldName("documentType");
        
        public static Partial<DocumentPublicationItem> WithDocumentType(this Partial<DocumentPublicationItem> it, Func<Partial<DraftDocumentType>, Partial<DraftDocumentType>> partialBuilder)
            => it.AddFieldName("documentType", partialBuilder(new Partial<DraftDocumentType>(it)));
        
    }
    
}
