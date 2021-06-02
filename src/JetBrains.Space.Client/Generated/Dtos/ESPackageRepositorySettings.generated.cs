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
    [JsonConverter(typeof(ClassNameDtoTypeConverter))]
    public abstract class ESPackageRepositorySettings
         : IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public virtual string? ClassName => "ES_PackageRepositorySettings";
        
        public static ESContainerRegistrySettings ESContainerRegistrySettings(bool immutableTags, RetentionPolicyParams? retentionPolicyParams = null, bool? immutablePackageVersions = null)
            => new ESContainerRegistrySettings(immutableTags: immutableTags, retentionPolicyParams: retentionPolicyParams, immutablePackageVersions: immutablePackageVersions);
        
        public static ESMavenRepositorySettings ESMavenRepositorySettings(bool enableSnapshots, RetentionPolicyParams? retentionPolicyParams = null, bool? immutablePackageVersions = null)
            => new ESMavenRepositorySettings(enableSnapshots: enableSnapshots, retentionPolicyParams: retentionPolicyParams, immutablePackageVersions: immutablePackageVersions);
        
        public static ESNpmRegistrySettings ESNpmRegistrySettings(RetentionPolicyParams? retentionPolicyParams = null, bool? immutablePackageVersions = null)
            => new ESNpmRegistrySettings(retentionPolicyParams: retentionPolicyParams, immutablePackageVersions: immutablePackageVersions);
        
        public static ESNuGetFeedSettings ESNuGetFeedSettings(RetentionPolicyParams? retentionPolicyParams = null, bool? immutablePackageVersions = null)
            => new ESNuGetFeedSettings(retentionPolicyParams: retentionPolicyParams, immutablePackageVersions: immutablePackageVersions);
        
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
        }
    
    }
    
}
