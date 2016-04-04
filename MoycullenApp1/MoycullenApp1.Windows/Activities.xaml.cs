using System;
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
    public sealed partial class Activities : Page
    {
        public Activities()
        {
            this.InitializeComponent();
        }

        private void butGym_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Cycling));
        }

        private void butGaa_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Gaa));
        }

        private void butWalk_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Gym));
        }

        private void butFarm_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(FarmPark));
        }

        private void butActBack_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }
    }
}
