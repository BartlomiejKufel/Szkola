using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Log
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void loginButton_Clicked(object sender, EventArgs e)
        {
            var email = emailEntry.Text.Trim();
            var password = passwordEntry.Text.Trim();

            var user = Users.Accounts.FirstOrDefault(x => x.Email == email && x.Password == password);

            if (user == null)
            {
                await DisplayAlert("Błąd", "Błędny login lub hasło", "OK");
                return;
            }

            await Navigation.PushAsync(new MainPage());
        }

        private async void newAccountButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewAccPage());

        }
    }
}