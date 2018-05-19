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
using Windows.UI.Xaml.Controls.Maps;
using Windows.Devices.Geolocation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Wander
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DrawMap : Page
    {

        public DrawMap()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

            // Specify a known location.
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 46.283333, Longitude = 86.666667 };
            Geopoint cityCenter = new Geopoint(cityPosition);

            // Set the map location.
            MapMaker.StyleSheet = MapStyleSheet.RoadDark();
            MapMaker.Center = cityCenter;
            MapMaker.ZoomLevel = 12;
            MapMaker.LandmarksVisible = true;

        }
    }
}