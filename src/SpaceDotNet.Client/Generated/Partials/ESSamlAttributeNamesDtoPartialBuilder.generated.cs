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

namespace SpaceDotNet.Client.ESSamlAttributeNamesDtoPartialBuilder
{
    public static class ESSamlAttributeNamesDtoPartialExtensions
    {
        public static Partial<ESSamlAttributeNamesDto> WithLoginAttributeName(this Partial<ESSamlAttributeNamesDto> it)
            => it.AddFieldName("loginAttributeName");
        
        public static Partial<ESSamlAttributeNamesDto> WithFirstNameAttributeName(this Partial<ESSamlAttributeNamesDto> it)
            => it.AddFieldName("firstNameAttributeName");
        
        public static Partial<ESSamlAttributeNamesDto> WithLastNameAttributeName(this Partial<ESSamlAttributeNamesDto> it)
            => it.AddFieldName("lastNameAttributeName");
        
        public static Partial<ESSamlAttributeNamesDto> WithFullNameAttributeName(this Partial<ESSamlAttributeNamesDto> it)
            => it.AddFieldName("fullNameAttributeName");
        
        public static Partial<ESSamlAttributeNamesDto> WithEmailAttributeName(this Partial<ESSamlAttributeNamesDto> it)
            => it.AddFieldName("emailAttributeName");
        
        public static Partial<ESSamlAttributeNamesDto> WithEmailVerified(this Partial<ESSamlAttributeNamesDto> it)
            => it.AddFieldName("emailVerified");
        
    }
    
}
