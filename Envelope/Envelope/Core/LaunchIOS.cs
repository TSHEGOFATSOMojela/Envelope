using System;
using System.Collections.Generic;
using System.Text;
using Android.OS;
using Envelope.Core.iOS;
using Foundation;
using UIKit;

[assembly: Xamarin.Forms.Dependency(typeof(LaunchIOS))]

namespace Envelope.Core.iOS
{
    public class LaunchIOS : ILaunch
    {
        public LaunchIOS() { }

        public void OpenExternalApp()
        {
            NSUrl request = new NSUrl("Envelope:https://drive.google.com/file/d/0B5unsMnPuO8kMzVyQkN1YS1Ld2c/view");

            try
            {
                bool isOpened = UIApplication.SharedApplication.OpenUrl(request);

                if (isOpened == false)
                    UIApplication.SharedApplication.OpenUrl(new NSUrl("https://drive.google.com/file/d/0B5unsMnPuO8kMzVyQkN1YS1Ld2c/view"));
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Cannot open url: {0}, Error: {1}", request.AbsoluteString, ex.Message);
#pragma warning disable CS0618 // Type or member is obsolete
                var alertView = new UIAlertView("Error", ex.Message, null, "OK", null);
#pragma warning restore CS0618 // Type or member is obsolete

                alertView.Show();
            }

        }

    }
}
