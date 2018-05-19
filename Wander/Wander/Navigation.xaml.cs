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
using System.Net.NetworkInformation;


namespace Wander
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Navigation : Page
    {
        public Navigation()
        {
            this.InitializeComponent();
            this.MapFrame.Navigate(typeof(DrawMap));
           
        }
        private void Options_Loaded(object sender, RoutedEventArgs e)
        {
            Options.MenuItems.Add(new NavigationViewItemSeparator());
            Options.MenuItems.Add(new NavigationViewItem()
            { Content = "Locations", Icon = new SymbolIcon(Symbol.Target), Tag = "Locations" });

            foreach (NavigationViewItemBase item in Options.MenuItems)
            {
                if (item is NavigationViewItem && item.Tag.ToString() == "home")
                {
                    Options.SelectedItem = item;
                    break;
                }
            }
            
        }
        private void NavView_Navigate(NavigationViewItem item)
        {
            switch (item.Tag)
            {
              
                //Test Interweb
                case "network":
                    MapFrame.Navigate(typeof(NetworkCheck));
                    break;
                //select API or Reference 
                case "API":
                    MapFrame.Navigate(typeof(DrawMap));
                    break;
                //select algorithm
                case "algo":
                    MapFrame.Navigate(typeof(Algorithm));
                    break;
                //Get Input
                case "Locations":
                    MapFrame.Navigate(typeof(SelectLocations));
                    break;
                //figure it out
                case "calc":
                    MapFrame.Navigate(typeof(GetRoute));
                    break;
            }
        }

        private void Options_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            if (args.IsSettingsInvoked)
            {
                MapFrame.Navigate(typeof(Settings));
            }
            else
            {
                // find NavigationViewItem with Content that equals InvokedItem
                var item = sender.MenuItems.OfType<NavigationViewItem>().First(x => (string)x.Content == (string)args.InvokedItem);
                NavView_Navigate(item as NavigationViewItem);
            }
        }

    }
}
