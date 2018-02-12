using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Auth;
using Newtonsoft.Json;


namespace Envelope
{
	public partial class MainPage : ContentPage
	{
        public MainPage()
        {
            InitializeComponent();
        }
        async void LoginClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new HomePage());
        }
        private async void LoginWithFacebook_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FacebookProfilePage());
        }
        private async void CreateClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegisterPage());
        }
        private async void ForgetPassClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ForgetPassPage());
        }
        public void LoginWithTwitter_Clicked(object sender, EventArgs e)
        {
            var auth = new OAuth1Authenticator(
                 consumerKey: "i7iFU4LVvXRRKon1nl14dfJvR",
                 consumerSecret: "R7ogTG85TV3Whio55URxyLRM2LVi2Z58CqHO3JE5628W9b1IeB",
                 requestTokenUrl: new Uri("https://api.twitter.com/oauth/request_token"),
                 authorizeUrl: new Uri("https://api.twitter.com/oauth/authorize"),
                 accessTokenUrl: new Uri("https://api.twitter.com/oauth/access_token"),
                 callbackUrl: new Uri("http://mobile.twitter.com")
                 );



            auth.Completed += OnAuthCompleted;
            
            var presenter = new Xamarin.Auth.Presenters.OAuthLoginPresenter();
            presenter.Login(auth);
           
        }

        async void OnAuthCompleted(object sender, AuthenticatorCompletedEventArgs e)
        {
           
            if (e.IsAuthenticated)
            {
                //use the account object and make the desired API call
                var request = new OAuth1Request(
                  "GET",
                  new Uri("https://api.twitter.com/1.1/account/verify_credentials.json"),
                  null,
                  e.Account);
                var response = await request.GetResponseAsync();
                var json = response.GetResponseText();
                var twitterUser = JsonConvert.DeserializeObject<TwitterUser>(json);
            }
            else
            {
                Console.WriteLine("not loged in");
            }
            


        }

    }

}
