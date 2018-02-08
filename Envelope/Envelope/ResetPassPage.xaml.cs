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
	public partial class ResetPassPage : ContentPage
	{
		public ResetPassPage ()
		{
			InitializeComponent ();
		}
        private async void SubmitPassClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomePage());
        }
    }
}
