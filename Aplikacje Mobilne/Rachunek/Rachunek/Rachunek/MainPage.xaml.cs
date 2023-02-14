using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Rachunek
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        
        private async void Button_Clicked(object sender, EventArgs e)
        {
            double litry = literSlider.Value;

            await Navigation.PushAsync(new BillPage());
        }
    }
}
