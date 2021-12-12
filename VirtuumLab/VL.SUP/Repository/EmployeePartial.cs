using System;
using System.Linq;

namespace VLSUP.Repository
{
    public partial class Employee
    {
        public String FullName
        {
            get => $"{LastName} {FirstName} {SecondName}";
        }

        public String EmployeeTypeString
        {
            get => $"Должность: {EmployeeType.Title}";
        }

        public String Salary
        {
            get => $"Зарплата: {EmployeeType.Salary}";
        }

        public String PerformerTaskCount
        {
            get => $"Задач на выполнение: {Tasks.Where(t => t.TaskState.State != "Завершено").Count()}";
        }

        public String TesterTaskCount
        {
            get => $"Задач на тестирование: {Tasks1.Where(t => t.TaskState.State != "Завершено").Count()}";
        }

        public String ProjectsCount
        {
            get => $"Активных проектов: {ProjectWorks.Where(pw => pw.DateEnd == null).Count()}";
        }

        public Boolean Border { get; set; } = false;
    }
}
