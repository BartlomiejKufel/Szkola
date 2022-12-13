using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListView
{
    public partial class MainPage : ContentPage
    {
        private List<User> users;
        public MainPage()
        {
            InitializeComponent();
           users = new List<User>()
           {
               new User(){Name="Bartłomiej Kufel", Email="kufel.bartlomiej@google.com" },
               new User(){Name="Andrzej Kowalski", Email="kowalski.andrzej@wp.pl" },
               new User(){Name="Piotr Szalik", Email="szalik.piotr@onet.pl" },
           };

           usersListView.ItemsSource = users;
        }

        private void addUser_Clicked(object sender, EventArgs e)
        {

        }
    }
}
