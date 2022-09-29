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

namespace WpfApp1
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

        private void btnWyczysc_Click(object sender, RoutedEventArgs e)
        {
            txtBok.Text = String.Empty;
            txtObwod.Text = String.Empty;
            txtPole.Text = String.Empty;
            lblKomunikat.Visibility = Visibility.Visible;

        }



        private void txtBok_TextChanged(object sender, TextChangedEventArgs e)
        {

            int bok;
            int.TryParse(txtBok.Text.ToString(), out bok);

            if (bok > 0)
            {
                lblKomunikat.Visibility = Visibility.Hidden;
                txtObwod.Text = (bok * 4).ToString();
                txtPole.Text = (bok * bok).ToString();
                lblKomunikat.Content = "Wpisz wymiar boku";
            }
            else if (bok < 0)
            {
                lblKomunikat.Visibility = Visibility.Visible;
                lblKomunikat.Content = "Wpisz liczbę dodatnią";
                txtObwod.Text = String.Empty;
                txtPole.Text = String.Empty;
            }
            else
            {
                lblKomunikat.Visibility = Visibility.Visible;
                lblKomunikat.Content = "Wpisz wymiar boku";
                txtObwod.Text = String.Empty;
                txtPole.Text = String.Empty;
            }
        }
    }
}
