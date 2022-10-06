using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Next_Controls
{
    public partial class MainPage : ContentPage
    {
        double progresss = 0;
        public MainPage()
        {

            InitializeComponent();
        }

        private void urodzinyDatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            var date = (sender as DatePicker).Date;
            var month = date.Month;

            if(month == 12 || month == 1 || month == 2)
            {
                urodzinyLable.Text = "Urodziłeś się w: zimie";
            }
            else if(month == 3 || month == 4 || month == 5)
            {
                urodzinyLable.Text = "Urodziłeś się w: wiośnie";
            }
            else if(month == 6 || month == 7 || month == 8)
            {
                urodzinyLable.Text = "Urodziłeś się w: lecie";
            }
            else if(month == 9 || month == 10 || month == 11)
            {
                urodzinyLable.Text = "Urodziłeś się w: jesieni";
            }
            progresss += 0.50;
            progreBar.Progress = progresss;
        }

        private void koniecTimePicker_PropertyChanging(object sender, Xamarin.Forms.PropertyChangingEventArgs e)
        {
            var timePicker = sender as TimePicker;
            var hours = timePicker.Time.Hours;
            var minutes = timePicker.Time.Minutes;
            var seconds = timePicker.Time.Seconds;
            if (hours == 0 && minutes == 0 && seconds == 0) return;

            koniecLable.Text = $"Dziś kończę o: {hours}";
            progresss += 0.50;
            progreBar.Progress = progresss;
        }

        private void progreBar_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if(progreBar.Progress==1)
                zatwerdzButton.IsEnabled = true;
        }
    }
}
