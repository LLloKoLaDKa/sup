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
using VLSUP.Repository;

namespace VLSUP.Views.Windows
{
    /// <summary>
    /// Interaction logic for EmployeeEditor.xaml
    /// </summary>
    public partial class EmployeeEditor : Window
    {
        SUPEntities db = new SUPEntities();
        public Employee Employee { get; set; }
        public EmployeeEditor(Employee employee = null)
        {
            InitializeComponent();
            EmployeeType[] types = db.EmployeeTypes.ToArray();
            typeBox.ItemsSource = types;

            Employee = employee ?? new Employee();
            this.DataContext = Employee;

        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            Employee.Type = (typeBox.SelectedItem as EmployeeType).Id;
            if (Employee.Id == Guid.Empty) Employee.Id = Guid.NewGuid();
            db.Employees.Add(Employee);
            db.Entry(Employee).State = System.Data.EntityState.Added;
            db.SaveChanges();
            this.Close();
        }
    }
}
