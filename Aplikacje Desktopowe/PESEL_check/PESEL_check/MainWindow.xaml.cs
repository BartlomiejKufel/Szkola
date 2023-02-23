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

namespace PESEL_check
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
            string PESEL = inputTextBox.Text;

            int sum = 0;
            for (int i = 0; i < PESEL.Length-1; i++)
            {
                int.TryParse(PESEL[i].ToString(), out int num);
                sum += Multiply(i, num);

            }

            if (sum >= 10)
                sum %= 10;

            sum = 10 - sum;

            

            if (PESEL[PESEL.Length-1].ToString() == sum.ToString())
                MessageBox.Show("PESEL jest poprawny");
            else
                MessageBox.Show("PESLE jest nie poprawny");


        }




        private int Multiply(int index, int num)
        {
            switch (index)
            {
                case 0:  num*=1; break;
                case 1:  num*=3; break;
                case 2:  num*=7; break;
                case 3:  num*=9; break;
                case 4:  num*=1; break;
                case 5:  num*=3; break;
                case 6:  num*=7; break;
                case 7:  num*=9; break;
                case 8:  num*=1; break;
                case 9:  num*=3; break;

                default:
                    break;
            }

            
            if(num >= 10)
            {
                return num%10;
            }
            
            return num;
        }
    }
}
