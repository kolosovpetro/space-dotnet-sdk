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

namespace JetBrains.Space.Client.CallSessionPartialBuilder;

public static class CallSessionPartialExtensions
{
    public static Partial<CallSession> WithId(this Partial<CallSession> it)
        => it.AddFieldName("id");
    
    public static Partial<CallSession> WithIsArchived(this Partial<CallSession> it)
        => it.AddFieldName("archived");
    
    public static Partial<CallSession> WithRoom(this Partial<CallSession> it)
        => it.AddFieldName("room");
    
    public static Partial<CallSession> WithRoom(this Partial<CallSession> it, Func<Partial<Room>, Partial<Room>> partialBuilder)
        => it.AddFieldName("room", partialBuilder(new Partial<Room>(it)));
    
    public static Partial<CallSession> WithDescription(this Partial<CallSession> it)
        => it.AddFieldName("description");
    
    public static Partial<CallSession> WithStart(this Partial<CallSession> it)
        => it.AddFieldName("start");
    
    public static Partial<CallSession> WithEnd(this Partial<CallSession> it)
        => it.AddFieldName("end");
    
    public static Partial<CallSession> WithChannel(this Partial<CallSession> it)
        => it.AddFieldName("channel");
    
    public static Partial<CallSession> WithChannel(this Partial<CallSession> it, Func<Partial<M2ChannelRecord>, Partial<M2ChannelRecord>> partialBuilder)
        => it.AddFieldName("channel", partialBuilder(new Partial<M2ChannelRecord>(it)));
    
    public static Partial<CallSession> WithTopology(this Partial<CallSession> it)
        => it.AddFieldName("topology");
    
    public static Partial<CallSession> WithTopology(this Partial<CallSession> it, Func<Partial<ConnectionTopology>, Partial<ConnectionTopology>> partialBuilder)
        => it.AddFieldName("topology", partialBuilder(new Partial<ConnectionTopology>(it)));
    
    public static Partial<CallSession> WithIsResourcesPrepared(this Partial<CallSession> it)
        => it.AddFieldName("resourcesPrepared");
    
}

