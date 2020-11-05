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

namespace JetBrains.Space.Client.StickerContentDetailsPartialBuilder
{
    public static class StickerContentDetailsPartialExtensions
    {
        public static Partial<StickerContentDetails> WithSticker(this Partial<StickerContentDetails> it)
            => it.AddFieldName("sticker");
        
        public static Partial<StickerContentDetails> WithSticker(this Partial<StickerContentDetails> it, Func<Partial<Sticker>, Partial<Sticker>> partialBuilder)
            => it.AddFieldName("sticker", partialBuilder(new Partial<Sticker>(it)));
        
        public static Partial<StickerContentDetails> WithPack(this Partial<StickerContentDetails> it)
            => it.AddFieldName("pack");
        
        public static Partial<StickerContentDetails> WithPack(this Partial<StickerContentDetails> it, Func<Partial<StickerPackInfo>, Partial<StickerPackInfo>> partialBuilder)
            => it.AddFieldName("pack", partialBuilder(new Partial<StickerPackInfo>(it)));
        
    }
    
}