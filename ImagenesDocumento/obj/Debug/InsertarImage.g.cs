﻿#pragma checksum "..\..\InsertarImage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "734DE7E3CBB83334C04EDDD127396805B619BF6696C68DA80FB5FECAB81FA422"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using ImagenesDocumento;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace ImagenesDocumento {
    
    
    /// <summary>
    /// InsertarImage
    /// </summary>
    public partial class InsertarImage : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\InsertarImage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TXTcodigo_docum;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\InsertarImage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TXTnombre_docum;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\InsertarImage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Tx_idrowDoc;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\InsertarImage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTNimage;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\InsertarImage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTNsubirFoto;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\InsertarImage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border border;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\InsertarImage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image image;
        
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
            System.Uri resourceLocater = new System.Uri("/ImagenesDocumento;component/insertarimage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\InsertarImage.xaml"
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
            
            #line 9 "..\..\InsertarImage.xaml"
            ((ImagenesDocumento.InsertarImage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TXTcodigo_docum = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.TXTnombre_docum = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.Tx_idrowDoc = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.BTNimage = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\InsertarImage.xaml"
            this.BTNimage.Click += new System.Windows.RoutedEventHandler(this.BTNimage_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BTNsubirFoto = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\InsertarImage.xaml"
            this.BTNsubirFoto.Click += new System.Windows.RoutedEventHandler(this.BTNsubirFoto_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.border = ((System.Windows.Controls.Border)(target));
            return;
            case 8:
            this.image = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

