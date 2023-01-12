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
        private void Currency_Change(object sender, RoutedEventArgs e)
        {
            myCurrency = true;
            if (!myCurrency)
            {
                currency = new double[] { 500, 200, 100, 50, 20, 10, 5, 2, 1, 0.50, 0.20, 0.10, 0.05, 0.02, 0.01 };
                return;
            }

            string ciag = ownCurrency.Text;

            ciag = string.Join("", ciag.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));
            int count = ciag.Count(f => f == ',')+1;
            double[] tab = new double[count];

            int place = -1;
            for(int i = 0; i<count; i++)
            {
                string tmp = "";
                for(int j = place+1; j<ciag.Length; j++)
                {
                    place++;
                    char c = ciag[j];

                    if (c == ',')
                        break;

                    tmp += c;
                }

                double.TryParse(tmp, out tab[i]);
            }
            currency = tab;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            resultListBox.Items.Clear();

            double.TryParse(moneyInput.Text, out double money);

            if (money <= 0)
                return;
            
            double check = 0, doubleCheck = money;

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

                check += tmp * currency[i];
            }

            if (check != doubleCheck)
                MessageBox.Show("Suma nominałów nie jest równa kwocie do wydania.");
        }
    }
}
