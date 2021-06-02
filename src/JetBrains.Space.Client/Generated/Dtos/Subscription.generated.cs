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
    public sealed class Subscription
         : IPropagatePropertyAccessPath
    {
        public Subscription() { }
        
        public Subscription(string id, string name, bool enabled, Subscription subscription, PrivateFeed? privateFeed = null, ESApp? application = null, SubscriptionRequestedAuthorizations? requestedAuthentication = null)
        {
            Id = id;
            Name = name;
            IsEnabled = enabled;
            SubscriptionItem = subscription;
            PrivateFeed = privateFeed;
            Application = application;
            RequestedAuthentication = requestedAuthentication;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(Subscription), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get => _id.GetValue();
            set => _id.SetValue(value);
        }
    
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(Subscription), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get => _name.GetValue();
            set => _name.SetValue(value);
        }
    
        private PropertyValue<bool> _enabled = new PropertyValue<bool>(nameof(Subscription), nameof(IsEnabled));
        
        [Required]
        [JsonPropertyName("enabled")]
        public bool IsEnabled
        {
            get => _enabled.GetValue();
            set => _enabled.SetValue(value);
        }
    
        private PropertyValue<Subscription> _subscription = new PropertyValue<Subscription>(nameof(Subscription), nameof(SubscriptionItem));
        
        [Required]
        [JsonPropertyName("subscription")]
        public Subscription SubscriptionItem
        {
            get => _subscription.GetValue();
            set => _subscription.SetValue(value);
        }
    
        private PropertyValue<PrivateFeed?> _privateFeed = new PropertyValue<PrivateFeed?>(nameof(Subscription), nameof(PrivateFeed));
        
        [JsonPropertyName("privateFeed")]
        public PrivateFeed? PrivateFeed
        {
            get => _privateFeed.GetValue();
            set => _privateFeed.SetValue(value);
        }
    
        private PropertyValue<ESApp?> _application = new PropertyValue<ESApp?>(nameof(Subscription), nameof(Application));
        
        [JsonPropertyName("application")]
        public ESApp? Application
        {
            get => _application.GetValue();
            set => _application.SetValue(value);
        }
    
        private PropertyValue<SubscriptionRequestedAuthorizations?> _requestedAuthentication = new PropertyValue<SubscriptionRequestedAuthorizations?>(nameof(Subscription), nameof(RequestedAuthentication));
        
        [JsonPropertyName("requestedAuthentication")]
        public SubscriptionRequestedAuthorizations? RequestedAuthentication
        {
            get => _requestedAuthentication.GetValue();
            set => _requestedAuthentication.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _name.SetAccessPath(path, validateHasBeenSet);
            _enabled.SetAccessPath(path, validateHasBeenSet);
            _subscription.SetAccessPath(path, validateHasBeenSet);
            _privateFeed.SetAccessPath(path, validateHasBeenSet);
            _application.SetAccessPath(path, validateHasBeenSet);
            _requestedAuthentication.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
