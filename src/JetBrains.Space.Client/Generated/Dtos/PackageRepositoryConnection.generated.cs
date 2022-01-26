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

[JsonConverter(typeof(ClassNameDtoTypeConverter))]
public class PackageRepositoryConnection
     : IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public virtual string? ClassName => "PackageRepositoryConnection";
    
    public static PackageRepositoryConnectionRemote Remote(string id, bool enabled, bool rememberDownloaded, string url, PackageRepositoryCredentials credentials, List<string>? packageNameFilters = null, string? secretId = null, string? secretValue = null, PackageRepositoryConnectionSettings? settings = null)
        => new PackageRepositoryConnectionRemote(id: id, enabled: enabled, rememberDownloaded: rememberDownloaded, url: url, credentials: credentials, packageNameFilters: packageNameFilters, secretId: secretId, secretValue: secretValue, settings: settings);
    
    public static PackageRepositoryConnectionSpace Space(string id, bool enabled, bool rememberDownloaded, ProjectPackageRepository repository, List<string>? packageNameFilters = null)
        => new PackageRepositoryConnectionSpace(id: id, enabled: enabled, rememberDownloaded: rememberDownloaded, repository: repository, packageNameFilters: packageNameFilters);
    
    public PackageRepositoryConnection() { }
    
    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

