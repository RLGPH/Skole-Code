﻿#pragma checksum "..\..\..\Add to library.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E9E53C92EBABC32800B6EC2080EBF5845D75EC57"
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
    /// Add_to_library
    /// </summary>
    public partial class Add_to_library : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\Add to library.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_Game_Name;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Add to library.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_Hours_Played;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Add to library.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox CHB_Steam;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Add to library.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox CHB_Epic;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Add to library.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox CHB_Other;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Add to library.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_DESCRIPTION;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Add to library.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_Close_without_Save;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Add to library.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_Close_and_save;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\Add to library.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_ID;
        
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
            System.Uri resourceLocater = new System.Uri("/Library For Games;component/add%20to%20library.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Add to library.xaml"
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
            this.TB_Game_Name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.TB_Hours_Played = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.CHB_Steam = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 4:
            this.CHB_Epic = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 5:
            this.CHB_Other = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 6:
            this.TB_DESCRIPTION = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.BTN_Close_without_Save = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\Add to library.xaml"
            this.BTN_Close_without_Save.Click += new System.Windows.RoutedEventHandler(this.BTN_Close_without_Save_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.BTN_Close_and_save = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\Add to library.xaml"
            this.BTN_Close_and_save.Click += new System.Windows.RoutedEventHandler(this.BTN_Close_and_save_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.TB_ID = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

