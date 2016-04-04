﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MoycullenApp1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void butPubs_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Pubs));
        }

        private void butRes_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Resturants));
        }

        private void butSights_Click(object sender, RoutedEventArgs e)
        {
            //i had an idea of people uploading nice pictures of the area to the app but could not figure out how to do it
        }

        private void butPic_Click(object sender, RoutedEventArgs e)
        {
           
            // Frame.Navigate(typeof());
        }

        private void butInfo_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Info));
        }

        private void butAct_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Activities));
        }
    }
}