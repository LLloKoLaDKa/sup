using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using VLSUP.Repository;

namespace VLSUP
{
    public class DragAndDrop
    {
        static public ListBox DragSource;
        static public Type DragType;

        #region Helper
        private static object GetObjectDataFromPoint(ListBox source, Point point)
        {
            UIElement element = source.InputHitTest(point) as UIElement;
            if (element != null)
            {
                //get the object from the element
                object data = DependencyProperty.UnsetValue;
                while (data == DependencyProperty.UnsetValue)
                {
                    // try to get the object value for the corresponding element
                    data = source.ItemContainerGenerator.ItemFromContainer(element);

                    //get the parent and we will iterate again
                    if (data == DependencyProperty.UnsetValue)
                        element = VisualTreeHelper.GetParent(element) as UIElement;

                    //if we reach the actual listbox then we must break to avoid an infinite loop
                    if (element == source)
                        return null;
                }

                //return the data that we fetched only if it is not Unset value, 
                //which would mean that we did not find the data
                if (data != DependencyProperty.UnsetValue)
                    return data;
            }

            return null;
        }
        #endregion

        #region DragEnabled
        public static readonly DependencyProperty DragEnabledProperty =
            DependencyProperty.RegisterAttached("DragEnabled",
                typeof(Boolean),
                typeof(DragAndDrop),
                new FrameworkPropertyMetadata(OnDragEnabledChanged));

        public static void SetDragEnabled(DependencyObject element, Boolean value)
        {
            element.SetValue(DragEnabledProperty, value);
        }

        public static Boolean GetDragEnabled(DependencyObject element)
        {
            return (Boolean)element.GetValue(DragEnabledProperty);
        }

        public static void OnDragEnabledChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            if ((bool)args.NewValue == true)
            {
                ListBox listbox = (ListBox)obj;
                listbox.PreviewMouseLeftButtonDown += new MouseButtonEventHandler(listbox_PreviewMouseLeftButtonDown);
            }
        }
        #endregion

        #region DropEnabled
        public static readonly DependencyProperty DropEnabledProperty =
            DependencyProperty.RegisterAttached("DropEnabled",
                typeof(Boolean),
                typeof(DragAndDrop),
                new FrameworkPropertyMetadata(OnDropEnabledChanged));

        public static void SetDropEnabled(DependencyObject element, Boolean value)
        {
            element.SetValue(DropEnabledProperty, value);
        }

        public static Boolean GetDropEnabled(DependencyObject element)
        {
            return (Boolean)element.GetValue(DropEnabledProperty);
        }

        public static void OnDropEnabledChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            if ((bool)args.NewValue == true)
            {
                ListBox listbox = (ListBox)obj;
                listbox.AllowDrop = true;
                listbox.Drop += new DragEventHandler(listbox_Drop);
            }
        }
        #endregion

        static void listbox_Drop(object sender, DragEventArgs e)
        {
            Task task = e.Data.GetData(DragType) as Task;
            //Change: Check if type is visible, remove only visible items from DragSource...
            if (DragType.IsVisible == true)
            {
                switch (DragSource.Tag)
                {
                    case "backlog": App.TasksPage.RemoveFromBackLog(task); break;
                    case "inwork": App.TasksPage.RemoveFromInWork(task); break;
                    case "completed": App.TasksPage.RemoveFromConpleted(task); break;
                }
            }
            ListBox listViewDrop = (sender as ListBox);
            switch(listViewDrop.Tag)
            {
                case "backlog": App.TasksPage.AddToBackLog(task); break;
                case "inwork": App.TasksPage.AddToInWork(task); break;
                case "completed": App.TasksPage.AddToConpleted(task); break;
            }
            App.TasksPage.LoadData();
        }

        public static void listbox_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragSource = (ListBox)sender;
            object data = (object)GetObjectDataFromPoint(DragSource, e.GetPosition(DragSource));
            if (data != null)
            {
                // Only get type if it is a valid data object
                DragType = data.GetType();
                DragDrop.DoDragDrop(DragSource, data, DragDropEffects.Copy);
            }
        }
    }
}
