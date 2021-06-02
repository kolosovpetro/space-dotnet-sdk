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
    public sealed class ProjectPackageRepository
         : IPropagatePropertyAccessPath
    {
        public ProjectPackageRepository() { }
        
        public ProjectPackageRepository(string id, PRProject project, string name, PackageRepository repository, bool archived, List<PackageRepositoryConnection> mirrors, string? description = null)
        {
            Id = id;
            Project = project;
            Name = name;
            Description = description;
            Repository = repository;
            IsArchived = archived;
            Mirrors = mirrors;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(ProjectPackageRepository), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get => _id.GetValue();
            set => _id.SetValue(value);
        }
    
        private PropertyValue<PRProject> _project = new PropertyValue<PRProject>(nameof(ProjectPackageRepository), nameof(Project));
        
        [Required]
        [JsonPropertyName("project")]
        public PRProject Project
        {
            get => _project.GetValue();
            set => _project.SetValue(value);
        }
    
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(ProjectPackageRepository), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get => _name.GetValue();
            set => _name.SetValue(value);
        }
    
        private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(ProjectPackageRepository), nameof(Description));
        
        [JsonPropertyName("description")]
        public string? Description
        {
            get => _description.GetValue();
            set => _description.SetValue(value);
        }
    
        private PropertyValue<PackageRepository> _repository = new PropertyValue<PackageRepository>(nameof(ProjectPackageRepository), nameof(Repository));
        
        [Required]
        [JsonPropertyName("repository")]
        public PackageRepository Repository
        {
            get => _repository.GetValue();
            set => _repository.SetValue(value);
        }
    
        private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(ProjectPackageRepository), nameof(IsArchived));
        
        [Required]
        [JsonPropertyName("archived")]
        public bool IsArchived
        {
            get => _archived.GetValue();
            set => _archived.SetValue(value);
        }
    
        private PropertyValue<List<PackageRepositoryConnection>> _mirrors = new PropertyValue<List<PackageRepositoryConnection>>(nameof(ProjectPackageRepository), nameof(Mirrors), new List<PackageRepositoryConnection>());
        
        [Required]
        [JsonPropertyName("mirrors")]
        public List<PackageRepositoryConnection> Mirrors
        {
            get => _mirrors.GetValue();
            set => _mirrors.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _project.SetAccessPath(path, validateHasBeenSet);
            _name.SetAccessPath(path, validateHasBeenSet);
            _description.SetAccessPath(path, validateHasBeenSet);
            _repository.SetAccessPath(path, validateHasBeenSet);
            _archived.SetAccessPath(path, validateHasBeenSet);
            _mirrors.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
