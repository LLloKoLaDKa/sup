//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp1.Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class Project
    {
        public Project()
        {
            this.ProjectWorks = new HashSet<ProjectWork>();
            this.Tasks = new HashSet<Task>();
        }
    
        public System.Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsRemoved { get; set; }
    
        public virtual ICollection<ProjectWork> ProjectWorks { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
    }
}
