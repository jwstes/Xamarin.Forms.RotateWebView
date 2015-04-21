using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace WorkingWithWebview
{
    public partial class AboutPage : ContentPage
    {
        public string DefaultUrl = "http://www.casamba.net";
        public WebView WebViewMain;

        public AboutPage()
        {

            // Example of adding an additional back button. This button is placed on the right of the title. 
            var backButton = new ToolbarItem("Back", "", NavigateBack, 0, 0);
            this.ToolbarItems.Add(backButton);

            WebViewMain = new WebView
            {
                Source = new UrlWebViewSource
                {
                    Url = DefaultUrl,
                }
            };
            Content = WebViewMain;
        }

        public void NavigateBack()
        {
            Navigation.PopAsync();
        }
    }
}