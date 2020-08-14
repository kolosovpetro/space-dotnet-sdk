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

namespace SpaceDotNet.Client.KBFolderDtoPartialBuilder
{
    public static class KBFolderDtoPartialExtensions
    {
        public static Partial<KBFolderDto> WithId(this Partial<KBFolderDto> it)
            => it.AddFieldName("id");
        
        public static Partial<KBFolderDto> WithArchived(this Partial<KBFolderDto> it)
            => it.AddFieldName("archived");
        
        public static Partial<KBFolderDto> WithName(this Partial<KBFolderDto> it)
            => it.AddFieldName("name");
        
        public static Partial<KBFolderDto> WithParent(this Partial<KBFolderDto> it)
            => it.AddFieldName("parent");
        
        public static Partial<KBFolderDto> WithParentRecursive(this Partial<KBFolderDto> it)
            => it.AddFieldName("parent!");
        
        public static Partial<KBFolderDto> WithParent(this Partial<KBFolderDto> it, Func<Partial<KBFolderDto>, Partial<KBFolderDto>> partialBuilder)
            => it.AddFieldName("parent", partialBuilder(new Partial<KBFolderDto>(it)));
        
        public static Partial<KBFolderDto> WithSubfolders(this Partial<KBFolderDto> it)
            => it.AddFieldName("subfolders");
        
        public static Partial<KBFolderDto> WithSubfoldersRecursive(this Partial<KBFolderDto> it)
            => it.AddFieldName("subfolders!");
        
        public static Partial<KBFolderDto> WithSubfolders(this Partial<KBFolderDto> it, Func<Partial<KBFolderDto>, Partial<KBFolderDto>> partialBuilder)
            => it.AddFieldName("subfolders", partialBuilder(new Partial<KBFolderDto>(it)));
        
        public static Partial<KBFolderDto> WithArticles(this Partial<KBFolderDto> it)
            => it.AddFieldName("articles");
        
        public static Partial<KBFolderDto> WithArticles(this Partial<KBFolderDto> it, Func<Partial<KBArticleDto>, Partial<KBArticleDto>> partialBuilder)
            => it.AddFieldName("articles", partialBuilder(new Partial<KBArticleDto>(it)));
        
        public static Partial<KBFolderDto> WithBook(this Partial<KBFolderDto> it)
            => it.AddFieldName("book");
        
        public static Partial<KBFolderDto> WithBook(this Partial<KBFolderDto> it, Func<Partial<KBBookDto>, Partial<KBBookDto>> partialBuilder)
            => it.AddFieldName("book", partialBuilder(new Partial<KBBookDto>(it)));
        
        public static Partial<KBFolderDto> WithCover(this Partial<KBFolderDto> it)
            => it.AddFieldName("cover");
        
        public static Partial<KBFolderDto> WithCover(this Partial<KBFolderDto> it, Func<Partial<KBArticleDto>, Partial<KBArticleDto>> partialBuilder)
            => it.AddFieldName("cover", partialBuilder(new Partial<KBArticleDto>(it)));
        
        public static Partial<KBFolderDto> WithAlias(this Partial<KBFolderDto> it)
            => it.AddFieldName("alias");
        
    }
    
}
