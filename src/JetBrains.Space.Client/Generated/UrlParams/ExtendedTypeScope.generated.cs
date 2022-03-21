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

[JsonConverter(typeof(UrlParameterConverter))]
public abstract class ExtendedTypeScope : IUrlParameter
{
    public static ExtendedTypeScope Container(string containerId)
        => new ExtendedTypeScopeContainer(containerId);
    
    public static ExtendedTypeScope Org
        => new ExtendedTypeScopeOrg();
    
    public class ExtendedTypeScopeContainer : ExtendedTypeScope
    {
        [Required]
        [JsonPropertyName("containerId")]
#if NET6_0_OR_GREATER
        public string ContainerId { get; init; }
#else
        public string ContainerId { get; set; }
#endif
        
#if !NET6_0_OR_GREATER
#pragma warning disable CS8618
        public ExtendedTypeScopeContainer() { }
#pragma warning restore CS8618
#endif
        
        public ExtendedTypeScopeContainer(string containerId)
        {
            ContainerId = containerId;
        }
        
        public override string ToString()
            => $"containerId:{ContainerId}";
    }
    
    public class ExtendedTypeScopeOrg : ExtendedTypeScope
    {
        public override string ToString()
            => "org";
    }
    
}

