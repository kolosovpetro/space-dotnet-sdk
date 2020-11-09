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

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Client.Internal;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client.MavenPackageVersionDetailsPartialBuilder
{
    public static class MavenPackageVersionDetailsPartialExtensions
    {
        public static Partial<MavenPackageVersionDetails> WithType(this Partial<MavenPackageVersionDetails> it)
            => it.AddFieldName("type");
        
        public static Partial<MavenPackageVersionDetails> WithType(this Partial<MavenPackageVersionDetails> it, Func<Partial<PackageType>, Partial<PackageType>> partialBuilder)
            => it.AddFieldName("type", partialBuilder(new Partial<PackageType>(it)));
        
        public static Partial<MavenPackageVersionDetails> WithRepository(this Partial<MavenPackageVersionDetails> it)
            => it.AddFieldName("repository");
        
        public static Partial<MavenPackageVersionDetails> WithName(this Partial<MavenPackageVersionDetails> it)
            => it.AddFieldName("name");
        
        public static Partial<MavenPackageVersionDetails> WithVersion(this Partial<MavenPackageVersionDetails> it)
            => it.AddFieldName("version");
        
        public static Partial<MavenPackageVersionDetails> WithTags(this Partial<MavenPackageVersionDetails> it)
            => it.AddFieldName("tags");
        
        public static Partial<MavenPackageVersionDetails> WithCreated(this Partial<MavenPackageVersionDetails> it)
            => it.AddFieldName("created");
        
        public static Partial<MavenPackageVersionDetails> WithAccessed(this Partial<MavenPackageVersionDetails> it)
            => it.AddFieldName("accessed");
        
        public static Partial<MavenPackageVersionDetails> WithDownloads(this Partial<MavenPackageVersionDetails> it)
            => it.AddFieldName("downloads");
        
        public static Partial<MavenPackageVersionDetails> WithDiskSize(this Partial<MavenPackageVersionDetails> it)
            => it.AddFieldName("diskSize");
        
        public static Partial<MavenPackageVersionDetails> WithAuthor(this Partial<MavenPackageVersionDetails> it)
            => it.AddFieldName("author");
        
        public static Partial<MavenPackageVersionDetails> WithAuthor(this Partial<MavenPackageVersionDetails> it, Func<Partial<CPrincipal>, Partial<CPrincipal>> partialBuilder)
            => it.AddFieldName("author", partialBuilder(new Partial<CPrincipal>(it)));
        
        public static Partial<MavenPackageVersionDetails> WithAuthors(this Partial<MavenPackageVersionDetails> it)
            => it.AddFieldName("authors");
        
        public static Partial<MavenPackageVersionDetails> WithAuthors(this Partial<MavenPackageVersionDetails> it, Func<Partial<CPrincipal>, Partial<CPrincipal>> partialBuilder)
            => it.AddFieldName("authors", partialBuilder(new Partial<CPrincipal>(it)));
        
        public static Partial<MavenPackageVersionDetails> WithMetadata(this Partial<MavenPackageVersionDetails> it)
            => it.AddFieldName("metadata");
        
        public static Partial<MavenPackageVersionDetails> WithMetadata(this Partial<MavenPackageVersionDetails> it, Func<Partial<string>, Partial<string>> partialBuilder)
            => it.AddFieldName("metadata", partialBuilder(new Partial<string>(it)));
        
        public static Partial<MavenPackageVersionDetails> WithPackaging(this Partial<MavenPackageVersionDetails> it)
            => it.AddFieldName("packaging");
        
        public static Partial<MavenPackageVersionDetails> WithPackageName(this Partial<MavenPackageVersionDetails> it)
            => it.AddFieldName("packageName");
        
        public static Partial<MavenPackageVersionDetails> WithDescription(this Partial<MavenPackageVersionDetails> it)
            => it.AddFieldName("description");
        
        public static Partial<MavenPackageVersionDetails> WithUrl(this Partial<MavenPackageVersionDetails> it)
            => it.AddFieldName("url");
        
        public static Partial<MavenPackageVersionDetails> WithLicenses(this Partial<MavenPackageVersionDetails> it)
            => it.AddFieldName("licenses");
        
        public static Partial<MavenPackageVersionDetails> WithScmUrl(this Partial<MavenPackageVersionDetails> it)
            => it.AddFieldName("scmUrl");
        
        public static Partial<MavenPackageVersionDetails> WithDependencies(this Partial<MavenPackageVersionDetails> it)
            => it.AddFieldName("dependencies");
        
        public static Partial<MavenPackageVersionDetails> WithDependencies(this Partial<MavenPackageVersionDetails> it, Func<Partial<MavenPackageDependency>, Partial<MavenPackageDependency>> partialBuilder)
            => it.AddFieldName("dependencies", partialBuilder(new Partial<MavenPackageDependency>(it)));
        
        public static Partial<MavenPackageVersionDetails> WithKotlinPlatforms(this Partial<MavenPackageVersionDetails> it)
            => it.AddFieldName("kotlinPlatforms");
        
        public static Partial<MavenPackageVersionDetails> WithKotlinPlatforms(this Partial<MavenPackageVersionDetails> it, Func<Partial<KotlinPlatform>, Partial<KotlinPlatform>> partialBuilder)
            => it.AddFieldName("kotlinPlatforms", partialBuilder(new Partial<KotlinPlatform>(it)));
        
        public static Partial<MavenPackageVersionDetails> WithParent(this Partial<MavenPackageVersionDetails> it)
            => it.AddFieldName("parent");
        
        public static Partial<MavenPackageVersionDetails> WithParent(this Partial<MavenPackageVersionDetails> it, Func<Partial<MavenPackageParent>, Partial<MavenPackageParent>> partialBuilder)
            => it.AddFieldName("parent", partialBuilder(new Partial<MavenPackageParent>(it)));
        
        public static Partial<MavenPackageVersionDetails> WithPathPrefix(this Partial<MavenPackageVersionDetails> it)
            => it.AddFieldName("pathPrefix");
        
        public static Partial<MavenPackageVersionDetails> WithFiles(this Partial<MavenPackageVersionDetails> it)
            => it.AddFieldName("files");
        
        public static Partial<MavenPackageVersionDetails> WithFiles(this Partial<MavenPackageVersionDetails> it, Func<Partial<MavenPackageFile>, Partial<MavenPackageFile>> partialBuilder)
            => it.AddFieldName("files", partialBuilder(new Partial<MavenPackageFile>(it)));
        
    }
    
}
