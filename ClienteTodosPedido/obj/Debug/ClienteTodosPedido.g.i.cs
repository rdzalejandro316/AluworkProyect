﻿#pragma checksum "..\..\ClienteTodosPedido.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E3C25C1EC06C3F1E5823A5CD74151847F1BB2AC0"
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
    /// ClienteTodosPedido
    /// </summary>
    public partial class ClienteTodosPedido : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 35 "..\..\ClienteTodosPedido.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tx_name;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\ClienteTodosPedido.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnExportar;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\ClienteTodosPedido.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Syncfusion.UI.Xaml.Grid.SfDataGrid dataGridPedidos;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\ClienteTodosPedido.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Syncfusion.Windows.Controls.Notification.SfBusyIndicator sfBusyIndicator;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\ClienteTodosPedido.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Tx_total;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\ClienteTodosPedido.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnFacturar;
        
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
            System.Uri resourceLocater = new System.Uri("/ClienteTodosPedido;component/clientetodospedido.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ClienteTodosPedido.xaml"
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
            
            #line 8 "..\..\ClienteTodosPedido.xaml"
            ((SiasoftAppExt.ClienteTodosPedido)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            
            #line 8 "..\..\ClienteTodosPedido.xaml"
            ((SiasoftAppExt.ClienteTodosPedido)(target)).PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.Window_PreviewKeyDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tx_name = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.BtnExportar = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\ClienteTodosPedido.xaml"
            this.BtnExportar.Click += new System.Windows.RoutedEventHandler(this.BtnExportar_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.dataGridPedidos = ((Syncfusion.UI.Xaml.Grid.SfDataGrid)(target));
            return;
            case 7:
            this.sfBusyIndicator = ((Syncfusion.Windows.Controls.Notification.SfBusyIndicator)(target));
            return;
            case 8:
            this.Tx_total = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.BtnFacturar = ((System.Windows.Controls.Button)(target));
            
            #line 93 "..\..\ClienteTodosPedido.xaml"
            this.BtnFacturar.Click += new System.Windows.RoutedEventHandler(this.BtnFacturar_Click);
            
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
            case 5:
            
            #line 48 "..\..\ClienteTodosPedido.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnPedido_Click);
            
            #line default
            #line hidden
            break;
            case 6:
            
            #line 56 "..\..\ClienteTodosPedido.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Checked += new System.Windows.RoutedEventHandler(this.CheckBox_Checked);
            
            #line default
            #line hidden
            
            #line 56 "..\..\ClienteTodosPedido.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.CheckBox_Unchecked);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

