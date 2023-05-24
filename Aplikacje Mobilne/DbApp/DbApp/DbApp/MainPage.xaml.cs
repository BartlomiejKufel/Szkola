using DbApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SQLite;
//using Xamarin.Essentials;

namespace DbApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing() // wywoływana w momencie pojawiania się bieżącej strony
        {
            base.OnAppearing();
            await readDatabase();
        }

        private async void addToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new AddContactPage());
        }

        private async Task readDatabase()
        {
            List<Contact> contacts = new List<Contact>();
            var connection = new SQLiteAsyncConnection(App.GetDbPath());

            await connection.CreateTableAsync<Contact>();

            contacts = await connection.Table<Contact>().ToListAsync();

            await connection.CloseAsync();

            contactsListView.ItemsSource = contacts;
        }

        private async void deleteMenuItem_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var contactToDelete = menuItem.CommandParameter as Contact;
            var confirm = await DisplayAlert("Usuwanie kontaktu", $"Czy na pewno chcesz usunąć kontakt: {contactToDelete.Email}?", "Tak", "Anuluj");

            if (!confirm)
            {
                return;
            }

            var connection = new SQLiteAsyncConnection(App.GetDbPath());

            await connection.CreateTableAsync<Contact>();

            await connection.DeleteAsync(contactToDelete);

            await connection.CloseAsync();

            await readDatabase();
        }

        private async void editMenuItem_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var contactToEdit = menuItem.CommandParameter as Contact;

            var confirm = await DisplayAlert("Edytowanie kontaktu", $"Czy na pewno chcesz edytować kontakt: {contactToEdit.Email}?", "Tak", "Anuluj");

            if (!confirm)
            {
                return;
            }

            string newEmail = await DisplayPromptAsync("Edycja Emaila", $"Stary email: {contactToEdit.Email}");
            string newName = await DisplayPromptAsync("Edycja Imienia i nazwiska", $"Stare imię i nazwisko: {contactToEdit.Name}");


            contactToEdit.Email = newEmail;
            contactToEdit.Name = newName;

            var connection = new SQLiteAsyncConnection(App.GetDbPath());

            await connection.CreateTableAsync<Contact>();

            await connection.UpdateAsync(contactToEdit);

            await connection.CloseAsync();

            await readDatabase();
        }
    }
}
