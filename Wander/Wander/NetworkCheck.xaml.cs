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
using System.Net;

namespace Wander
{
    /// <summary>
    /// A quick and dirty network check. 
    /// TODO:
    /// Implement offline option 
    /// Add additional types of checks i.e. ping/local
    /// </summary>
    public sealed partial class NetworkCheck : Page
    {
        public NetworkCheck()
        {
            this.InitializeComponent();
            isConnected();
        }

        public static async void isConnected()
        {
            if (CheckForInternetConnection() == true)
            {
                ContentDialog connection = new ContentDialog
                {
                    Title = "Success!",
                    Content = "Connectivity Checks out.",
                    CloseButtonText = "Ok"
                };
                ContentDialogResult result = await connection.ShowAsync();
                

            }
            else
            {
                ContentDialog noConnection = new ContentDialog
                {
                    Title = "No connection",
                    Content = "Check your connection and try again.",
                    CloseButtonText = "Ok"
                };
                ContentDialogResult result = await noConnection.ShowAsync();
            }
        }


        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://clients3.google.com/generate_204"))
                {

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

    }
}
