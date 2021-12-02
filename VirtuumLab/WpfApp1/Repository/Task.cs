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
    
    public partial class Task
    {
        public System.Guid Id { get; set; }
        public System.Guid ProjectId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Nullable<System.Guid> PerformerId { get; set; }
        public Nullable<System.Guid> TesterId { get; set; }
        public System.Guid State { get; set; }
        public bool IsRemoved { get; set; }
    
        public virtual Employee Performer { get; set; }
        public virtual Employee Tester { get; set; }
        public virtual Project Project { get; set; }
        public virtual TaskState TaskState { get; set; }
    }
}
