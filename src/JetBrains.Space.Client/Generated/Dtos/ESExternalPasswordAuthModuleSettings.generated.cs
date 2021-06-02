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
    public abstract class ESExternalPasswordAuthModuleSettings
         : ESPasswordAuthModuleSettings, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public override string? ClassName => "ES_ExternalPasswordAuthModuleSettings";
        
        public static ESLdapAuthModuleSettings ESLdapAuthModuleSettings(LdapModuleType type, bool registerNewUsers, string serverUrl, int connectionTimeout, int readTimeout, List<ESTeamMapping> teamMappings, bool referralIgnored, string filter, string bindUserDN, string bindUserPassword, ESLdapAttributeNames attributeNames, SSLKeystore? sslKeystore = null)
            => new ESLdapAuthModuleSettings(type: type, registerNewUsers: registerNewUsers, serverUrl: serverUrl, connectionTimeout: connectionTimeout, readTimeout: readTimeout, teamMappings: teamMappings, referralIgnored: referralIgnored, filter: filter, bindUserDN: bindUserDN, bindUserPassword: bindUserPassword, attributeNames: attributeNames, sslKeystore: sslKeystore);
        
        public override void SetAccessPath(string path, bool validateHasBeenSet)
        {
        }
    
    }
    
}
