﻿#pragma checksum "..\..\HomeRentOrBuy.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F68A9483081E27B7861AFE63B8C932955ED4D8AD255C9CB82C9BF9560BCC3D97"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Final_POE;
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


namespace Final_POE {
    
    
    /// <summary>
    /// HomeRentOrBuy
    /// </summary>
    public partial class HomeRentOrBuy : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 36 "..\..\HomeRentOrBuy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_Exit;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\HomeRentOrBuy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_Back;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\HomeRentOrBuy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_Buy;
        
        #line default
        #line hidden
        
        
        #line 115 "..\..\HomeRentOrBuy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_Rent;
        
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
            System.Uri resourceLocater = new System.Uri("/Final_POE;component/homerentorbuy.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\HomeRentOrBuy.xaml"
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
            this.Btn_Exit = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\HomeRentOrBuy.xaml"
            this.Btn_Exit.Click += new System.Windows.RoutedEventHandler(this.Btn_Exit_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Btn_Back = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\HomeRentOrBuy.xaml"
            this.Btn_Back.Click += new System.Windows.RoutedEventHandler(this.Btn_Back_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Btn_Buy = ((System.Windows.Controls.Button)(target));
            
            #line 92 "..\..\HomeRentOrBuy.xaml"
            this.Btn_Buy.Click += new System.Windows.RoutedEventHandler(this.Btn_Buy_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Btn_Rent = ((System.Windows.Controls.Button)(target));
            
            #line 115 "..\..\HomeRentOrBuy.xaml"
            this.Btn_Rent.Click += new System.Windows.RoutedEventHandler(this.Btn_Rent_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
