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
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Client.Internal;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client
{
    public sealed class PermissionSnapshotRight
         : IPropagatePropertyAccessPath
    {
        public PermissionSnapshotRight() { }
        
        public PermissionSnapshotRight(string rightCode, string targetType)
        {
            RightCode = rightCode;
            TargetType = targetType;
        }
        
        private PropertyValue<string> _rightCode = new PropertyValue<string>(nameof(PermissionSnapshotRight), nameof(RightCode));
        
        [Required]
        [JsonPropertyName("rightCode")]
        public string RightCode
        {
            get => _rightCode.GetValue();
            set => _rightCode.SetValue(value);
        }
    
        private PropertyValue<string> _targetType = new PropertyValue<string>(nameof(PermissionSnapshotRight), nameof(TargetType));
        
        [Required]
        [JsonPropertyName("targetType")]
        public string TargetType
        {
            get => _targetType.GetValue();
            set => _targetType.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _rightCode.SetAccessPath(path, validateHasBeenSet);
            _targetType.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}