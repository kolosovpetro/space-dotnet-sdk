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
    public sealed class M2ChannelContentRecordDto
         : IPropagatePropertyAccessPath
    {
        public M2ChannelContentRecordDto() { }
        
        public M2ChannelContentRecordDto(string id, M2ChannelContentInfoDto? content = null)
        {
            Id = id;
            Content = content;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(M2ChannelContentRecordDto), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<M2ChannelContentInfoDto?> _content = new PropertyValue<M2ChannelContentInfoDto?>(nameof(M2ChannelContentRecordDto), nameof(Content));
        
        [JsonPropertyName("content")]
        public M2ChannelContentInfoDto? Content
        {
            get { return _content.GetValue(); }
            set { _content.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _content.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
