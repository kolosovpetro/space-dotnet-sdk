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
#pragma warning disable 618

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

namespace JetBrains.Space.Client.DRDraftHeaderPartialBuilder
{
    public static class DRDraftHeaderPartialExtensions
    {
        public static Partial<DRDraftHeader> WithId(this Partial<DRDraftHeader> it)
            => it.AddFieldName("id");
        
        public static Partial<DRDraftHeader> WithTitle(this Partial<DRDraftHeader> it)
            => it.AddFieldName("title");
        
        public static Partial<DRDraftHeader> WithAuthor(this Partial<DRDraftHeader> it)
            => it.AddFieldName("author");
        
        public static Partial<DRDraftHeader> WithAuthor(this Partial<DRDraftHeader> it, Func<Partial<TDMemberProfile>, Partial<TDMemberProfile>> partialBuilder)
            => it.AddFieldName("author", partialBuilder(new Partial<TDMemberProfile>(it)));
        
        public static Partial<DRDraftHeader> WithModified(this Partial<DRDraftHeader> it)
            => it.AddFieldName("modified");
        
        public static Partial<DRDraftHeader> WithCreated(this Partial<DRDraftHeader> it)
            => it.AddFieldName("created");
        
        public static Partial<DRDraftHeader> WithModifiedBy(this Partial<DRDraftHeader> it)
            => it.AddFieldName("modifiedBy");
        
        public static Partial<DRDraftHeader> WithModifiedBy(this Partial<DRDraftHeader> it, Func<Partial<CPrincipal>, Partial<CPrincipal>> partialBuilder)
            => it.AddFieldName("modifiedBy", partialBuilder(new Partial<CPrincipal>(it)));
        
        public static Partial<DRDraftHeader> WithIsShared(this Partial<DRDraftHeader> it)
            => it.AddFieldName("shared");
        
        public static Partial<DRDraftHeader> WithPublicationDetails2(this Partial<DRDraftHeader> it)
            => it.AddFieldName("publicationDetails2");
        
        public static Partial<DRDraftHeader> WithPublicationDetails2(this Partial<DRDraftHeader> it, Func<Partial<PublicationDetails>, Partial<PublicationDetails>> partialBuilder)
            => it.AddFieldName("publicationDetails2", partialBuilder(new Partial<PublicationDetails>(it)));
        
        public static Partial<DRDraftHeader> WithIsDeleted(this Partial<DRDraftHeader> it)
            => it.AddFieldName("deleted");
        
        public static Partial<DRDraftHeader> WithFolder(this Partial<DRDraftHeader> it)
            => it.AddFieldName("folder");
        
        public static Partial<DRDraftHeader> WithFolder(this Partial<DRDraftHeader> it, Func<Partial<DocumentFolderRecord>, Partial<DocumentFolderRecord>> partialBuilder)
            => it.AddFieldName("folder", partialBuilder(new Partial<DocumentFolderRecord>(it)));
        
        public static Partial<DRDraftHeader> WithContainerInfo(this Partial<DRDraftHeader> it)
            => it.AddFieldName("containerInfo");
        
        public static Partial<DRDraftHeader> WithContainerInfo(this Partial<DRDraftHeader> it, Func<Partial<DocumentContainerInfo>, Partial<DocumentContainerInfo>> partialBuilder)
            => it.AddFieldName("containerInfo", partialBuilder(new Partial<DocumentContainerInfo>(it)));
        
        public static Partial<DRDraftHeader> WithBodyType(this Partial<DRDraftHeader> it)
            => it.AddFieldName("bodyType");
        
        public static Partial<DRDraftHeader> WithBodyType(this Partial<DRDraftHeader> it, Func<Partial<DocumentBodyType>, Partial<DocumentBodyType>> partialBuilder)
            => it.AddFieldName("bodyType", partialBuilder(new Partial<DocumentBodyType>(it)));
        
    }
    
}
