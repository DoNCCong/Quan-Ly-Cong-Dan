﻿#pragma checksum "..\..\..\..\..\FUserControls\CongDan\ThongTinCD\ThongTinCaNhan.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B06C7BD1394589CFF1363D0B019F22AEAA366478"
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
using QuanLyCDTP;
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


namespace QuanLyCDTP {
    
    
    /// <summary>
    /// ThongTinCaNhan
    /// </summary>
    public partial class ThongTinCaNhan : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\..\..\FUserControls\CongDan\ThongTinCD\ThongTinCaNhan.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal QuanLyCDTP.ThongTinCaNhan tracuu;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\..\FUserControls\CongDan\ThongTinCD\ThongTinCaNhan.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border boHienthi;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\..\FUserControls\CongDan\ThongTinCD\ThongTinCaNhan.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid ThongTin;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\..\FUserControls\CongDan\ThongTinCD\ThongTinCaNhan.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridhienthi;
        
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
            System.Uri resourceLocater = new System.Uri("/QuanLyCDTP;component/fusercontrols/congdan/thongtincd/thongtincanhan.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\FUserControls\CongDan\ThongTinCD\ThongTinCaNhan.xaml"
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
            this.tracuu = ((QuanLyCDTP.ThongTinCaNhan)(target));
            return;
            case 2:
            
            #line 23 "..\..\..\..\..\FUserControls\CongDan\ThongTinCD\ThongTinCaNhan.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btn_cmnd_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 24 "..\..\..\..\..\FUserControls\CongDan\ThongTinCD\ThongTinCaNhan.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnHoKhau_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.boHienthi = ((System.Windows.Controls.Border)(target));
            return;
            case 5:
            this.ThongTin = ((System.Windows.Controls.Grid)(target));
            return;
            case 6:
            this.gridhienthi = ((System.Windows.Controls.Grid)(target));
            return;
            case 7:
            
            #line 53 "..\..\..\..\..\FUserControls\CongDan\ThongTinCD\ThongTinCaNhan.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LamSach);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

