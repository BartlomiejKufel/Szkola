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

namespace PerfectNum
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int x = int.Parse(inputTextBox.Text);
            int suma =0;

            for(int i = 1; i < x; i++)
            {
                if(x % i == 0)
                    suma += i;
            }

            if (suma == x)
                MessageBox.Show("Liczba jest doskonała");
            else
                MessageBox.Show("Liczba nie jest doskonała");
        }


    }
}
