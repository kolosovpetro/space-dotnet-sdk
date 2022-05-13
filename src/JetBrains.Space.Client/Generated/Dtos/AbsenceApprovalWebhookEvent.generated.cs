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

public sealed class AbsenceApprovalWebhookEvent
     : WebhookEvent, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "AbsenceApprovalWebhookEvent";
    
    public AbsenceApprovalWebhookEvent() { }
    
    public AbsenceApprovalWebhookEvent(KMetaMod meta, AbsenceRecord absence, TDMemberProfile member, Modification<bool> approved)
    {
        Meta = meta;
        Absence = absence;
        Member = member;
        Approved = approved;
    }
    
    private PropertyValue<KMetaMod> _meta = new PropertyValue<KMetaMod>(nameof(AbsenceApprovalWebhookEvent), nameof(Meta), "meta");
    
    [Required]
    [JsonPropertyName("meta")]
    public KMetaMod Meta
    {
        get => _meta.GetValue(InlineErrors);
        set => _meta.SetValue(value);
    }

    private PropertyValue<AbsenceRecord> _absence = new PropertyValue<AbsenceRecord>(nameof(AbsenceApprovalWebhookEvent), nameof(Absence), "absence");
    
    [Required]
    [JsonPropertyName("absence")]
    public AbsenceRecord Absence
    {
        get => _absence.GetValue(InlineErrors);
        set => _absence.SetValue(value);
    }

    private PropertyValue<TDMemberProfile> _member = new PropertyValue<TDMemberProfile>(nameof(AbsenceApprovalWebhookEvent), nameof(Member), "member");
    
    [Required]
    [JsonPropertyName("member")]
    public TDMemberProfile Member
    {
        get => _member.GetValue(InlineErrors);
        set => _member.SetValue(value);
    }

    private PropertyValue<Modification<bool>> _approved = new PropertyValue<Modification<bool>>(nameof(AbsenceApprovalWebhookEvent), nameof(Approved), "approved");
    
    [Required]
    [JsonPropertyName("approved")]
    public Modification<bool> Approved
    {
        get => _approved.GetValue(InlineErrors);
        set => _approved.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _meta.SetAccessPath(parentChainPath, validateHasBeenSet);
        _absence.SetAccessPath(parentChainPath, validateHasBeenSet);
        _member.SetAccessPath(parentChainPath, validateHasBeenSet);
        _approved.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

