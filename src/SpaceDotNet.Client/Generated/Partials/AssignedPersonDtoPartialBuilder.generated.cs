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

namespace SpaceDotNet.Client.AssignedPersonDtoPartialBuilder
{
    public static class AssignedPersonDtoPartialExtensions
    {
        public static Partial<AssignedPersonDto> WithProfile(this Partial<AssignedPersonDto> it)
            => it.AddFieldName("profile");
        
        public static Partial<AssignedPersonDto> WithProfile(this Partial<AssignedPersonDto> it, Func<Partial<TDMemberProfileDto>, Partial<TDMemberProfileDto>> partialBuilder)
            => it.AddFieldName("profile", partialBuilder(new Partial<TDMemberProfileDto>(it)));
        
        public static Partial<AssignedPersonDto> WithRole(this Partial<AssignedPersonDto> it)
            => it.AddFieldName("role");
        
    }
    
}
