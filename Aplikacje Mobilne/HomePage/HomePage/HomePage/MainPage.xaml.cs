﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirstApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void addNumbers_Clicked(object sender, EventArgs e)
        {
            try
            {

                var num1 = float.Parse(num2Entry.Text);
                var num2 = Convert.ToSingle(num1Entry.Text);
                var isValid = float.TryParse(num3Entry.Text, out float num3);
                var sum = num1 + num2 + num3;

                if (!isValid)
                {
                    throw new Exception();
                }

                Wynik.Text = sum.ToString();
            }
            catch (Exception ex)
            {
                Wynik.Text = "Złe dane wejściowe";
            }
        
            
        }
    }
}