using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfApp1.Repository;

namespace WpfApp1.Views
{
    /// <summary>
    /// Interaction logic for ProjectsWindow.xaml
    /// </summary>
    public partial class ProjectsWindow : Window
    {
        SUPEntities db = new SUPEntities();
        public ProjectsWindow()
        {
            InitializeComponent();
            Project[] projects = db.Projects.ToArray();
            projectsBox.ItemsSource = projects;
        }
    }
}
