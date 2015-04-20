using System;
using Xamarin.Forms;

namespace WorkingWithWebview
{
	public class App : Application // superclass new in 1.3
	{
		public App ()
		{
			var tabs = new TabbedPage ();
            tabs.Children.Add(new WebPage("http://www.casamba.net") { Title = "Casamaba" });

			MainPage = tabs;
		}
	}
}

