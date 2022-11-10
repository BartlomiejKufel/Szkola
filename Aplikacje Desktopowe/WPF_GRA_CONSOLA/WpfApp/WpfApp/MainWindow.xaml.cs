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

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Random rnd = new Random();
        public int numberToFind = rnd.Next(1, 11);

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            int tmp = 0;
            int.TryParse(numberTextBox.Text, out tmp);

            if (tmp == numberToFind)
            {
                resultTextBlock.Foreground = Brushes.Green;
                resultTextBlock.Text = "Gratulację";
            }
            else if (tmp > numberToFind)
            {
                resultTextBlock.Foreground = Brushes.OrangeRed;
                resultTextBlock.Text = "Mniej";
            }
            else if (tmp < numberToFind)
            {
                resultTextBlock.Foreground = Brushes.DeepSkyBlue;
                resultTextBlock.Text = "Więcej";
            }
        }
    }
}
