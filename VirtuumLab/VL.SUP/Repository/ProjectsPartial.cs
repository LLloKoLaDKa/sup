using System;
using System.Linq;

namespace VLSUP.Repository
{
    public partial class Project
    {
        private readonly Guid BacklogTaskState = Guid.Parse("a95103de-0215-45ba-abf4-d76754d388c1");
        private readonly Guid InWorkTaskState = Guid.Parse("53b8db15-40e2-4bfa-aecd-ebd7029dd0fc");
        private readonly Guid CompletedTaskState = Guid.Parse("6a81d05e-ee85-4446-895a-b07019dcf0b3");

        public Int32 BacklogTaskCount
        {
            get
            {
                return Tasks.Where(t => t.State == BacklogTaskState).Count();
            }
        }

        public Int32 InWorkTaskCount
        {
            get
            {
                return Tasks.Where(t => t.State == InWorkTaskState).Count();
            }
        }
        public Int32 CompletedTaskCount
        {
            get
            {
                return Tasks.Where(t => t.State == CompletedTaskState).Count();
            }
        }

        public Int32 EmployeeCount
        {
            get
            {
                return ProjectWorks.Count;
            }
        }

        public Employee[] Employees
        {
            get
            {
                return ProjectWorks.Select(pw => pw.Employee).ToArray();
            }
        }
    }
}
