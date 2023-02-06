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


        private int road()
        {
            int.TryParse(inputEnd.Text, out int end);
            int.TryParse(inputStart.Text, out int start);

            return end - start;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int distance = road();

            if (distance < 0)
            {
                MessageBox.Show("Błąd, podano złe wartości");
                return;
            }

            double ret = 0.39 * distance;

            outputText.Text = ret.ToString();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int distance = road();

            if (distance < 0)
            {
                MessageBox.Show("Błąd, podano złe wartości");
                return;
            }

            if (distance == 1)
            {
                MessageBox.Show($"{distance} kilometr");
                return;
            }

            MessageBox.Show($"{distance} kilometrów");

        }
    }
}
