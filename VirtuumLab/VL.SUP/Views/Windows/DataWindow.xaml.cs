using System;
using System.Linq;
using System.Windows;
using VLSUP.Repository;

namespace VLSUP.Views
{
    /// <summary>
    /// Interaction logic for DataWindow.xaml
    /// </summary>
    public partial class DataWindow : Window
    {
        public Action ReturnAction { get; set; }
        public Int32 ProjectCount { get; set; } = new SUPEntities().Projects.Where(p => !p.IsRemoved).Count();
        public DataWindow()
        {
            InitializeComponent();
            App.ProjectsPage = new ProjectsPage();
            mainFrame.Content = App.ProjectsPage;
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы уверены, что хотите закрыть приложение?", "Подтверждение", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.Yes)
            {
                App.Current.Shutdown();
            }
        }

        private void Grid_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e) => this.DragMove();

        private void returnButton_Click(object sender, RoutedEventArgs e)
        {
            if (ReturnAction == null) return;

            ReturnAction();
        }

        public void SetReturnAction(Action action)
        {
            ReturnAction = action;
            returnButton.Visibility = Visibility.Visible;

        }

        public void ResetReturnAction()
        {
            ReturnAction = null;
            returnButton.Visibility = Visibility.Hidden;
        }
    }
}
