using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PagesApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private async void addButton_Clicked(object sender, EventArgs e)
        {
            double result = double.Parse(number1Entry.Text) + double.Parse(number2Entry.Text);

            await Navigation.PushAsync(new ResultPage(result));
        }
    }
}