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

namespace SpaceDotNet.Client.FTSBlogCommentExtensions
{
    public static class FTSBlogCommentDtoPartialExtensions
    {
        public static Partial<FTSBlogCommentDto> WithAuthor(this Partial<FTSBlogCommentDto> it)
            => it.AddFieldName("author");
        
        public static Partial<FTSBlogCommentDto> WithAuthor(this Partial<FTSBlogCommentDto> it, Func<Partial<TDMemberProfileDto>, Partial<TDMemberProfileDto>> partialBuilder)
            => it.AddFieldName("author", partialBuilder(new Partial<TDMemberProfileDto>()));
        
        public static Partial<FTSBlogCommentDto> WithDate(this Partial<FTSBlogCommentDto> it)
            => it.AddFieldName("date");
        
        public static Partial<FTSBlogCommentDto> WithSnippets(this Partial<FTSBlogCommentDto> it)
            => it.AddFieldName("snippets");
        
    }
    
}
