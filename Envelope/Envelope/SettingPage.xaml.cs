using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Envelope
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SettingPage : ContentPage
	{
		public SettingPage ()
		{
			InitializeComponent ();

            SettingListView.ItemsSource = new List<settingLv>
            {
                new settingLv
                { SettingOptions = "Edit Profile"},
                new settingLv
                { SettingOptions =   "Preferences"},
                new settingLv
                { SettingOptions = "Change Password"}
                
            };

        }
        private async void TapGestureRecognizer_Tapped_4(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomePage());
        }
    }
}