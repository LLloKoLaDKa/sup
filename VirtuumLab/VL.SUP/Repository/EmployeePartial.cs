using System;

namespace VLSUP.Repository
{
    public partial class Employee
    {
        public String FullName
        {
            get => $"{LastName} {FirstName} {SecondName}";
        }
    }
}
