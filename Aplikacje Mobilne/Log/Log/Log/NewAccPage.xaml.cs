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
    public partial class NewAccPage : ContentPage
    {
        public NewAccPage()
        {
            InitializeComponent();
        }

        private async void createAccountButton_Clicked(object sender, EventArgs e)
        {
            var email = emailEntry.Text;
            var password = passwordEntry.Text;
            var confirmPassowrd = confirmPasswordEntry.Text;

            if (password != confirmPassowrd)
            {
                await DisplayAlert("Błąd", "Hasła nie są takie same", "OK");
                return;
            }

            var allAccounts = Users.Accounts.Select(x => x.Email).ToList();

            if (allAccounts.Contains(email))
            {
                await DisplayAlert("Błąd", "Podany email jest już zarejestrowany", "OK");
                return;
            }

            Users.Accounts.Add(new User() { Email = email, Password = password });
            await DisplayAlert("Sukces", $"Dodano konto dla maila:\n{email}", "OK");
            await Navigation.PopAsync();
        }
    }
}