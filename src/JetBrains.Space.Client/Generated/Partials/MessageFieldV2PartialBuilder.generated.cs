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

namespace JetBrains.Space.Client.MessageFieldV2PartialBuilder;

public static class MessageFieldV2PartialExtensions
{
    public static Partial<MessageFieldV2> WithFirst(this Partial<MessageFieldV2> it)
        => it.AddFieldName("first");
    
    public static Partial<MessageFieldV2> WithFirst(this Partial<MessageFieldV2> it, Func<Partial<MessageInlineElement>, Partial<MessageInlineElement>> partialBuilder)
        => it.AddFieldName("first", partialBuilder(new Partial<MessageInlineElement>(it)));
    
    public static Partial<MessageFieldV2> WithSecond(this Partial<MessageFieldV2> it)
        => it.AddFieldName("second");
    
    public static Partial<MessageFieldV2> WithSecond(this Partial<MessageFieldV2> it, Func<Partial<MessageInlineElement>, Partial<MessageInlineElement>> partialBuilder)
        => it.AddFieldName("second", partialBuilder(new Partial<MessageInlineElement>(it)));
    
}
