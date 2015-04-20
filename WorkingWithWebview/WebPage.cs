using System;
using Xamarin.Forms;

namespace WorkingWithWebview
{
	public class WebPage : ContentPage
	{
		public WebPage (String url)
		{
            var browser = new WebView();

            browser.Source = "http://www.casamba.net";

            Content = browser;
		}
	}
}