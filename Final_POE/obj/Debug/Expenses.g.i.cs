// Updated by XamlIntelliSenseFileGenerator 2021/07/06 12:09:36
#pragma checksum "..\..\Expenses.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C1C0D97ADC23300E5536456E6CEBC26CC5D833A77DE58E9D48E59F3731529FF5"
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


namespace Final_POE
{


    /// <summary>
    /// Expenses
    /// </summary>
    public partial class Expenses : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 34 "..\..\Expenses.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_Exit;

#line default
#line hidden


#line 58 "..\..\Expenses.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_Back;

#line default
#line hidden


#line 91 "..\..\Expenses.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBox_Income;

#line default
#line hidden


#line 99 "..\..\Expenses.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBox_Groceries;

#line default
#line hidden


#line 103 "..\..\Expenses.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBox_WaterAndElectricity;

#line default
#line hidden


#line 107 "..\..\Expenses.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBox_TravelCosts;

#line default
#line hidden


#line 111 "..\..\Expenses.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBox_Tele;

#line default
#line hidden


#line 115 "..\..\Expenses.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBox_OtherExp;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Final_POE;component/expenses.xaml", System.UriKind.Relative);

#line 1 "..\..\Expenses.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.Btn_Exit = ((System.Windows.Controls.Button)(target));

#line 35 "..\..\Expenses.xaml"
                    this.Btn_Exit.Click += new System.Windows.RoutedEventHandler(this.Btn_Exit_Click);

#line default
#line hidden
                    return;
                case 2:
                    this.Btn_Back = ((System.Windows.Controls.Button)(target));

#line 59 "..\..\Expenses.xaml"
                    this.Btn_Back.Click += new System.Windows.RoutedEventHandler(this.Btn_Back_Click);

#line default
#line hidden
                    return;
                case 3:
                    this.txtBox_Income = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 4:
                    this.txtBox_Groceries = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 5:
                    this.txtBox_WaterAndElectricity = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 6:
                    this.txtBox_TravelCosts = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 7:
                    this.txtBox_Tele = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 8:
                    this.txtBox_OtherExp = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 9:
                    this.Btn_Sub = ((System.Windows.Controls.Button)(target));

#line 117 "..\..\Expenses.xaml"
                    this.Btn_Sub.Click += new System.Windows.RoutedEventHandler(this.Btn_Sub_Click);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.Button Btn_Submit;
    }
}

