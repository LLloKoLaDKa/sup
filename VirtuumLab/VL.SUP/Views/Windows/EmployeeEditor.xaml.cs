using System;
using System.Collections.Generic;
using System.Data;
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
        private Action SaveAction { get; set; }
        public EmployeeEditor(Action saveAction, Employee employee = null)
        {
            InitializeComponent();
            EmployeeType[] types = db.EmployeeTypes.OrderBy(e => e.Salary).ToArray();
            typeBox.ItemsSource = types;

            if (employee != null)
            {
                Employee = employee;
                typeBox.SelectedItem = types.FirstOrDefault(t => t.Id == employee.EmployeeType.Id);
            }
            else
            {
                deleteButton.Visibility = Visibility.Collapsed;
                Employee = new Employee();
            }
            SaveAction = saveAction;
            this.DataContext = Employee;

        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            EmployeeType type = (typeBox.SelectedItem as EmployeeType);
            if (type is null)
            {
                MessageBox.Show("Вы не указали тип сотрудника", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (String.IsNullOrWhiteSpace(Employee.FirstName))
            {
                MessageBox.Show("Вы не указали имя сотрудника", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (String.IsNullOrWhiteSpace(Employee.LastName))
            {
                MessageBox.Show("Вы не указали фамилию сотрудника", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            Employee.Type = type.Id;
            if (Employee.Id == Guid.Empty)
            {
                Employee.Id = Guid.NewGuid();
                db.Employees.Add(Employee);
                db.Entry(Employee).State = System.Data.EntityState.Added;
            }
            else
            {
                Employee oldEmployee = db.Employees.FirstOrDefault(emp => emp.Id == Employee.Id);
                oldEmployee.FirstName = Employee.FirstName;
                oldEmployee.LastName = Employee.LastName;
                oldEmployee.SecondName = Employee.SecondName;
                oldEmployee.Type = Employee.Type;
                db.Entry(oldEmployee).State = EntityState.Modified;
            }

            db.SaveChanges();
            SaveAction();
            this.Close();
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show($"Вы уверены, что хотите удалить сотрудника {Employee.FullName}?","Подтверждение", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.Yes)
            {
                Employee employee = db.Employees.FirstOrDefault(emp => emp.Id == Employee.Id);
                if (employee is null) return;
                if (employee.ProjectWorks.Count != 0)
                {
                    MessageBox.Show("Нельзя удалить сотрудника с активными проектами", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                employee.IsRemoved = true;
                db.Entry(employee).State = EntityState.Modified;
                db.SaveChanges();
                SaveAction();
                this.Close();
            }
        }
    }
}
