// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    [JsonConverter(typeof(EnumerationConverter))]
    public sealed class HierarchyRole : Enumeration
    {
        private HierarchyRole(string value) : base(value) { }
        
        public static readonly HierarchyRole SEALED = new HierarchyRole("SEALED");
        public static readonly HierarchyRole OPEN = new HierarchyRole("OPEN");
        public static readonly HierarchyRole FINAL = new HierarchyRole("FINAL");
        public static readonly HierarchyRole ABSTRACT = new HierarchyRole("ABSTRACT");
        public static readonly HierarchyRole INTERFACE = new HierarchyRole("INTERFACE");
    }
    
}
