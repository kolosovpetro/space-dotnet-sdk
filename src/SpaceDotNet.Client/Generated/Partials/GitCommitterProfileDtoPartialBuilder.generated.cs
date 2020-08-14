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

namespace SpaceDotNet.Client.GitCommitterProfileDtoPartialBuilder
{
    public static class GitCommitterProfileDtoPartialExtensions
    {
        public static Partial<GitCommitterProfileDto> WithAuthor(this Partial<GitCommitterProfileDto> it)
            => it.AddFieldName("author");
        
        public static Partial<GitCommitterProfileDto> WithEmail(this Partial<GitCommitterProfileDto> it)
            => it.AddFieldName("email");
        
        public static Partial<GitCommitterProfileDto> WithProfile(this Partial<GitCommitterProfileDto> it)
            => it.AddFieldName("profile");
        
        public static Partial<GitCommitterProfileDto> WithProfile(this Partial<GitCommitterProfileDto> it, Func<Partial<TDMemberProfileDto>, Partial<TDMemberProfileDto>> partialBuilder)
            => it.AddFieldName("profile", partialBuilder(new Partial<TDMemberProfileDto>(it)));
        
    }
    
}
