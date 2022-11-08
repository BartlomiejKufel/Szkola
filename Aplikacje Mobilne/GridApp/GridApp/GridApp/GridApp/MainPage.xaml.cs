using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GridApp
{
    public partial class MainPage : ContentPage
    {
        private float number1;
        private float number2;
        private bool isNumberSecond = false;
        private string operation;

        public MainPage()
        {
            InitializeComponent();
        }

        private void NumberButton_Clicked(object sender, EventArgs e)
        {
            if (poleEntry.Text =="0")
            {
                poleEntry.Text = string.Empty;
            }
            

            var sen = sender as Button;
            poleEntry.Text += sen.Text;
        }

        private void NegativePositiveButton_Clicked(object sender, EventArgs e)
        {
            string entry = poleEntry.Text;
            
            if (!entry.StartsWith("-") && !(entry=="0"))
            {
                poleEntry.Text = $"-{entry}";
            }
            else if (entry =="0")
            {
                poleEntry.Text = entry;
            }
            else
            {
                poleEntry.Text = $"{entry.Substring(1,entry.Length-1)}";
            }
        }

        private void ClearButton_Clicked(object sender, EventArgs e)
        {
            poleEntry.Text = "0";
            isNumberSecond = false;
            operation = "";
            number1 = 0;
            number2 = 0;
        }

        private void DeleteButton_Clicked(object sender, EventArgs e)
        {
            string primalEntry = poleEntry.Text;
            string subEntry = primalEntry.Substring(0,primalEntry.Length-1);
            if (subEntry == string.Empty)
            {
                poleEntry.Text = "0";
            }
            else
            {
                poleEntry.Text= subEntry;
            }
        }

        private void OperationButton_Clicked(object sender, EventArgs e)
        {
            var sen = sender as Button;

            float.TryParse(poleEntry.Text, out number1);

            isNumberSecond = true;

            poleEntry.Text = "0";

            operation = sen.Text;
        }

        private void ResultButton_Clicked(object sender, EventArgs e)
        {
            
            float.TryParse(poleEntry.Text, out number2);

            float result = 0;
            switch (operation)
            {
                case "+":result = number1 + number2;break; 
                case "-":result = number1 - number2;break; 
                case "*":result = number1 * number2;break; 
                default:
                    break;
            }

            if (operation == "/" && number2 != 0) result = number1 / number2;

            poleEntry.Text = $"{result}";
            operation = "";
            isNumberSecond = false;
        }

        private void FractionButton_Clicked(object sender, EventArgs e)
        {
            string entry = poleEntry.Text;
            if (!entry.Contains("."))
            {
                poleEntry.Text+=".";
            }
        }

        private void PercentButton_Clicked(object sender, EventArgs e)
        {
            float percentNum = 0;
            float.TryParse(poleEntry.Text, out percentNum);

            if (isNumberSecond)
            {
                 percentNum= (number1*percentNum)/1000;
            }
            poleEntry.Text = percentNum.ToString();
        }
    }
}
