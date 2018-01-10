using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Envelope
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        async void loginClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new HomePage());
        }

  
    }
}
