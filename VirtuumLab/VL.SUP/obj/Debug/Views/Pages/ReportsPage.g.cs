﻿#pragma checksum "..\..\..\..\Views\Pages\ReportsPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "283B035F8777D92FE91B5DAB4D9E8C08CD86B14B1583A451BEE353C0F42E07A5"
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
using VLSUP.Views.Pages;


namespace VLSUP.Views.Pages {
    
    
    /// <summary>
    /// ReportsPage
    /// </summary>
    public partial class ReportsPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\..\Views\Pages\ReportsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox projectBox;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\Views\Pages\ReportsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button pdfButton;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\Views\Pages\ReportsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar progressPdf;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\Views\Pages\ReportsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button excelButton;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\Views\Pages\ReportsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar progressExcel;
        
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
            System.Uri resourceLocater = new System.Uri("/VLSUP;component/views/pages/reportspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\Pages\ReportsPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
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
            this.projectBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.pdfButton = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\..\Views\Pages\ReportsPage.xaml"
            this.pdfButton.Click += new System.Windows.RoutedEventHandler(this.pdfButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.progressPdf = ((System.Windows.Controls.ProgressBar)(target));
            return;
            case 4:
            this.excelButton = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\..\Views\Pages\ReportsPage.xaml"
            this.excelButton.Click += new System.Windows.RoutedEventHandler(this.excelButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.progressExcel = ((System.Windows.Controls.ProgressBar)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

