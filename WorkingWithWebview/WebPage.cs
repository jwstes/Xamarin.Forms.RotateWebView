using System;
using Xamarin.Forms;

namespace WorkingWithWebview
{
	public class WebPage : ContentPage
	{
		public WebPage (String url)
		{
            Content = new WebView { Source = url };
		}
	}
}