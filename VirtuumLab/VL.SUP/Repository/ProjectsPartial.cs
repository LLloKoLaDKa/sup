using System;
using System.Linq;

namespace VLSUP.Repository
{
    public partial class Project
    {
        public Int32 BacklogTaskCount
        {
            get
            {
                return Tasks.Where(t => t.State == App.BacklogTaskState).Count();
            }
        }

        public Int32 InWorkTaskCount
        {
            get
            {
                return Tasks.Where(t => t.State == App.InWorkTaskState).Count();
            }
        }
        public Int32 CompletedTaskCount
        {
            get
            {
                return Tasks.Where(t => t.State == App.CompletedTaskState).Count();
            }
        }

        public Int32 EmployeeCount
        {
            get
            {
                return ProjectWorks.Where(pw => pw.DateEnd == null).Count();
            }
        }

        public Employee[] Employees
        {
            get
            {
                return ProjectWorks.Where(pw => pw.DateEnd == null).Select(pw => pw.Employee).ToArray();
            }
        }
    }
}
