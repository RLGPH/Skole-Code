﻿#pragma checksum "..\..\..\Custom Pizza.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1C2943681120DBC0AEF28D45B25240641D1C3893"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Pizza_menu;
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


namespace Pizza_menu {
    
    
    /// <summary>
    /// Custom_Pizza
    /// </summary>
    public partial class Custom_Pizza : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\Custom Pizza.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid dtg_Pizza;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\Custom Pizza.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_add;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\Custom Pizza.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Remove_Topping;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Custom Pizza.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_price_custom;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Custom Pizza.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Save;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Custom Pizza.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_GoBack;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Custom Pizza.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dtg_Toppings;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Custom Pizza.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dtg_PizzaWToppings;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Custom Pizza.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_Selected_pizza;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.11.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Pizza menu;V1.0.0.0;component/custom%20pizza.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Custom Pizza.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.11.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.dtg_Pizza = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.btn_add = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\Custom Pizza.xaml"
            this.btn_add.Click += new System.Windows.RoutedEventHandler(this.btn_add_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btn_Remove_Topping = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\Custom Pizza.xaml"
            this.btn_Remove_Topping.Click += new System.Windows.RoutedEventHandler(this.btn_Remove_Topping_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.tb_price_custom = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.btn_Save = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\Custom Pizza.xaml"
            this.btn_Save.Click += new System.Windows.RoutedEventHandler(this.btn_Save_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btn_GoBack = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\Custom Pizza.xaml"
            this.btn_GoBack.Click += new System.Windows.RoutedEventHandler(this.btn_GoBack_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.dtg_Toppings = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 8:
            this.dtg_PizzaWToppings = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 9:
            this.tb_Selected_pizza = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

