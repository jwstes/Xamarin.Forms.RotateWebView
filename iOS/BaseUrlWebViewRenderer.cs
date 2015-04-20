using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using Foundation;
using UIKit;
using WorkingWithWebview;
using WorkingWithWebview.iOS;
using Rectangle = Xamarin.Forms.Rectangle;
using System.Drawing;

[assembly: ExportRenderer(typeof(RotatingWebView), typeof(BaseUrlWebViewRenderer))]

namespace WorkingWithWebview.iOS
{
	public class BaseUrlWebViewRenderer : WebViewRenderer 
	{

        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);
            this.ScalesPageToFit = true;
            this.AutoresizingMask = UIViewAutoresizing.FlexibleDimensions;
        }
      
	}
}