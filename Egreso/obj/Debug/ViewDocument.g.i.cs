﻿#pragma checksum "..\..\ViewDocument.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32054FD35775945B04D978CE5B58B856608419A9"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Egreso;
using Syncfusion;
using Syncfusion.UI.Xaml.Controls.DataPager;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Grid.RowFilter;
using Syncfusion.UI.Xaml.TreeGrid;
using Syncfusion.Windows;
using Syncfusion.Windows.Controls.Notification;
using Syncfusion.Windows.Shared;
using Syncfusion.Windows.Tools.Controls;
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


namespace Egreso {
    
    
    /// <summary>
    /// ViewDocument
    /// </summary>
    public partial class ViewDocument : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 53 "..\..\ViewDocument.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Syncfusion.UI.Xaml.Grid.SfDataGrid dataGridCab;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\ViewDocument.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Syncfusion.UI.Xaml.Grid.SfDataGrid dataGridCue;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\ViewDocument.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TotDeb;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\ViewDocument.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TotCre;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\ViewDocument.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Dife;
        
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
            System.Uri resourceLocater = new System.Uri("/Egreso;component/viewdocument.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ViewDocument.xaml"
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
            
            #line 9 "..\..\ViewDocument.xaml"
            ((Egreso.ViewDocument)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.dataGridCab = ((Syncfusion.UI.Xaml.Grid.SfDataGrid)(target));
            
            #line 53 "..\..\ViewDocument.xaml"
            this.dataGridCab.SelectionChanged += new Syncfusion.UI.Xaml.Grid.GridSelectionChangedEventHandler(this.DataGridCab_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.dataGridCue = ((Syncfusion.UI.Xaml.Grid.SfDataGrid)(target));
            
            #line 79 "..\..\ViewDocument.xaml"
            this.dataGridCue.SelectionChanged += new Syncfusion.UI.Xaml.Grid.GridSelectionChangedEventHandler(this.DataGridCab_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TotDeb = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.TotCre = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.Dife = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

