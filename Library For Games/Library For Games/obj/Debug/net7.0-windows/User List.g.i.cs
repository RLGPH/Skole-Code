﻿#pragma checksum "..\..\..\User List.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1516B3B1229EC84557E9229144B3744A8E777945"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Library_For_Games;
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


namespace Library_For_Games {
    
    
    /// <summary>
    /// User_List
    /// </summary>
    public partial class User_List : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\User List.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_CLOSE;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\User List.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_REMOVE;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\User List.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_ADD;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\User List.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_EDIT;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\User List.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DTG_Users;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\User List.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_Search;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\User List.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border B_ID;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\User List.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_ID_SELECT;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Library For Games;V1.0.0.0;component/user%20list.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\User List.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.BTN_CLOSE = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\User List.xaml"
            this.BTN_CLOSE.Click += new System.Windows.RoutedEventHandler(this.BTN_CLOSE_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BTN_REMOVE = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\User List.xaml"
            this.BTN_REMOVE.Click += new System.Windows.RoutedEventHandler(this.BTN_REMOVE_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BTN_ADD = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\User List.xaml"
            this.BTN_ADD.Click += new System.Windows.RoutedEventHandler(this.BTN_ADD_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BTN_EDIT = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\User List.xaml"
            this.BTN_EDIT.Click += new System.Windows.RoutedEventHandler(this.BTN_EDIT_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.DTG_Users = ((System.Windows.Controls.DataGrid)(target));
            
            #line 31 "..\..\..\User List.xaml"
            this.DTG_Users.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DTG_Users_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.TB_Search = ((System.Windows.Controls.TextBox)(target));
            
            #line 50 "..\..\..\User List.xaml"
            this.TB_Search.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TB_Search_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.B_ID = ((System.Windows.Controls.Border)(target));
            return;
            case 8:
            this.TB_ID_SELECT = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

