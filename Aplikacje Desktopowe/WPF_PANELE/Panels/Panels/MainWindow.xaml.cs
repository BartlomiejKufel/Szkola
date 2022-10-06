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

namespace Panels
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
            var num1 = double.Parse(num1TextBox.Text);
            var num2 = double.Parse(num2TextBox.Text);

            if(rownanieComboBox.SelectedIndex == 0)
                wynikTextBox.Text = (num1+num2).ToString();
            else if(rownanieComboBox.SelectedIndex == 1)
                wynikTextBox.Text = (num1-num2).ToString();
            else if (rownanieComboBox.SelectedIndex == 2)
                wynikTextBox.Text = (num1 * num2).ToString();
            else if (rownanieComboBox.SelectedIndex == 3)
            {
                double wynik = num1 / num2;
                wynikTextBox.Text = wynik.ToString();
            }


        }
    }
}
