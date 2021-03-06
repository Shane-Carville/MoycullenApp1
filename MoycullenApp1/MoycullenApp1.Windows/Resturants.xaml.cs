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
    public sealed partial class Resturants : Page
    {
        public Resturants()
        {
            this.InitializeComponent();
        }

        private void butSargram_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Sargram));
        }

        private void butForge2_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ForgeRest));
        }

        private void butWhite_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(White));
        }

        private void butDragon_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Dragon));
        }

        private void butBackRest_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }
    }
}
