using System.Windows.Controls;
using VLSUP.Repository;

namespace VLSUP.Views.Pages
{
    /// <summary>
    /// Interaction logic for ActiveProjectPage.xaml
    /// </summary>
    public partial class ActiveProjectPage : Page
    {
        public Project Project { get; set; }
        public ActiveProjectPage(Project project)
        {
            Project = project;
            InitializeComponent();
            this.DataContext = Project;
        }
    }
}
