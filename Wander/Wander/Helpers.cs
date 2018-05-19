using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
namespace Wander
{
    class Helpers
    {
        public static async void Oops()
        {
            ContentDialog connection = new ContentDialog
            {
                Title = "Oops!",
                Content = "Nothing here yet, sorry!",
                CloseButtonText = "Ok"
            };
            ContentDialogResult result = await connection.ShowAsync();
        }
           
    }
}
