﻿#pragma checksum "..\..\..\UserControls\Fsohokhau.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7C8CF71CBBBCFD5C2992A3A2E67EABD6649C0B7BCF87AC1E75DDF7B0CDE24B2E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FontAwesome.Sharp;
using QuanLyCDTP.User_Controls;
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


namespace QuanLyCDTP.User_Controls {
    
    
    /// <summary>
    /// Fsohokhau
    /// </summary>
    public partial class Fsohokhau : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\UserControls\Fsohokhau.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal QuanLyCDTP.User_Controls.InfoCard TimKiemHK;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\UserControls\Fsohokhau.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridhienthi;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\UserControls\Fsohokhau.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Them;
        
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
            System.Uri resourceLocater = new System.Uri("/QuanLyCDTP;component/usercontrols/fsohokhau.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UserControls\Fsohokhau.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.TimKiemHK = ((QuanLyCDTP.User_Controls.InfoCard)(target));
            return;
            case 2:
            
            #line 20 "..\..\..\UserControls\Fsohokhau.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ClickTimKiem);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 23 "..\..\..\UserControls\Fsohokhau.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnNext_click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 26 "..\..\..\UserControls\Fsohokhau.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnPrev_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.gridhienthi = ((System.Windows.Controls.Grid)(target));
            return;
            case 6:
            this.Them = ((System.Windows.Controls.Grid)(target));
            return;
            case 7:
            
            #line 31 "..\..\..\UserControls\Fsohokhau.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BTThemThanhVien);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

