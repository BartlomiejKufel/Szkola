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
            int sum = Convert.ToInt32(num2Entry.Text) + Convert.ToInt32(num1Entry.Text);
            Wynik.Text=sum.ToString();
        }
    }
}