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

namespace SpaceDotNet.Client.ProjectPackageRepositoryDtoPartialBuilder
{
    public static class ProjectPackageRepositoryDtoPartialExtensions
    {
        public static Partial<ProjectPackageRepositoryDto> WithId(this Partial<ProjectPackageRepositoryDto> it)
            => it.AddFieldName("id");
        
        public static Partial<ProjectPackageRepositoryDto> WithProject(this Partial<ProjectPackageRepositoryDto> it)
            => it.AddFieldName("project");
        
        public static Partial<ProjectPackageRepositoryDto> WithProject(this Partial<ProjectPackageRepositoryDto> it, Func<Partial<PRProjectDto>, Partial<PRProjectDto>> partialBuilder)
            => it.AddFieldName("project", partialBuilder(new Partial<PRProjectDto>(it)));
        
        public static Partial<ProjectPackageRepositoryDto> WithName(this Partial<ProjectPackageRepositoryDto> it)
            => it.AddFieldName("name");
        
        public static Partial<ProjectPackageRepositoryDto> WithDescription(this Partial<ProjectPackageRepositoryDto> it)
            => it.AddFieldName("description");
        
        public static Partial<ProjectPackageRepositoryDto> WithRepository(this Partial<ProjectPackageRepositoryDto> it)
            => it.AddFieldName("repository");
        
        public static Partial<ProjectPackageRepositoryDto> WithRepository(this Partial<ProjectPackageRepositoryDto> it, Func<Partial<PackageRepositoryDto>, Partial<PackageRepositoryDto>> partialBuilder)
            => it.AddFieldName("repository", partialBuilder(new Partial<PackageRepositoryDto>(it)));
        
        public static Partial<ProjectPackageRepositoryDto> WithArchived(this Partial<ProjectPackageRepositoryDto> it)
            => it.AddFieldName("archived");
        
    }
    
}
