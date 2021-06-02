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
    [JsonConverter(typeof(ClassNameDtoTypeConverter))]
    public abstract class CodeReviewRecord
         : IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public virtual string? ClassName => "CodeReviewRecord";
        
        public static CommitSetReviewRecord CommitSetReviewRecord(ProjectKey project, string projectId, int number, string title, CodeReviewState state, long createdAt, bool? canBeReopened = null, TDMemberProfile? createdBy = null, bool? turnBased = null, M2ChannelRecord? feedChannel = null)
            => new CommitSetReviewRecord(project: project, projectId: projectId, number: number, title: title, state: state, createdAt: createdAt, canBeReopened: canBeReopened, createdBy: createdBy, turnBased: turnBased, feedChannel: feedChannel);
        
        public static MergeRequestRecord MergeRequestRecord(ProjectKey project, string projectId, int number, string title, CodeReviewState state, long createdAt, List<MergeRequestBranchPair> branchPairs, bool? canBeReopened = null, TDMemberProfile? createdBy = null, bool? turnBased = null, M2ChannelRecord? feedChannel = null)
            => new MergeRequestRecord(project: project, projectId: projectId, number: number, title: title, state: state, createdAt: createdAt, branchPairs: branchPairs, canBeReopened: canBeReopened, createdBy: createdBy, turnBased: turnBased, feedChannel: feedChannel);
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(CodeReviewRecord), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get => _id.GetValue();
            set => _id.SetValue(value);
        }
    
        private PropertyValue<List<CodeReviewParticipantRecord>> _authors = new PropertyValue<List<CodeReviewParticipantRecord>>(nameof(CodeReviewRecord), nameof(Authors), new List<CodeReviewParticipantRecord>());
        
        [Required]
        [Obsolete("Use participants (since 2020-11-03) (will be removed in a future version)")]
        [JsonPropertyName("authors")]
        public List<CodeReviewParticipantRecord> Authors
        {
            get => _authors.GetValue();
            set => _authors.SetValue(value);
        }
    
        private PropertyValue<Counter> _discussionCounter = new PropertyValue<Counter>(nameof(CodeReviewRecord), nameof(DiscussionCounter));
        
        [Required]
        [JsonPropertyName("discussionCounter")]
        public Counter DiscussionCounter
        {
            get => _discussionCounter.GetValue();
            set => _discussionCounter.SetValue(value);
        }
    
        private PropertyValue<List<string>> _issueIds = new PropertyValue<List<string>>(nameof(CodeReviewRecord), nameof(IssueIds), new List<string>());
        
        [Required]
        [JsonPropertyName("issueIds")]
        public List<string> IssueIds
        {
            get => _issueIds.GetValue();
            set => _issueIds.SetValue(value);
        }
    
        private PropertyValue<List<CodeReviewParticipant>?> _participants = new PropertyValue<List<CodeReviewParticipant>?>(nameof(CodeReviewRecord), nameof(Participants));
        
        [JsonPropertyName("participants")]
        public List<CodeReviewParticipant>? Participants
        {
            get => _participants.GetValue();
            set => _participants.SetValue(value);
        }
    
        private PropertyValue<List<CodeReviewParticipantRecord>> _reviewers = new PropertyValue<List<CodeReviewParticipantRecord>>(nameof(CodeReviewRecord), nameof(Reviewers), new List<CodeReviewParticipantRecord>());
        
        [Required]
        [Obsolete("Use participants (since 2020-11-03) (will be removed in a future version)")]
        [JsonPropertyName("reviewers")]
        public List<CodeReviewParticipantRecord> Reviewers
        {
            get => _reviewers.GetValue();
            set => _reviewers.SetValue(value);
        }
    
        private PropertyValue<List<CodeReviewParticipantRecord>> _watchers = new PropertyValue<List<CodeReviewParticipantRecord>>(nameof(CodeReviewRecord), nameof(Watchers), new List<CodeReviewParticipantRecord>());
        
        [Required]
        [Obsolete("Use participants (since 2020-11-03) (will be removed in a future version)")]
        [JsonPropertyName("watchers")]
        public List<CodeReviewParticipantRecord> Watchers
        {
            get => _watchers.GetValue();
            set => _watchers.SetValue(value);
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _authors.SetAccessPath(path, validateHasBeenSet);
            _discussionCounter.SetAccessPath(path, validateHasBeenSet);
            _issueIds.SetAccessPath(path, validateHasBeenSet);
            _participants.SetAccessPath(path, validateHasBeenSet);
            _reviewers.SetAccessPath(path, validateHasBeenSet);
            _watchers.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
