﻿#pragma checksum "..\..\VehicleLoan.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9F9B2471EAA541485533620412E20FD2FCF333E1369AE3DE370A9E9DCA1BA025"
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
    /// VehicleLoan
    /// </summary>
    public partial class VehicleLoan : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 37 "..\..\VehicleLoan.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_Exit;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\VehicleLoan.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_Back;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\VehicleLoan.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBox_ModelAndMake;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\VehicleLoan.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBox_VehiclePrice;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\VehicleLoan.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBox_VehicleDeposit;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\VehicleLoan.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBox_VehicleInterest;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\VehicleLoan.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBox_VehicleInsurance;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\VehicleLoan.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_Submit;
        
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
            System.Uri resourceLocater = new System.Uri("/Final_POE;component/vehicleloan.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\VehicleLoan.xaml"
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
            
            #line 38 "..\..\VehicleLoan.xaml"
            this.Btn_Exit.Click += new System.Windows.RoutedEventHandler(this.Btn_Exit_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Btn_Back = ((System.Windows.Controls.Button)(target));
            
            #line 62 "..\..\VehicleLoan.xaml"
            this.Btn_Back.Click += new System.Windows.RoutedEventHandler(this.Btn_Back_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtBox_ModelAndMake = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtBox_VehiclePrice = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtBox_VehicleDeposit = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtBox_VehicleInterest = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txtBox_VehicleInsurance = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.Btn_Submit = ((System.Windows.Controls.Button)(target));
            
            #line 116 "..\..\VehicleLoan.xaml"
            this.Btn_Submit.Click += new System.Windows.RoutedEventHandler(this.Btn_Submit_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

