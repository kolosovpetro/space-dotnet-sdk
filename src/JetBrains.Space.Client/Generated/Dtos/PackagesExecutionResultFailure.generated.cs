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
    public sealed class PackagesExecutionResultFailure
         : PackagesExecutionResult, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public override string? ClassName => "PackagesExecutionResult.Failure";
        
        public PackagesExecutionResultFailure() { }
        
        public PackagesExecutionResultFailure(string error)
        {
            Error = error;
        }
        
        private PropertyValue<string> _error = new PropertyValue<string>(nameof(PackagesExecutionResultFailure), nameof(Error));
        
        [Required]
        [JsonPropertyName("error")]
        public string Error
        {
            get => _error.GetValue();
            set => _error.SetValue(value);
        }
    
        public override void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _error.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
