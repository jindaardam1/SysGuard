﻿#pragma checksum "..\..\MenuPrincipal.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6C207D83AFBCFE93AED8589E7C932DEF6AAD5FB6AB5FDB09F753F5A7F3B0D7FC"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using SysGuard;
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


namespace SysGuard {
    
    
    /// <summary>
    /// MenuPrincipal
    /// </summary>
    public partial class MenuPrincipal : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\MenuPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridBarraSuperior;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\MenuPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridCPU;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\MenuPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock NombreProcesador;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\MenuPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock miTextBlock;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\MenuPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridRAM;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\MenuPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock CantidadRAM;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\MenuPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock PorcentajeRAM;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\MenuPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridGPU;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\MenuPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock NombreGrafica;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\MenuPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TemperaturaGrafica;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\MenuPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridBarraMenuIzquierda;
        
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
            System.Uri resourceLocater = new System.Uri("/SysGuard;component/menuprincipal.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MenuPrincipal.xaml"
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
            this.GridBarraSuperior = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.GridCPU = ((System.Windows.Controls.Grid)(target));
            
            #line 38 "..\..\MenuPrincipal.xaml"
            this.GridCPU.Loaded += new System.Windows.RoutedEventHandler(this.GridProcesador_OnLoaded);
            
            #line default
            #line hidden
            return;
            case 3:
            this.NombreProcesador = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.miTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.GridRAM = ((System.Windows.Controls.Grid)(target));
            
            #line 54 "..\..\MenuPrincipal.xaml"
            this.GridRAM.Loaded += new System.Windows.RoutedEventHandler(this.GridRAM_OnLoaded);
            
            #line default
            #line hidden
            return;
            case 6:
            this.CantidadRAM = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.PorcentajeRAM = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.GridGPU = ((System.Windows.Controls.Grid)(target));
            
            #line 68 "..\..\MenuPrincipal.xaml"
            this.GridGPU.Loaded += new System.Windows.RoutedEventHandler(this.GridGrafica_OnLoaded);
            
            #line default
            #line hidden
            return;
            case 9:
            this.NombreGrafica = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.TemperaturaGrafica = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 11:
            this.GridBarraMenuIzquierda = ((System.Windows.Controls.Grid)(target));
            return;
            case 12:
            
            #line 96 "..\..\MenuPrincipal.xaml"
            ((System.Windows.Controls.Border)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.Monitoreo_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 103 "..\..\MenuPrincipal.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.Benchmark_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 109 "..\..\MenuPrincipal.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.Stress_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 115 "..\..\MenuPrincipal.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.Ajustes_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

