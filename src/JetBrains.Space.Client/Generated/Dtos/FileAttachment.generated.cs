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
    public sealed class FileAttachment
         : AttachmentIn, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "FileAttachment";
        
        public FileAttachment() { }
        
        public FileAttachment(string id, long sizeBytes, string filename)
        {
            Id = id;
            SizeBytes = sizeBytes;
            Filename = filename;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(FileAttachment), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get => _id.GetValue();
            set => _id.SetValue(value);
        }
    
        private PropertyValue<long> _sizeBytes = new PropertyValue<long>(nameof(FileAttachment), nameof(SizeBytes));
        
        [Required]
        [JsonPropertyName("sizeBytes")]
        public long SizeBytes
        {
            get => _sizeBytes.GetValue();
            set => _sizeBytes.SetValue(value);
        }
    
        private PropertyValue<string> _filename = new PropertyValue<string>(nameof(FileAttachment), nameof(Filename));
        
        [Required]
        [JsonPropertyName("filename")]
        public string Filename
        {
            get => _filename.GetValue();
            set => _filename.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _sizeBytes.SetAccessPath(path, validateHasBeenSet);
            _filename.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
