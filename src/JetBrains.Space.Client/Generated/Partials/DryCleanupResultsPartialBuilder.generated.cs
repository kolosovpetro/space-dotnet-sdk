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

namespace JetBrains.Space.Client.DryCleanupResultsPartialBuilder
{
    public static class DryCleanupResultsPartialExtensions
    {
        public static Partial<DryCleanupResults> WithTotalSize(this Partial<DryCleanupResults> it)
            => it.AddFieldName("totalSize");
        
        public static Partial<DryCleanupResults> WithPackageVersions(this Partial<DryCleanupResults> it)
            => it.AddFieldName("packageVersions");
        
        public static Partial<DryCleanupResults> WithPackageVersions(this Partial<DryCleanupResults> it, Func<Partial<PackageVersionRef>, Partial<PackageVersionRef>> partialBuilder)
            => it.AddFieldName("packageVersions", partialBuilder(new Partial<PackageVersionRef>(it)));
        
    }
    
}