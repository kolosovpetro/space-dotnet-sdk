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

namespace SpaceDotNet.Client
{
    [JsonConverter(typeof(UrlParameterConverter))]
    public abstract class ProjectIdentifier : IUrlParameter
    {
        public static ProjectIdentifier Id(string id)
            => new ProjectIdentifierId(id);
        
        public static ProjectIdentifier Key(string key)
            => new ProjectIdentifierKey(key);
        
        private class ProjectIdentifierId : ProjectIdentifier
        {
            public readonly string _id;
            
            public ProjectIdentifierId(string id)
            {
                _id = id;
            }
            
            public override string ToString()
            {
                return $"id:{_id}";
            }
        }
        
        private class ProjectIdentifierKey : ProjectIdentifier
        {
            public readonly string _key;
            
            public ProjectIdentifierKey(string key)
            {
                _key = key;
            }
            
            public override string ToString()
            {
                return $"key:{_key}";
            }
        }
        
    }
    
}
