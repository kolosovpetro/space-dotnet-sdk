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

namespace SpaceDotNet.Client.UpdateSpokenLanguageRequestExtensions
{
    public static class UpdateSpokenLanguageRequestPartialExtensions
    {
        public static Partial<UpdateSpokenLanguageRequest> WithLanguage(this Partial<UpdateSpokenLanguageRequest> it)
            => it.AddFieldName("language");
        
        public static Partial<UpdateSpokenLanguageRequest> WithFirstName(this Partial<UpdateSpokenLanguageRequest> it)
            => it.AddFieldName("firstName");
        
        public static Partial<UpdateSpokenLanguageRequest> WithLastName(this Partial<UpdateSpokenLanguageRequest> it)
            => it.AddFieldName("lastName");
        
    }
    
}