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

namespace JetBrains.Space.Client.PackageRepositoryConnectionRemotePartialBuilder
{
    public static class PackageRepositoryConnectionRemotePartialExtensions
    {
        public static Partial<PackageRepositoryConnectionRemote> WithId(this Partial<PackageRepositoryConnectionRemote> it)
            => it.AddFieldName("id");
        
        public static Partial<PackageRepositoryConnectionRemote> WithUrl(this Partial<PackageRepositoryConnectionRemote> it)
            => it.AddFieldName("url");
        
        public static Partial<PackageRepositoryConnectionRemote> WithCredentials(this Partial<PackageRepositoryConnectionRemote> it)
            => it.AddFieldName("credentials");
        
        public static Partial<PackageRepositoryConnectionRemote> WithCredentials(this Partial<PackageRepositoryConnectionRemote> it, Func<Partial<PackageRepositoryCredentials>, Partial<PackageRepositoryCredentials>> partialBuilder)
            => it.AddFieldName("credentials", partialBuilder(new Partial<PackageRepositoryCredentials>(it)));
        
        public static Partial<PackageRepositoryConnectionRemote> WithSecretId(this Partial<PackageRepositoryConnectionRemote> it)
            => it.AddFieldName("secretId");
        
        public static Partial<PackageRepositoryConnectionRemote> WithSecretValue(this Partial<PackageRepositoryConnectionRemote> it)
            => it.AddFieldName("secretValue");
        
        public static Partial<PackageRepositoryConnectionRemote> WithParameters(this Partial<PackageRepositoryConnectionRemote> it)
            => it.AddFieldName("parameters");
        
        public static Partial<PackageRepositoryConnectionRemote> WithParameters(this Partial<PackageRepositoryConnectionRemote> it, Func<Partial<Pair<string, string>>, Partial<Pair<string, string>>> partialBuilder)
            => it.AddFieldName("parameters", partialBuilder(new Partial<Pair<string, string>>(it)));
        
    }
    
}
