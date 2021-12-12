using System;

namespace VLSUP.Repository
{
    public partial class Task
    {
        public String PerformerName => Performer is null ? "Отсутствует" : $"{Performer.LastName} {Performer.FirstName}";
        public String TesterName => Tester is null ? "Отсутствует" : $"{Tester.LastName} {Tester.FirstName}";
    }
}
