﻿#pragma checksum "..\..\..\Main\MainWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "FB2DA08A4FAD5D7C0636FAC298D74F77"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DotNetSourceBuilder;
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


namespace DotNetSourceBuilder {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\..\Main\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DotNetSourceBuilder.MainWindow Visual_Studio_Manual_Builder;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Main\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBuild;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Main\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSolutionPath;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Main\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnOpenFile;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Main\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chkCopyBuildBin;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Main\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDestinationBinPath;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Main\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblBuildDestinationFolder;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Main\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtOutput;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Main\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblExtensionPatternToCopy;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Main\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtExtensionPattern;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\Main\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnOpenDestinationBinPath;
        
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
            System.Uri resourceLocater = new System.Uri("/TaskRunner;component/main/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Main\MainWindow.xaml"
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
            this.Visual_Studio_Manual_Builder = ((DotNetSourceBuilder.MainWindow)(target));
            return;
            case 2:
            this.btnBuild = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\Main\MainWindow.xaml"
            this.btnBuild.Click += new System.Windows.RoutedEventHandler(this.btnBuild_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtSolutionPath = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.btnOpenFile = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\Main\MainWindow.xaml"
            this.btnOpenFile.Click += new System.Windows.RoutedEventHandler(this.btnOpenFile_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.chkCopyBuildBin = ((System.Windows.Controls.CheckBox)(target));
            
            #line 30 "..\..\..\Main\MainWindow.xaml"
            this.chkCopyBuildBin.Checked += new System.Windows.RoutedEventHandler(this.CheckBox_Checked);
            
            #line default
            #line hidden
            
            #line 30 "..\..\..\Main\MainWindow.xaml"
            this.chkCopyBuildBin.Unchecked += new System.Windows.RoutedEventHandler(this.CheckBox_UnChecked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtDestinationBinPath = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.lblBuildDestinationFolder = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.txtOutput = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.lblExtensionPatternToCopy = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.txtExtensionPattern = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.btnOpenDestinationBinPath = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\Main\MainWindow.xaml"
            this.btnOpenDestinationBinPath.Click += new System.Windows.RoutedEventHandler(this.btnOpenDestinationBinPath_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

