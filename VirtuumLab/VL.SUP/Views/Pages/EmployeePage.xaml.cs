using System.Linq;
using System.Windows;
using System.Windows.Controls;
using VLSUP.Repository;
using VLSUP.Views.Windows;

namespace VLSUP.Views
{
    /// <summary>
    /// Interaction logic for EmployeePage.xaml
    /// </summary>
    public partial class EmployeePage : Page
    {
        SUPEntities db = new SUPEntities();
        public EmployeePage()
        {
            InitializeComponent();
            Employee[] employees = db.Employees.Where(e => !e.IsRemoved).ToArray();
            mainList.ItemsSource = employees;
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            EmployeeEditor editor = new EmployeeEditor();
            editor.ShowDialog();
        }

        private void vacationsButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void typesButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
