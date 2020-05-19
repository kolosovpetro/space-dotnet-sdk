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
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client.RevisionAuthorExtensions
{
    public static class RevisionAuthorDtoPartialExtensions
    {
        public static Partial<RevisionAuthorDto> WithAuthorName(this Partial<RevisionAuthorDto> it)
            => it.AddFieldName("authorName");
        
        public static Partial<RevisionAuthorDto> WithProfile(this Partial<RevisionAuthorDto> it)
            => it.AddFieldName("profile");
        
        public static Partial<RevisionAuthorDto> WithProfile(this Partial<RevisionAuthorDto> it, Func<Partial<TDMemberProfileDto>, Partial<TDMemberProfileDto>> partialBuilder)
            => it.AddFieldName("profile", partialBuilder(new Partial<TDMemberProfileDto>()));
        
    }
    
}