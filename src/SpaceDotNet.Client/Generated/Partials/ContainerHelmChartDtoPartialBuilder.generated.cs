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

namespace SpaceDotNet.Client.ContainerHelmChartDtoPartialBuilder
{
    public static class ContainerHelmChartDtoPartialExtensions
    {
        public static Partial<ContainerHelmChartDto> WithName(this Partial<ContainerHelmChartDto> it)
            => it.AddFieldName("name");
        
        public static Partial<ContainerHelmChartDto> WithDescription(this Partial<ContainerHelmChartDto> it)
            => it.AddFieldName("description");
        
        public static Partial<ContainerHelmChartDto> WithTags(this Partial<ContainerHelmChartDto> it)
            => it.AddFieldName("tags");
        
        public static Partial<ContainerHelmChartDto> WithProjectUrl(this Partial<ContainerHelmChartDto> it)
            => it.AddFieldName("projectUrl");
        
        public static Partial<ContainerHelmChartDto> WithSourceUrl(this Partial<ContainerHelmChartDto> it)
            => it.AddFieldName("sourceUrl");
        
        public static Partial<ContainerHelmChartDto> WithVersion(this Partial<ContainerHelmChartDto> it)
            => it.AddFieldName("version");
        
        public static Partial<ContainerHelmChartDto> WithApiVersion(this Partial<ContainerHelmChartDto> it)
            => it.AddFieldName("apiVersion");
        
        public static Partial<ContainerHelmChartDto> WithAppVersion(this Partial<ContainerHelmChartDto> it)
            => it.AddFieldName("appVersion");
        
        public static Partial<ContainerHelmChartDto> WithDependencies(this Partial<ContainerHelmChartDto> it)
            => it.AddFieldName("dependencies");
        
        public static Partial<ContainerHelmChartDto> WithDependencies(this Partial<ContainerHelmChartDto> it, Func<Partial<ContainerHelmChartDependencyDto>, Partial<ContainerHelmChartDependencyDto>> partialBuilder)
            => it.AddFieldName("dependencies", partialBuilder(new Partial<ContainerHelmChartDependencyDto>(it)));
        
        public static Partial<ContainerHelmChartDto> WithType(this Partial<ContainerHelmChartDto> it)
            => it.AddFieldName("type");
        
    }
    
}
