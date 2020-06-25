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

namespace SpaceDotNet.Client.M2ChannelContentArticleDtoPartialBuilder
{
    public static class M2ChannelContentArticleDtoPartialExtensions
    {
        public static Partial<M2ChannelContentArticleDto> WithArticle(this Partial<M2ChannelContentArticleDto> it)
            => it.AddFieldName("article");
        
        public static Partial<M2ChannelContentArticleDto> WithArticle(this Partial<M2ChannelContentArticleDto> it, Func<Partial<ArticleRecordDto>, Partial<ArticleRecordDto>> partialBuilder)
            => it.AddFieldName("article", partialBuilder(new Partial<ArticleRecordDto>(it)));
        
        public static Partial<M2ChannelContentArticleDto> WithArticleContent(this Partial<M2ChannelContentArticleDto> it)
            => it.AddFieldName("articleContent");
        
        public static Partial<M2ChannelContentArticleDto> WithArticleContent(this Partial<M2ChannelContentArticleDto> it, Func<Partial<ArticleContentRecordDto>, Partial<ArticleContentRecordDto>> partialBuilder)
            => it.AddFieldName("articleContent", partialBuilder(new Partial<ArticleContentRecordDto>(it)));
        
        public static Partial<M2ChannelContentArticleDto> WithDetails(this Partial<M2ChannelContentArticleDto> it)
            => it.AddFieldName("details");
        
        public static Partial<M2ChannelContentArticleDto> WithDetails(this Partial<M2ChannelContentArticleDto> it, Func<Partial<ArticleDetailsRecordDto>, Partial<ArticleDetailsRecordDto>> partialBuilder)
            => it.AddFieldName("details", partialBuilder(new Partial<ArticleDetailsRecordDto>(it)));
        
    }
    
}