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
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client.CodeDiscussionSnippetInlineDiffSnippetDtoPartialBuilder
{
    public static class CodeDiscussionSnippetInlineDiffSnippetDtoPartialExtensions
    {
        public static Partial<CodeDiscussionSnippetInlineDiffSnippetDto> WithLines(this Partial<CodeDiscussionSnippetInlineDiffSnippetDto> it)
            => it.AddFieldName("lines");
        
        public static Partial<CodeDiscussionSnippetInlineDiffSnippetDto> WithLines(this Partial<CodeDiscussionSnippetInlineDiffSnippetDto> it, Func<Partial<InlineDiffLineDto>, Partial<InlineDiffLineDto>> partialBuilder)
            => it.AddFieldName("lines", partialBuilder(new Partial<InlineDiffLineDto>(it)));
        
    }
    
}
