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

namespace JetBrains.Space.Client.StickerVariantPartialBuilder
{
    public static class StickerVariantPartialExtensions
    {
        public static Partial<StickerVariant> WithId(this Partial<StickerVariant> it)
            => it.AddFieldName("id");
        
        public static Partial<StickerVariant> WithName(this Partial<StickerVariant> it)
            => it.AddFieldName("name");
        
        public static Partial<StickerVariant> WithWidth(this Partial<StickerVariant> it)
            => it.AddFieldName("width");
        
        public static Partial<StickerVariant> WithHeight(this Partial<StickerVariant> it)
            => it.AddFieldName("height");
        
    }
    
}