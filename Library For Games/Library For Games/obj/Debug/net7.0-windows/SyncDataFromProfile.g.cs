﻿#pragma checksum "..\..\..\SyncDataFromProfile.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C90C35FABA9FC2F4613974F0E50EBC2A3F96C70B"
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
    /// SyncDataFromProfile
    /// </summary>
    public partial class SyncDataFromProfile : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\SyncDataFromProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_GET_STEAM;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\SyncDataFromProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_Updated_steam;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\SyncDataFromProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_SteamID;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\SyncDataFromProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_API_KEY;
        
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
            System.Uri resourceLocater = new System.Uri("/Library For Games;component/syncdatafromprofile.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\SyncDataFromProfile.xaml"
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
            this.BTN_GET_STEAM = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\SyncDataFromProfile.xaml"
            this.BTN_GET_STEAM.Click += new System.Windows.RoutedEventHandler(this.BTN_GET_STEAM_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BTN_Updated_steam = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\SyncDataFromProfile.xaml"
            this.BTN_Updated_steam.Click += new System.Windows.RoutedEventHandler(this.BTN_Updated_steam_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TB_SteamID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.TB_API_KEY = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

