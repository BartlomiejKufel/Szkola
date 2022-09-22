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

namespace FirstApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            /*//zad2.2
            btnStart.Opacity=0.5;
            MessageBox.Show("Hello World");
            btnStart.Opacity = 1;
            */
            /*
            //zad 2.3
            btnStart.Visibility = Visibility.Hidden;
            MessageBox.Show("Hello World");
            btnStart.Visibility = Visibility.Visible;
            */

            MessageBox.Show("Hello World");
            }


        private void btnCzas_MouseEnter(object sender, MouseEventArgs e)
        {
            DateTime dt = DateTime.Now;
            btnCzas.Content = dt.ToString("T");

        }

        private void btnCzas_MouseLeave(object sender, MouseEventArgs e)
        {
            btnCzas.Content = "Start";
        }

        private void btnAktualizuj_Click(object sender, RoutedEventArgs e)
        {
            btnStart.IsEnabled = true;
        }
    }
}
