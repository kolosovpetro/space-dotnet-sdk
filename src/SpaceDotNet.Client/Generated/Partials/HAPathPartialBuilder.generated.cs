// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS0108

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client.HAPathPartialBuilder
{
    public static class HAPathPartialExtensions
    {
        public static Partial<HAPath> WithSegments(this Partial<HAPath> it)
            => it.AddFieldName("segments");
        
        public static Partial<HAPath> WithSegments(this Partial<HAPath> it, Func<Partial<HAPathSegment>, Partial<HAPathSegment>> partialBuilder)
            => it.AddFieldName("segments", partialBuilder(new Partial<HAPathSegment>(it)));
        
    }
    
}