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

public sealed class EndpointAuthCreateDTO
     : IPropagatePropertyAccessPath
{
    public EndpointAuthCreateDTO() { }
    
    public EndpointAuthCreateDTO(EndpointAuthCreate appLevelAuth, SSLKeystoreEndpointAuth? sslKeystore = null)
    {
        AppLevelAuth = appLevelAuth;
        SslKeystore = sslKeystore;
    }
    
    private PropertyValue<EndpointAuthCreate> _appLevelAuth = new PropertyValue<EndpointAuthCreate>(nameof(EndpointAuthCreateDTO), nameof(AppLevelAuth));
    
    [Required]
    [JsonPropertyName("appLevelAuth")]
    public EndpointAuthCreate AppLevelAuth
    {
        get => _appLevelAuth.GetValue();
        set => _appLevelAuth.SetValue(value);
    }

    private PropertyValue<SSLKeystoreEndpointAuth?> _sslKeystore = new PropertyValue<SSLKeystoreEndpointAuth?>(nameof(EndpointAuthCreateDTO), nameof(SslKeystore));
    
    [JsonPropertyName("sslKeystore")]
    public SSLKeystoreEndpointAuth? SslKeystore
    {
        get => _sslKeystore.GetValue();
        set => _sslKeystore.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _appLevelAuth.SetAccessPath(path, validateHasBeenSet);
        _sslKeystore.SetAccessPath(path, validateHasBeenSet);
    }

}
