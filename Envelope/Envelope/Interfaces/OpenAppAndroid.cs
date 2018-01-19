using Android.App;
using Android.Content;
using Envelope.Interfaces.Droid;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using Xamarin.Forms;


[assembly: Xamarin.Forms.Dependency(typeof(OpenAppAndroid))]
namespace Envelope.Interfaces.Droid
{
    [Activity(Label = "OpenAppAndroid")]
    public class OpenAppAndroid : Activity, IOpenApp
    {
        public OpenAppAndroid() { }

        public void OpenExternalApp()
        {
            Intent intent = Android.App.Application.Context.PackageManager.GetLaunchIntentForPackage("za.co.esiyakhokha");

            // If not NULL run the app, if not, take the user to the app store
            if (intent != null)
            {
                intent.AddFlags(ActivityFlags.NewTask);
               
                Android.App.Application.Context.StartActivity(intent);
            }
            else
            {
                intent = new Intent(Intent.ActionView);
                intent.AddFlags(ActivityFlags.NewTask);
                intent.SetData(Android.Net.Uri.Parse("https://play.google.com/store/apps/details?id=za.co.esiyakhokha"));
                Android.App.Application.Context.StartActivity(intent);
            }
        }

    }
}
