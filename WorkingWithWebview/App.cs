using System;
using Xamarin.Forms;

namespace WorkingWithWebview
{
	public class App : Application // superclass new in 1.3
	{
		public App ()
		{
            var mainNav = new NavigationPage(new MainPage());
            MainPage = mainNav;
		}
	}
}

