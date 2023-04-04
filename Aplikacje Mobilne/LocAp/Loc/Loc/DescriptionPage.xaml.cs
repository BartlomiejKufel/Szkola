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
    public partial class DescriptionPage : ContentPage
    {
        public DescriptionPage()
        {
            InitializeComponent();
        }

        private async void logoutButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}