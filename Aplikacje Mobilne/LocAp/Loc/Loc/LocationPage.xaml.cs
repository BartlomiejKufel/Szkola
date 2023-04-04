using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LocApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LocationPage : TabbedPage
    {
        public LocationPage()
        {
            InitializeComponent();

            locationListView.ItemsSource = DBlocation.locations;
        }

        private void locationListView_Refreshing(object sender, EventArgs e)
        {
            locationListView.ItemsSource = DBlocation.locations;
            locationListView.EndRefresh();
        }

        

        private async void MenuItem_Clicked(object sender, EventArgs e)
        {
            var menuItem = (MenuItem)sender;
            var loc = (Location)menuItem.CommandParameter;

            var delete = await DisplayAlert($"Usuwanie lokalizacji: {loc.Name}", "Czy napewno chcesz usunąć lokalizację", "Tak", "Nie");
            if (!delete) return;

            var confirm = DBlocation.locations.Remove(loc);

            string msg = "";
            if (confirm)
                msg = "Pomyślnie usunięto lokalizację.";
            else
                msg = "Wystąpił błąd podczas usuwania lokalizacji";

            await DisplayAlert("Informacja", msg, "OK");
        }
    }
}