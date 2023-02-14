using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Rachunek
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BillPage : ContentPage
    {
        private double cena =0;
        private double litry =0;
        public BillPage()
        {
            InitializeComponent();
        }

        public BillPage(double cena, double ilosc)
        {
            InitializeComponent();

            this.cena = cena;
            litry = ilosc;
            litryLable.Text = $"Ilość: {litry}";
        }
    }
}