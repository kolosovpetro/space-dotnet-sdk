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

namespace JetBrains.Space.Client
{
    public sealed class DRDraftHeader
         : IPropagatePropertyAccessPath
    {
        public DRDraftHeader() { }
        
        public DRDraftHeader(string id, string title, TDMemberProfile author, DateTime modified, bool shared, DocumentContainerInfo containerInfo, DocumentBodyType bodyType, DateTime? created = null, CPrincipal? modifiedBy = null, PublicationDetails? publicationDetails2 = null, bool? deleted = null, DocumentFolderRecord? folder = null, DocumentFolder? folderRef = null)
        {
            Id = id;
            Title = title;
            Author = author;
            Modified = modified;
            Created = created;
            ModifiedBy = modifiedBy;
            IsShared = shared;
            PublicationDetails2 = publicationDetails2;
            IsDeleted = deleted;
            Folder = folder;
            FolderRef = folderRef;
            ContainerInfo = containerInfo;
            BodyType = bodyType;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(DRDraftHeader), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get => _id.GetValue();
            set => _id.SetValue(value);
        }
    
        private PropertyValue<string> _title = new PropertyValue<string>(nameof(DRDraftHeader), nameof(Title));
        
        [Required]
        [JsonPropertyName("title")]
        public string Title
        {
            get => _title.GetValue();
            set => _title.SetValue(value);
        }
    
        private PropertyValue<TDMemberProfile> _author = new PropertyValue<TDMemberProfile>(nameof(DRDraftHeader), nameof(Author));
        
        [Required]
        [JsonPropertyName("author")]
        public TDMemberProfile Author
        {
            get => _author.GetValue();
            set => _author.SetValue(value);
        }
    
        private PropertyValue<DateTime> _modified = new PropertyValue<DateTime>(nameof(DRDraftHeader), nameof(Modified));
        
        [Required]
        [JsonPropertyName("modified")]
        [JsonConverter(typeof(SpaceDateTimeConverter))]
        public DateTime Modified
        {
            get => _modified.GetValue();
            set => _modified.SetValue(value);
        }
    
        private PropertyValue<DateTime?> _created = new PropertyValue<DateTime?>(nameof(DRDraftHeader), nameof(Created));
        
        [JsonPropertyName("created")]
        [JsonConverter(typeof(SpaceDateTimeConverter))]
        public DateTime? Created
        {
            get => _created.GetValue();
            set => _created.SetValue(value);
        }
    
        private PropertyValue<CPrincipal?> _modifiedBy = new PropertyValue<CPrincipal?>(nameof(DRDraftHeader), nameof(ModifiedBy));
        
        [JsonPropertyName("modifiedBy")]
        public CPrincipal? ModifiedBy
        {
            get => _modifiedBy.GetValue();
            set => _modifiedBy.SetValue(value);
        }
    
        private PropertyValue<bool> _shared = new PropertyValue<bool>(nameof(DRDraftHeader), nameof(IsShared));
        
        [Required]
        [JsonPropertyName("shared")]
        public bool IsShared
        {
            get => _shared.GetValue();
            set => _shared.SetValue(value);
        }
    
        private PropertyValue<PublicationDetails?> _publicationDetails2 = new PropertyValue<PublicationDetails?>(nameof(DRDraftHeader), nameof(PublicationDetails2));
        
        [JsonPropertyName("publicationDetails2")]
        public PublicationDetails? PublicationDetails2
        {
            get => _publicationDetails2.GetValue();
            set => _publicationDetails2.SetValue(value);
        }
    
        private PropertyValue<bool?> _deleted = new PropertyValue<bool?>(nameof(DRDraftHeader), nameof(IsDeleted));
        
        [JsonPropertyName("deleted")]
        public bool? IsDeleted
        {
            get => _deleted.GetValue();
            set => _deleted.SetValue(value);
        }
    
        private PropertyValue<DocumentFolderRecord?> _folder = new PropertyValue<DocumentFolderRecord?>(nameof(DRDraftHeader), nameof(Folder));
        
        [JsonPropertyName("folder")]
        public DocumentFolderRecord? Folder
        {
            get => _folder.GetValue();
            set => _folder.SetValue(value);
        }
    
        private PropertyValue<DocumentFolder?> _folderRef = new PropertyValue<DocumentFolder?>(nameof(DRDraftHeader), nameof(FolderRef));
        
        [JsonPropertyName("folderRef")]
        public DocumentFolder? FolderRef
        {
            get => _folderRef.GetValue();
            set => _folderRef.SetValue(value);
        }
    
        private PropertyValue<DocumentContainerInfo> _containerInfo = new PropertyValue<DocumentContainerInfo>(nameof(DRDraftHeader), nameof(ContainerInfo));
        
        [Required]
        [JsonPropertyName("containerInfo")]
        public DocumentContainerInfo ContainerInfo
        {
            get => _containerInfo.GetValue();
            set => _containerInfo.SetValue(value);
        }
    
        private PropertyValue<DocumentBodyType> _bodyType = new PropertyValue<DocumentBodyType>(nameof(DRDraftHeader), nameof(BodyType));
        
        [Required]
        [JsonPropertyName("bodyType")]
        public DocumentBodyType BodyType
        {
            get => _bodyType.GetValue();
            set => _bodyType.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _title.SetAccessPath(path, validateHasBeenSet);
            _author.SetAccessPath(path, validateHasBeenSet);
            _modified.SetAccessPath(path, validateHasBeenSet);
            _created.SetAccessPath(path, validateHasBeenSet);
            _modifiedBy.SetAccessPath(path, validateHasBeenSet);
            _shared.SetAccessPath(path, validateHasBeenSet);
            _publicationDetails2.SetAccessPath(path, validateHasBeenSet);
            _deleted.SetAccessPath(path, validateHasBeenSet);
            _folder.SetAccessPath(path, validateHasBeenSet);
            _folderRef.SetAccessPath(path, validateHasBeenSet);
            _containerInfo.SetAccessPath(path, validateHasBeenSet);
            _bodyType.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
