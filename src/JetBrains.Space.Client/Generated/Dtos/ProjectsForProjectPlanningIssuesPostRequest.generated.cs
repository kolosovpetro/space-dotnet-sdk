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

public class ProjectsForProjectPlanningIssuesPostRequest
     : IPropagatePropertyAccessPath
{
    public ProjectsForProjectPlanningIssuesPostRequest() { }
    
    public ProjectsForProjectPlanningIssuesPostRequest(string title, string status, List<string>? tags = null, List<string>? checklists = null, List<SprintIdentifier>? sprints = null, string? description = null, ProfileIdentifier? assignee = null, DateTime? dueDate = null, List<AttachmentIn>? attachments = null, MessageLink? fromMessage = null, List<CustomFieldInputValue>? customFields = null, List<string>? topics = null, List<IssueIdentifier>? parents = null)
    {
        Title = title;
        Description = description;
        Assignee = assignee;
        Status = status;
        DueDate = dueDate;
        Tags = (tags ?? new List<string>());
        Checklists = (checklists ?? new List<string>());
        Sprints = (sprints ?? new List<SprintIdentifier>());
        Attachments = (attachments ?? new List<AttachmentIn>());
        FromMessage = fromMessage;
        CustomFields = customFields;
        Topics = topics;
        Parents = parents;
    }
    
    private PropertyValue<string> _title = new PropertyValue<string>(nameof(ProjectsForProjectPlanningIssuesPostRequest), nameof(Title), "title");
    
    [Required]
    [JsonPropertyName("title")]
    public string Title
    {
        get => _title.GetValue(InlineErrors);
        set => _title.SetValue(value);
    }

    private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(ProjectsForProjectPlanningIssuesPostRequest), nameof(Description), "description");
    
    [JsonPropertyName("description")]
    public string? Description
    {
        get => _description.GetValue(InlineErrors);
        set => _description.SetValue(value);
    }

    private PropertyValue<ProfileIdentifier?> _assignee = new PropertyValue<ProfileIdentifier?>(nameof(ProjectsForProjectPlanningIssuesPostRequest), nameof(Assignee), "assignee");
    
    [JsonPropertyName("assignee")]
    public ProfileIdentifier? Assignee
    {
        get => _assignee.GetValue(InlineErrors);
        set => _assignee.SetValue(value);
    }

    private PropertyValue<string> _status = new PropertyValue<string>(nameof(ProjectsForProjectPlanningIssuesPostRequest), nameof(Status), "status");
    
    [Required]
    [JsonPropertyName("status")]
    public string Status
    {
        get => _status.GetValue(InlineErrors);
        set => _status.SetValue(value);
    }

    private PropertyValue<DateTime?> _dueDate = new PropertyValue<DateTime?>(nameof(ProjectsForProjectPlanningIssuesPostRequest), nameof(DueDate), "dueDate");
    
    [JsonPropertyName("dueDate")]
    [JsonConverter(typeof(SpaceDateConverter))]
    public DateTime? DueDate
    {
        get => _dueDate.GetValue(InlineErrors);
        set => _dueDate.SetValue(value);
    }

    private PropertyValue<List<string>> _tags = new PropertyValue<List<string>>(nameof(ProjectsForProjectPlanningIssuesPostRequest), nameof(Tags), "tags", new List<string>());
    
    [JsonPropertyName("tags")]
    public List<string> Tags
    {
        get => _tags.GetValue(InlineErrors);
        set => _tags.SetValue(value);
    }

    private PropertyValue<List<string>> _checklists = new PropertyValue<List<string>>(nameof(ProjectsForProjectPlanningIssuesPostRequest), nameof(Checklists), "checklists", new List<string>());
    
    [JsonPropertyName("checklists")]
    public List<string> Checklists
    {
        get => _checklists.GetValue(InlineErrors);
        set => _checklists.SetValue(value);
    }

    private PropertyValue<List<SprintIdentifier>> _sprints = new PropertyValue<List<SprintIdentifier>>(nameof(ProjectsForProjectPlanningIssuesPostRequest), nameof(Sprints), "sprints", new List<SprintIdentifier>());
    
    [JsonPropertyName("sprints")]
    public List<SprintIdentifier> Sprints
    {
        get => _sprints.GetValue(InlineErrors);
        set => _sprints.SetValue(value);
    }

    private PropertyValue<List<AttachmentIn>?> _attachments = new PropertyValue<List<AttachmentIn>?>(nameof(ProjectsForProjectPlanningIssuesPostRequest), nameof(Attachments), "attachments", new List<AttachmentIn>());
    
    [JsonPropertyName("attachments")]
    public List<AttachmentIn>? Attachments
    {
        get => _attachments.GetValue(InlineErrors);
        set => _attachments.SetValue(value);
    }

    private PropertyValue<MessageLink?> _fromMessage = new PropertyValue<MessageLink?>(nameof(ProjectsForProjectPlanningIssuesPostRequest), nameof(FromMessage), "fromMessage");
    
    [JsonPropertyName("fromMessage")]
    public MessageLink? FromMessage
    {
        get => _fromMessage.GetValue(InlineErrors);
        set => _fromMessage.SetValue(value);
    }

    private PropertyValue<List<CustomFieldInputValue>?> _customFields = new PropertyValue<List<CustomFieldInputValue>?>(nameof(ProjectsForProjectPlanningIssuesPostRequest), nameof(CustomFields), "customFields");
    
    [JsonPropertyName("customFields")]
    public List<CustomFieldInputValue>? CustomFields
    {
        get => _customFields.GetValue(InlineErrors);
        set => _customFields.SetValue(value);
    }

    private PropertyValue<List<string>?> _topics = new PropertyValue<List<string>?>(nameof(ProjectsForProjectPlanningIssuesPostRequest), nameof(Topics), "topics");
    
    [JsonPropertyName("topics")]
    public List<string>? Topics
    {
        get => _topics.GetValue(InlineErrors);
        set => _topics.SetValue(value);
    }

    private PropertyValue<List<IssueIdentifier>?> _parents = new PropertyValue<List<IssueIdentifier>?>(nameof(ProjectsForProjectPlanningIssuesPostRequest), nameof(Parents), "parents");
    
    [JsonPropertyName("parents")]
    public List<IssueIdentifier>? Parents
    {
        get => _parents.GetValue(InlineErrors);
        set => _parents.SetValue(value);
    }

    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _title.SetAccessPath(parentChainPath, validateHasBeenSet);
        _description.SetAccessPath(parentChainPath, validateHasBeenSet);
        _assignee.SetAccessPath(parentChainPath, validateHasBeenSet);
        _status.SetAccessPath(parentChainPath, validateHasBeenSet);
        _dueDate.SetAccessPath(parentChainPath, validateHasBeenSet);
        _tags.SetAccessPath(parentChainPath, validateHasBeenSet);
        _checklists.SetAccessPath(parentChainPath, validateHasBeenSet);
        _sprints.SetAccessPath(parentChainPath, validateHasBeenSet);
        _attachments.SetAccessPath(parentChainPath, validateHasBeenSet);
        _fromMessage.SetAccessPath(parentChainPath, validateHasBeenSet);
        _customFields.SetAccessPath(parentChainPath, validateHasBeenSet);
        _topics.SetAccessPath(parentChainPath, validateHasBeenSet);
        _parents.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

