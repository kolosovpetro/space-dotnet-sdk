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

namespace JetBrains.Space.Client.AuthModuleUsagePartialBuilder
{
    public static class AuthModuleUsagePartialExtensions
    {
        public static Partial<AuthModuleUsage> WithAuthModule(this Partial<AuthModuleUsage> it)
            => it.AddFieldName("authModule");
        
        public static Partial<AuthModuleUsage> WithAuthModule(this Partial<AuthModuleUsage> it, Func<Partial<ESAuthModule>, Partial<ESAuthModule>> partialBuilder)
            => it.AddFieldName("authModule", partialBuilder(new Partial<ESAuthModule>(it)));
        
        public static Partial<AuthModuleUsage> WithProfiles(this Partial<AuthModuleUsage> it)
            => it.AddFieldName("profiles");
        
    }
    
}
