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
using Microsoft.Phone.Shell;

namespace NavigatingWithStateApp
{
    public partial class Page2 : PhoneApplicationPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            if (this.State.ContainsKey("Person"))
            {
                Person p = (Person)this.State["Person"];
                txtName.Text = p.FirstName;
                txtLast.Text = p.LastName;
                txtCity.Text = p.City;
            }

            base.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(System.Windows.Navigation.NavigationEventArgs e)
        {
            if (e.Content == null)
            {
                SaveOrUpdate(false);
            }

            base.OnNavigatedFrom(e);
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            SaveOrUpdate(true);
            this.NavigationService.GoBack();
        }

        private void SaveOrUpdate(bool isSaved)
        {
            Person p = null;

            if (this.State.ContainsKey("Person"))
            {
                p = (Person)this.State["Person"];
                p.FirstName = txtName.Text;
                p.LastName = txtLast.Text;
                p.City = txtCity.Text;
            }
            else
            {
                p = new Person();
                p.FirstName = txtName.Text;
                p.LastName = txtLast.Text;
                p.City = txtCity.Text;
            }

            if (isSaved)
            {
                PhoneApplicationService.Current.State["Person"] = p;
            }

            this.State["Person"] = p;
        }

        private void txt_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox txt = sender as TextBox;
            txt.SelectAll();
        }
    }
}