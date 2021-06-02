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
    public sealed class ChannelEvent
         : WebhookEvent, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "ChannelEvent";
        
        public ChannelEvent() { }
        
        public ChannelEvent(KMetaMod meta, M2ChannelRecord channel, Modification<string>? name = null, Modification<string>? description = null, Modification<string>? icon = null, bool? restored = null, bool? archived = null)
        {
            Meta = meta;
            Channel = channel;
            Name = name;
            Description = description;
            Icon = icon;
            IsRestored = restored;
            IsArchived = archived;
        }
        
        private PropertyValue<KMetaMod> _meta = new PropertyValue<KMetaMod>(nameof(ChannelEvent), nameof(Meta));
        
        [Required]
        [JsonPropertyName("meta")]
        public KMetaMod Meta
        {
            get => _meta.GetValue();
            set => _meta.SetValue(value);
        }
    
        private PropertyValue<M2ChannelRecord> _channel = new PropertyValue<M2ChannelRecord>(nameof(ChannelEvent), nameof(Channel));
        
        [Required]
        [JsonPropertyName("channel")]
        public M2ChannelRecord Channel
        {
            get => _channel.GetValue();
            set => _channel.SetValue(value);
        }
    
        private PropertyValue<Modification<string>?> _name = new PropertyValue<Modification<string>?>(nameof(ChannelEvent), nameof(Name));
        
        [JsonPropertyName("name")]
        public Modification<string>? Name
        {
            get => _name.GetValue();
            set => _name.SetValue(value);
        }
    
        private PropertyValue<Modification<string>?> _description = new PropertyValue<Modification<string>?>(nameof(ChannelEvent), nameof(Description));
        
        [JsonPropertyName("description")]
        public Modification<string>? Description
        {
            get => _description.GetValue();
            set => _description.SetValue(value);
        }
    
        private PropertyValue<Modification<string>?> _icon = new PropertyValue<Modification<string>?>(nameof(ChannelEvent), nameof(Icon));
        
        [JsonPropertyName("icon")]
        public Modification<string>? Icon
        {
            get => _icon.GetValue();
            set => _icon.SetValue(value);
        }
    
        private PropertyValue<bool?> _restored = new PropertyValue<bool?>(nameof(ChannelEvent), nameof(IsRestored));
        
        [JsonPropertyName("restored")]
        public bool? IsRestored
        {
            get => _restored.GetValue();
            set => _restored.SetValue(value);
        }
    
        private PropertyValue<bool?> _archived = new PropertyValue<bool?>(nameof(ChannelEvent), nameof(IsArchived));
        
        [JsonPropertyName("archived")]
        public bool? IsArchived
        {
            get => _archived.GetValue();
            set => _archived.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _meta.SetAccessPath(path, validateHasBeenSet);
            _channel.SetAccessPath(path, validateHasBeenSet);
            _name.SetAccessPath(path, validateHasBeenSet);
            _description.SetAccessPath(path, validateHasBeenSet);
            _icon.SetAccessPath(path, validateHasBeenSet);
            _restored.SetAccessPath(path, validateHasBeenSet);
            _archived.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
