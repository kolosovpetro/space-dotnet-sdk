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
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client;

[JsonConverter(typeof(UrlParameterConverter))]
public abstract class ProfileIdentifier : IUrlParameter
{
    public static ProfileIdentifier ExternalId(string externalId)
        => new ProfileIdentifierExternalId(externalId);
    
    public static ProfileIdentifier Id(string id)
        => new ProfileIdentifierId(id);
    
    public static ProfileIdentifier Me
        => new ProfileIdentifierMe();
    
    public static ProfileIdentifier Username(string username)
        => new ProfileIdentifierUsername(username);
    
    private class ProfileIdentifierExternalId : ProfileIdentifier
    {
        private readonly string _externalId;
        
        public ProfileIdentifierExternalId(string externalId)
        {
            _externalId = externalId;
        }
        
        public override string ToString()
            => $"externalId:{_externalId}";
    }
    
    private class ProfileIdentifierId : ProfileIdentifier
    {
        private readonly string _id;
        
        public ProfileIdentifierId(string id)
        {
            _id = id;
        }
        
        public override string ToString()
            => $"id:{_id}";
    }
    
    private class ProfileIdentifierMe : ProfileIdentifier
    {
        public override string ToString()
            => "me";
    }
    
    private class ProfileIdentifierUsername : ProfileIdentifier
    {
        private readonly string _username;
        
        public ProfileIdentifierUsername(string username)
        {
            _username = username;
        }
        
        public override string ToString()
            => $"username:{_username}";
    }
    
}

