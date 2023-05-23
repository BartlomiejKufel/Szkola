using DbApp.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace DbApp
{
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<Contact> contacts;
        public MainPage()
        {
            InitializeComponent();
        
            contacts = new ObservableCollection<Contact>()
            {
                new Contact(){Email="jk@gmail.com", Name= "Jan Kowalski"},
                new Contact(){Email="andbar@gmail.com", Name= "Andrzej Barowski"}
            };

            readDatabase();
        }

        private async void AddToolBarIteam_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddContactPage());

            readDatabase();
        }


        private void readDatabase()
        {
            using (var connection = new SQLiteConnection(App.GetDbPath()))
            {
                connection.CreateTable<Contact>();
                contactsListView.ItemsSource = null;
                contactsListView.ItemsSource = connection.Table<Contact>().ToList();
            }

        }

        private void contactsListView_Refreshing(object sender, EventArgs e)
        {
            readDatabase();
            contactsListView.EndRefresh();
        }
    }
}
