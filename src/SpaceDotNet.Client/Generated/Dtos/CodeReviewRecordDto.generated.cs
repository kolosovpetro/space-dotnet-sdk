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
    [JsonConverter(typeof(ClassNameDtoTypeConverter))]
    public abstract class CodeReviewRecordDto
         : IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public virtual string? ClassName => "CodeReviewRecord";
        
        public static CommitSetReviewRecordDto CommitSetReviewRecord(ProjectKeyDto project, int number, string title, CodeReviewState state, long createdAt, bool? canBeReopened = null, TDMemberProfileDto? createdBy = null, bool? turnBased = null, M2ChannelRecordDto? feedChannel = null)
            => new CommitSetReviewRecordDto(project: project, number: number, title: title, state: state, createdAt: createdAt, canBeReopened: null, createdBy: null, turnBased: null, feedChannel: null);
        
        public static MergeRequestRecordDto MergeRequestRecord(ProjectKeyDto project, int number, string title, CodeReviewState state, long createdAt, List<MergeRequestBranchPairDto> branchPairs, bool? canBeReopened = null, TDMemberProfileDto? createdBy = null, bool? turnBased = null, M2ChannelRecordDto? feedChannel = null)
            => new MergeRequestRecordDto(project: project, number: number, title: title, state: state, createdAt: createdAt, branchPairs: branchPairs, canBeReopened: null, createdBy: null, turnBased: null, feedChannel: null);
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(CodeReviewRecordDto), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<CounterDto> _counter = new PropertyValue<CounterDto>(nameof(CodeReviewRecordDto), nameof(Counter));
        
        [Required]
        [JsonPropertyName("counter")]
        public CounterDto Counter
        {
            get { return _counter.GetValue(); }
            set { _counter.SetValue(value); }
        }
    
        private PropertyValue<string> _projectId = new PropertyValue<string>(nameof(CodeReviewRecordDto), nameof(ProjectId));
        
        [Required]
        [JsonPropertyName("projectId")]
        public string ProjectId
        {
            get { return _projectId.GetValue(); }
            set { _projectId.SetValue(value); }
        }
    
        private PropertyValue<List<CodeReviewParticipantRecordDto>> _authors = new PropertyValue<List<CodeReviewParticipantRecordDto>>(nameof(CodeReviewRecordDto), nameof(Authors));
        
        [Required]
        [JsonPropertyName("authors")]
        public List<CodeReviewParticipantRecordDto> Authors
        {
            get { return _authors.GetValue(); }
            set { _authors.SetValue(value); }
        }
    
        private PropertyValue<List<CodeReviewParticipantDto>?> _participants = new PropertyValue<List<CodeReviewParticipantDto>?>(nameof(CodeReviewRecordDto), nameof(Participants));
        
        [JsonPropertyName("participants")]
        public List<CodeReviewParticipantDto>? Participants
        {
            get { return _participants.GetValue(); }
            set { _participants.SetValue(value); }
        }
    
        private PropertyValue<List<CodeReviewParticipantRecordDto>> _reviewers = new PropertyValue<List<CodeReviewParticipantRecordDto>>(nameof(CodeReviewRecordDto), nameof(Reviewers));
        
        [Required]
        [JsonPropertyName("reviewers")]
        public List<CodeReviewParticipantRecordDto> Reviewers
        {
            get { return _reviewers.GetValue(); }
            set { _reviewers.SetValue(value); }
        }
    
        private PropertyValue<List<CodeReviewParticipantRecordDto>> _watchers = new PropertyValue<List<CodeReviewParticipantRecordDto>>(nameof(CodeReviewRecordDto), nameof(Watchers));
        
        [Required]
        [JsonPropertyName("watchers")]
        public List<CodeReviewParticipantRecordDto> Watchers
        {
            get { return _watchers.GetValue(); }
            set { _watchers.SetValue(value); }
        }
    
        private PropertyValue<int> _count = new PropertyValue<int>(nameof(CodeReviewRecordDto), nameof(Count));
        
        [Required]
        [JsonPropertyName("count")]
        public int Count
        {
            get { return _count.GetValue(); }
            set { _count.SetValue(value); }
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _counter.SetAccessPath(path, validateHasBeenSet);
            _projectId.SetAccessPath(path, validateHasBeenSet);
            _authors.SetAccessPath(path, validateHasBeenSet);
            _participants.SetAccessPath(path, validateHasBeenSet);
            _reviewers.SetAccessPath(path, validateHasBeenSet);
            _watchers.SetAccessPath(path, validateHasBeenSet);
            _count.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
