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
    public sealed class RevisionInReviewDto
         : IPropagatePropertyAccessPath
    {
        public RevisionInReviewDto() { }
        
        public RevisionInReviewDto(string repository, string commit)
        {
            Repository = repository;
            Commit = commit;
        }
        
        private PropertyValue<string> _repository = new PropertyValue<string>(nameof(RevisionInReviewDto), nameof(Repository));
        
        [Required]
        [JsonPropertyName("repository")]
        public string Repository
        {
            get { return _repository.GetValue(); }
            set { _repository.SetValue(value); }
        }
    
        private PropertyValue<string> _commit = new PropertyValue<string>(nameof(RevisionInReviewDto), nameof(Commit));
        
        [Required]
        [JsonPropertyName("commit")]
        public string Commit
        {
            get { return _commit.GetValue(); }
            set { _commit.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _repository.SetAccessPath(path, validateHasBeenSet);
            _commit.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
