﻿#pragma checksum "..\..\..\..\..\..\部门模块\部门选择模块\人事部门\人事部门功能页\AllDepartment.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05634ABFA3AB9D707ECDCF93B4B06F4E3FF02F5D"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

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
using 高级人事管理系统.部门模块.部门选择模块.人事部门.人事部门功能页;


namespace 高级人事管理系统.部门模块.部门选择模块.人事部门.人事部门功能页 {
    
    
    /// <summary>
    /// AllDepartment
    /// </summary>
    public partial class AllDepartment : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 10 "..\..\..\..\..\..\部门模块\部门选择模块\人事部门\人事部门功能页\AllDepartment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid dataAsso;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\..\..\部门模块\部门选择模块\人事部门\人事部门功能页\AllDepartment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataDepartAndStaff;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\..\..\部门模块\部门选择模块\人事部门\人事部门功能页\AllDepartment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataChangeStaffSalary;
        
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
            System.Uri resourceLocater = new System.Uri("/高级人事管理系统;component/%e9%83%a8%e9%97%a8%e6%a8%a1%e5%9d%97/%e9%83%a8%e9%97%a8%e9%80" +
                    "%89%e6%8b%a9%e6%a8%a1%e5%9d%97/%e4%ba%ba%e4%ba%8b%e9%83%a8%e9%97%a8/%e4%ba%ba%e4" +
                    "%ba%8b%e9%83%a8%e9%97%a8%e5%8a%9f%e8%83%bd%e9%a1%b5/alldepartment.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\部门模块\部门选择模块\人事部门\人事部门功能页\AllDepartment.xaml"
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
            this.dataAsso = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.dataDepartAndStaff = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.dataChangeStaffSalary = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 4:
            
            #line 38 "..\..\..\..\..\..\部门模块\部门选择模块\人事部门\人事部门功能页\AllDepartment.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.saveChange);
            
            #line default
            #line hidden
            break;
            case 5:
            
            #line 47 "..\..\..\..\..\..\部门模块\部门选择模块\人事部门\人事部门功能页\AllDepartment.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.deleteStaff);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

