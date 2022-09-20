using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NewControls
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            var mySwitch = (sender as Switch);
         
            if (mySwitch.IsToggled)
            {
                switchLable.TextColor = Color.Blue;
            }
            else
            {
                switchLable.TextColor = Color.Green;
            }
            if(e.Value)
            {
                switchStateLable.Text = "ON";
            }
            else
            {
                switchStateLable.Text = "OFF";
            }
        }
    }
}
