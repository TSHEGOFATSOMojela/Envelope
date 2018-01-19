//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Text;
//using Envelope.Interfaces.iOS;
//using Foundation;
//using UIKit;

//[assembly: Xamarin.Forms.Dependency(typeof(OpenAppiOS))]

//namespace Envelope.Interfaces.iOS
//{
//    public class OpenAppiOS : IOpenApp
//    {
//        public OpenAppiOS() { }

//        public void OpenExternalApp()
//        {
//            NSUrl request = new NSUrl("za.co.esiyakhokha");

//            try
//            {
//                bool isOpened = UIApplication.SharedApplication.OpenUrl(request);

//                if (isOpened == false)
//                    UIApplication.SharedApplication.OpenUrl(new NSUrl("https://play.google.com/store/apps/details?id=za.co.esiyakhokha"));
//            }
//            catch (Exception ex)
//            {
//                Debug.WriteLine("Cannot open url: {0}, Error: {1}", request.AbsoluteString, ex.Message);
//#pragma warning disable CS0618 // Type or member is obsolete
//                var alertView = new UIAlertView("Error", ex.Message, null, "OK", null);
//#pragma warning restore CS0618 // Type or member is obsolete

//                alertView.Show();
//            }
//        }
//    }
//}