﻿#pragma checksum "..\..\..\Plotter.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "DC4CBFA3EAF2257B07FC515F1B57E9802FD3A8E9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Plotter;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace Plotter {
    
    
    /// <summary>
    /// Plotter
    /// </summary>
    public partial class Plotter : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\Plotter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Plotter.Plotter winPlotter;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Plotter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ColumnDefinition colDefKeret;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Plotter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border brdKulsoKeret;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Plotter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas rajzlap;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Plotter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Fej;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Plotter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grdBolcsok;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Plotter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border brdVezerloGombok;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Plotter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBezar;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Plotter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnInfo;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/PlotterFeladat;component/plotter.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Plotter.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.winPlotter = ((Plotter.Plotter)(target));
            
            #line 11 "..\..\..\Plotter.xaml"
            this.winPlotter.Loaded += new System.Windows.RoutedEventHandler(this.InditoKep);
            
            #line default
            #line hidden
            return;
            case 2:
            this.colDefKeret = ((System.Windows.Controls.ColumnDefinition)(target));
            return;
            case 3:
            this.brdKulsoKeret = ((System.Windows.Controls.Border)(target));
            return;
            case 4:
            this.rajzlap = ((System.Windows.Controls.Canvas)(target));
            return;
            case 5:
            this.Fej = ((System.Windows.Controls.Image)(target));
            return;
            case 6:
            this.grdBolcsok = ((System.Windows.Controls.Grid)(target));
            return;
            case 7:
            this.brdVezerloGombok = ((System.Windows.Controls.Border)(target));
            return;
            case 8:
            this.btnBezar = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\Plotter.xaml"
            this.btnBezar.Click += new System.Windows.RoutedEventHandler(this.btnPlotterKikapcsolas);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnInfo = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\Plotter.xaml"
            this.btnInfo.Click += new System.Windows.RoutedEventHandler(this.btnPlotterInformacio);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

