﻿#pragma checksum "..\..\ConditioningFrm.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E164E61575864353F1BF75F6CF37E37F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34011
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


namespace KinectKickboxingBVversion1 {
    
    
    /// <summary>
    /// ConditioningFrm
    /// </summary>
    public partial class ConditioningFrm : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\ConditioningFrm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button pushUpBtn;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\ConditioningFrm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button burpeeBtn;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\ConditioningFrm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button squatBtn;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\ConditioningFrm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button coreBtn;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\ConditioningFrm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image KinectVideo;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\ConditioningFrm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button homeBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/KinectKickboxingBVversion1;component/conditioningfrm.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ConditioningFrm.xaml"
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
            
            #line 4 "..\..\ConditioningFrm.xaml"
            ((KinectKickboxingBVversion1.ConditioningFrm)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.pushUpBtn = ((System.Windows.Controls.Button)(target));
            
            #line 8 "..\..\ConditioningFrm.xaml"
            this.pushUpBtn.Click += new System.Windows.RoutedEventHandler(this.pushUpBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.burpeeBtn = ((System.Windows.Controls.Button)(target));
            
            #line 9 "..\..\ConditioningFrm.xaml"
            this.burpeeBtn.Click += new System.Windows.RoutedEventHandler(this.burpeeBtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.squatBtn = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\ConditioningFrm.xaml"
            this.squatBtn.Click += new System.Windows.RoutedEventHandler(this.squatBtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.coreBtn = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\ConditioningFrm.xaml"
            this.coreBtn.Click += new System.Windows.RoutedEventHandler(this.coreBtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.KinectVideo = ((System.Windows.Controls.Image)(target));
            return;
            case 7:
            this.homeBtn = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\ConditioningFrm.xaml"
            this.homeBtn.Click += new System.Windows.RoutedEventHandler(this.homeBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

