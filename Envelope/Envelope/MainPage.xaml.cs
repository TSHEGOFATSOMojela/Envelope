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
        private void LoginWithTwitter_Clicked(object sender, EventArgs e)
        {
            var auth = new OAuth1Authenticator(
            consumerKey: "OhlSHGDo7v5KokVI3sqa3aVAx",
            consumerSecret: "a3rDk0MQFK6blQeReYkbzzoemuvDXgf5Qz7WbeLM0rF2Z8Itro",
            requestTokenUrl: new System.Uri("https://api.twitter.com/oauth/request_token"),
            authorizeUrl: new System.Uri("https://api.twitter.com/oauth/authorize"),
            accessTokenUrl: new System.Uri("https://api.twitter.com/oauth/access_token"),
            callbackUrl: new System.Uri("http://mobile.twitter.com/home")
            );

            auth.Completed += TwitterAuth_Completed;

            var presenter = new Xamarin.Auth.Presenters.OAuthLoginPresenter();
            presenter.Login(auth);
        }
        async void TwitterAuth_Completed(object sender, AuthenticatorCompletedEventArgs e)
        {
            if (e.IsAuthenticated)
            {
                Console.WriteLine("login successfull");
                var request = new OAuth1Request(
                "GET",
                new System.Uri("https://api.twitter.com/1.1/account/verify_credentials.json?screen_name=thulanspartacus&user_id=953234789087236096"),
                null, e.Account
                );

                var response = await request.GetResponseAsync();
                var json = response.GetResponseText();
                var twitteruser = JsonConvert.DeserializeObject<TwitterUser>(json);

                //_descriptionLabel.Text += twitteruser.name;

            }


        }
    }

}
