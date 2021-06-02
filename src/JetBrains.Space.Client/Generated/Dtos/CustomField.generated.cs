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
    public sealed class CustomField
         : IPropagatePropertyAccessPath
    {
        public CustomField() { }
        
        public CustomField(ExtendedType extendedType, string id, string name, CFType type, bool required, bool @private, CFValue defaultValue, int order, bool archived, string? description = null, string? key = null, CFConstraint? constraint = null, AccessType? access = null, ExtendedTypeScope? scope = null, bool? deleted = null)
        {
            ExtendedType = extendedType;
            Id = id;
            Name = name;
            Description = description;
            Key = key;
            Type = type;
            Constraint = constraint;
            IsRequired = required;
            IsPrivate = @private;
            Access = access;
            DefaultValue = defaultValue;
            Order = order;
            Scope = scope;
            IsDeleted = deleted;
            IsArchived = archived;
        }
        
        private PropertyValue<ExtendedType> _extendedType = new PropertyValue<ExtendedType>(nameof(CustomField), nameof(ExtendedType));
        
        [Required]
        [JsonPropertyName("extendedType")]
        public ExtendedType ExtendedType
        {
            get => _extendedType.GetValue();
            set => _extendedType.SetValue(value);
        }
    
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(CustomField), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get => _id.GetValue();
            set => _id.SetValue(value);
        }
    
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(CustomField), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get => _name.GetValue();
            set => _name.SetValue(value);
        }
    
        private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(CustomField), nameof(Description));
        
        [JsonPropertyName("description")]
        public string? Description
        {
            get => _description.GetValue();
            set => _description.SetValue(value);
        }
    
        private PropertyValue<string?> _key = new PropertyValue<string?>(nameof(CustomField), nameof(Key));
        
        [Obsolete("Use name instead (since 2020-09-28) (will be removed in a future version)")]
        [JsonPropertyName("key")]
        public string? Key
        {
            get => _key.GetValue();
            set => _key.SetValue(value);
        }
    
        private PropertyValue<CFType> _type = new PropertyValue<CFType>(nameof(CustomField), nameof(Type));
        
        [Required]
        [JsonPropertyName("type")]
        public CFType Type
        {
            get => _type.GetValue();
            set => _type.SetValue(value);
        }
    
        private PropertyValue<CFConstraint?> _constraint = new PropertyValue<CFConstraint?>(nameof(CustomField), nameof(Constraint));
        
        [JsonPropertyName("constraint")]
        public CFConstraint? Constraint
        {
            get => _constraint.GetValue();
            set => _constraint.SetValue(value);
        }
    
        private PropertyValue<bool> _required = new PropertyValue<bool>(nameof(CustomField), nameof(IsRequired));
        
        [Required]
        [JsonPropertyName("required")]
        public bool IsRequired
        {
            get => _required.GetValue();
            set => _required.SetValue(value);
        }
    
        private PropertyValue<bool> _private = new PropertyValue<bool>(nameof(CustomField), nameof(IsPrivate));
        
        [Required]
        [JsonPropertyName("private")]
        public bool IsPrivate
        {
            get => _private.GetValue();
            set => _private.SetValue(value);
        }
    
        private PropertyValue<AccessType?> _access = new PropertyValue<AccessType?>(nameof(CustomField), nameof(Access));
        
        [JsonPropertyName("access")]
        public AccessType? Access
        {
            get => _access.GetValue();
            set => _access.SetValue(value);
        }
    
        private PropertyValue<CFValue> _defaultValue = new PropertyValue<CFValue>(nameof(CustomField), nameof(DefaultValue));
        
        [Required]
        [JsonPropertyName("defaultValue")]
        public CFValue DefaultValue
        {
            get => _defaultValue.GetValue();
            set => _defaultValue.SetValue(value);
        }
    
        private PropertyValue<int> _order = new PropertyValue<int>(nameof(CustomField), nameof(Order));
        
        [Required]
        [JsonPropertyName("order")]
        public int Order
        {
            get => _order.GetValue();
            set => _order.SetValue(value);
        }
    
        private PropertyValue<ExtendedTypeScope?> _scope = new PropertyValue<ExtendedTypeScope?>(nameof(CustomField), nameof(Scope));
        
        [JsonPropertyName("scope")]
        public ExtendedTypeScope? Scope
        {
            get => _scope.GetValue();
            set => _scope.SetValue(value);
        }
    
        private PropertyValue<bool?> _deleted = new PropertyValue<bool?>(nameof(CustomField), nameof(IsDeleted));
        
        [JsonPropertyName("deleted")]
        public bool? IsDeleted
        {
            get => _deleted.GetValue();
            set => _deleted.SetValue(value);
        }
    
        private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(CustomField), nameof(IsArchived));
        
        [Required]
        [JsonPropertyName("archived")]
        public bool IsArchived
        {
            get => _archived.GetValue();
            set => _archived.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _extendedType.SetAccessPath(path, validateHasBeenSet);
            _id.SetAccessPath(path, validateHasBeenSet);
            _name.SetAccessPath(path, validateHasBeenSet);
            _description.SetAccessPath(path, validateHasBeenSet);
            _key.SetAccessPath(path, validateHasBeenSet);
            _type.SetAccessPath(path, validateHasBeenSet);
            _constraint.SetAccessPath(path, validateHasBeenSet);
            _required.SetAccessPath(path, validateHasBeenSet);
            _private.SetAccessPath(path, validateHasBeenSet);
            _access.SetAccessPath(path, validateHasBeenSet);
            _defaultValue.SetAccessPath(path, validateHasBeenSet);
            _order.SetAccessPath(path, validateHasBeenSet);
            _scope.SetAccessPath(path, validateHasBeenSet);
            _deleted.SetAccessPath(path, validateHasBeenSet);
            _archived.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
