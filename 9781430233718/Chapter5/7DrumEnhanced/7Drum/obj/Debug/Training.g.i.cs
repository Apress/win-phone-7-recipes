﻿#pragma checksum "C:\Dev\WP7\7DrumEnhanced\7Drum\Training.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4D68A6BE4119771A7A03BA14BA295CF3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
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


namespace _7Drum {
    
    
    public partial class Training : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock ApplicationTitle;
        
        internal System.Windows.Controls.TextBlock PageTitle;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.ListBox lbExercise;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton btnNew;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton btnPlay;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton btnEdit;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton btnDelete;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/7Drum;component/Training.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ApplicationTitle = ((System.Windows.Controls.TextBlock)(this.FindName("ApplicationTitle")));
            this.PageTitle = ((System.Windows.Controls.TextBlock)(this.FindName("PageTitle")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.lbExercise = ((System.Windows.Controls.ListBox)(this.FindName("lbExercise")));
            this.btnNew = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("btnNew")));
            this.btnPlay = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("btnPlay")));
            this.btnEdit = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("btnEdit")));
            this.btnDelete = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("btnDelete")));
        }
    }
}

