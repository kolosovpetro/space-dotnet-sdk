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

namespace JetBrains.Space.Client
{
    [JsonConverter(typeof(EnumerationConverter))]
    public sealed class ClientBrowser : Enumeration
    {
        private ClientBrowser(string value) : base(value) { }
        
        public static readonly ClientBrowser Other = new ClientBrowser("Other");
        public static readonly ClientBrowser Chrome = new ClientBrowser("Chrome");
        public static readonly ClientBrowser Firefox = new ClientBrowser("Firefox");
        public static readonly ClientBrowser Safari = new ClientBrowser("Safari");
        public static readonly ClientBrowser Edge = new ClientBrowser("Edge");
        public static readonly ClientBrowser Opera = new ClientBrowser("Opera");
    }
    
}