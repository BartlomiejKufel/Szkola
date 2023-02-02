using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public double Price
        {
            get
            {
                bool rabat = false;

                int.TryParse(numberOfPeople.Value.ToString(), out int people);
                double price = people * 25;

                if (healthCheckBox.IsChecked == true)
                {
                    price += 5 * people;
                    rabat = true;
                }
                else
                    price += 20 * people;

                if (decorationsCheckBox.IsChecked == true)
                    price += 15 * people + 50;
                else
                    price += 7.5 * people + 30;


                if (rabat)
                    price -= (price / 100) * 5;


                return price;
            }
            
        }

        public MainWindow()
        {
            
            InitializeComponent();

            Binding myBinding = new Binding();
            myBinding.Source = Price;
            outputBox.SetBinding(TextBox.TextProperty, myBinding);
        }

        


    }
}
