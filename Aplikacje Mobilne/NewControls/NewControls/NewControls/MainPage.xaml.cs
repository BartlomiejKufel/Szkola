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

        private void runProgram_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (runProgram.IsChecked)
            {
                programStack.IsVisible= true;
            }
            else
            {
                programStack.IsVisible= false;
            }
        }
        private void bSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            var b = (int)bSlider.Value;
            bLabel.Text = b.ToString();

        }

        private void aStepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            aLabel.Text = aStepper.Value.ToString();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if(!wynikEditor.IsVisible)
                wynikEditor.IsVisible = true;

            int a = (int)aStepper.Value;
            int b = (int)bSlider.Value;
            int c = int.Parse(cEntry.Text);

            double delta = (b * b) - (4 * a * c);

            if (delta > 0)
            {
                double x1 = Math.Round((-b - Math.Sqrt(delta)) / 2 * a, 2); 
                double x2 = Math.Round((-b + Math.Sqrt(delta)) / 2 * a, 2);
                
                wynikEditor.Text = $"Delta: {delta}\nx1: {x1}\nx2: {x2}";

            }
            else if (delta == 0)
            {
                double x0 = -(b / 2 * a);
                wynikEditor.Text = $"Delta: {delta}\nx0: {x0})";
            }
            else
            {
                wynikEditor.Text = $"Delta: {delta}\nRównanie nie posiada rozwiązania.";
            }
        }

    }
}
