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

namespace BinaryNum
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
            int.TryParse(inputTextBox.Text, out int num);
            string binary = "";

            while (num!=0)
            {
                binary += num % 2;
                num /= 2;
            }

            string reverse = String.Empty;
            
            for (int i = binary.Length - 1; i > -1; i--)
            {
                reverse += binary[i];
            }


            outputTextBox.Text = reverse;
        }
    }
}
