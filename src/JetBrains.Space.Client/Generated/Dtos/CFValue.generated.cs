// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS1591
#pragma warning disable CS0108

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Client.Internal;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client
{
    [JsonConverter(typeof(ClassNameDtoTypeConverter))]
    public abstract class CFValue
         : IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public virtual string? ClassName => "CFValue";
        
        public static BooleanCFValue Boolean(bool? value = null)
            => new BooleanCFValue(value: value);
        
        public static DateCFValue Date(DateTime? value = null)
            => new DateCFValue(value: value);
        
        public static EnumCFValue Enum(EnumValueData? value = null)
            => new EnumCFValue(value: value);
        
        public static EnumListCFValue EnumList(List<EnumValueData> values)
            => new EnumListCFValue(values: values);
        
        public static IntCFValue Int(int? value = null)
            => new IntCFValue(value: value);
        
        public static IntListCFValue IntList(List<int> values)
            => new IntListCFValue(values: values);
        
        public static PercentageCFValue Percentage(int? value = null)
            => new PercentageCFValue(value: value);
        
        public static ProfileCFValue Profile(TDMemberProfile? profile = null)
            => new ProfileCFValue(profile: profile);
        
        public static ProfileListCFValue ProfileList(List<TDMemberProfile> profiles)
            => new ProfileListCFValue(profiles: profiles);
        
        public static StringCFValue String(string? value = null)
            => new StringCFValue(value: value);
        
        public static StringListCFValue StringList(List<string> values)
            => new StringListCFValue(values: values);
        
        public static UrlCFValue Url(string? href = null)
            => new UrlCFValue(href: href);
        
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
        }
    
    }
    
}
