﻿#pragma checksum "..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "947D267BFE931632726FA01BF26D656084669BC8"
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
using ToDoListDapper;


namespace ToDoListDapper {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 268 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabControl tabControl1;
        
        #line default
        #line hidden
        
        
        #line 297 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem BusinessTab;
        
        #line default
        #line hidden
        
        
        #line 315 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Categories;
        
        #line default
        #line hidden
        
        
        #line 320 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button tabVisible;
        
        #line default
        #line hidden
        
        
        #line 322 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView BusinessListView;
        
        #line default
        #line hidden
        
        
        #line 327 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridView GridViewWithStyle;
        
        #line default
        #line hidden
        
        
        #line 348 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem CategoryTab;
        
        #line default
        #line hidden
        
        
        #line 362 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView CategoriesListView;
        
        #line default
        #line hidden
        
        
        #line 448 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem CalenderTab;
        
        #line default
        #line hidden
        
        
        #line 461 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Calendar calendar;
        
        #line default
        #line hidden
        
        
        #line 464 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView CalenderCategoriesListView;
        
        #line default
        #line hidden
        
        
        #line 527 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridView GridViewWithStyleCalender;
        
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
            System.Uri resourceLocater = new System.Uri("/ToDoListDapper;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.tabControl1 = ((System.Windows.Controls.TabControl)(target));
            return;
            case 2:
            this.BusinessTab = ((System.Windows.Controls.TabItem)(target));
            return;
            case 3:
            
            #line 301 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Label)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.CategoriestabItem1_Clicked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Categories = ((System.Windows.Controls.ComboBox)(target));
            
            #line 315 "..\..\MainWindow.xaml"
            this.Categories.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.chan);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 316 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GoToCategories);
            
            #line default
            #line hidden
            return;
            case 6:
            this.tabVisible = ((System.Windows.Controls.Button)(target));
            
            #line 320 "..\..\MainWindow.xaml"
            this.tabVisible.Click += new System.Windows.RoutedEventHandler(this.TabVisible);
            
            #line default
            #line hidden
            return;
            case 7:
            this.BusinessListView = ((System.Windows.Controls.ListView)(target));
            
            #line 322 "..\..\MainWindow.xaml"
            this.BusinessListView.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.editBusiness);
            
            #line default
            #line hidden
            return;
            case 8:
            this.GridViewWithStyle = ((System.Windows.Controls.GridView)(target));
            return;
            case 9:
            
            #line 337 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.NullBusiness);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 338 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AllBusiness);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 339 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddBusiness);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 340 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DeleteBusiness);
            
            #line default
            #line hidden
            return;
            case 13:
            this.CategoryTab = ((System.Windows.Controls.TabItem)(target));
            return;
            case 14:
            
            #line 359 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GoToBusinnes);
            
            #line default
            #line hidden
            return;
            case 15:
            this.CategoriesListView = ((System.Windows.Controls.ListView)(target));
            
            #line 362 "..\..\MainWindow.xaml"
            this.CategoriesListView.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.EditCategory);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 439 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddCategory);
            
            #line default
            #line hidden
            return;
            case 17:
            
            #line 440 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DeleteCategory);
            
            #line default
            #line hidden
            return;
            case 18:
            this.CalenderTab = ((System.Windows.Controls.TabItem)(target));
            return;
            case 19:
            this.calendar = ((System.Windows.Controls.Calendar)(target));
            
            #line 461 "..\..\MainWindow.xaml"
            this.calendar.SelectedDatesChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.Selecteddatechanged);
            
            #line default
            #line hidden
            return;
            case 20:
            this.CalenderCategoriesListView = ((System.Windows.Controls.ListView)(target));
            return;
            case 21:
            this.GridViewWithStyleCalender = ((System.Windows.Controls.GridView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
