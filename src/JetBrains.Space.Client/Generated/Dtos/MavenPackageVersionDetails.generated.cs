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
    public sealed class MavenPackageVersionDetails
         : PackageVersionDetails, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "MavenPackageVersionDetails";
        
        public MavenPackageVersionDetails() { }
        
        public MavenPackageVersionDetails(PackageType type, string repository, string name, string version, long created, long downloads, bool pinned, long diskSize, List<string> licenses, List<MavenPackageDependency> dependencies, List<MavenPackageFile> files, List<string>? tags = null, long? accessed = null, string? comment = null, CPrincipal? author = null, List<CPrincipal>? authors = null, PackageOrigin? origin = null, Dictionary<string, string>? metadata = null, string? packaging = null, string? packageName = null, string? description = null, string? url = null, string? scmUrl = null, List<KotlinPlatform>? kotlinPlatforms = null, MavenPackageParent? parent = null, string? pathPrefix = null)
        {
            Type = type;
            Repository = repository;
            Name = name;
            Version = version;
            Tags = tags;
            Created = created;
            Accessed = accessed;
            Downloads = downloads;
            IsPinned = pinned;
            Comment = comment;
            DiskSize = diskSize;
            Author = author;
            Authors = authors;
            Origin = origin;
            Metadata = metadata;
            Packaging = packaging;
            PackageName = packageName;
            Description = description;
            Url = url;
            Licenses = licenses;
            ScmUrl = scmUrl;
            Dependencies = dependencies;
            KotlinPlatforms = kotlinPlatforms;
            Parent = parent;
            PathPrefix = pathPrefix;
            Files = files;
        }
        
        private PropertyValue<PackageType> _type = new PropertyValue<PackageType>(nameof(MavenPackageVersionDetails), nameof(Type));
        
        [Required]
        [JsonPropertyName("type")]
        public PackageType Type
        {
            get => _type.GetValue();
            set => _type.SetValue(value);
        }
    
        private PropertyValue<string> _repository = new PropertyValue<string>(nameof(MavenPackageVersionDetails), nameof(Repository));
        
        [Required]
        [JsonPropertyName("repository")]
        public string Repository
        {
            get => _repository.GetValue();
            set => _repository.SetValue(value);
        }
    
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(MavenPackageVersionDetails), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get => _name.GetValue();
            set => _name.SetValue(value);
        }
    
        private PropertyValue<string> _version = new PropertyValue<string>(nameof(MavenPackageVersionDetails), nameof(Version));
        
        [Required]
        [JsonPropertyName("version")]
        public string Version
        {
            get => _version.GetValue();
            set => _version.SetValue(value);
        }
    
        private PropertyValue<List<string>?> _tags = new PropertyValue<List<string>?>(nameof(MavenPackageVersionDetails), nameof(Tags));
        
        [JsonPropertyName("tags")]
        public List<string>? Tags
        {
            get => _tags.GetValue();
            set => _tags.SetValue(value);
        }
    
        private PropertyValue<long> _created = new PropertyValue<long>(nameof(MavenPackageVersionDetails), nameof(Created));
        
        [Required]
        [JsonPropertyName("created")]
        public long Created
        {
            get => _created.GetValue();
            set => _created.SetValue(value);
        }
    
        private PropertyValue<long?> _accessed = new PropertyValue<long?>(nameof(MavenPackageVersionDetails), nameof(Accessed));
        
        [JsonPropertyName("accessed")]
        public long? Accessed
        {
            get => _accessed.GetValue();
            set => _accessed.SetValue(value);
        }
    
        private PropertyValue<long> _downloads = new PropertyValue<long>(nameof(MavenPackageVersionDetails), nameof(Downloads));
        
        [Required]
        [JsonPropertyName("downloads")]
        public long Downloads
        {
            get => _downloads.GetValue();
            set => _downloads.SetValue(value);
        }
    
        private PropertyValue<bool> _pinned = new PropertyValue<bool>(nameof(MavenPackageVersionDetails), nameof(IsPinned));
        
        [Required]
        [JsonPropertyName("pinned")]
        public bool IsPinned
        {
            get => _pinned.GetValue();
            set => _pinned.SetValue(value);
        }
    
        private PropertyValue<string?> _comment = new PropertyValue<string?>(nameof(MavenPackageVersionDetails), nameof(Comment));
        
        [JsonPropertyName("comment")]
        public string? Comment
        {
            get => _comment.GetValue();
            set => _comment.SetValue(value);
        }
    
        private PropertyValue<long> _diskSize = new PropertyValue<long>(nameof(MavenPackageVersionDetails), nameof(DiskSize));
        
        [Required]
        [JsonPropertyName("diskSize")]
        public long DiskSize
        {
            get => _diskSize.GetValue();
            set => _diskSize.SetValue(value);
        }
    
        private PropertyValue<CPrincipal?> _author = new PropertyValue<CPrincipal?>(nameof(MavenPackageVersionDetails), nameof(Author));
        
        [JsonPropertyName("author")]
        public CPrincipal? Author
        {
            get => _author.GetValue();
            set => _author.SetValue(value);
        }
    
        private PropertyValue<List<CPrincipal>?> _authors = new PropertyValue<List<CPrincipal>?>(nameof(MavenPackageVersionDetails), nameof(Authors));
        
        [JsonPropertyName("authors")]
        public List<CPrincipal>? Authors
        {
            get => _authors.GetValue();
            set => _authors.SetValue(value);
        }
    
        private PropertyValue<PackageOrigin?> _origin = new PropertyValue<PackageOrigin?>(nameof(MavenPackageVersionDetails), nameof(Origin));
        
        [JsonPropertyName("origin")]
        public PackageOrigin? Origin
        {
            get => _origin.GetValue();
            set => _origin.SetValue(value);
        }
    
        private PropertyValue<Dictionary<string, string>?> _metadata = new PropertyValue<Dictionary<string, string>?>(nameof(MavenPackageVersionDetails), nameof(Metadata));
        
        [JsonPropertyName("metadata")]
        public Dictionary<string, string>? Metadata
        {
            get => _metadata.GetValue();
            set => _metadata.SetValue(value);
        }
    
        private PropertyValue<string?> _packaging = new PropertyValue<string?>(nameof(MavenPackageVersionDetails), nameof(Packaging));
        
        [JsonPropertyName("packaging")]
        public string? Packaging
        {
            get => _packaging.GetValue();
            set => _packaging.SetValue(value);
        }
    
        private PropertyValue<string?> _packageName = new PropertyValue<string?>(nameof(MavenPackageVersionDetails), nameof(PackageName));
        
        [JsonPropertyName("packageName")]
        public string? PackageName
        {
            get => _packageName.GetValue();
            set => _packageName.SetValue(value);
        }
    
        private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(MavenPackageVersionDetails), nameof(Description));
        
        [JsonPropertyName("description")]
        public string? Description
        {
            get => _description.GetValue();
            set => _description.SetValue(value);
        }
    
        private PropertyValue<string?> _url = new PropertyValue<string?>(nameof(MavenPackageVersionDetails), nameof(Url));
        
        [JsonPropertyName("url")]
        public string? Url
        {
            get => _url.GetValue();
            set => _url.SetValue(value);
        }
    
        private PropertyValue<List<string>> _licenses = new PropertyValue<List<string>>(nameof(MavenPackageVersionDetails), nameof(Licenses), new List<string>());
        
        [Required]
        [JsonPropertyName("licenses")]
        public List<string> Licenses
        {
            get => _licenses.GetValue();
            set => _licenses.SetValue(value);
        }
    
        private PropertyValue<string?> _scmUrl = new PropertyValue<string?>(nameof(MavenPackageVersionDetails), nameof(ScmUrl));
        
        [JsonPropertyName("scmUrl")]
        public string? ScmUrl
        {
            get => _scmUrl.GetValue();
            set => _scmUrl.SetValue(value);
        }
    
        private PropertyValue<List<MavenPackageDependency>> _dependencies = new PropertyValue<List<MavenPackageDependency>>(nameof(MavenPackageVersionDetails), nameof(Dependencies), new List<MavenPackageDependency>());
        
        [Required]
        [JsonPropertyName("dependencies")]
        public List<MavenPackageDependency> Dependencies
        {
            get => _dependencies.GetValue();
            set => _dependencies.SetValue(value);
        }
    
        private PropertyValue<List<KotlinPlatform>?> _kotlinPlatforms = new PropertyValue<List<KotlinPlatform>?>(nameof(MavenPackageVersionDetails), nameof(KotlinPlatforms));
        
        [JsonPropertyName("kotlinPlatforms")]
        public List<KotlinPlatform>? KotlinPlatforms
        {
            get => _kotlinPlatforms.GetValue();
            set => _kotlinPlatforms.SetValue(value);
        }
    
        private PropertyValue<MavenPackageParent?> _parent = new PropertyValue<MavenPackageParent?>(nameof(MavenPackageVersionDetails), nameof(Parent));
        
        [JsonPropertyName("parent")]
        public MavenPackageParent? Parent
        {
            get => _parent.GetValue();
            set => _parent.SetValue(value);
        }
    
        private PropertyValue<string?> _pathPrefix = new PropertyValue<string?>(nameof(MavenPackageVersionDetails), nameof(PathPrefix));
        
        [JsonPropertyName("pathPrefix")]
        public string? PathPrefix
        {
            get => _pathPrefix.GetValue();
            set => _pathPrefix.SetValue(value);
        }
    
        private PropertyValue<List<MavenPackageFile>> _files = new PropertyValue<List<MavenPackageFile>>(nameof(MavenPackageVersionDetails), nameof(Files), new List<MavenPackageFile>());
        
        [Required]
        [JsonPropertyName("files")]
        public List<MavenPackageFile> Files
        {
            get => _files.GetValue();
            set => _files.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _type.SetAccessPath(path, validateHasBeenSet);
            _repository.SetAccessPath(path, validateHasBeenSet);
            _name.SetAccessPath(path, validateHasBeenSet);
            _version.SetAccessPath(path, validateHasBeenSet);
            _tags.SetAccessPath(path, validateHasBeenSet);
            _created.SetAccessPath(path, validateHasBeenSet);
            _accessed.SetAccessPath(path, validateHasBeenSet);
            _downloads.SetAccessPath(path, validateHasBeenSet);
            _pinned.SetAccessPath(path, validateHasBeenSet);
            _comment.SetAccessPath(path, validateHasBeenSet);
            _diskSize.SetAccessPath(path, validateHasBeenSet);
            _author.SetAccessPath(path, validateHasBeenSet);
            _authors.SetAccessPath(path, validateHasBeenSet);
            _origin.SetAccessPath(path, validateHasBeenSet);
            _metadata.SetAccessPath(path, validateHasBeenSet);
            _packaging.SetAccessPath(path, validateHasBeenSet);
            _packageName.SetAccessPath(path, validateHasBeenSet);
            _description.SetAccessPath(path, validateHasBeenSet);
            _url.SetAccessPath(path, validateHasBeenSet);
            _licenses.SetAccessPath(path, validateHasBeenSet);
            _scmUrl.SetAccessPath(path, validateHasBeenSet);
            _dependencies.SetAccessPath(path, validateHasBeenSet);
            _kotlinPlatforms.SetAccessPath(path, validateHasBeenSet);
            _parent.SetAccessPath(path, validateHasBeenSet);
            _pathPrefix.SetAccessPath(path, validateHasBeenSet);
            _files.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
