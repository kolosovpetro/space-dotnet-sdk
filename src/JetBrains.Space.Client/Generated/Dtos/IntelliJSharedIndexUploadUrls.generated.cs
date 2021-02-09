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
    public sealed class IntelliJSharedIndexUploadUrls
         : IPropagatePropertyAccessPath
    {
        public IntelliJSharedIndexUploadUrls() { }
        
        public IntelliJSharedIndexUploadUrls(List<IntelliJSharedIndexNamedUploadUrl> urls)
        {
            Urls = urls;
        }
        
        private PropertyValue<List<IntelliJSharedIndexNamedUploadUrl>> _urls = new PropertyValue<List<IntelliJSharedIndexNamedUploadUrl>>(nameof(IntelliJSharedIndexUploadUrls), nameof(Urls));
        
        [Required]
        [JsonPropertyName("urls")]
        public List<IntelliJSharedIndexNamedUploadUrl> Urls
        {
            get => _urls.GetValue();
            set => _urls.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _urls.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}