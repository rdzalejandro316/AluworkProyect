﻿#pragma checksum "..\..\ImportacionContable.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1C98DB8F56612F2E86BC2C8D8066AAA4D88C5CE2"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using SiasoftAppExt;
using Syncfusion;
using Syncfusion.UI.Xaml.Controls.DataPager;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Grid.Converter;
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


namespace SiasoftAppExt {
    
    
    /// <summary>
    /// ImportacionContable
    /// </summary>
    public partial class ImportacionContable : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 35 "..\..\ImportacionContable.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Val;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\ImportacionContable.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Tx_val;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\ImportacionContable.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnImpo;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\ImportacionContable.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnPlant;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\ImportacionContable.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Syncfusion.UI.Xaml.Grid.SfDataGrid dataGridExcel;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\ImportacionContable.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Syncfusion.Windows.Controls.Notification.SfBusyIndicator sfBusyIndicator;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\ImportacionContable.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Tx_deb;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\ImportacionContable.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Tx_cre;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\ImportacionContable.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnGenerar;
        
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
            System.Uri resourceLocater = new System.Uri("/ImportacionContable;component/importacioncontable.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ImportacionContable.xaml"
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
            this.Val = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.Tx_val = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.BtnImpo = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\ImportacionContable.xaml"
            this.BtnImpo.Click += new System.Windows.RoutedEventHandler(this.BtnImpo_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BtnPlant = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\ImportacionContable.xaml"
            this.BtnPlant.Click += new System.Windows.RoutedEventHandler(this.BtnPlant_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.dataGridExcel = ((Syncfusion.UI.Xaml.Grid.SfDataGrid)(target));
            return;
            case 6:
            this.sfBusyIndicator = ((Syncfusion.Windows.Controls.Notification.SfBusyIndicator)(target));
            return;
            case 7:
            this.Tx_deb = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.Tx_cre = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.BtnGenerar = ((System.Windows.Controls.Button)(target));
            
            #line 103 "..\..\ImportacionContable.xaml"
            this.BtnGenerar.Click += new System.Windows.RoutedEventHandler(this.BtnGenerar_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
