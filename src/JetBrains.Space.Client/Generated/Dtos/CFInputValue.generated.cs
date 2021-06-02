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
#pragma warning disable 618

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client
{
    public interface CFInputValue
         : IClassNameConvertible, IPropagatePropertyAccessPath
    {
        public static BooleanCFValue BooleanCFValue(bool? value = null)
            => new BooleanCFValue(value: value);
        
        public static DateCFValue DateCFValue(DateTime? value = null)
            => new DateCFValue(value: value);
        
        public static DateTimeCFValue DateTimeCFValue(DateTime? value = null)
            => new DateTimeCFValue(value: value);
        
        public static EnumCFValue EnumCFValue(EnumValueData? value = null)
            => new EnumCFValue(value: value);
        
        public static EnumListCFValue EnumListCFValue(List<EnumValueData> values)
            => new EnumListCFValue(values: values);
        
        public static IntCFValue IntCFValue(int? value = null)
            => new IntCFValue(value: value);
        
        public static IntListCFValue IntListCFValue(List<int> values)
            => new IntListCFValue(values: values);
        
        public static IssueCFInputValue Issue(IssueIdentifier? issue = null)
            => new IssueCFInputValue(issue: issue);
        
        public static IssueListCFInputValue IssueList(List<IssueIdentifier> issues)
            => new IssueListCFInputValue(issues: issues);
        
        public static LocationCFInputValue Location(string? location = null)
            => new LocationCFInputValue(location: location);
        
        public static OpenEnumCFValue OpenEnumCFValue(EnumValueData? value = null)
            => new OpenEnumCFValue(value: value);
        
        public static OpenEnumListCFValue OpenEnumListCFValue(List<EnumValueData> values)
            => new OpenEnumListCFValue(values: values);
        
        public static PercentageCFValue PercentageCFValue(int? value = null)
            => new PercentageCFValue(value: value);
        
        public static ProfileCFInputValue Profile(ProfileIdentifier? profile = null)
            => new ProfileCFInputValue(profile: profile);
        
        public static ProfileListCFInputValue ProfileList(List<ProfileIdentifier> profiles)
            => new ProfileListCFInputValue(profiles: profiles);
        
        public static ProjectCFInputValue Project(string? project = null)
            => new ProjectCFInputValue(project: project);
        
        public static StringCFValue StringCFValue(string? value = null)
            => new StringCFValue(value: value);
        
        public static StringListCFValue StringListCFValue(List<string> values)
            => new StringListCFValue(values: values);
        
        public static TeamCFInputValue Team(string? team = null)
            => new TeamCFInputValue(team: team);
        
        public static UrlCFValue UrlCFValue(string? href = null)
            => new UrlCFValue(href: href);
        
    }
    
}
