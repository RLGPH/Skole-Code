﻿#pragma checksum "..\..\..\Most Played Save.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87F94801BE3BAB4CFFD088B9F221D5862E5C5649"
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
    /// Most_Played_Save
    /// </summary>
    public partial class Most_Played_Save : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\Most Played Save.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DTG_Games;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Most Played Save.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border B_Filter;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Most Played Save.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CBB_Filter;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\Most Played Save.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_REMOVE;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\Most Played Save.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_ADD;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\Most Played Save.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_CLOSE;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\Most Played Save.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_EDIT;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\Most Played Save.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border B_ID;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\Most Played Save.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_ID_SELECT;
        
        #line default
        #line hidden
        
        
        #line 118 "..\..\..\Most Played Save.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_Search;
        
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
            System.Uri resourceLocater = new System.Uri("/Library For Games;component/most%20played%20save.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Most Played Save.xaml"
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
            this.DTG_Games = ((System.Windows.Controls.DataGrid)(target));
            
            #line 27 "..\..\..\Most Played Save.xaml"
            this.DTG_Games.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DTG_Games_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.B_Filter = ((System.Windows.Controls.Border)(target));
            return;
            case 3:
            this.CBB_Filter = ((System.Windows.Controls.ComboBox)(target));
            
            #line 49 "..\..\..\Most Played Save.xaml"
            this.CBB_Filter.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CBB_Filter_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BTN_REMOVE = ((System.Windows.Controls.Button)(target));
            
            #line 64 "..\..\..\Most Played Save.xaml"
            this.BTN_REMOVE.Click += new System.Windows.RoutedEventHandler(this.BTN_REMOVE_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BTN_ADD = ((System.Windows.Controls.Button)(target));
            
            #line 71 "..\..\..\Most Played Save.xaml"
            this.BTN_ADD.Click += new System.Windows.RoutedEventHandler(this.BTN_ADD_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BTN_CLOSE = ((System.Windows.Controls.Button)(target));
            
            #line 81 "..\..\..\Most Played Save.xaml"
            this.BTN_CLOSE.Click += new System.Windows.RoutedEventHandler(this.BTN_CLOSE_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.BTN_EDIT = ((System.Windows.Controls.Button)(target));
            
            #line 88 "..\..\..\Most Played Save.xaml"
            this.BTN_EDIT.Click += new System.Windows.RoutedEventHandler(this.BTN_EDIT_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.B_ID = ((System.Windows.Controls.Border)(target));
            return;
            case 9:
            this.TB_ID_SELECT = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.TB_Search = ((System.Windows.Controls.TextBox)(target));
            
            #line 118 "..\..\..\Most Played Save.xaml"
            this.TB_Search.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TB_Search_TextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

