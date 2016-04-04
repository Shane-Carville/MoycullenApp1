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
    public sealed partial class Pubs : Page
    {
        public Pubs()
        {
            this.InitializeComponent();
        }

        private void butRegans_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Regans));
        }

        private void butDooleys_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Dooleys));
        }

        private void butForge_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Forge));
        }

        private void butBackPub_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }
    }
}
