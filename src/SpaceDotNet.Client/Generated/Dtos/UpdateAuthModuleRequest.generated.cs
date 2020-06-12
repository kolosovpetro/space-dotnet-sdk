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
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public class UpdateAuthModuleRequest
    {
        private PropertyValue<string?> _key = new PropertyValue<string?>(nameof(UpdateAuthModuleRequest), nameof(Key));
        
        [JsonPropertyName("key")]
        public string? Key
        {
            get { return _key.GetValue(); }
            set { _key.SetValue(value); }
        }
    
        private PropertyValue<string?> _name = new PropertyValue<string?>(nameof(UpdateAuthModuleRequest), nameof(Name));
        
        [JsonPropertyName("name")]
        public string? Name
        {
            get { return _name.GetValue(); }
            set { _name.SetValue(value); }
        }
    
        private PropertyValue<bool?> _enabled = new PropertyValue<bool?>(nameof(UpdateAuthModuleRequest), nameof(Enabled));
        
        [JsonPropertyName("enabled")]
        public bool? Enabled
        {
            get { return _enabled.GetValue(); }
            set { _enabled.SetValue(value); }
        }
    
        private PropertyValue<ESAuthModuleSettingsDto?> _settings = new PropertyValue<ESAuthModuleSettingsDto?>(nameof(UpdateAuthModuleRequest), nameof(Settings));
        
        [JsonPropertyName("settings")]
        public ESAuthModuleSettingsDto? Settings
        {
            get { return _settings.GetValue(); }
            set { _settings.SetValue(value); }
        }
    
    }
    
}