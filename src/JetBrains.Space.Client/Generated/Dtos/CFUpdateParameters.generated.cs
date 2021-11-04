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
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client;

public interface CFUpdateParameters
     : IClassNameConvertible, IPropagatePropertyAccessPath
{
    public static AutonumberCFParameters AutonumberCFParameters(string prefix, string suffix)
        => new AutonumberCFParameters(prefix: prefix, suffix: suffix);
    
    public static ContactCFParameters ContactCFParameters(TDContactKind? contactKind = null)
        => new ContactCFParameters(contactKind: contactKind);
    
    public static DocumentCFParametersInput DocumentCFParametersInput(DocumentCFScopeInput documentScope)
        => new DocumentCFParametersInput(documentScope: documentScope);
    
    public static EnumCFInputParameters EnumCFInputParameters(List<string> values)
        => new EnumCFInputParameters(values: values);
    
    public static OpenEnumCFUpdateParameters OpenEnum(List<CFEnumValueModification> modifications)
        => new OpenEnumCFUpdateParameters(modifications: modifications);
    
    public static VcsCommitCFParametersInput VcsCommitCFParametersInput(VcsCFScopeInput vcsCFScope)
        => new VcsCommitCFParametersInput(vcsCFScope: vcsCFScope);
    
}
