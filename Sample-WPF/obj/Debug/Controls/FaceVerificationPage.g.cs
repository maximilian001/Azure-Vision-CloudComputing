﻿#pragma checksum "..\..\..\Controls\FaceVerificationPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56ED0DA9D55B1A2CE0E1092B462C925F21E32A8C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.ProjectOxford.Face.Controls;
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


namespace Microsoft.ProjectOxford.Face.Controls {
    
    
    /// <summary>
    /// FaceVerificationPage
    /// </summary>
    public partial class FaceVerificationPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 42 "..\..\..\Controls\FaceVerificationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.ProjectOxford.Face.Controls.FaceVerificationPage FaceVerificationPane;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\Controls\FaceVerificationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image LeftImageDisplay;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\..\Controls\FaceVerificationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image RightImageDisplay;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\..\Controls\FaceVerificationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FaceVerifyButton;
        
        #line default
        #line hidden
        
        
        #line 224 "..\..\..\Controls\FaceVerificationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image RightImageDisplay2;
        
        #line default
        #line hidden
        
        
        #line 226 "..\..\..\Controls\FaceVerificationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PersonVerifyButton;
        
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
            System.Uri resourceLocater = new System.Uri("/FaceAPI-WPF-Samples;component/controls/faceverificationpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Controls\FaceVerificationPage.xaml"
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
            this.FaceVerificationPane = ((Microsoft.ProjectOxford.Face.Controls.FaceVerificationPage)(target));
            return;
            case 2:
            
            #line 72 "..\..\..\Controls\FaceVerificationPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LeftImagePicker_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 73 "..\..\..\Controls\FaceVerificationPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.RightImagePicker_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.LeftImageDisplay = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.RightImageDisplay = ((System.Windows.Controls.Image)(target));
            return;
            case 6:
            this.FaceVerifyButton = ((System.Windows.Controls.Button)(target));
            
            #line 116 "..\..\..\Controls\FaceVerificationPage.xaml"
            this.FaceVerifyButton.Click += new System.Windows.RoutedEventHandler(this.Face2FaceVerification_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 127 "..\..\..\Controls\FaceVerificationPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.PersonImageFolderPicker_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 128 "..\..\..\Controls\FaceVerificationPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.FaceImagePicker_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.RightImageDisplay2 = ((System.Windows.Controls.Image)(target));
            return;
            case 10:
            this.PersonVerifyButton = ((System.Windows.Controls.Button)(target));
            
            #line 226 "..\..\..\Controls\FaceVerificationPage.xaml"
            this.PersonVerifyButton.Click += new System.Windows.RoutedEventHandler(this.Face2PersonVerification_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

