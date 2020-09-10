// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS0108

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public sealed class ChannelSpecificDefaults
         : IPropagatePropertyAccessPath
    {
        public ChannelSpecificDefaults() { }
        
        public ChannelSpecificDefaults(NotificationFilter filter, bool push, M2EmailNotificationType email)
        {
            Filter = filter;
            IsPush = push;
            Email = email;
        }
        
        private PropertyValue<NotificationFilter> _filter = new PropertyValue<NotificationFilter>(nameof(ChannelSpecificDefaults), nameof(Filter));
        
        [Required]
        [JsonPropertyName("filter")]
        public NotificationFilter Filter
        {
            get { return _filter.GetValue(); }
            set { _filter.SetValue(value); }
        }
    
        private PropertyValue<bool> _push = new PropertyValue<bool>(nameof(ChannelSpecificDefaults), nameof(IsPush));
        
        [Required]
        [JsonPropertyName("push")]
        public bool IsPush
        {
            get { return _push.GetValue(); }
            set { _push.SetValue(value); }
        }
    
        private PropertyValue<M2EmailNotificationType> _email = new PropertyValue<M2EmailNotificationType>(nameof(ChannelSpecificDefaults), nameof(Email));
        
        [Required]
        [JsonPropertyName("email")]
        public M2EmailNotificationType Email
        {
            get { return _email.GetValue(); }
            set { _email.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _filter.SetAccessPath(path, validateHasBeenSet);
            _push.SetAccessPath(path, validateHasBeenSet);
            _email.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}