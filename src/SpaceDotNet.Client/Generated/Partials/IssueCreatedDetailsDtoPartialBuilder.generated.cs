// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client.IssueCreatedDetailsDtoPartialBuilder
{
    public static class IssueCreatedDetailsDtoPartialExtensions
    {
        public static Partial<IssueCreatedDetailsDto> WithIssue(this Partial<IssueCreatedDetailsDto> it)
            => it.AddFieldName("issue");
        
        public static Partial<IssueCreatedDetailsDto> WithIssue(this Partial<IssueCreatedDetailsDto> it, Func<Partial<IssueDto>, Partial<IssueDto>> partialBuilder)
            => it.AddFieldName("issue", partialBuilder(new Partial<IssueDto>(it)));
        
    }
    
}
