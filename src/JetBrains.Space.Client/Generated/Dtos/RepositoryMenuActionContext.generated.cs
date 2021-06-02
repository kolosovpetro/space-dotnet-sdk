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
    public sealed class RepositoryMenuActionContext
         : MenuActionContext, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "RepositoryMenuActionContext";
        
        public RepositoryMenuActionContext() { }
        
        public RepositoryMenuActionContext(string menuId, PRProject project, string repo)
        {
            MenuId = menuId;
            Project = project;
            Repo = repo;
        }
        
        private PropertyValue<string> _menuId = new PropertyValue<string>(nameof(RepositoryMenuActionContext), nameof(MenuId));
        
        [Required]
        [JsonPropertyName("menuId")]
        public string MenuId
        {
            get => _menuId.GetValue();
            set => _menuId.SetValue(value);
        }
    
        private PropertyValue<PRProject> _project = new PropertyValue<PRProject>(nameof(RepositoryMenuActionContext), nameof(Project));
        
        [Required]
        [JsonPropertyName("project")]
        public PRProject Project
        {
            get => _project.GetValue();
            set => _project.SetValue(value);
        }
    
        private PropertyValue<string> _repo = new PropertyValue<string>(nameof(RepositoryMenuActionContext), nameof(Repo));
        
        [Required]
        [JsonPropertyName("repo")]
        public string Repo
        {
            get => _repo.GetValue();
            set => _repo.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _menuId.SetAccessPath(path, validateHasBeenSet);
            _project.SetAccessPath(path, validateHasBeenSet);
            _repo.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
