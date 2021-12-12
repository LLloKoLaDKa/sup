using System;
using System.Linq;
using System.Windows;
using System.Windows.Threading;
using VLSUP.Repository;
using VLSUP.Views;
using VLSUP.Views.Pages;

namespace VLSUP
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static readonly Guid BacklogTaskState = Guid.Parse("a95103de-0215-45ba-abf4-d76754d388c1");
        public static readonly Guid InWorkTaskState = Guid.Parse("53b8db15-40e2-4bfa-aecd-ebd7029dd0fc");
        public static readonly Guid CompletedTaskState = Guid.Parse("6a81d05e-ee85-4446-895a-b07019dcf0b3");

        public static SUPEntities db = new SUPEntities();

        public static ProjectsPage ProjectsPage;
        public static EmployeesPage EmployeesPage;
        public static VacationsPage VacationsPage;
        public static TasksPage TasksPage;
        public static ReportsPage ReportsPage;
        private static DataWindow _window => App.Current?.MainWindow as DataWindow;


        public static void ChangeToProjectsPage()
        {
            if (ProjectsPage is null) ProjectsPage = new ProjectsPage();
            else ProjectsPage.LoadData();

            _window.mainFrame.Content = ProjectsPage;
            _window.ResetReturnAction();
            _window.frameTitle.Text = "Проекты";
            RenderInfo("ProjectsPage");
        }

        public static void RenderInfo(String typePage, Guid? ProjectId = null)
        {
            if (typePage == "ProjectsPage")
            {
                Int32 projectsCount = db.Projects.Where(p => !p.IsRemoved).Count();
                _window.infoBlock.Text = $"Активных проектов: {projectsCount}";
            }

            if (typePage == "EmployeesPage")
            {
                Int32 employeeCount = db.Employees.Where(e => !e.IsRemoved).Count();
                _window.infoBlock.Text = $"Сотрудников: {employeeCount}";
            }

            if (typePage == "TasksPage")
            {
                Int32 tasksCount = db.Tasks.Where(t => t.ProjectId == ProjectId && t.State == CompletedTaskState && !t.IsRemoved).Count();
                _window.infoBlock.Text = $"Завершено задач: {tasksCount}";
            }

            if (typePage == "ReportsPage")
            {
                _window.infoBlock.Text = "";
            }

            if (typePage == "VacationsPage")
            {
                Int32 vacationsCount = db.Vacations.Where(v => !v.IsRemoved && v.DateStart.Year == DateTime.Now.Year).Count();
                _window.infoBlock.Text = $"Отпусков за {DateTime.Now.Year} год: {vacationsCount}";
            }
        }

        public static void ChangeToTasksPage(Project project)
        {
            TasksPage = new TasksPage(project);
            _window.mainFrame.Content = TasksPage;
            _window.SetReturnAction(ChangeToProjectsPage);
            _window.frameTitle.Text = $"{project.Name}";
            RenderInfo("TasksPage");
        }

        public static void ChangeToReportsPage()
        {
            ReportsPage = new ReportsPage();
            _window.mainFrame.Content = ReportsPage;
            _window.SetReturnAction(ChangeToProjectsPage);
            _window.frameTitle.Text = "";
            RenderInfo("ReportsPage");

        }

        public static void ChangeToEmployeesPage()
        {
            EmployeesPage = new EmployeesPage();

            _window.mainFrame.Content = EmployeesPage;
            _window.SetReturnAction(ChangeToProjectsPage);
            _window.frameTitle.Text = "Сотрудники";
            RenderInfo("EmployeesPage");
        }

        public static void ChangeToVacationsPage()
        {
            VacationsPage = new VacationsPage();
            _window.mainFrame.Content = VacationsPage;
            _window.SetReturnAction(ChangeToEmployeesPage);
            _window.frameTitle.Text = "Отпуска";
            RenderInfo("VacationsPage");
        }
    }
}
