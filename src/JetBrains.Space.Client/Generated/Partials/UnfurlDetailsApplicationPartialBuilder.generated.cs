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

namespace JetBrains.Space.Client.UnfurlDetailsApplicationPartialBuilder
{
    public static class UnfurlDetailsApplicationPartialExtensions
    {
        public static Partial<UnfurlDetailsApplication> WithApp(this Partial<UnfurlDetailsApplication> it)
            => it.AddFieldName("app");
        
        public static Partial<UnfurlDetailsApplication> WithApp(this Partial<UnfurlDetailsApplication> it, Func<Partial<ESApp>, Partial<ESApp>> partialBuilder)
            => it.AddFieldName("app", partialBuilder(new Partial<ESApp>(it)));
        
    }
    
}
