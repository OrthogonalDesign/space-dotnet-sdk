// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS0108

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client.ImageAttachmentPartialBuilder
{
    public static class ImageAttachmentPartialExtensions
    {
        public static Partial<ImageAttachment> WithId(this Partial<ImageAttachment> it)
            => it.AddFieldName("id");
        
        public static Partial<ImageAttachment> WithName(this Partial<ImageAttachment> it)
            => it.AddFieldName("name");
        
        public static Partial<ImageAttachment> WithWidth(this Partial<ImageAttachment> it)
            => it.AddFieldName("width");
        
        public static Partial<ImageAttachment> WithHeight(this Partial<ImageAttachment> it)
            => it.AddFieldName("height");
        
        public static Partial<ImageAttachment> WithPreviewBytes(this Partial<ImageAttachment> it)
            => it.AddFieldName("previewBytes");
        
        public static Partial<ImageAttachment> WithVariants(this Partial<ImageAttachment> it)
            => it.AddFieldName("variants");
        
        public static Partial<ImageAttachment> WithVariants(this Partial<ImageAttachment> it, Func<Partial<ImageAttachmentVariant>, Partial<ImageAttachmentVariant>> partialBuilder)
            => it.AddFieldName("variants", partialBuilder(new Partial<ImageAttachmentVariant>(it)));
        
    }
    
}