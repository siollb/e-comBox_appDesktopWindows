﻿#pragma checksum "..\..\..\e-comBox\EcomBox.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "730C642C73D3990DA0B7BC1459E82B82157B8A390B680488E38981928315B393"
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
using e_combox_appDesktopWindows.e_comBox;


namespace e_combox_appDesktopWindows.e_comBox {
    
    
    /// <summary>
    /// EcomBox
    /// </summary>
    public partial class EcomBox : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\e-comBox\EcomBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar pbLoading;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\e-comBox\EcomBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.DialogHost dialogInfo;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\e-comBox\EcomBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_Start;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\e-comBox\EcomBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgStart;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\e-comBox\EcomBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtStart;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\e-comBox\EcomBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_Renew;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\e-comBox\EcomBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.DialogHost dialogProgress;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\e-comBox\EcomBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_Configure;
        
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
            System.Uri resourceLocater = new System.Uri("/e-combox_appDesktopWindows;component/e-combox/ecombox.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\e-comBox\EcomBox.xaml"
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
            
            #line 11 "..\..\..\e-comBox\EcomBox.xaml"
            ((e_combox_appDesktopWindows.e_comBox.EcomBox)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.pbLoading = ((System.Windows.Controls.ProgressBar)(target));
            return;
            case 3:
            this.dialogInfo = ((MaterialDesignThemes.Wpf.DialogHost)(target));
            return;
            case 4:
            this.Button_Start = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\e-comBox\EcomBox.xaml"
            this.Button_Start.Click += new System.Windows.RoutedEventHandler(this.Button_Start_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.imgStart = ((System.Windows.Controls.Image)(target));
            return;
            case 6:
            this.txtStart = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.Button_Renew = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\..\e-comBox\EcomBox.xaml"
            this.Button_Renew.Click += new System.Windows.RoutedEventHandler(this.Button_Renew_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.dialogProgress = ((MaterialDesignThemes.Wpf.DialogHost)(target));
            
            #line 61 "..\..\..\e-comBox\EcomBox.xaml"
            this.dialogProgress.DialogOpened += new MaterialDesignThemes.Wpf.DialogOpenedEventHandler(this.DialogHost_DialogOpened);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Button_Configure = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

