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
    public sealed partial class Dooleys : Page
    {
        public Dooleys()
        {
            this.InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //I tried to get the GPS working for this but it would not work

          /*  Geolocator myGeo;
            double[,] posArray = new double[4, 2];
            uint _desiredAccuracy = 1;  // give me data within one metre
            Geoposition[] posTest = new Geoposition[3];

        public MainPage()
        {
            this.InitializeComponent();

            setupGeoLocation();
            _count = -1;
        }

        private async void setupGeoLocation()
        {
            // ask for permission 
            var accessStatus = await Geolocator.RequestAccessAsync();
            switch (accessStatus)
            {
                case GeolocationAccessStatus.Allowed:
                    {
                        MessageDialog myMsg = new MessageDialog("waiting for update from location data");
                        await myMsg.ShowAsync();
                        myGeo = new Geolocator();
                        myGeo.DesiredAccuracy = PositionAccuracy.High;
                        //myGeo = new Geolocator { DesiredAccuracyInMeters = _desiredAccuracy };
                        myGeo.ReportInterval = (uint)5000;
                        // set up the events
                        // status changed, position changed
                        myGeo.StatusChanged += MyGeo_StatusChanged;*/
                    }

        private void butMainDool_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void butBackDool_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Pubs));
        }
    }
}
