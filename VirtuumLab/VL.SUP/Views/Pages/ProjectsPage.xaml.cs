using System.Linq;
using System.Windows.Controls;
using VLSUP.Repository;
using VLSUP.Views.Pages;

namespace VLSUP.Views
{
    /// <summary>
    /// Interaction logic for ProjectsPage.xaml
    /// </summary>
    public partial class ProjectsPage : Page
    {
        private readonly SUPEntities db = new SUPEntities();
        public ProjectsPage()
        {
            InitializeComponent();
            Project[] projects = db.Projects.Where(p => !p.IsRemoved).ToArray();
            projectsBox.ItemsSource = projects;
            // обновлять количество проектов
        }

        private void projectsBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListView list = sender as ListView;
            if (list is null) return;

            Project project = list.SelectedItem as Project;
            if (project is null) return;

            App.ChangeToActiveProjectPage(project);
            list.SelectedItem = null;
        }

        private void addProjectButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {

        }

        private void employeesButton_Click(object sender, System.Windows.RoutedEventArgs e) => App.ChangeToEmployeesPage();

        private void reportsButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {

        }
    }
}
