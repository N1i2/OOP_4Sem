﻿#pragma checksum "..\..\..\..\user\Login.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9874F8A227A736B37E04A3F12281A8E4D31655AF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using laba4;


namespace laba4 {
    
    
    /// <summary>
    /// Login
    /// </summary>
    public partial class Login : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\..\user\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid fon;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\user\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button but;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\..\user\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ansverPassword;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\..\user\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox passwordBox;
        
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
            System.Uri resourceLocater = new System.Uri("/laba4;component/user/login.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\user\Login.xaml"
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
            this.fon = ((System.Windows.Controls.Grid)(target));
            
            #line 11 "..\..\..\..\user\Login.xaml"
            this.fon.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ButtonDownFone);
            
            #line default
            #line hidden
            
            #line 11 "..\..\..\..\user\Login.xaml"
            this.fon.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.ButtonUpFone);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 34 "..\..\..\..\user\Login.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.TextBlock_MouseDown);
            
            #line default
            #line hidden
            
            #line 35 "..\..\..\..\user\Login.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.TextBlock_MouseUp);
            
            #line default
            #line hidden
            return;
            case 3:
            this.but = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\..\user\Login.xaml"
            this.but.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ButtonDown);
            
            #line default
            #line hidden
            
            #line 44 "..\..\..\..\user\Login.xaml"
            this.but.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.ButtonUp);
            
            #line default
            #line hidden
            
            #line 46 "..\..\..\..\user\Login.xaml"
            this.but.Click += new System.Windows.RoutedEventHandler(this.ButtonClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ansverPassword = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.passwordBox = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 76 "..\..\..\..\user\Login.xaml"
            this.passwordBox.KeyUp += new System.Windows.Input.KeyEventHandler(this.passwordBox_KeyUp);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

