using System.Linq;
using System.Windows.Controls;
using VLSUP.Repository;

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
        }
    }
}
