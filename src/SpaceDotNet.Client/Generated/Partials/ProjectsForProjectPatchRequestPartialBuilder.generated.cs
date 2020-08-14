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

namespace SpaceDotNet.Client.ProjectsForProjectPatchRequestPartialBuilder
{
    public static class ProjectsForProjectPatchRequestPartialExtensions
    {
        public static Partial<ProjectsForProjectPatchRequest> WithKey(this Partial<ProjectsForProjectPatchRequest> it)
            => it.AddFieldName("key");
        
        public static Partial<ProjectsForProjectPatchRequest> WithKey(this Partial<ProjectsForProjectPatchRequest> it, Func<Partial<ProjectKeyDto>, Partial<ProjectKeyDto>> partialBuilder)
            => it.AddFieldName("key", partialBuilder(new Partial<ProjectKeyDto>(it)));
        
        public static Partial<ProjectsForProjectPatchRequest> WithName(this Partial<ProjectsForProjectPatchRequest> it)
            => it.AddFieldName("name");
        
        public static Partial<ProjectsForProjectPatchRequest> WithDescription(this Partial<ProjectsForProjectPatchRequest> it)
            => it.AddFieldName("description");
        
        public static Partial<ProjectsForProjectPatchRequest> WithPrivate(this Partial<ProjectsForProjectPatchRequest> it)
            => it.AddFieldName("private");
        
        public static Partial<ProjectsForProjectPatchRequest> WithTags(this Partial<ProjectsForProjectPatchRequest> it)
            => it.AddFieldName("tags");
        
        public static Partial<ProjectsForProjectPatchRequest> WithIcon(this Partial<ProjectsForProjectPatchRequest> it)
            => it.AddFieldName("icon");
        
    }
    
}
