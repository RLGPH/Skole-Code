﻿#pragma checksum "..\..\..\Main_Menu.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A99D87E914CB91E0EC11591FB68063E9C31CD083"
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
    /// Main_Menu
    /// </summary>
    public partial class Main_Menu : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\..\Main_Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_LIBRARY;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Main_Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_ADD_TO;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\Main_Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_Steam_Sync;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\Main_Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_Logout;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\Main_Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_Users;
        
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
            System.Uri resourceLocater = new System.Uri("/Library For Games;component/main_menu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Main_Menu.xaml"
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
            this.BTN_LIBRARY = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\Main_Menu.xaml"
            this.BTN_LIBRARY.Click += new System.Windows.RoutedEventHandler(this.BTN_LIBRARY_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BTN_ADD_TO = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\Main_Menu.xaml"
            this.BTN_ADD_TO.Click += new System.Windows.RoutedEventHandler(this.BTN_ADD_TO_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BTN_Steam_Sync = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\..\Main_Menu.xaml"
            this.BTN_Steam_Sync.Click += new System.Windows.RoutedEventHandler(this.BTN_Steam_Sync_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BTN_Logout = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\..\Main_Menu.xaml"
            this.BTN_Logout.Click += new System.Windows.RoutedEventHandler(this.BTN_Logout_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BTN_Users = ((System.Windows.Controls.Button)(target));
            
            #line 70 "..\..\..\Main_Menu.xaml"
            this.BTN_Users.Click += new System.Windows.RoutedEventHandler(this.BTN_Users_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

