﻿#pragma checksum "..\..\..\..\Views\Pages\TasksPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "68EE4B79304B42E19DA6BDC71E2A980429BFC58486DAC6585380F1B07FD3560D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using VLSUP;
using VLSUP.Views;


namespace VLSUP.Views {
    
    
    /// <summary>
    /// TasksPage
    /// </summary>
    public partial class TasksPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 1 "..\..\..\..\Views\Pages\TasksPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VLSUP.Views.TasksPage tasksPage;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\Views\Pages\TasksPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid mainGrid;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\Views\Pages\TasksPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox backlogTasksBox;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\..\Views\Pages\TasksPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox inWorkTasksBox;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\..\Views\Pages\TasksPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox completedTasksBox;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\..\Views\Pages\TasksPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addButton;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\..\..\Views\Pages\TasksPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button employeeButton;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\..\Views\Pages\TasksPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button editProjectButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/VLSUP;component/views/pages/taskspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\Pages\TasksPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.tasksPage = ((VLSUP.Views.TasksPage)(target));
            return;
            case 2:
            this.mainGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.backlogTasksBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 5:
            this.inWorkTasksBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 7:
            this.completedTasksBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 9:
            this.addButton = ((System.Windows.Controls.Button)(target));
            
            #line 94 "..\..\..\..\Views\Pages\TasksPage.xaml"
            this.addButton.Click += new System.Windows.RoutedEventHandler(this.addButton_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.employeeButton = ((System.Windows.Controls.Button)(target));
            
            #line 95 "..\..\..\..\Views\Pages\TasksPage.xaml"
            this.employeeButton.Click += new System.Windows.RoutedEventHandler(this.employeeButton_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.editProjectButton = ((System.Windows.Controls.Button)(target));
            
            #line 96 "..\..\..\..\Views\Pages\TasksPage.xaml"
            this.editProjectButton.Click += new System.Windows.RoutedEventHandler(this.editProjectButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 4:
            
            #line 38 "..\..\..\..\Views\Pages\TasksPage.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.Button_MouseEnter);
            
            #line default
            #line hidden
            
            #line 38 "..\..\..\..\Views\Pages\TasksPage.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.Button_MouseLeave);
            
            #line default
            #line hidden
            
            #line 38 "..\..\..\..\Views\Pages\TasksPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.editButton_Click);
            
            #line default
            #line hidden
            break;
            case 6:
            
            #line 60 "..\..\..\..\Views\Pages\TasksPage.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.Button_MouseEnter);
            
            #line default
            #line hidden
            
            #line 60 "..\..\..\..\Views\Pages\TasksPage.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.Button_MouseLeave);
            
            #line default
            #line hidden
            
            #line 60 "..\..\..\..\Views\Pages\TasksPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.editButton_Click);
            
            #line default
            #line hidden
            break;
            case 8:
            
            #line 82 "..\..\..\..\Views\Pages\TasksPage.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.Button_MouseEnter);
            
            #line default
            #line hidden
            
            #line 82 "..\..\..\..\Views\Pages\TasksPage.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.Button_MouseLeave);
            
            #line default
            #line hidden
            
            #line 82 "..\..\..\..\Views\Pages\TasksPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.editButton_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

