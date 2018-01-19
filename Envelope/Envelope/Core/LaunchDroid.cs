using Android.App;
using Android.Content;
using Envelope.Core.Droid;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;


[assembly: Xamarin.Forms.Dependency(typeof(LaunchDroid))]


namespace Envelope.Core.Droid
{
    [Activity(Label = "LaunchDroid")]
    public class LaunchDroid : Activity, ILaunch
    {
        public LaunchDroid() { }

        public void OpenExternalApp()
        {
            Intent intent = Android.App.Application.Context.PackageManager.GetLaunchIntentForPackage("https://drive.google.com/file/d/0B5unsMnPuO8kMzVyQkN1YS1Ld2c/view");

            // If not NULL run the app, if not, take the user to the app store
            if (intent != null)
            {
                intent.AddFlags(ActivityFlags.NewTask);
#pragma warning disable CS0618 // Type or member is obsolete
                Forms.Context.StartActivity(intent);
#pragma warning restore CS0618 // Type or member is obsolete
            }
            else
            {
                intent = new Intent(Intent.ActionView);
                intent.AddFlags(ActivityFlags.NewTask);
                intent.SetData(Android.Net.Uri.Parse("market://details?id=https://drive.google.com/file/d/0B5unsMnPuO8kMzVyQkN1YS1Ld2c/view"));
#pragma warning disable CS0618 // Type or member is obsolete
                Forms.Context.StartActivity(intent);
#pragma warning restore CS0618 // Type or member is obsolete
            }

        }
    };
};