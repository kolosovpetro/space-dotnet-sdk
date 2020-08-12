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

namespace SpaceDotNet.Client.DRDraftDtoPartialBuilder
{
    public static class DRDraftDtoPartialExtensions
    {
        public static Partial<DRDraftDto> WithId(this Partial<DRDraftDto> it)
            => it.AddFieldName("id");
        
        public static Partial<DRDraftDto> WithTitle(this Partial<DRDraftDto> it)
            => it.AddFieldName("title");
        
        public static Partial<DRDraftDto> WithModified(this Partial<DRDraftDto> it)
            => it.AddFieldName("modified");
        
        public static Partial<DRDraftDto> WithCreated(this Partial<DRDraftDto> it)
            => it.AddFieldName("created");
        
        public static Partial<DRDraftDto> WithShared(this Partial<DRDraftDto> it)
            => it.AddFieldName("shared");
        
        public static Partial<DRDraftDto> WithDeleted(this Partial<DRDraftDto> it)
            => it.AddFieldName("deleted");
        
        public static Partial<DRDraftDto> WithPublicationDetails(this Partial<DRDraftDto> it)
            => it.AddFieldName("publicationDetails");
        
        public static Partial<DRDraftDto> WithPublicationDetails(this Partial<DRDraftDto> it, Func<Partial<DraftPublicationDetailsDto>, Partial<DraftPublicationDetailsDto>> partialBuilder)
            => it.AddFieldName("publicationDetails", partialBuilder(new Partial<DraftPublicationDetailsDto>(it)));
        
        public static Partial<DRDraftDto> WithPublicationDetails2(this Partial<DRDraftDto> it)
            => it.AddFieldName("publicationDetails2");
        
        public static Partial<DRDraftDto> WithPublicationDetails2(this Partial<DRDraftDto> it, Func<Partial<PublicationDetailsDto>, Partial<PublicationDetailsDto>> partialBuilder)
            => it.AddFieldName("publicationDetails2", partialBuilder(new Partial<PublicationDetailsDto>(it)));
        
        public static Partial<DRDraftDto> WithAuthor(this Partial<DRDraftDto> it)
            => it.AddFieldName("author");
        
        public static Partial<DRDraftDto> WithAuthor(this Partial<DRDraftDto> it, Func<Partial<TDMemberProfileDto>, Partial<TDMemberProfileDto>> partialBuilder)
            => it.AddFieldName("author", partialBuilder(new Partial<TDMemberProfileDto>(it)));
        
        public static Partial<DRDraftDto> WithPublishedFlag(this Partial<DRDraftDto> it)
            => it.AddFieldName("publishedFlag");
        
        public static Partial<DRDraftDto> WithPublished(this Partial<DRDraftDto> it)
            => it.AddFieldName("published");
        
        public static Partial<DRDraftDto> WithFolder(this Partial<DRDraftDto> it)
            => it.AddFieldName("folder");
        
        public static Partial<DRDraftDto> WithFolder(this Partial<DRDraftDto> it, Func<Partial<DocumentFolderRecordDto>, Partial<DocumentFolderRecordDto>> partialBuilder)
            => it.AddFieldName("folder", partialBuilder(new Partial<DocumentFolderRecordDto>(it)));
        
        public static Partial<DRDraftDto> WithAccessOrdinal(this Partial<DRDraftDto> it)
            => it.AddFieldName("accessOrdinal");
        
        public static Partial<DRDraftDto> WithEditors(this Partial<DRDraftDto> it)
            => it.AddFieldName("editors");
        
        public static Partial<DRDraftDto> WithEditors(this Partial<DRDraftDto> it, Func<Partial<TDMemberProfileDto>, Partial<TDMemberProfileDto>> partialBuilder)
            => it.AddFieldName("editors", partialBuilder(new Partial<TDMemberProfileDto>(it)));
        
        public static Partial<DRDraftDto> WithEditorsTeams(this Partial<DRDraftDto> it)
            => it.AddFieldName("editorsTeams");
        
        public static Partial<DRDraftDto> WithEditorsTeams(this Partial<DRDraftDto> it, Func<Partial<TDTeamDto>, Partial<TDTeamDto>> partialBuilder)
            => it.AddFieldName("editorsTeams", partialBuilder(new Partial<TDTeamDto>(it)));
        
        public static Partial<DRDraftDto> WithDocument(this Partial<DRDraftDto> it)
            => it.AddFieldName("document");
        
        public static Partial<DRDraftDto> WithDocument(this Partial<DRDraftDto> it, Func<Partial<TextDocumentDto>, Partial<TextDocumentDto>> partialBuilder)
            => it.AddFieldName("document", partialBuilder(new Partial<TextDocumentDto>(it)));
        
    }
    
}
