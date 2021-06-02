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
    public class TeamDirectoryMemberLocationsPostRequest
         : IPropagatePropertyAccessPath
    {
        public TeamDirectoryMemberLocationsPostRequest() { }
        
        public TeamDirectoryMemberLocationsPostRequest(ProfileIdentifier member, string location, DateTime? since = null, DateTime? till = null, string? previousLocation = null)
        {
            Member = member;
            Location = location;
            Since = since;
            Till = till;
            PreviousLocation = previousLocation;
        }
        
        private PropertyValue<ProfileIdentifier> _member = new PropertyValue<ProfileIdentifier>(nameof(TeamDirectoryMemberLocationsPostRequest), nameof(Member));
        
        [Required]
        [JsonPropertyName("member")]
        public ProfileIdentifier Member
        {
            get => _member.GetValue();
            set => _member.SetValue(value);
        }
    
        private PropertyValue<string> _location = new PropertyValue<string>(nameof(TeamDirectoryMemberLocationsPostRequest), nameof(Location));
        
        [Required]
        [JsonPropertyName("location")]
        public string Location
        {
            get => _location.GetValue();
            set => _location.SetValue(value);
        }
    
        private PropertyValue<DateTime?> _since = new PropertyValue<DateTime?>(nameof(TeamDirectoryMemberLocationsPostRequest), nameof(Since));
        
        [JsonPropertyName("since")]
        [JsonConverter(typeof(SpaceDateConverter))]
        public DateTime? Since
        {
            get => _since.GetValue();
            set => _since.SetValue(value);
        }
    
        private PropertyValue<DateTime?> _till = new PropertyValue<DateTime?>(nameof(TeamDirectoryMemberLocationsPostRequest), nameof(Till));
        
        [JsonPropertyName("till")]
        [JsonConverter(typeof(SpaceDateConverter))]
        public DateTime? Till
        {
            get => _till.GetValue();
            set => _till.SetValue(value);
        }
    
        private PropertyValue<string?> _previousLocation = new PropertyValue<string?>(nameof(TeamDirectoryMemberLocationsPostRequest), nameof(PreviousLocation));
        
        [JsonPropertyName("previousLocation")]
        public string? PreviousLocation
        {
            get => _previousLocation.GetValue();
            set => _previousLocation.SetValue(value);
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _member.SetAccessPath(path, validateHasBeenSet);
            _location.SetAccessPath(path, validateHasBeenSet);
            _since.SetAccessPath(path, validateHasBeenSet);
            _till.SetAccessPath(path, validateHasBeenSet);
            _previousLocation.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
