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
    public sealed class QRCodeDto
         : IPropagatePropertyAccessPath
    {
        public QRCodeDto() { }
        
        public QRCodeDto(int width, string base64Bitmap)
        {
            Width = width;
            Base64Bitmap = base64Bitmap;
        }
        
        private PropertyValue<int> _width = new PropertyValue<int>(nameof(QRCodeDto), nameof(Width));
        
        [Required]
        [JsonPropertyName("width")]
        public int Width
        {
            get { return _width.GetValue(); }
            set { _width.SetValue(value); }
        }
    
        private PropertyValue<string> _base64Bitmap = new PropertyValue<string>(nameof(QRCodeDto), nameof(Base64Bitmap));
        
        [Required]
        [JsonPropertyName("base64Bitmap")]
        public string Base64Bitmap
        {
            get { return _base64Bitmap.GetValue(); }
            set { _base64Bitmap.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _width.SetAccessPath(path, validateHasBeenSet);
            _base64Bitmap.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
