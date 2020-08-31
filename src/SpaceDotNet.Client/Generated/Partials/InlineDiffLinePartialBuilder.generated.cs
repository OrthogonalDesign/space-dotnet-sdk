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

namespace SpaceDotNet.Client.InlineDiffLinePartialBuilder
{
    public static class InlineDiffLinePartialExtensions
    {
        public static Partial<InlineDiffLine> WithText(this Partial<InlineDiffLine> it)
            => it.AddFieldName("text");
        
        public static Partial<InlineDiffLine> WithType(this Partial<InlineDiffLine> it)
            => it.AddFieldName("type");
        
        public static Partial<InlineDiffLine> WithType(this Partial<InlineDiffLine> it, Func<Partial<DiffLineType>, Partial<DiffLineType>> partialBuilder)
            => it.AddFieldName("type", partialBuilder(new Partial<DiffLineType>(it)));
        
        public static Partial<InlineDiffLine> WithOldLineNum(this Partial<InlineDiffLine> it)
            => it.AddFieldName("oldLineNum");
        
        public static Partial<InlineDiffLine> WithNewLineNum(this Partial<InlineDiffLine> it)
            => it.AddFieldName("newLineNum");
        
        public static Partial<InlineDiffLine> WithOldFileOffset(this Partial<InlineDiffLine> it)
            => it.AddFieldName("oldFileOffset");
        
        public static Partial<InlineDiffLine> WithNewFileOffset(this Partial<InlineDiffLine> it)
            => it.AddFieldName("newFileOffset");
        
        public static Partial<InlineDiffLine> WithSyntax(this Partial<InlineDiffLine> it)
            => it.AddFieldName("syntax");
        
        public static Partial<InlineDiffLine> WithSyntax(this Partial<InlineDiffLine> it, Func<Partial<SyntaxMarkup>, Partial<SyntaxMarkup>> partialBuilder)
            => it.AddFieldName("syntax", partialBuilder(new Partial<SyntaxMarkup>(it)));
        
        public static Partial<InlineDiffLine> WithDeletes(this Partial<InlineDiffLine> it)
            => it.AddFieldName("deletes");
        
        public static Partial<InlineDiffLine> WithDeletes(this Partial<InlineDiffLine> it, Func<Partial<TextRange>, Partial<TextRange>> partialBuilder)
            => it.AddFieldName("deletes", partialBuilder(new Partial<TextRange>(it)));
        
        public static Partial<InlineDiffLine> WithInserts(this Partial<InlineDiffLine> it)
            => it.AddFieldName("inserts");
        
        public static Partial<InlineDiffLine> WithInserts(this Partial<InlineDiffLine> it, Func<Partial<TextRange>, Partial<TextRange>> partialBuilder)
            => it.AddFieldName("inserts", partialBuilder(new Partial<TextRange>(it)));
        
    }
    
}