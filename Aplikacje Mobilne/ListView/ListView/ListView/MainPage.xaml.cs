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
    }
}
