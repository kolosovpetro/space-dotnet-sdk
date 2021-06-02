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
    public sealed class HolidaysEvent
         : IPropagatePropertyAccessPath
    {
        public HolidaysEvent() { }
        
        public HolidaysEvent(TDMemberProfile profile, List<PublicHoliday> holidays)
        {
            Profile = profile;
            Holidays = holidays;
        }
        
        private PropertyValue<TDMemberProfile> _profile = new PropertyValue<TDMemberProfile>(nameof(HolidaysEvent), nameof(Profile));
        
        [Required]
        [JsonPropertyName("profile")]
        public TDMemberProfile Profile
        {
            get => _profile.GetValue();
            set => _profile.SetValue(value);
        }
    
        private PropertyValue<List<PublicHoliday>> _holidays = new PropertyValue<List<PublicHoliday>>(nameof(HolidaysEvent), nameof(Holidays), new List<PublicHoliday>());
        
        [Required]
        [JsonPropertyName("holidays")]
        public List<PublicHoliday> Holidays
        {
            get => _holidays.GetValue();
            set => _holidays.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _profile.SetAccessPath(path, validateHasBeenSet);
            _holidays.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
