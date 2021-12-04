using System;
using System.Linq;
using System.Windows;
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
        static SUPEntities db = new SUPEntities();

        public static ProjectsPage ProjectsPage;
        public static ActiveProjectPage ActiveProjectPage;
        public static EmployeesPage EmployeesPage;
        public static VacationsPage VacationsPage;
        public static TasksPages TasksPages;
        private static DataWindow _window => App.Current?.MainWindow as DataWindow;

        public static void ChangeToProjectsPage()
        {
            Int32 projectsCount = db.Projects.Where(p => !p.IsRemoved).Count();
            if (ProjectsPage is null) ProjectsPage = new ProjectsPage();

            _window.mainFrame.Content = ProjectsPage;
            _window.ResetReturnAction();
            _window.frameTitle.Text = "Проекты";
            _window.infoBlock.Text = $"Активных проектов: {projectsCount}";
        }

        public static void ChangeToActiveProjectPage(Project project)
        {
            ActiveProjectPage = new ActiveProjectPage(project);
            _window.mainFrame.Content = ActiveProjectPage;
            _window.SetReturnAction(ChangeToProjectsPage);
            _window.frameTitle.Text = "Редактор проекта";
            _window.infoBlock.Text = "Возможно какой-то текст";
        }

        public static void ChangeToEmployeesPage()
        {
            Int32 employeeCount = db.Employees.Where(e => !e.IsRemoved).Count();
            EmployeesPage = new EmployeesPage();

            _window.mainFrame.Content = EmployeesPage;
            _window.SetReturnAction(ChangeToProjectsPage);
            _window.frameTitle.Text = "Сотрудники";
            _window.infoBlock.Text = $"Сотрудников: {employeeCount}";
        }

        public static void ChangeToVacationsPage()
        {
            Int32 vacationsCount = db.Vacations.Where(v => !v.IsRemoved && v.DateStart.Year == DateTime.Now.Year).Count();
            VacationsPage = new VacationsPage();
            _window.mainFrame.Content = VacationsPage;
            _window.SetReturnAction(ChangeToEmployeesPage);
            _window.frameTitle.Text = "Отпуска";
            _window.infoBlock.Text = $"Отпусков за {DateTime.Now.Year} год: {vacationsCount}";
        }
    }
}
