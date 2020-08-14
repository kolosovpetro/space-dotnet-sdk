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

namespace SpaceDotNet.Client.ProjectsSecretsInDefaultBundlePostRequestPartialBuilder
{
    public static class ProjectsSecretsInDefaultBundlePostRequestPartialExtensions
    {
        public static Partial<ProjectsSecretsInDefaultBundlePostRequest> WithProjectId(this Partial<ProjectsSecretsInDefaultBundlePostRequest> it)
            => it.AddFieldName("projectId");
        
        public static Partial<ProjectsSecretsInDefaultBundlePostRequest> WithKey(this Partial<ProjectsSecretsInDefaultBundlePostRequest> it)
            => it.AddFieldName("key");
        
        public static Partial<ProjectsSecretsInDefaultBundlePostRequest> WithValueBase64(this Partial<ProjectsSecretsInDefaultBundlePostRequest> it)
            => it.AddFieldName("valueBase64");
        
        public static Partial<ProjectsSecretsInDefaultBundlePostRequest> WithPublicKeyId(this Partial<ProjectsSecretsInDefaultBundlePostRequest> it)
            => it.AddFieldName("publicKeyId");
        
    }
    
}
