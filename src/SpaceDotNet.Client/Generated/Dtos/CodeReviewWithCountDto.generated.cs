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
    public sealed class CodeReviewWithCountDto
         : IPropagatePropertyAccessPath
    {
        public CodeReviewWithCountDto() { }
        
        public CodeReviewWithCountDto(CodeReviewRecordDto review, int messagesCount, List<GitCommitterProfileDto> authors, CodeReviewParticipantsDto participants)
        {
            Review = review;
            MessagesCount = messagesCount;
            Authors = authors;
            Participants = participants;
        }
        
        private PropertyValue<CodeReviewRecordDto> _review = new PropertyValue<CodeReviewRecordDto>(nameof(CodeReviewWithCountDto), nameof(Review));
        
        [Required]
        [JsonPropertyName("review")]
        public CodeReviewRecordDto Review
        {
            get { return _review.GetValue(); }
            set { _review.SetValue(value); }
        }
    
        private PropertyValue<int> _messagesCount = new PropertyValue<int>(nameof(CodeReviewWithCountDto), nameof(MessagesCount));
        
        [Required]
        [JsonPropertyName("messagesCount")]
        public int MessagesCount
        {
            get { return _messagesCount.GetValue(); }
            set { _messagesCount.SetValue(value); }
        }
    
        private PropertyValue<List<GitCommitterProfileDto>> _authors = new PropertyValue<List<GitCommitterProfileDto>>(nameof(CodeReviewWithCountDto), nameof(Authors));
        
        [Required]
        [JsonPropertyName("authors")]
        public List<GitCommitterProfileDto> Authors
        {
            get { return _authors.GetValue(); }
            set { _authors.SetValue(value); }
        }
    
        private PropertyValue<CodeReviewParticipantsDto> _participants = new PropertyValue<CodeReviewParticipantsDto>(nameof(CodeReviewWithCountDto), nameof(Participants));
        
        [Required]
        [JsonPropertyName("participants")]
        public CodeReviewParticipantsDto Participants
        {
            get { return _participants.GetValue(); }
            set { _participants.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _review.SetAccessPath(path, validateHasBeenSet);
            _messagesCount.SetAccessPath(path, validateHasBeenSet);
            _authors.SetAccessPath(path, validateHasBeenSet);
            _participants.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
