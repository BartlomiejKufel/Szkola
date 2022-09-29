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

namespace RownanieKwadratowe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnOblicz_Click(object sender, RoutedEventArgs e)
        {
            lblX1.Visibility = Visibility.Hidden;
            lblX2.Visibility = Visibility.Hidden;
            lblDelta.Visibility = Visibility.Hidden;

            int a, b, c;
            int.TryParse(txtA.Text.ToString(), out a);
            int.TryParse(txtB.Text.ToString(), out b);
            int.TryParse(txtC.Text.ToString(), out c);

            lblDzialanie.Visibility = Visibility.Visible;
            lblDzialanie.Content = $"{a}*x^2 + {b}x + {c}=0";

            double delta = (b * b) - (4 * a * c);
            lblDelta.Visibility = Visibility.Visible;
            lblDelta.Content = $"{delta}";

            if (delta > 0)
            {
                double x1 = Math.Round((-b - Math.Sqrt(delta)) / 2 * a, 2);
                double x2 = Math.Round((-b + Math.Sqrt(delta)) / 2 * a, 2);

                lblX1.Visibility = Visibility.Visible;
                lblX2.Visibility = Visibility.Visible;
                lblX1.Content = $"X1 = {x1}";
                lblX2.Content = $"X2 = {x2}";
            }
            else if (delta == 0)
            {
                lblX1.Visibility = Visibility.Visible;
                double x0 = -(b / 2 * a);
                lblX1.Content = $"X1 = {x0}";
            }
            else
            {
                lblX1.Visibility = Visibility.Visible;
                lblX1.Content = "Brak pierwiastków";
            }

        }
    }
}
