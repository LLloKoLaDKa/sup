using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VLSUP.Repository
{
    public partial class Vacation
    {
        public String EmployeeName => $"{Employee.LastName} {Employee.FirstName}";
        public String Period => $"{DateStartOnlyDate} - {DateEndOnlyDate}";
        public String DateStartOnlyDate => $"{DateStart.Day}.{DateStart.Month}.{DateStart.Year}";
        public String DateEndOnlyDate => $"{DateEnd.Day}.{DateEnd.Month}.{DateEnd.Year}";
    }
}
