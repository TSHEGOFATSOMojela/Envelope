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
    public partial class GeneralsPage : ContentPage
    {
        public GeneralsPage()
        {
            InitializeComponent();

            GeneralListView.ItemsSource = new List<GeneralLv>
            {
                new GeneralLv
                { GeneralOptions = "Balance Enquiry"},
                new GeneralLv
                { GeneralOptions =   "Query Case"}


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
        private async void BalanceEnquiryClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BalanceEnquiryPage());
        }
        private async void QueryCaseClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new QueryCasePage());
        }

    }
}