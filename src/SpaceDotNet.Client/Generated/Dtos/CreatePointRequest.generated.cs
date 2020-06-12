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
    public class CreatePointRequest
    {
        private PropertyValue<int> _x = new PropertyValue<int>(nameof(CreatePointRequest), nameof(X));
        
        [Required]
        [JsonPropertyName("x")]
        public int X
        {
            get { return _x.GetValue(); }
            set { _x.SetValue(value); }
        }
    
        private PropertyValue<int> _y = new PropertyValue<int>(nameof(CreatePointRequest), nameof(Y));
        
        [Required]
        [JsonPropertyName("y")]
        public int Y
        {
            get { return _y.GetValue(); }
            set { _y.SetValue(value); }
        }
    
        private PropertyValue<string> _mapId = new PropertyValue<string>(nameof(CreatePointRequest), nameof(MapId));
        
        [Required]
        [JsonPropertyName("mapId")]
        public string MapId
        {
            get { return _mapId.GetValue(); }
            set { _mapId.SetValue(value); }
        }
    
    }
    
}