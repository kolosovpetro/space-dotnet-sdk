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

namespace SpaceDotNet.Client.EnumListCFValuePartialBuilder
{
    public static class EnumListCFValuePartialExtensions
    {
        public static Partial<EnumListCFValue> WithValues(this Partial<EnumListCFValue> it)
            => it.AddFieldName("values");
        
        public static Partial<EnumListCFValue> WithValues(this Partial<EnumListCFValue> it, Func<Partial<EnumValueData>, Partial<EnumValueData>> partialBuilder)
            => it.AddFieldName("values", partialBuilder(new Partial<EnumValueData>(it)));
        
    }
    
}