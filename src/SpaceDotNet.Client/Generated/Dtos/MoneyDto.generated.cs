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
    public sealed class MoneyDto
         : IPropagatePropertyAccessPath
    {
        public MoneyDto() { }
        
        public MoneyDto(int value, int currency)
        {
            Value = value;
            Currency = currency;
        }
        
        private PropertyValue<int> _value = new PropertyValue<int>(nameof(MoneyDto), nameof(Value));
        
        [Required]
        [JsonPropertyName("value")]
        public int Value
        {
            get { return _value.GetValue(); }
            set { _value.SetValue(value); }
        }
    
        private PropertyValue<int> _currency = new PropertyValue<int>(nameof(MoneyDto), nameof(Currency));
        
        [Required]
        [JsonPropertyName("currency")]
        public int Currency
        {
            get { return _currency.GetValue(); }
            set { _currency.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _value.SetAccessPath(path, validateHasBeenSet);
            _currency.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
