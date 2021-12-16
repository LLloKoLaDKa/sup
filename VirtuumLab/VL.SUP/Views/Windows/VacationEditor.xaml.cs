﻿using System;
using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using VL.Validator;
using VL.Validator.Models;
using VLSUP.Repository;

namespace VLSUP.Views.Windows
{
    /// <summary>
    /// Interaction logic for VacationEditor.xaml
    /// </summary>
    public partial class VacationEditor : Window
    {
        private readonly SUPEntities db = new SUPEntities();
        public Vacation Vacation { get; set; }
        private Action LoadDataAction { get; set; }
        
        public VacationEditor(Action action, Vacation vacation = null)
        {
            InitializeComponent();
            LoadDataAction = action;
            Employee[] employees = db.Employees.ToArray();
            employeeBox.ItemsSource = employees;

            if (vacation == null)
            {
                Vacation = new Vacation();
                Vacation.DateStart = DateTime.Now;
                Vacation.DateEnd = DateTime.Now.AddDays(14);
                deleteButton.Visibility = Visibility.Collapsed;
            }
            else
            {
                Vacation = vacation;
                employeeBox.IsEnabled = false;
                employeeBox.SelectedItem = employees.FirstOrDefault(e => e.Id == vacation.Employee.Id);
            }
                
            this.DataContext = Vacation;
        }

        private void closeButton_Click(object sender, RoutedEventArgs e) => this.Close();
        private void Border_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e) => this.DragMove();

        private void startDateBox_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DatePicker picker = sender as DatePicker;
            DateTime? date = picker.SelectedDate;
            if (date == null) return;

            endDateBox.SelectedDate = date.Value.AddDays(14);
        }

        private void endDateBox_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DatePicker picker = sender as DatePicker;
            DateTime dateStart = Vacation.DateStart;
            DateTime? date = picker.SelectedDate;
            if (date == null) return;

            if (date <= dateStart)
            {
                MessageBox.Show("Дата окончания отпуска не может быть раньше начала", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                e.Handled = true;
                Vacation.DateEnd = Vacation.DateStart.AddDays(14);
                picker.SelectedDate = Vacation.DateStart.AddDays(14);
            }
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            Result result = Validator.ValidateVacation(Vacation.EmployeeId, Vacation.DateStart, Vacation.DateEnd);
            if (!result.IsSuccess)
            {
                MessageBox.Show(result.Errors[0], "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (Vacation.Id == Guid.Empty)
            {
                Vacation.Id = Guid.NewGuid();
                db.Vacations.Add(Vacation);
                db.Entry(Vacation).State = System.Data.EntityState.Added;
            }
            else
            {
                Vacation vacation = db.Vacations.FirstOrDefault(v => v.Id == Vacation.Id);
                vacation.DateStart = Vacation.DateStart;
                vacation.DateEnd = Vacation.DateEnd;
                vacation.Comment = Vacation.Comment;
                db.Entry(vacation).State = EntityState.Modified;
            }
            db.SaveChanges();
            LoadDataAction();
            this.Close();

        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show(
                $"Вы уверены, что хотите удалить отпуск у сотрудника {Vacation.EmployeeName} c {Vacation.DateStartOnlyDate} по {Vacation.DateEndOnlyDate}?",
                "Подтверждение",
                MessageBoxButton.YesNo,
                MessageBoxImage.Warning
            );
            if (result == MessageBoxResult.Yes)
            {
                Vacation vacation = db.Vacations.FirstOrDefault(v => v.Id == Vacation.Id);
                vacation.IsRemoved = true;
                db.Entry(vacation).State = EntityState.Modified;
                db.SaveChanges();
                LoadDataAction();
                this.Close();
            }
        }

        private void employeeBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox combo = sender as ComboBox;
            Employee employee = combo.SelectedItem as Employee;
            Vacation.EmployeeId = employee.Id;
        }
    }
}
