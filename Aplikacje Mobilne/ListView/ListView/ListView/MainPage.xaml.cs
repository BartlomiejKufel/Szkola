using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace ListView
{
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<User> users;
        public MainPage()
        {
            InitializeComponent();
           users = new ObservableCollection<User>()
           {
               new User(){Name="Bartłomiej Kufel", Email="kufel.bartlomiej@google.com" },
               new User(){Name="Andrzej Kowalski", Email="kowalski.andrzej@wp.pl" },
               new User(){Name="Piotr Szalik", Email="szalik.piotr@onet.pl" },
           };

           usersListView.ItemsSource = users;
        }

        private async void addUser_Clicked(object sender, EventArgs e)
        {
            var enteredName = await DisplayPromptAsync("Dodawanie nowego urzytkownika", "Podaj imię i nazwisko", "Dodaj", "Anuluj");
            if (enteredName == null) return;

            var enteredEmail = await DisplayPromptAsync("Dodawanie nowego urzytkownika", "Podaj email", "Dodaj", "Anuluj");
            if(enteredEmail==null) return;

            users.Add(new User() { Name = enteredName, Email = enteredEmail });
        }

        private async void moreMenuItem_Clicked(object sender, EventArgs e)
        {
            var menuItem = (MenuItem)sender;
            var user = (User)menuItem.CommandParameter;
            var userDetails = $"Nazwa: {user.Name}\nEmail: {user.Email}"; 
            await DisplayAlert("Informacje o urzytkowniku", userDetails, "Ok");
        }

        private async void deleteMenuItem_Clicked(object sender, EventArgs e)
        {
            var menuItem = (MenuItem)sender;
            var user = (User)menuItem.CommandParameter;

            var delete = await DisplayAlert($"Usuwanie użytkownika: {user.Name}", "Czy napewno chcesz usunąć użytkownika", "Tak", "Nie");
            if (!delete) return;

            var confirm = users.Remove(user);

            string msg = "";
            if (confirm)
                msg = "Pomyślnie usunięto użytkownika.";
            else
                msg = "Wystąpił błąd podczas usuwania użytkownika";

            await DisplayAlert("Informacja", msg, "OK");
           
        }

        private async void editMenuItem_Clicked(object sender, EventArgs e)
        {
            var menuItem = (MenuItem)sender;
            var user = (User)menuItem.CommandParameter;

            var find = users.IndexOf(user);
            var editName = "";
            do
            {
                editName = await DisplayPromptAsync("", "Edytuj Imię i Nazwisko", "OK", "Anuluj", user.Name);
                if (editName == null) return;
            } while (editName == String.Empty);
            user.Name = editName;

            var editEmail = "";
            do
            {
                editEmail = await DisplayPromptAsync("", "Edytuj Email", "OK", "Anuluj", user.Email);
                if (editEmail == null) return;
            }while (editEmail == String.Empty);

            user.Email = editEmail;

            users[find] = user;

        }

        private void usersListView_Refreshing(object sender, EventArgs e)
        {
            usersListView.ItemsSource = users;
            usersListView.EndRefresh();
        }
    }
}
