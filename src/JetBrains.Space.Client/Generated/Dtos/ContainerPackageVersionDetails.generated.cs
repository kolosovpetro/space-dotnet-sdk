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
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client;

public sealed class ContainerPackageVersionDetails
     : PackageVersionDetails, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "ContainerPackageVersionDetails";
    
    public ContainerPackageVersionDetails() { }
    
    public ContainerPackageVersionDetails(PackageType type, string repository, string name, string version, long created, long downloads, bool pinned, long diskSize, int schemaVersion, string mediaType, string manifestType, List<string>? tags = null, long? accessed = null, string? comment = null, CPrincipal? author = null, List<CPrincipal>? authors = null, PackageOrigin? origin = null, Dictionary<string, string>? metadata = null, ContainerImage? image = null, ContainerHelmChart? chart = null)
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
        SchemaVersion = schemaVersion;
        MediaType = mediaType;
        ManifestType = manifestType;
        Image = image;
        Chart = chart;
    }
    
    private PropertyValue<PackageType> _type = new PropertyValue<PackageType>(nameof(ContainerPackageVersionDetails), nameof(Type), "type");
    
    [Required]
    [JsonPropertyName("type")]
    public PackageType Type
    {
        get => _type.GetValue(InlineErrors);
        set => _type.SetValue(value);
    }

    private PropertyValue<string> _repository = new PropertyValue<string>(nameof(ContainerPackageVersionDetails), nameof(Repository), "repository");
    
    [Required]
    [JsonPropertyName("repository")]
    public string Repository
    {
        get => _repository.GetValue(InlineErrors);
        set => _repository.SetValue(value);
    }

    private PropertyValue<string> _name = new PropertyValue<string>(nameof(ContainerPackageVersionDetails), nameof(Name), "name");
    
    [Required]
    [JsonPropertyName("name")]
    public string Name
    {
        get => _name.GetValue(InlineErrors);
        set => _name.SetValue(value);
    }

    private PropertyValue<string> _version = new PropertyValue<string>(nameof(ContainerPackageVersionDetails), nameof(Version), "version");
    
    [Required]
    [JsonPropertyName("version")]
    public string Version
    {
        get => _version.GetValue(InlineErrors);
        set => _version.SetValue(value);
    }

    private PropertyValue<List<string>?> _tags = new PropertyValue<List<string>?>(nameof(ContainerPackageVersionDetails), nameof(Tags), "tags");
    
    [JsonPropertyName("tags")]
    public List<string>? Tags
    {
        get => _tags.GetValue(InlineErrors);
        set => _tags.SetValue(value);
    }

    private PropertyValue<long> _created = new PropertyValue<long>(nameof(ContainerPackageVersionDetails), nameof(Created), "created");
    
    [Required]
    [JsonPropertyName("created")]
    public long Created
    {
        get => _created.GetValue(InlineErrors);
        set => _created.SetValue(value);
    }

    private PropertyValue<long?> _accessed = new PropertyValue<long?>(nameof(ContainerPackageVersionDetails), nameof(Accessed), "accessed");
    
    [JsonPropertyName("accessed")]
    public long? Accessed
    {
        get => _accessed.GetValue(InlineErrors);
        set => _accessed.SetValue(value);
    }

    private PropertyValue<long> _downloads = new PropertyValue<long>(nameof(ContainerPackageVersionDetails), nameof(Downloads), "downloads");
    
    [Required]
    [JsonPropertyName("downloads")]
    public long Downloads
    {
        get => _downloads.GetValue(InlineErrors);
        set => _downloads.SetValue(value);
    }

    private PropertyValue<bool> _pinned = new PropertyValue<bool>(nameof(ContainerPackageVersionDetails), nameof(IsPinned), "pinned");
    
    [Required]
    [JsonPropertyName("pinned")]
    public bool IsPinned
    {
        get => _pinned.GetValue(InlineErrors);
        set => _pinned.SetValue(value);
    }

    private PropertyValue<string?> _comment = new PropertyValue<string?>(nameof(ContainerPackageVersionDetails), nameof(Comment), "comment");
    
    [JsonPropertyName("comment")]
    public string? Comment
    {
        get => _comment.GetValue(InlineErrors);
        set => _comment.SetValue(value);
    }

    private PropertyValue<long> _diskSize = new PropertyValue<long>(nameof(ContainerPackageVersionDetails), nameof(DiskSize), "diskSize");
    
    [Required]
    [JsonPropertyName("diskSize")]
    public long DiskSize
    {
        get => _diskSize.GetValue(InlineErrors);
        set => _diskSize.SetValue(value);
    }

    private PropertyValue<CPrincipal?> _author = new PropertyValue<CPrincipal?>(nameof(ContainerPackageVersionDetails), nameof(Author), "author");
    
    [JsonPropertyName("author")]
    public CPrincipal? Author
    {
        get => _author.GetValue(InlineErrors);
        set => _author.SetValue(value);
    }

    private PropertyValue<List<CPrincipal>?> _authors = new PropertyValue<List<CPrincipal>?>(nameof(ContainerPackageVersionDetails), nameof(Authors), "authors");
    
    [JsonPropertyName("authors")]
    public List<CPrincipal>? Authors
    {
        get => _authors.GetValue(InlineErrors);
        set => _authors.SetValue(value);
    }

    private PropertyValue<PackageOrigin?> _origin = new PropertyValue<PackageOrigin?>(nameof(ContainerPackageVersionDetails), nameof(Origin), "origin");
    
    [JsonPropertyName("origin")]
    public PackageOrigin? Origin
    {
        get => _origin.GetValue(InlineErrors);
        set => _origin.SetValue(value);
    }

    private PropertyValue<Dictionary<string, string>?> _metadata = new PropertyValue<Dictionary<string, string>?>(nameof(ContainerPackageVersionDetails), nameof(Metadata), "metadata");
    
    [JsonPropertyName("metadata")]
    public Dictionary<string, string>? Metadata
    {
        get => _metadata.GetValue(InlineErrors);
        set => _metadata.SetValue(value);
    }

    private PropertyValue<int> _schemaVersion = new PropertyValue<int>(nameof(ContainerPackageVersionDetails), nameof(SchemaVersion), "schemaVersion");
    
    [Required]
    [JsonPropertyName("schemaVersion")]
    public int SchemaVersion
    {
        get => _schemaVersion.GetValue(InlineErrors);
        set => _schemaVersion.SetValue(value);
    }

    private PropertyValue<string> _mediaType = new PropertyValue<string>(nameof(ContainerPackageVersionDetails), nameof(MediaType), "mediaType");
    
    [Required]
    [JsonPropertyName("mediaType")]
    public string MediaType
    {
        get => _mediaType.GetValue(InlineErrors);
        set => _mediaType.SetValue(value);
    }

    private PropertyValue<string> _manifestType = new PropertyValue<string>(nameof(ContainerPackageVersionDetails), nameof(ManifestType), "manifestType");
    
    [Required]
    [JsonPropertyName("manifestType")]
    public string ManifestType
    {
        get => _manifestType.GetValue(InlineErrors);
        set => _manifestType.SetValue(value);
    }

    private PropertyValue<ContainerImage?> _image = new PropertyValue<ContainerImage?>(nameof(ContainerPackageVersionDetails), nameof(Image), "image");
    
    [JsonPropertyName("image")]
    public ContainerImage? Image
    {
        get => _image.GetValue(InlineErrors);
        set => _image.SetValue(value);
    }

    private PropertyValue<ContainerHelmChart?> _chart = new PropertyValue<ContainerHelmChart?>(nameof(ContainerPackageVersionDetails), nameof(Chart), "chart");
    
    [JsonPropertyName("chart")]
    public ContainerHelmChart? Chart
    {
        get => _chart.GetValue(InlineErrors);
        set => _chart.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _type.SetAccessPath(parentChainPath, validateHasBeenSet);
        _repository.SetAccessPath(parentChainPath, validateHasBeenSet);
        _name.SetAccessPath(parentChainPath, validateHasBeenSet);
        _version.SetAccessPath(parentChainPath, validateHasBeenSet);
        _tags.SetAccessPath(parentChainPath, validateHasBeenSet);
        _created.SetAccessPath(parentChainPath, validateHasBeenSet);
        _accessed.SetAccessPath(parentChainPath, validateHasBeenSet);
        _downloads.SetAccessPath(parentChainPath, validateHasBeenSet);
        _pinned.SetAccessPath(parentChainPath, validateHasBeenSet);
        _comment.SetAccessPath(parentChainPath, validateHasBeenSet);
        _diskSize.SetAccessPath(parentChainPath, validateHasBeenSet);
        _author.SetAccessPath(parentChainPath, validateHasBeenSet);
        _authors.SetAccessPath(parentChainPath, validateHasBeenSet);
        _origin.SetAccessPath(parentChainPath, validateHasBeenSet);
        _metadata.SetAccessPath(parentChainPath, validateHasBeenSet);
        _schemaVersion.SetAccessPath(parentChainPath, validateHasBeenSet);
        _mediaType.SetAccessPath(parentChainPath, validateHasBeenSet);
        _manifestType.SetAccessPath(parentChainPath, validateHasBeenSet);
        _image.SetAccessPath(parentChainPath, validateHasBeenSet);
        _chart.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

