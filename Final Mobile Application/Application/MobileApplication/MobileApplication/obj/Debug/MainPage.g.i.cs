﻿#pragma checksum "C:\Users\Adrian\Desktop\MobileApplication\MobileApplication\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "EF5B80F3D99F17DBAB106F42682F2669"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace MobileApplication {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal Microsoft.Phone.Controls.PhoneApplicationPage Main_Page;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock lblWelcome;
        
        internal System.Windows.Controls.TextBlock lblHeading;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.Button btnToday;
        
        internal System.Windows.Controls.Button btnWeek;
        
        internal System.Windows.Controls.Button btnMonth;
        
        internal System.Windows.Controls.Button btnAbout;
        
        internal System.Windows.Controls.Button btnExit;
        
        internal System.Windows.Controls.TextBlock lblInfo;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/MobileApplication;component/MainPage.xaml", System.UriKind.Relative));
            this.Main_Page = ((Microsoft.Phone.Controls.PhoneApplicationPage)(this.FindName("Main_Page")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.lblWelcome = ((System.Windows.Controls.TextBlock)(this.FindName("lblWelcome")));
            this.lblHeading = ((System.Windows.Controls.TextBlock)(this.FindName("lblHeading")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.btnToday = ((System.Windows.Controls.Button)(this.FindName("btnToday")));
            this.btnWeek = ((System.Windows.Controls.Button)(this.FindName("btnWeek")));
            this.btnMonth = ((System.Windows.Controls.Button)(this.FindName("btnMonth")));
            this.btnAbout = ((System.Windows.Controls.Button)(this.FindName("btnAbout")));
            this.btnExit = ((System.Windows.Controls.Button)(this.FindName("btnExit")));
            this.lblInfo = ((System.Windows.Controls.TextBlock)(this.FindName("lblInfo")));
        }
    }
}

