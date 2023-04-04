using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LocApp
{
    public partial class LoginPage : ContentPage
    {
        public List<DBusers> users = new List<DBusers>()
        {
            new DBusers("bkufel", "123fg"),
            new DBusers("sgala", "zxcv"),
            new DBusers("bbarzyk", "asj12"),
        };

        public LoginPage()
        {
            InitializeComponent();
        }

        private async void loginButton_Clicked(object sender, EventArgs e)
        {
            string name = nameEntry.Text;
            string password = passwordEntry.Text;

            var userToCheck = users.Find(users => users.Name == name);

            if (userToCheck == null)
            {
                errorLable.Text = "Nie znalezniono użytkownika.";
                errorLable.IsVisible = true;
                return;
            }


            if (userToCheck.Password != password)
            {
                errorLable.Text = "Złe hasło";
                errorLable.IsVisible = true;
                return;
            }

            errorLable.Text = "";
            errorLable.IsVisible = false;

            await Navigation.PushAsync(new LocationPage());
        }
    }
}
