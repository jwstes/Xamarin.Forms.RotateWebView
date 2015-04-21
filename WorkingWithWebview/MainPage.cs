using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WorkingWithWebview
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            var listView = new ListView();

            listView.ItemsSource = new[] { "AboutPage" };

            listView.ItemTapped += (sender, e) =>
            {
                Navigation.PushAsync(new AboutPage { Title = "About" });
                ((ListView)sender).SelectedItem = null; // de-select the row
            };
            Content = listView;
        }
    }
}