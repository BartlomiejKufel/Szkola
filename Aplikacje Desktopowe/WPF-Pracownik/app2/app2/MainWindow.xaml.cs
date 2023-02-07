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

namespace app2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        double[] currency = new double[] { 200, 100, 50, 20, 10, 5, 2, 1, 0.50, 0.20, 0.10, 0.05, 0.02, 0.01 };
        public MainWindow()
        {
            InitializeComponent();
            outputBox.Text = ShowPrice();
            Change();


            numberOfPeople.ValueChanged += NumberOfPeople_ValueChanged;
            decorationsCheckBox.Checked += CheckBox_Event;
            decorationsCheckBox.Unchecked +=CheckBox_Event;
            healthCheckBox.Checked += CheckBox_Event;
            healthCheckBox.Unchecked += CheckBox_Event;

        }

        private void CheckBox_Event(object sender, RoutedEventArgs e)
        {
            outputBox.Text = ShowPrice();
            Change();
        }

        private void NumberOfPeople_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            outputBox.Text = ShowPrice();
            Change();
        }

        private string ShowPrice()
        {
            return String.Format("{0:0.00} zł", Price());
        }

        private double Price()
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


            return Math.Round(price,2);

        }

        private void Change()
        {
            resultListBox.Items.Clear();

            double money = Price();

            if (money <= 0)
                return;

            double check = 0, doubleCheck = money;

            for (int i = 0; i < currency.Length; i++)
            {
                money = Math.Round(money, 3);
                double tmp = Math.Floor(money / currency[i]);
                money -= tmp * currency[i];

                if (tmp != 0)
                {
                    resultListBox.Items.Add($"{tmp} x {currency[i]}zł");
                }

                if (money == 0)
                    return;

                check += tmp * currency[i];
            }

            if (check != doubleCheck)
                MessageBox.Show("Suma nominałów nie jest równa kwocie do wydania.");
        }


    }
}
