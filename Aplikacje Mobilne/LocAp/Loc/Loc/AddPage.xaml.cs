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
    public partial class AddPage : ContentPage
    {
        public AddPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string enteredName = nameEntry.Text;
            string enteredCountry = countryEntry.Text;
            int.TryParse(ratingEntry.Text, out int enteredRating);

            DBlocation.locations.Add(new Location(enteredName, enteredCountry, enteredRating) );
        }
    }
}