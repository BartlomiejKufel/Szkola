using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PickerApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            peopleAmountPicker.ItemsSource = new List<string>()
            {
                "1 osoba",
                "2 osoby",
                "3 osoby",
                "4 osoby",
                "5 osób"
            };
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var isDistanceValid = float.TryParse(distanceEntry.Text, out var distance);
            if(!isDistanceValid || distance <= 0)
            {
                await DisplayAlert("Błąd", "Niewłaściwa wartość dystansu", "Zamknij");
                return;
            }
            
            var isFuealUsageValid = float.TryParse(fuelUsageEntry.Text, out var fuealUsage);
            if (!isFuealUsageValid || fuealUsage <= 0)
            {
                await DisplayAlert("Błąd", "Niewłaściwa wartość spalania", "Zamknij");
                return;
            }
            
            var isGasCostValid = float.TryParse(gasCostEntry.Text, out var gasCost);
            if (!isGasCostValid || gasCost <= 0)
            {
                await DisplayAlert("Błąd", "Niewłaściwa wartość ceny benzyny", "Zamknij");
                return;
            }

            var peopleAmount = peopleAmountPicker.SelectedIndex + 1;
            if (peopleAmount <= 0)
            {
                await DisplayAlert("Błąd", "Nie wybrano ilości osób", "Zamknij");
                return;
            }


            float totalCost =(distance * (fuealUsage/100) * gasCost) / peopleAmount;
            resultLable.Text = $"Koszt: {totalCost.ToString("0.00")} zł";
        }
    }
}
