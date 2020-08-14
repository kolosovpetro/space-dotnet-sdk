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

namespace SpaceDotNet.Client.VoteGroupDtoPartialBuilder
{
    public static class VoteGroupDtoPartialExtensions
    {
        public static Partial<VoteGroupDto> WithVariantName(this Partial<VoteGroupDto> it)
            => it.AddFieldName("variantName");
        
        public static Partial<VoteGroupDto> WithCount(this Partial<VoteGroupDto> it)
            => it.AddFieldName("count");
        
        public static Partial<VoteGroupDto> WithMeVote(this Partial<VoteGroupDto> it)
            => it.AddFieldName("meVote");
        
        public static Partial<VoteGroupDto> WithLastUsers(this Partial<VoteGroupDto> it)
            => it.AddFieldName("lastUsers");
        
        public static Partial<VoteGroupDto> WithLastUsers(this Partial<VoteGroupDto> it, Func<Partial<TDMemberProfileDto>, Partial<TDMemberProfileDto>> partialBuilder)
            => it.AddFieldName("lastUsers", partialBuilder(new Partial<TDMemberProfileDto>(it)));
        
        public static Partial<VoteGroupDto> WithOwner(this Partial<VoteGroupDto> it)
            => it.AddFieldName("owner");
        
        public static Partial<VoteGroupDto> WithOwner(this Partial<VoteGroupDto> it, Func<Partial<TDMemberProfileDto>, Partial<TDMemberProfileDto>> partialBuilder)
            => it.AddFieldName("owner", partialBuilder(new Partial<TDMemberProfileDto>(it)));
        
    }
    
}
