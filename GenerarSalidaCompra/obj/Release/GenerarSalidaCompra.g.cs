﻿#pragma checksum "..\..\GenerarSalidaCompra.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8A1A56F1E3F54BF814D3E4CA2B921DCC1998C164E26AC7F55C8731A3617A00D0"
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
    /// GenerarSalidaCompra
    /// </summary>
    public partial class GenerarSalidaCompra : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\GenerarSalidaCompra.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Tx_compra;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\GenerarSalidaCompra.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker Tx_fecha;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\GenerarSalidaCompra.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnGenerar;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\GenerarSalidaCompra.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnSalir;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\GenerarSalidaCompra.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Grid;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\GenerarSalidaCompra.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Tx_document;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\GenerarSalidaCompra.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnDoc;
        
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
            System.Uri resourceLocater = new System.Uri("/GenerarSalidaCompra;component/generarsalidacompra.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\GenerarSalidaCompra.xaml"
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
            
            #line 7 "..\..\GenerarSalidaCompra.xaml"
            ((SiasoftAppExt.GenerarSalidaCompra)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Tx_compra = ((System.Windows.Controls.TextBox)(target));
            
            #line 34 "..\..\GenerarSalidaCompra.xaml"
            this.Tx_compra.LostFocus += new System.Windows.RoutedEventHandler(this.Tx__LostFocus);
            
            #line default
            #line hidden
            
            #line 34 "..\..\GenerarSalidaCompra.xaml"
            this.Tx_compra.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.Tx__PreviewKeyDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Tx_fecha = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.BtnGenerar = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\GenerarSalidaCompra.xaml"
            this.BtnGenerar.Click += new System.Windows.RoutedEventHandler(this.BtnGenerar_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BtnSalir = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\GenerarSalidaCompra.xaml"
            this.BtnSalir.Click += new System.Windows.RoutedEventHandler(this.BtnSalir_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Grid = ((System.Windows.Controls.Grid)(target));
            return;
            case 7:
            this.Tx_document = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.BtnDoc = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\GenerarSalidaCompra.xaml"
            this.BtnDoc.Click += new System.Windows.RoutedEventHandler(this.BtnDoc_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

