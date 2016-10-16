﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace _7Drum
{
    public partial class MainPage : PhoneApplicationPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void tbRecordGroove_ManipulationStarted(object sender, ManipulationStartedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/VirtualDrum.xaml", UriKind.Relative));
            e.Complete();
            e.Handled = true;
        }

        private void tbTraining_ManipulationStarted(object sender, ManipulationStartedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/Training.xaml", UriKind.Relative));
            e.Complete();
            e.Handled = true;
        }

        private void tbMetronome_ManipulationStarted(object sender, ManipulationStartedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/Metronome.xaml", UriKind.Relative));
            e.Complete();
            e.Handled = true;
        }
    }
}