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
    [JsonConverter(typeof(EnumerationConverter))]
    public sealed class AbsenceListMode : Enumeration
    {
        private AbsenceListMode(string value) : base(value) { }
        
        public static readonly AbsenceListMode All = new AbsenceListMode("All");
        public static readonly AbsenceListMode WithAccessibleReasonUnapproved = new AbsenceListMode("WithAccessibleReasonUnapproved");
        public static readonly AbsenceListMode WithAccessibleReasonAll = new AbsenceListMode("WithAccessibleReasonAll");
    }
    
}
