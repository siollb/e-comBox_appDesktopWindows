﻿#pragma checksum "..\..\..\Docker\docker.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D866CA2A63F01CC1EA1EF7C9F704F3384AAC5802773D13EDE74ED49B08C0205F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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
using e_combox_appDesktopWindows.D_ocker;


namespace e_combox_appDesktopWindows.D_ocker {
    
    
    /// <summary>
    /// docker
    /// </summary>
    public partial class docker : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\Docker\docker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar pbLoading;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Docker\docker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_Start_Off;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Docker\docker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgStartOff;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Docker\docker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtStartOff;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Docker\docker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_Relancer;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Docker\docker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar ProgressBarMemoire;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\Docker\docker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar ProgressBarStockage;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Docker\docker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtStockageDocker;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\Docker\docker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar ProgressBarProcesseur;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\Docker\docker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtProcesseurDocker;
        
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
            System.Uri resourceLocater = new System.Uri("/e-combox_appDesktopWindows;component/docker/docker.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Docker\docker.xaml"
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
            
            #line 11 "..\..\..\Docker\docker.xaml"
            ((e_combox_appDesktopWindows.D_ocker.docker)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.pbLoading = ((System.Windows.Controls.ProgressBar)(target));
            return;
            case 3:
            this.Button_Start_Off = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\Docker\docker.xaml"
            this.Button_Start_Off.Click += new System.Windows.RoutedEventHandler(this.Button_Start_Off_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.imgStartOff = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.txtStartOff = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.Button_Relancer = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\Docker\docker.xaml"
            this.Button_Relancer.Click += new System.Windows.RoutedEventHandler(this.Button_Relancer_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ProgressBarMemoire = ((System.Windows.Controls.ProgressBar)(target));
            return;
            case 8:
            this.ProgressBarStockage = ((System.Windows.Controls.ProgressBar)(target));
            return;
            case 9:
            this.txtStockageDocker = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.ProgressBarProcesseur = ((System.Windows.Controls.ProgressBar)(target));
            return;
            case 11:
            this.txtProcesseurDocker = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

