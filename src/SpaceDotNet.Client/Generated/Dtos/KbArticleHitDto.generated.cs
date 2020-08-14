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
    public sealed class KbArticleHitDto
         : EntityHitDto, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public override string? ClassName => "KbArticleHit";
        
        public KbArticleHitDto() { }
        
        public KbArticleHitDto(string id, double score, string bookId, string title, string body)
        {
            Id = id;
            Score = score;
            BookId = bookId;
            Title = title;
            Body = body;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(KbArticleHitDto), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<double> _score = new PropertyValue<double>(nameof(KbArticleHitDto), nameof(Score));
        
        [Required]
        [JsonPropertyName("score")]
        public double Score
        {
            get { return _score.GetValue(); }
            set { _score.SetValue(value); }
        }
    
        private PropertyValue<string> _bookId = new PropertyValue<string>(nameof(KbArticleHitDto), nameof(BookId));
        
        [Required]
        [JsonPropertyName("bookId")]
        public string BookId
        {
            get { return _bookId.GetValue(); }
            set { _bookId.SetValue(value); }
        }
    
        private PropertyValue<string> _title = new PropertyValue<string>(nameof(KbArticleHitDto), nameof(Title));
        
        [Required]
        [JsonPropertyName("title")]
        public string Title
        {
            get { return _title.GetValue(); }
            set { _title.SetValue(value); }
        }
    
        private PropertyValue<string> _body = new PropertyValue<string>(nameof(KbArticleHitDto), nameof(Body));
        
        [Required]
        [JsonPropertyName("body")]
        public string Body
        {
            get { return _body.GetValue(); }
            set { _body.SetValue(value); }
        }
    
        public override void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _score.SetAccessPath(path, validateHasBeenSet);
            _bookId.SetAccessPath(path, validateHasBeenSet);
            _title.SetAccessPath(path, validateHasBeenSet);
            _body.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
