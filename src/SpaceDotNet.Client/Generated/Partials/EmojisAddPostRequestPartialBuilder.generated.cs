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

namespace SpaceDotNet.Client.EmojisAddPostRequestPartialBuilder
{
    public static class EmojisAddPostRequestPartialExtensions
    {
        public static Partial<EmojisAddPostRequest> WithEmoji(this Partial<EmojisAddPostRequest> it)
            => it.AddFieldName("emoji");
        
        public static Partial<EmojisAddPostRequest> WithAttachmentId(this Partial<EmojisAddPostRequest> it)
            => it.AddFieldName("attachmentId");
        
    }
    
}
