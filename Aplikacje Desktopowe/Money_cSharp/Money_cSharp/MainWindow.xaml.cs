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

namespace Money_cSharp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double[] currency = new double[] { 500, 200, 100, 50, 20, 10, 5, 2, 1, 0.50, 0.20, 0.10, 0.05, 0.02, 0.01 };
        bool myCurrency = false;

        public MainWindow()
        {
            InitializeComponent();
        }
        /*
        private void Currency_Change(object sender, RoutedEventArgs e)
        {
            myCurrency = true;
            if (!myCurrency)
            {
                currency = new double[] { 500, 200, 100, 50, 20, 10, 5, 2, 1, 0.50, 0.20, 0.10, 0.05, 0.02, 0.01 };
                return;
            }

            string ciąg = ownCurrency.Text;

            ciąg = "";
            MessageBox.Show($"[{ciąg.Trim()}]");

        }*/


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            resultListBox.Items.Clear();

            double.TryParse(moneyInput.Text, out double money);

            if (money <= 0)
                return;


            for (int i = 0; i < currency.Length; i++)
            {
                money = Math.Round(money, 3);
                double tmp =Math.Floor(money / currency[i]);
                money -= tmp * currency[i];

                if (tmp != 0)
                {
                    resultListBox.Items.Add($"{tmp} x {currency[i]}zł");
                }

                if (money == 0)
                    return;
            }
        }
    }
}
