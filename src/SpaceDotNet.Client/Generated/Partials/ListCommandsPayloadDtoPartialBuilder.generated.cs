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

namespace SpaceDotNet.Client.ListCommandsPayloadDtoPartialBuilder
{
    public static class ListCommandsPayloadDtoPartialExtensions
    {
        public static Partial<ListCommandsPayloadDto> WithAccessToken(this Partial<ListCommandsPayloadDto> it)
            => it.AddFieldName("accessToken");
        
        public static Partial<ListCommandsPayloadDto> WithVerificationToken(this Partial<ListCommandsPayloadDto> it)
            => it.AddFieldName("verificationToken");
        
        public static Partial<ListCommandsPayloadDto> WithUserId(this Partial<ListCommandsPayloadDto> it)
            => it.AddFieldName("userId");
        
    }
    
}
