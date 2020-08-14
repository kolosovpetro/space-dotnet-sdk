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
    public class ProjectsForProjectPlanningIssuesForIssueIdPatchRequest
         : IPropagatePropertyAccessPath
    {
        public ProjectsForProjectPlanningIssuesForIssueIdPatchRequest() { }
        
        public ProjectsForProjectPlanningIssuesForIssueIdPatchRequest(string title, string status, string? description = null, string? assignee = null, SpaceDate? dueDate = null, ImportedEntityInfoDto? importInfo = null)
        {
            Title = title;
            Description = description;
            Assignee = assignee;
            Status = status;
            DueDate = dueDate;
            ImportInfo = importInfo;
        }
        
        private PropertyValue<string> _title = new PropertyValue<string>(nameof(ProjectsForProjectPlanningIssuesForIssueIdPatchRequest), nameof(Title));
        
        [JsonPropertyName("title")]
        public string Title
        {
            get { return _title.GetValue(); }
            set { _title.SetValue(value); }
        }
    
        private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(ProjectsForProjectPlanningIssuesForIssueIdPatchRequest), nameof(Description));
        
        [JsonPropertyName("description")]
        public string? Description
        {
            get { return _description.GetValue(); }
            set { _description.SetValue(value); }
        }
    
        private PropertyValue<string?> _assignee = new PropertyValue<string?>(nameof(ProjectsForProjectPlanningIssuesForIssueIdPatchRequest), nameof(Assignee));
        
        [JsonPropertyName("assignee")]
        public string? Assignee
        {
            get { return _assignee.GetValue(); }
            set { _assignee.SetValue(value); }
        }
    
        private PropertyValue<string> _status = new PropertyValue<string>(nameof(ProjectsForProjectPlanningIssuesForIssueIdPatchRequest), nameof(Status));
        
        [JsonPropertyName("status")]
        public string Status
        {
            get { return _status.GetValue(); }
            set { _status.SetValue(value); }
        }
    
        private PropertyValue<SpaceDate?> _dueDate = new PropertyValue<SpaceDate?>(nameof(ProjectsForProjectPlanningIssuesForIssueIdPatchRequest), nameof(DueDate));
        
        [JsonPropertyName("dueDate")]
        public SpaceDate? DueDate
        {
            get { return _dueDate.GetValue(); }
            set { _dueDate.SetValue(value); }
        }
    
        private PropertyValue<ImportedEntityInfoDto?> _importInfo = new PropertyValue<ImportedEntityInfoDto?>(nameof(ProjectsForProjectPlanningIssuesForIssueIdPatchRequest), nameof(ImportInfo));
        
        [JsonPropertyName("importInfo")]
        public ImportedEntityInfoDto? ImportInfo
        {
            get { return _importInfo.GetValue(); }
            set { _importInfo.SetValue(value); }
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _title.SetAccessPath(path, validateHasBeenSet);
            _description.SetAccessPath(path, validateHasBeenSet);
            _assignee.SetAccessPath(path, validateHasBeenSet);
            _status.SetAccessPath(path, validateHasBeenSet);
            _dueDate.SetAccessPath(path, validateHasBeenSet);
            _importInfo.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
