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
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public class UpdateTodoFilterRequest
    {
        private PropertyValue<bool> _todoFilters = new PropertyValue<bool>(nameof(UpdateTodoFilterRequest), nameof(TodoFilters));
        
        [Required]
        [JsonPropertyName("todoFilters")]
        public bool TodoFilters
        {
            get { return _todoFilters.GetValue(); }
            set { _todoFilters.SetValue(value); }
        }
    
    }
    
}
