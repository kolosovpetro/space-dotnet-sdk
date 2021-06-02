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
    public sealed class Issue
         : IPropagatePropertyAccessPath
    {
        public Issue() { }
        
        public Issue(string id, bool archived, string projectId, int number, CPrincipal createdBy, DateTime creationTime, IssueStatus status, List<PlanningTag> tags, string title, List<AttachmentInfo> attachments, M2ChannelRecord channel, List<Checklist> checklists, Dictionary<string, CFValue> customFields, List<SprintRecord> sprints, PRProject? projectRef = null, IssueTracker? trackerRef = null, TDMemberProfile? assignee = null, DateTime? dueDate = null, ExternalEntityInfoRecord? externalEntityInfo = null, int? attachmentsCount = null, string? description = null)
        {
            Id = id;
            IsArchived = archived;
            ProjectId = projectId;
            ProjectRef = projectRef;
            TrackerRef = trackerRef;
            Number = number;
            CreatedBy = createdBy;
            CreationTime = creationTime;
            Assignee = assignee;
            Status = status;
            DueDate = dueDate;
            ExternalEntityInfo = externalEntityInfo;
            Tags = tags;
            Title = title;
            AttachmentsCount = attachmentsCount;
            Attachments = attachments;
            Channel = channel;
            Checklists = checklists;
            CustomFields = customFields;
            Description = description;
            Sprints = sprints;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(Issue), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get => _id.GetValue();
            set => _id.SetValue(value);
        }
    
        private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(Issue), nameof(IsArchived));
        
        [Required]
        [JsonPropertyName("archived")]
        public bool IsArchived
        {
            get => _archived.GetValue();
            set => _archived.SetValue(value);
        }
    
        private PropertyValue<string> _projectId = new PropertyValue<string>(nameof(Issue), nameof(ProjectId));
        
        [Required]
        [JsonPropertyName("projectId")]
        public string ProjectId
        {
            get => _projectId.GetValue();
            set => _projectId.SetValue(value);
        }
    
        private PropertyValue<PRProject?> _projectRef = new PropertyValue<PRProject?>(nameof(Issue), nameof(ProjectRef));
        
        [JsonPropertyName("projectRef")]
        public PRProject? ProjectRef
        {
            get => _projectRef.GetValue();
            set => _projectRef.SetValue(value);
        }
    
        private PropertyValue<IssueTracker?> _trackerRef = new PropertyValue<IssueTracker?>(nameof(Issue), nameof(TrackerRef));
        
        [JsonPropertyName("trackerRef")]
        public IssueTracker? TrackerRef
        {
            get => _trackerRef.GetValue();
            set => _trackerRef.SetValue(value);
        }
    
        private PropertyValue<int> _number = new PropertyValue<int>(nameof(Issue), nameof(Number));
        
        [Required]
        [JsonPropertyName("number")]
        public int Number
        {
            get => _number.GetValue();
            set => _number.SetValue(value);
        }
    
        private PropertyValue<CPrincipal> _createdBy = new PropertyValue<CPrincipal>(nameof(Issue), nameof(CreatedBy));
        
        [Required]
        [JsonPropertyName("createdBy")]
        public CPrincipal CreatedBy
        {
            get => _createdBy.GetValue();
            set => _createdBy.SetValue(value);
        }
    
        private PropertyValue<DateTime> _creationTime = new PropertyValue<DateTime>(nameof(Issue), nameof(CreationTime));
        
        [Required]
        [JsonPropertyName("creationTime")]
        [JsonConverter(typeof(SpaceDateTimeConverter))]
        public DateTime CreationTime
        {
            get => _creationTime.GetValue();
            set => _creationTime.SetValue(value);
        }
    
        private PropertyValue<TDMemberProfile?> _assignee = new PropertyValue<TDMemberProfile?>(nameof(Issue), nameof(Assignee));
        
        [JsonPropertyName("assignee")]
        public TDMemberProfile? Assignee
        {
            get => _assignee.GetValue();
            set => _assignee.SetValue(value);
        }
    
        private PropertyValue<IssueStatus> _status = new PropertyValue<IssueStatus>(nameof(Issue), nameof(Status));
        
        [Required]
        [JsonPropertyName("status")]
        public IssueStatus Status
        {
            get => _status.GetValue();
            set => _status.SetValue(value);
        }
    
        private PropertyValue<DateTime?> _dueDate = new PropertyValue<DateTime?>(nameof(Issue), nameof(DueDate));
        
        [JsonPropertyName("dueDate")]
        [JsonConverter(typeof(SpaceDateConverter))]
        public DateTime? DueDate
        {
            get => _dueDate.GetValue();
            set => _dueDate.SetValue(value);
        }
    
        private PropertyValue<ExternalEntityInfoRecord?> _externalEntityInfo = new PropertyValue<ExternalEntityInfoRecord?>(nameof(Issue), nameof(ExternalEntityInfo));
        
        [JsonPropertyName("externalEntityInfo")]
        public ExternalEntityInfoRecord? ExternalEntityInfo
        {
            get => _externalEntityInfo.GetValue();
            set => _externalEntityInfo.SetValue(value);
        }
    
        private PropertyValue<List<PlanningTag>> _tags = new PropertyValue<List<PlanningTag>>(nameof(Issue), nameof(Tags), new List<PlanningTag>());
        
        [Required]
        [JsonPropertyName("tags")]
        public List<PlanningTag> Tags
        {
            get => _tags.GetValue();
            set => _tags.SetValue(value);
        }
    
        private PropertyValue<string> _title = new PropertyValue<string>(nameof(Issue), nameof(Title));
        
        [Required]
        [JsonPropertyName("title")]
        public string Title
        {
            get => _title.GetValue();
            set => _title.SetValue(value);
        }
    
        private PropertyValue<int?> _attachmentsCount = new PropertyValue<int?>(nameof(Issue), nameof(AttachmentsCount));
        
        [JsonPropertyName("attachmentsCount")]
        public int? AttachmentsCount
        {
            get => _attachmentsCount.GetValue();
            set => _attachmentsCount.SetValue(value);
        }
    
        private PropertyValue<List<AttachmentInfo>> _attachments = new PropertyValue<List<AttachmentInfo>>(nameof(Issue), nameof(Attachments), new List<AttachmentInfo>());
        
        [Required]
        [JsonPropertyName("attachments")]
        public List<AttachmentInfo> Attachments
        {
            get => _attachments.GetValue();
            set => _attachments.SetValue(value);
        }
    
        private PropertyValue<M2ChannelRecord> _channel = new PropertyValue<M2ChannelRecord>(nameof(Issue), nameof(Channel));
        
        [Required]
        [JsonPropertyName("channel")]
        public M2ChannelRecord Channel
        {
            get => _channel.GetValue();
            set => _channel.SetValue(value);
        }
    
        private PropertyValue<List<Checklist>> _checklists = new PropertyValue<List<Checklist>>(nameof(Issue), nameof(Checklists), new List<Checklist>());
        
        [Required]
        [JsonPropertyName("checklists")]
        public List<Checklist> Checklists
        {
            get => _checklists.GetValue();
            set => _checklists.SetValue(value);
        }
    
        private PropertyValue<Dictionary<string, CFValue>> _customFields = new PropertyValue<Dictionary<string, CFValue>>(nameof(Issue), nameof(CustomFields), new Dictionary<string, CFValue>());
        
        [Required]
        [JsonPropertyName("customFields")]
        public Dictionary<string, CFValue> CustomFields
        {
            get => _customFields.GetValue();
            set => _customFields.SetValue(value);
        }
    
        private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(Issue), nameof(Description));
        
        [JsonPropertyName("description")]
        public string? Description
        {
            get => _description.GetValue();
            set => _description.SetValue(value);
        }
    
        private PropertyValue<List<SprintRecord>> _sprints = new PropertyValue<List<SprintRecord>>(nameof(Issue), nameof(Sprints), new List<SprintRecord>());
        
        [Required]
        [JsonPropertyName("sprints")]
        public List<SprintRecord> Sprints
        {
            get => _sprints.GetValue();
            set => _sprints.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _archived.SetAccessPath(path, validateHasBeenSet);
            _projectId.SetAccessPath(path, validateHasBeenSet);
            _projectRef.SetAccessPath(path, validateHasBeenSet);
            _trackerRef.SetAccessPath(path, validateHasBeenSet);
            _number.SetAccessPath(path, validateHasBeenSet);
            _createdBy.SetAccessPath(path, validateHasBeenSet);
            _creationTime.SetAccessPath(path, validateHasBeenSet);
            _assignee.SetAccessPath(path, validateHasBeenSet);
            _status.SetAccessPath(path, validateHasBeenSet);
            _dueDate.SetAccessPath(path, validateHasBeenSet);
            _externalEntityInfo.SetAccessPath(path, validateHasBeenSet);
            _tags.SetAccessPath(path, validateHasBeenSet);
            _title.SetAccessPath(path, validateHasBeenSet);
            _attachmentsCount.SetAccessPath(path, validateHasBeenSet);
            _attachments.SetAccessPath(path, validateHasBeenSet);
            _channel.SetAccessPath(path, validateHasBeenSet);
            _checklists.SetAccessPath(path, validateHasBeenSet);
            _customFields.SetAccessPath(path, validateHasBeenSet);
            _description.SetAccessPath(path, validateHasBeenSet);
            _sprints.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
