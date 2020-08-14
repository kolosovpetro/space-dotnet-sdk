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
    public sealed class LaunchResultErrorDto
         : LaunchResultDto, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public override string? ClassName => "LaunchResult.Error";
        
        public LaunchResultErrorDto() { }
        
        public LaunchResultErrorDto(string message)
        {
            Message = message;
        }
        
        private PropertyValue<string> _message = new PropertyValue<string>(nameof(LaunchResultErrorDto), nameof(Message));
        
        [Required]
        [JsonPropertyName("message")]
        public string Message
        {
            get { return _message.GetValue(); }
            set { _message.SetValue(value); }
        }
    
        public override void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _message.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
