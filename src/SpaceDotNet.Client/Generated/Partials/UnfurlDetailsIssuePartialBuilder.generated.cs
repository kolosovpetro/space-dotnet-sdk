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

namespace SpaceDotNet.Client.UnfurlDetailsIssuePartialBuilder
{
    public static class UnfurlDetailsIssuePartialExtensions
    {
        public static Partial<UnfurlDetailsIssue> WithIssue(this Partial<UnfurlDetailsIssue> it)
            => it.AddFieldName("issue");
        
        public static Partial<UnfurlDetailsIssue> WithIssue(this Partial<UnfurlDetailsIssue> it, Func<Partial<Issue>, Partial<Issue>> partialBuilder)
            => it.AddFieldName("issue", partialBuilder(new Partial<Issue>(it)));
        
    }
    
}