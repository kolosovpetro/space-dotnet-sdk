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

namespace JetBrains.Space.Client.HATypeArrayPartialBuilder
{
    public static class HATypeArrayPartialExtensions
    {
        public static Partial<HATypeArray> WithElementType(this Partial<HATypeArray> it)
            => it.AddFieldName("elementType");
        
        public static Partial<HATypeArray> WithElementType(this Partial<HATypeArray> it, Func<Partial<HAType>, Partial<HAType>> partialBuilder)
            => it.AddFieldName("elementType", partialBuilder(new Partial<HAType>(it)));
        
        public static Partial<HATypeArray> WithIsNullable(this Partial<HATypeArray> it)
            => it.AddFieldName("nullable");
        
        public static Partial<HATypeArray> WithTags(this Partial<HATypeArray> it)
            => it.AddFieldName("tags");
        
    }
    
}
